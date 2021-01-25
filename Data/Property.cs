using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ParadisePropertyScraper.Data
{
	/// <summary>
	/// Data model class for Properties from the Json string
	/// </summary>
	public class Property
	{
		public int Id { get; set; }

		public int Bedrooms { get; set; }

		public int Bathrooms { get; set; }

		public string StreetName { get; set; }

		public int StreetNumber { get; set; }

		public string SaleOrRent { get; set; }

		public Zip Zip { get; set; }

		public int Price { get; set; }

		public double Size { get; set; }

		public string Category { get; set; }

		public int Rooms { get; set; }

		public int ImagesNr { get; set; }

		public string Image { get; set; }

		public string Latitude { get; set; }

		public string Longitude { get; set; }

		public string LegitRealestateAgent { get; set; }

		public JsonOpenHouse Openhouse { get; set; }


	}

	/// <summary>
	/// Postal code information
	/// </summary>
	public class Zip
	{
		public int ZipCode { get; set; }

		public string Town { get; set; }
	}

	/// <summary>
	/// Open house information on each property, not much used
	/// </summary>
	public class OpenHouse
	{
		public object Property { get; set; }

		public object Date { get; set; }

		public object TimeStart { get; set; }

		public object TimeEnd { get; set; }

		public object Description { get; set; }
	}

	/// <summary>
	/// List of properties
	/// </summary>
	public class PropertyList : List<Property>
	{
	}
}