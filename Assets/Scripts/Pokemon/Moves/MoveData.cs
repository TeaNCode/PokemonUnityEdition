public struct MoveData
{
    public string name;
    public Type type;
    public MoveCategory category;
    public byte pp;
    public byte power;
    public float accuracy;
    public SpecialEffect effect;
    public float effectChance;
    public float recoilDamage;

    private MoveData(string name, Type type, MoveCategory category, byte pp, byte power, float accuracy) : this(name, type, category, pp, power, accuracy, SpecialEffect.None, 0f)
    {
        //Just exists to leave out a few variables
    }

    private MoveData(string name, Type type, MoveCategory category, byte pp, byte power, float accuracy, SpecialEffect effect, float effectChance) : this(name, type, category, pp, power, accuracy, effect, effectChance, 0f)
    {
        //Same as above
    }

    private MoveData(string name, Type type, MoveCategory category, byte pp, byte power, float accuracy, SpecialEffect effect, float effectChance, float recoilDamage)
    {
        this.name = name;
        this.type = type;
        this.category = category;
        this.pp = pp;
        this.power = power;
        this.accuracy = accuracy;
        this.effect = effect;
        this.effectChance = effectChance;
        this.recoilDamage = recoilDamage;
    }
}
