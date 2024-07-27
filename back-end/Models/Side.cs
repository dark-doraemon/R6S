namespace back_end;

public class Side
{
    public string SideId { get; set; }
    public string SideName { get; set; }
    public IList<Operator> Operators { get; set; }
}
