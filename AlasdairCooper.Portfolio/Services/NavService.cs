namespace AlasdairCooper.Portfolio.Services;
public class NavService
{
	public NavPage CurrentPage { get; set; } = null!;

	public event Action? OnPageChange;

	private void NotifyStateChanged() => OnPageChange?.Invoke();

	public void SetCurrentPage(NavPage nextPage)
	{
		if (CurrentPage == null || nextPage != CurrentPage)
		{
			CurrentPage = nextPage;
			NotifyStateChanged();
		}
	}
}