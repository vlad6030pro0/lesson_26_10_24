using lesson_26_10_24.Services;
using lesson_26_10_24.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddHttpClient<ICurrencyService, CurrencyService>();
builder.Services.AddHttpClient<IEmailService, EmailService>();

builder.Services.AddSingleton<ITestService, TestService>();
builder.Services.AddSingleton<AnotherTestService>();

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
