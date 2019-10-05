using System;
namespace Ghasedak.Kavenegar.Core.Models
{
 public class AccountInfoResult
 {
	public long RemainCredit { get; set; }
	public long Expiredate { get; set; }
	public DateTime GregorianExpiredate
	{
	 get { return Utils.DateHelper.UnixTimestampToDateTime(Expiredate); }
	}
	public string Type { get; set; }
 }
}