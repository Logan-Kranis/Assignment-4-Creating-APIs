var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();
builder.Services.AddCors(Options =>
{
    Options.AddPolicy("AllowMyRazorPagesApp", builder =>
    {
        builder.WithOrigins("https://localhost:7197")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});
var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCors("AllowMyRazorPagesApp");
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
