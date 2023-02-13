using System;
using System.Collections.Generic;
using System.Text;

namespace Nebula.CLI.Core.Attributes
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class CommandNameAttribute : Attribute
	{
		public string Name { get; set; }

		public CommandNameAttribute(string name)
		{
			Name = name;
		}
	}
}
