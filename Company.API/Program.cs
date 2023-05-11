using Company.Common.DTOs;
using Company.Data.Entities;
using Company.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CompanyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CompanyConnection")));

ConfigureAutomapper(builder.Services);

RegisterServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void ConfigureAutomapper(IServiceCollection services)
{
    var config = new MapperConfiguration(mc =>
    {
        mc.CreateMap<Company.Data.Entities.Company, CompanyDTO>().ReverseMap();
        mc.CreateMap<Department, DepartmentDTO>().ReverseMap();
        mc.CreateMap<Employee, EmployeeDTO>().ReverseMap();
        mc.CreateMap<EmployeeTitle, EmployeeTitleDTO>().ReverseMap();
        mc.CreateMap<Title, TitleDTO>().ReverseMap();
    });
    IMapper mapper = config.CreateMapper();
    services.AddSingleton(mapper);
}

void RegisterServices(IServiceCollection services)
{
    services.AddScoped<IDbService, DbService>();
}