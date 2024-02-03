
using System.Text.Json.Serialization;

namespace Celeste64;

/// <summary>
/// Stores Meta-Info about a specific Mod
/// </summary>
public class ModInfo
{
	public string Id { get; set; } = "";
	public string Name { get; set; } = "";
	public string? ModAuthor { get; set; }
	public string? Description { get; set; }
	public string? Icon { get; set; }
	public Dictionary<string, string>? Dependencies { get; set; }
	public Dictionary<string, string>? AssetReplaceItems { get; set; }

	public bool IsValid()
	{
		return string.IsNullOrEmpty(Id) && string.IsNullOrEmpty(Name);
	}
}

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(ModInfo))]
internal partial class ModInfoContext : JsonSerializerContext { }