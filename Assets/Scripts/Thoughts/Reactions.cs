using System;
using System.Collections;
using System.Collections.Generic;

public class Reactions
{
    public enum Verb {
        Light,
        Photograph,
        Record,
        Pay
    };
    public enum Item {
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

    public string GeneralFailure()
    {
        return "Sigh... I don't know why I thought that would help me feel less homesick.";
    }

    public string GetQuip(Verb verb, Item item)
    {
        switch (item)
        {
            case Item.Cat:
                switch (verb)
                {
                    case Verb.Light:
                        return "You look just like my old cat, Mr. Whiskers!";
                    case Verb.Photograph:
                        return "I guess I'm a guy who takes cat photos now. Huh.";
                    case Verb.Record:
                        return "C'mon kitty... Meow or purr or something... Dang.";
                    case Verb.Pay:
                        return "I don't think this cat takes cards. What a weird thing to do --- I better go home and rest.";
                }

            case Item.Beach:
                switch (verb)
                {
                    case Verb.Photograph:
                        return "A great view. The water reaches right up to the city... just like in Mar del Plata.";
                    default:
                        return GeneralFailure();

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

// case Action.Light:
// case Action.Rat:
//     return "Aaaaaaaaaaaaaaaaaaaaaahhhhh!!!!!";

// case Action.Light:
// case Action.Squirrel:
//     return "Cute. But not a very good pet.";
