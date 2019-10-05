using System;

namespace Ghasedak.Kavenegar.Core.Json
{
 public class JsonNullable : JsonObject
 {
	public String Nullable { get; set; }

	public JsonNullable()
	{
	 Nullable = "Null";
	}

	public JsonObject UpCast()
	{
	 JsonObject objectJ = this;
	 return objectJ;
	}
 }
}
