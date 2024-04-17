using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using TokenManagement.Model;
using TokenManagement.Services;

var builder = WebApplication.CreateBuilder(args);
var service = builder.Services;

service.AddControllers();
service.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options=>
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = JwtOptions.ISSUER,
            ValidateAudience = true,
            ValidAudience = JwtOptions.AUDIENCE,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = JwtOptions.GetSymmetricSecurityKey()
        }
    );
service.AddAuthorization();

service.AddSingleton<UserContext>();
service.AddTransient<TokenService>();
service.AddSingleton<AuthManager>();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

//app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
