using System;
using System.Collections.Generic;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    private readonly int _mask;

    public Allergies(int mask)
    {
        _mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        int flag = 1 << (int)allergen;
        return (_mask & flag) != 0;
    }

    public Allergen[] List()
    {
        var result = new List<Allergen>();

        foreach (Allergen allergen in Enum.GetValues<Allergen>())
        {
            if (IsAllergicTo(allergen))
            {
                result.Add(allergen);
            }
        }

        return result.ToArray();
    }
}