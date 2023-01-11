using AlasdairCooper.Portfolio.Services;

namespace AlasdairCooper.Portfolio.Models;

public class NavPage
{
	public string Name { get; set; }
	public int Id { get; set; }
	public string Url { get; set; }
	public string? Icon { get; set; }
	public int? ParentPageId { get; set; }

	private readonly NavService navService;

	public NavPage(NavService _navService, string name, int id, string url = "/", string? icon = "", int? parentPageId = null)
	{
		navService = _navService;

		Name = name;
		Id = id;
		Url = url;
		Icon = icon;
		ParentPageId = parentPageId;
	}

	public bool IsCurrentPage() => Id == navService.CurrentPage.Id;
}