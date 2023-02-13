using System;

namespace Nebula.CLI.Core.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class ParameterAttribute : Attribute
{
	public string Name { get; set; } = string.Empty;
	public bool Mandatory { get; set; }
	public object? DefaultValue { get; set; }
}