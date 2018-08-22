namespace Brewery.Web.Areas.Admin.Models.ViewModels
{
	public abstract class IdentifiableViewModel<T>
	{
		public T Id { get; set; }
	}
}