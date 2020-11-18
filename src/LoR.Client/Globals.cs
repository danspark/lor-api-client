namespace LoR.Client
{
    public abstract record NamedResource(string Name, string NameRef) { }

    public record VocabularyTerm(string Description, string Name, string NameRef) : NamedResource(Name, NameRef) { }

    public record Keyword(string Description, string Name, string NameRef) : NamedResource(Name, NameRef) { }

    public record Region(string Abbreviation, string IconAbsolutePath, string Name, string NameRef) : NamedResource(Name, NameRef) { }

    public record SpellSpeed(string Name, string NameRef) : NamedResource(Name, NameRef) { }

    public record Rarity(string Name, string NameRef) : NamedResource(Name, NameRef) { }

    public record CardSet(string IconAbsolutePath, string Name, string NameRef) : NamedResource(Name, NameRef) { }
}
