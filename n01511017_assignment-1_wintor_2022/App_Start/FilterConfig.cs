using System.Web;
using System.Web.Mvc;

namespace n01511017_assignment_1_wintor_2022
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
