var builder = WebApplication.CreateBuilder(args);
//St�d f�r controllers och view
builder.Services.AddControllersWithViews();
var app = builder.Build();

//St�d f�r att mappa HTTP-anrop till v�ra controllers
app.UseRouting();
// St�d f�r Route-attribut p� v�ra Action-metoder
app.UseEndpoints(o => o.MapControllers());

app.Run();
