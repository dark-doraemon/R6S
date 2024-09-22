namespace back_end;

public class Squad
{
    public string SquadId { get; set; }
    public string SquadName { get; set;}
    public string SquadIcon { get; set; }
    public ICollection<Operator> Operators { get; set; }
   
}
