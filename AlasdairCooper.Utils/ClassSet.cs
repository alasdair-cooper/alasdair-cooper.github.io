namespace AlasdairCooper.Utils;

public class ClassSet : HashSet<string>
{
	public override string ToString()
	{
		return string.Join(" ", this);
	}

	public void Toggle(string className, bool state = true)
	{
		if (state)
		{
			Add(className);
		}
		else
		{
			Remove(className);
		}
	}

	public void Has(string className) => Contains(className);
}