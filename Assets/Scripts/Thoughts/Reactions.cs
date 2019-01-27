using System;
using System.Collections;
using System.Collections.Generic;

public class Reactions
{
    public enum Verb
    {
        Light,
        Photograph,
        Record,
        Pay
    };

    public enum Item
    {
        // Wanted items
        Beach,
        Cat,
        Grocer,
        BluesBand,
        // Unwanted items
        Squirrel,
        Rat,
        TacoVendor,
        ChineseRestaurant,
        MusicShop,
        Band,
        NavyPier,
        FerrisWheel
    };

    private Dictionary<Verb, string> CatQuips;


    public string GeneralFailure()
    {
        return "Sigh... I don't know why I thought that would help me feel less homesick.";
    }

    public string GetQuip(Verb verb, Item item)
    {
        CatQuips.Add(Light, "You look just like my old cat, Mr Whiskers!");
        CatQuips.Add(Photograph, "I guess I'm a guy who takes cat photos now. Huh.");
        CatQuips.Add(Record, "C'mon kitty... Meow or purr or something... Dang.");
        CatQuips.Add(Pay, "You're trying to buy something from a cat, Nacho. Wow. I better go home and rest.");

        switch (item)
        {
            case Item.Cat:
                return CatQuips[verb];

            case Item.Beach:
                switch (verb)
                {
                    case Verb.Photograph:
                        return "A great view. The water reaches right up to the city... just like in Mar del Plata.";
                    default:
                        return GeneralFailure();
                }

            case Item.Grocer:
                switch (verb)
                {
                    case Verb.Pay:
                        return "Chicken, garlic, parsley, tomato, lemon... and cheese, of course. I can almost taste my mother’s milanesa already.";
                    default:
                        return GeneralFailure();
                }

            case Item.BluesBand:
                switch (verb)
                {
                    case Verb.Record:
                        return "Yes! I love it! The blues reminds me that you can be happy even when times are tough.";
                    default:
                        return GeneralFailure();
                }

            default:
                return "Sigh... I don't know why I thought that would help me feel less homesick.";
        }
    }

    public string Gerund(Verb verb)
    {
        return verb.ToString() + "ing";
    }

}
