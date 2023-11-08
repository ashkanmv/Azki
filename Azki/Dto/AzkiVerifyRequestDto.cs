namespace Azki.Dto;

public class AzkiVerifyRequestDto
{
    public string phoneNumber { get; set; }
    public string verifyCode { get; set; }
    public bool corporationUser { get; set; } = false;
}