namespace domain;

public class Recepie: Base
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required double Views { get; set; }
    public required User Author { get; set; }
    public required List<Comentary> Comentaries {get;set;}

}
