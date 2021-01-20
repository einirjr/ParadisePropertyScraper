using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace ParadisePropertyScraper.Data
{
	public class PropertyService
	{
		public Task<PropertyList> GetProperties(string postalCode = "900")
		{
			var response = new WebClient().DownloadString($"http://fasteignir.visir.is/api/search?onpage=1000&zip={postalCode}");

			return Task.FromResult(JsonSerializer.Deserialize<PropertyList>(response));
		}
	}
}
