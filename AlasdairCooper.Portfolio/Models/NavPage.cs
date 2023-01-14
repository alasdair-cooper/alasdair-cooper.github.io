namespace AlasdairCooper.Portfolio.Models;

public class NavPage
{
	public string Name { get; set; }
	public int Id { get; set; }
	public string Url { get; set; }
	public string? Icon { get; set; }
	public int? ParentPageId { get; set; }

	public NavPage(string name, int id, string url = "/", string? icon = "", int? parentPageId = null)
	{
		Id = id;
		Name = name;
		Url = url;
		Icon = icon;
		ParentPageId = parentPageId;
	}
}