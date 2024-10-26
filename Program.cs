using BeybladeMatchMakerAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container with JSON options
builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
    });

// Optional: Configure CORS (for cross-origin access)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

// Register AppDbContext and configure the connection string
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BMMDB")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register services dynamically using reflection
RegisterServices(builder.Services, Assembly.GetExecutingAssembly());

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    // Only show Swagger UI in Development mode
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = "swagger"; // This makes Swagger available at the root
    });
}

// app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");  // Apply CORS policy, if added
app.UseAuthorization();

app.MapControllers();

// Define the health check endpoint
app.MapGet("isHealthy", async context =>
{
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync("<html><body><h1>API is Healthy</h1></body></html>");
});

app.Run();

/// <summary>
/// Dynamically registers services that match certain criteria, such as implementing an interface or having "Service" in the name.
/// </summary>
/// <param name="services">The service collection to register services in.</param>
/// <param name="assembly">The assembly to scan for service classes.</param>
void RegisterServices(IServiceCollection services, Assembly assembly)
{
    // Automatically register any class that implements an interface or is named "Service"
    var serviceTypes = assembly.GetTypes()
        .Where(type => type.IsClass && !type.IsAbstract)
        .Where(type => type.Name.EndsWith("Service") || type.Name.EndsWith("Process")) // Include Process classes
        .Select(type => new
        {
            Service = type.GetInterfaces().FirstOrDefault(), // Find the first interface
            Implementation = type
        });

    foreach (var type in serviceTypes)
    {
        if (type.Service != null)
        {
            // Register class with its interface (e.g., IBladeService -> BladeService)
            services.AddTransient(type.Service, type.Implementation);
        }
        else
        {
            // If there's no interface, register the class itself (e.g., BladeProcess)
            services.AddTransient(type.Implementation);
        }
    }
}


// ~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*


