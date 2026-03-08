using ItemChanger.Serialization;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace ItemChanger.Silksong.Serialization;

/// <summary>
/// An <see cref="IValueProvider{T}"/> for composing other value providers by string interpolation.
/// </summary>
public record CompositeString : IValueProvider<string>
{
    /// <summary>
    /// A wrapper whose string output may contain groups of the form {key} to be replaced by the entry of <see cref="Params"/> at key.
    /// </summary>
    public required IValueProvider<string> Pattern { get; init; }

    /// <summary>
    /// Parameters to be substituted into <see cref="Pattern"/> by key.
    /// </summary>
    public required ReadOnlyDictionary<string, IValueProvider<object>> Params { get; init; }

    /// <summary>
    /// Creates a <see cref="CompositeString"/> which substitutes for {0}, {1}, etc in <paramref name="format"/> according to index in the <paramref name="args"/> sequence.
    /// </summary>
    public static CompositeString Create(IValueProvider<string> format, params IEnumerable<IValueProvider<object>> args) 
        => Create(format, args.Select((val, i) => (i.ToString(), val)));

    /// <summary>
    /// Creates a <see cref="CompositeString"/> which substitutes {key} by value in <paramref name="pattern"/>, for each element of the <paramref name="args"/> sequence.
    /// Keys in the <paramref name="args"/> sequence must be unique.
    /// </summary>
    public static CompositeString Create(IValueProvider<string> pattern, params IEnumerable<(string key, IValueProvider<object> value)> args)
    {
        return new() { Pattern = pattern, Params = new(args.ToDictionary(a => a.key, a => a.value)), };
    }

    [JsonIgnore]
    public string Value
    {
        get
        {
            string pattern = Pattern.Value;
            foreach (KeyValuePair<string, IValueProvider<object>> kvp in Params)
            {
                pattern = pattern.Replace("{" + kvp.Key + "}", kvp.Value.Value.ToString());
            }
            return pattern;
        }
    }
}
