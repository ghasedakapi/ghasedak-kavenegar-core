using Ghasedak.Kavenegar.Core.Models.Enums;
namespace Ghasedak.Kavenegar.Core.Models
{
 public class StatusResult
 {
	public long Messageid { get; set; }
	public MessageStatus Status { get; set; }
	public string Statustext { get; set; }
 }
}