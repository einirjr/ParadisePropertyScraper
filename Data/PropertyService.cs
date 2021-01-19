using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ParadisePropertyScraper.Data
{
	public class PropertyService
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		public Task<PropertyList> GetProperties(string postalCode = "900")
		{
			var response = new WebClient().DownloadString($"http://fasteignir.visir.is/api/search?onpage=1000&zip={postalCode}");

			return Task.FromResult(JsonSerializer.Deserialize<PropertyList>(response));
		}
	}
}
