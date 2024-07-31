namespace back_end;

public class Side
{
    public string SideId { get; set; }
    public string SideName { get; set; }
    public ICollection<Operator> Operators { get; set; }
}
