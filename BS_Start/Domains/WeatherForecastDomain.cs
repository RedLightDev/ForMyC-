using BS_Start.Repository;
namespace BS_Start.Domains
{
    public class WeatherForecastDomain
    {
        //ANY LOGIC WILL BE IN HERE
        public WeatherForecastRepository _repository = new WeatherForecastRepository();
        public WeatherForecastDomain()
        {
        }
        public WeatherForecast[] GetIfAllowed(int Id)
        {
            WeatherForecast[] result;
            if (Id == 1)
            {
                result = _repository.GetAll();
            }
            else
            {
                result = null;
            }
            return result;
        }
    }
}
