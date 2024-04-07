using SoapCore;
using SoapTestApplication.ServiceContract;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddScoped<ISoapServices, SoapServices>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<ISoapServices>("/mockServer", new SoapEncoderOptions(),
        SoapSerializer.XmlSerializer);
});

app.Run();