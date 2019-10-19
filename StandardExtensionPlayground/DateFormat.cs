using System;
using System.Collections.Generic;
using System.Text;

namespace StandardExtensionPlayground
{
	public static class DateFormat
	{
		public static string LongDate(this DateTime date)
		{
			return date.ToLongDateString();
		}
	}
}
