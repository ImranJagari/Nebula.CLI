using System;

namespace Nebula.CLI.Core.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class ParameterAttribute<T> : Attribute
{
    public string ParameterName { get; set; }

    public T? DefaultValue { get; set; }

    public ParameterAttribute(string parameterName, T? defaultValue = default)
    {
        ParameterName = parameterName;
        DefaultValue = defaultValue;
    }
}