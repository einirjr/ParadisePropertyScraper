using System;
using System.Net;
using System.Text.Json;

namespace ParadisePropertyScraper.Data
{
	public static class PropertyService
	{
		public static PropertyList Properties { get; set; }
		public static void GetProperties(string postalCode = "900")
		{
			var response = new WebClient().DownloadString($"http://fasteignir.visir.is/api/search?onpage=1000&zip={postalCode}");

			JsonPropertyList jsonProp = JsonSerializer.Deserialize<JsonPropertyList>(response);

			Properties = ConvertJsonProperties(jsonProp);
		}

		private static PropertyList ConvertJsonProperties(JsonPropertyList jsonProp)
		{
			PropertyList tempPropertyList = new PropertyList();

			foreach (var property in jsonProp)
			{
				tempPropertyList.Add(new Property
				{
					Id = int.TryParse(property.Id, out int id) ? id : 0,
					Bedrooms = int.TryParse(property.Bedrooms, out int bedr) ? bedr : 0,
					Bathrooms = int.TryParse(property.Bathrooms, out int bathr) ? bathr : 0,
					StreetName = property.StreetName,
					StreetNumber = int.TryParse(property.StreetNumber, out int snr) ? snr : 0,
					SaleOrRent = property.SaleOrRent,
					Zip = new Zip
					{
						ZipCode = int.TryParse(property.Zip.ZipCode, out int zipc) ? zipc : 0,
						Town = property.Zip.Town
					},
					Price = int.TryParse(property.Price, out int price) ? price : 0,
					Size = double.TryParse(property.Size, out double size) ? size : 0,
					Category = property.Category,
					Rooms = int.TryParse(property.Rooms, out int rooms) ? rooms : 0,
					ImagesNr = int.TryParse(property.ImagesNr, out int imgnr) ? imgnr : 0,
					Image = property.Image,
					Latitude = property.Latitude,
					Longitude = property.Longitude,
					LegitRealestateAgent = property.LegitRealestateAgent,
					Openhouse = property.Openhouse
				});
			}

			return tempPropertyList;
		}
	}
}
