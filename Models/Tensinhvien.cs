namespace _2526_2121050111_BaiThi.Models;

public class Tensinhvien
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
