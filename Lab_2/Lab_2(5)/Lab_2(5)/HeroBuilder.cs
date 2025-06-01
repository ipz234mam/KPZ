public class HeroBuilder : ICharacterBuilder
{
    private Character character = new Character();

    public ICharacterBuilder SetName(string name)
    {
        character.Name = name;
        return this;
    }

    public ICharacterBuilder SetHeight(double height)
    {
        character.Height = height;
        return this;
    }

    public ICharacterBuilder SetBodyType(string bodyType)
    {
        character.BodyType = bodyType;
        return this;
    }

    public ICharacterBuilder SetHairColor(string color)
    {
        character.HairColor = color;
        return this;
    }

    public ICharacterBuilder SetEyeColor(string color)
    {
        character.EyeColor = color;
        return this;
    }

    public ICharacterBuilder SetClothing(string clothing)
    {
        character.Clothing = clothing;
        return this;
    }

    public ICharacterBuilder AddItem(string item)
    {
        character.Inventory.Add(item);
        return this;
    }

    public HeroBuilder AddGoodDeed(string deed)
    {
        character.Actions.Add("Добра справа: " + deed);
        return this;
    }

    public Character Build()
    {
        return character;
    }
}
