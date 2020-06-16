using CoVid19Info.Models;
using CoVid19Info.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CoVid19Info.Services.QuartzScheduler.UpdateDbJob
{
    [DisallowConcurrentExecution]
    public class UpdateAllCountriesJob : IJob
    {
        private readonly ILogger<UpdateAllCountriesJob> _logger;
        private readonly IServiceProvider _provider;

        public UpdateAllCountriesJob(ILogger<UpdateAllCountriesJob> logger, IServiceProvider provider)
        {
            _logger = logger;
            _provider = provider;
        }
        public async Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");

            // How to create scoped service inside singleton 
            using (var scope = _provider.CreateScope())
            {
                var dataContext = scope.ServiceProvider.GetService<DataContext>();
                var countryModels =
                    DeserializeByQueryString.GetModels<AllCountriesModel>("https://disease.sh/v2/countries");

                var first50CountryModels = countryModels
                    .OrderByDescending(x => x.Cases)
                    .Take(50)
                    .ToList();

                //var all = dataContext.AllCountriesModels.ToList();
                //dataContext.RemoveRange(all);

                dataContext.AllCountriesModels.AddRange(first50CountryModels);

                await dataContext.SaveChangesAsync();
            }
        }
    }
}
