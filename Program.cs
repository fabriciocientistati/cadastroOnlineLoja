
// -� necessario fazer a conex�o com o banco de dados Na Classe Program.cs que est� na Raiz do Projeto *Aqui que ser� utilizado o PACOTE EntityFramework para o SqlServer ou outros bancos*

//3.1 Criar um novo service (builder.Services) que ir� adicionar "DbContext" que est� na Pasta Date criada na Raiz do projeto Ex: (builder.Services.AddDbContext)
// 3.2 Adicionar dentro do "DbContext<>" a Classe que est� dentro da Pasta "Date" que � o nome da Classe public * Ex: class ApplicationDbContext :* Ex: (builder.Services.AddDbContext<ApplicationDbContext>())
// 3.3 Incluir dentro do "construtor" as (options) que ser� uma fun��o Ex: (builder.Services.AddDbContext<ApplicationDbContext>(options => { });)
// 4.4 A options ir� usar o pacote EntityFramework.SqlServer Ex: (options.UseSqlServer()) para acessar as conex�es do banco de dados que est� no arquivo "appsettings.json".
// 4.5 Criar a configura��o de conex�o dentro do "options.UseSqlServer()" Ex: (options.UseSqlServer(builder.Configuration.GetConnectionString());)
// 4.5 E por ultimo chamar o nome de refer�ncia criado para a conex�o do banco de dados que foi inserida no arquivo "appsettings.json" Ex: (options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));)

using CadastroPrimoMoveis.Date;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Conex�o com o Banco de dados indo no arquivo appsettings.json e buscando a String de conex�o criada que o nome foi dado "DefaultConnection"
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
