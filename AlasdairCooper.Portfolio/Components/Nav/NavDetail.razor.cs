using Microsoft.AspNetCore.Components;

namespace AlasdairCooper.Portfolio.Components.Nav;

public partial class NavDetail
{
	[Parameter, EditorRequired]
	public NavPage Page { get; set; } = null!;

	[Parameter]
	public bool IsFavourite { get; set; }

	[Parameter]
	public EventCallback<bool> OnFavouriteToggled { get; set; }

	private ClassSet classSet = new();

	private bool IsIconVisible => IsFavourite || Page == _navService.CurrentPage;

	protected override void OnParametersSet()
	{
		classSet = new() { "favourite-icon" };

        if (!IsIconVisible)
        {
            classSet.Add("visible-on-hover");
        }
	}

	private async Task OnCheckedChanged(bool isChecked)
	{
		IsFavourite = isChecked;

		classSet.Toggle("visible-on-hover", !IsIconVisible);

		await OnFavouriteToggled.InvokeAsync(IsFavourite);
	}
}