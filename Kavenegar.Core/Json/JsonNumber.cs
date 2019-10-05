using Ghasedak.Kavenegar.Core.Json;

namespace Ghasedak.Kavenegar.Core.Json
{
 public class JsonNumber : JsonObject
 {
	public float Number { get; set; }

	public JsonNumber(float number)
	{
	 Number = number;
	}

	public JsonObject UpCast()
	{
	 JsonObject objectJ = this;
	 return objectJ;
	}
 }

}
