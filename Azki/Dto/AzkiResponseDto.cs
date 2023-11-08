namespace Azki.Dto;

public class AzkiResponseDto<T>
{
    public int messageCode { get; set; }
    public string message { get; set; }
    public T? result { get; set; }
}
