using NavTabler.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddHealthChecks();
// builder.Services.Configure<RouteOptions>(op=>
// {
//     op.AppendTrailingSlash = true;
// });
var app = builder.Build();


app.MapRazorPages();
app.MapHealthChecks("/healthz");
// app.MapGet("/test", () => $"Hello World! {DateTime.Now.ToString("hh:mm:ss")}");
// app.MapGet("/test", () => Url.Page);
app.MapGet("/test2", async context => 
{
    await context.Response.WriteAsync("test 2 is good");
});
app.MapGet("/Test3", async context =>
{
    await context.Response.WriteAsJsonAsync(new Table[]{
        new Table {Name = "Ball"},
        new Table {Name = "Small"},
        new Table {Name = "Scroll"}
});
});
app.Run();
