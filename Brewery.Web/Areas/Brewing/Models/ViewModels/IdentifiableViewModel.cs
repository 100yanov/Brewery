namespace Brewery.Web.Areas.Brewing.Models.ViewModels
{
	public abstract class IdentifiableViewModel<T>
	{
		public T Id { get; set; }
	}
}