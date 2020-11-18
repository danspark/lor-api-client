namespace LoR.Client
{
    public abstract record NamedResource(string Name, string NameRef) { }

    public record VocabularyTerm(string Description, string Name, string NameRef) : NamedResource(Name, NameRef) { }

    public record Keyword(string Description, string Name, string NameRef) : NamedResource(Name, NameRef) { }

    public record Region(string Abbreviation, string IconAbsolutePath, string Name, string NameRef) : NamedResource(Name, NameRef) { }

    public record SpellSpeed(string Name, string NameRef) : NamedResource(Name, NameRef) { }

    public record Rarity(string Name, string NameRef) : NamedResource(Name, NameRef) { }

    public record CardSet(string IconAbsolutePath, string Name, string NameRef) : NamedResource(Name, NameRef) { }

    public record Asset(string GameAbsolutePath, string FullAbsolutePath);

    public record Card(string[] AssociatedCards, string[] AssociatedCardRefs, Asset[] Assets, string Region, string RegionRef,
        int Attack, int Cost, int Health, string Description, string DescriptionRaw, string LevelUpDescription, string LevelUpDescriptionRaw,
        string FlavorText, string ArtistName, string Name, string CardCode, string[] Keywords, string[] KeywordRefs,
        string SpellSpeed, string SpellSpeedRef, string Rarity, string RarityRef, string Subtype, string[] Subtypes, string Type,
        bool Collectible, string Set);
}
