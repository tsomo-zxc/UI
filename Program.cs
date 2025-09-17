var builder = WebApplication.CreateBuilder(args);

// ������ �������� Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ϳ�������� Razor Pages ������ ����������
app.MapRazorPages();

app.Run();
