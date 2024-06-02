namespace CRUD.Models;

public class Question
{
	public int Id { get; set; }
	public string? Definition { get; set; }
	public DateTime AccomplishedDate { get; set; }

    public override string ToString()
    {
        return $"[Wish {Id}]";
    }
}