using ProjecteAccessBBDDHugo.Data;
using ProjecteAccessBBDDHugo.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

using(var context = new ApplicationDbContext())
{
    var simulation = new Simulation
    {
        Tipus = "Fotovoltaica",
        HoresSol = 8,
        VelocitatVent = 0,
        CabalAigua = 0,
        Rati = 0,
        EnergiaGenerada = 0,
        CostKWh = 0,
        PreuKWh = 0,
        DataHora = DateTime.Now.ToString()
    };
    context.Simulations.Add(simulation);
    context.SaveChanges();
}