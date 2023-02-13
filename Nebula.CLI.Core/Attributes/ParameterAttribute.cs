using System;

namespace Nebula.CLI.Core.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public sealed class ParameterAttribute : Attribute
{
	public string Name { get; set; } = string.Empty;
	public bool IsOptional { get; set; }
	public object? DefaultValue { get; set; }
}