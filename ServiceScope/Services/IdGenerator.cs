namespace ServiceScope.Services;

public static class IdGenerator
{
    private static readonly string[] Names =
    [
        "Adrian", "Anne Maline", "Bård Terje", "Carl Andre",
        "Emil", "Emma Lu", "Falk Leander", "Hans-Kristian",
        "Håkon", "Håkon", "Håkon", "Janicke", "Jelmer", "Johanne",
        "Jostein", "Jøran", "Jørn Bøni", "Kim André", "Kristian",
        "Lars Jørgen", "Lars", "Leon", "Magnus", "Martin Nordahl", "Matias",
        "Matilde", "Michael", "Morten", "Olav", "Paul Anton",
        "Per Ola", "Jørgen", "Rudi", "Runar", "Sara", "Sigurd",
        "Sondre", "Svein Erik", "Tore", "Vegard", "Katrine", "Richard"
    ];

    private static readonly string[] Adjectives =
    [
        "Strålende", "Glade", "Spreke", "Energiske", "Sjenerøse", "Kloke",
        "Modige", "Vennlige", "Inspirerende", "Omsorgsfulle", "Ærlige",
        "Fantastiske", "Kreative", "Tålmodige", "Optimistiske", "Engasjerte",
        "Varme", "Trofaste", "Dyktige", "Hjelpsomme", "Rolige", "Geniale",
        "Oppmuntrende", "Pålitelige", "Utholdende", "Eventyrlystne", "Livlige",
        "Sjarmerende", "Rause", "Entusiastiske", "Smarte"
    ];

    public static string Generate()
    {
        var adjective = Adjectives[Random.Shared.Next(Adjectives.Length)];
        var name = Names[Random.Shared.Next(Names.Length)];
        return $"{adjective} {name}";
    }
}
