namespace back_end;

public class Biography
{
    public string BiographyId { get; set; }
    public string RealName { get; set; }
    public string DateOfBirth { get; set; }
    public string PlaceOfBirth { get; set; }
    public string Description { get; set; }
    public string PshychologicalReport { get; set; }

    //a operator is only have one Biography
    public Operator Operator { get; set; }

}
