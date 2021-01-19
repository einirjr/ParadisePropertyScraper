using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ParadisePropertyScraper.Data
{
	public class Property
	{
		[JsonPropertyName("id")]
		public string Id { get; set; }

		[JsonPropertyName("bedrooms")]
		public string Bedrooms { get; set; }

		[JsonPropertyName("bathrooms")]
		public string Bathrooms { get; set; }

		[JsonPropertyName("street_name")]
		public string StreetName { get; set; }

		[JsonPropertyName("street_number")]
		public string StreetNumber { get; set; }

		[JsonPropertyName("sale_or_rent")]
		public string SaleOrRent { get; set; }

		[JsonPropertyName("zip")]
		public Zip Zip { get; set; }

		[JsonPropertyName("price")]
		public string Price { get; set; }

		[JsonPropertyName("size")]
		public string Size { get; set; }

		[JsonPropertyName("category")]
		public string Category { get; set; }

		[JsonPropertyName("rooms")]
		public string Rooms { get; set; }

		[JsonPropertyName("images_nr")]
		public string ImagesNr { get; set; }

		[JsonPropertyName("image")]
		public string Image { get; set; }

		[JsonPropertyName("latitude")]
		public string Latitude { get; set; }

		[JsonPropertyName("longitude")]
		public string Longitude { get; set; }

		[JsonPropertyName("legit_realestate_agent")]
		public string LegitRealestateAgent { get; set; }

		[JsonPropertyName("openhouse")]
		public Openhouse Openhouse { get; set; }


	}

	public class Zip
	{
		[JsonPropertyName("zip")]
		public string ZipCode { get; set; }

		[JsonPropertyName("town")]
		public string Town { get; set; }
	}

	public class Openhouse
	{
		[JsonPropertyName("property")]
		public object Property { get; set; }

		[JsonPropertyName("date")]
		public object Date { get; set; }

		[JsonPropertyName("time_start")]
		public object TimeStart { get; set; }

		[JsonPropertyName("time_end")]
		public object TimeEnd { get; set; }

		[JsonPropertyName("description")]
		public object Description { get; set; }
	}

	public class PropertyList : List<Property>
	{
	}
}