var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCors("AllowMyRazorPagesApp");
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
