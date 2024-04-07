using SoapCore;
using SoapTestApplication.SoapService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddScoped<ISumService, SumService>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<ISumService>("/mockServer", new SoapEncoderOptions(),
        SoapSerializer.XmlSerializer);
});

app.Run();