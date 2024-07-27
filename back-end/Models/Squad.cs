namespace back_end;

public class Squad
{
    public string SquadId { get; set; }
    public string SquadName { get; set;}
    public IList<Operator> Operator { get; set; }
}
