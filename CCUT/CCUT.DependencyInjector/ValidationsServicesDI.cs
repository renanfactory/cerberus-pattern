using CCUT.Validations;
using Microsoft.Extensions.DependencyInjection;

namespace CCUT.DependencyInjector
{
    public static class ValidationsServicesDI
    {
        public static void ConfigureValidationsService(this IServiceCollection services)
        {
            // Serviço de validação de documentos
            services.AddSingleton<ICustomValidations, CustomValidations>();
        }
    }
}
