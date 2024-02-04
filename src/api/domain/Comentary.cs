namespace domain;

public class Comentary: Base
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required double Views { get; set; }
    public required int Rate { get; set; }  
    public required User Author { get; set; }  

    //Relationships
    public Recepie? Recepie { get; set; }
}
