public class CharacterDirector
{
    public Character CreateHero(ICharacterBuilder builder)
    {
        return builder
            .SetName("Елейн")
            .SetHeight(1.75)
            .SetBodyType("Струнка")
            .SetHairColor("Руде")
            .SetEyeColor("Зелені")
            .SetClothing("Легка броня")
            .AddItem("Меч")
            .AddItem("Щит")
            .AddItem("Цілюще зілля")
            .Build();
    }

    public Character CreateEnemy(ICharacterBuilder builder)
    {
        return builder
            .SetName("Темний Лорд")
            .SetHeight(2.1)
            .SetBodyType("Могутній")
            .SetHairColor("Чорне")
            .SetEyeColor("Червоні")
            .SetClothing("Чорна мантія")
            .AddItem("Чаклунський посох")
            .AddItem("Темне зілля")
            .Build();
    }
}
