public struct MoveData
{
    public string name;
    public Type type;
    public MoveCategory category;
    public byte pp;
    public byte power;
    public float accuracy;
    public MoveEffect effect;
    public float recoilDamage;

    public static readonly MoveData struggle = new MoveData("Struggle", Type.Struggle, MoveCategory.Physical, 50, 100, 1, .25f);
    public static readonly MoveData tackle = new MoveData("Tackle", Type.Normal, MoveCategory.Physical, 50, 100, 35);
    public static readonly MoveData Growl = new MoveData("Growl", Type.Normal, MoveCategory.Status, 0, 100, 40, new MoveEffect(Statistic.Attack, -1));
    

    private MoveData(string name, Type type, MoveCategory category, byte power, float accuracy, byte pp) : this(name, type, category, power, accuracy, pp, MoveEffect.none)
    {
        //Just exists to leave out a few variables, shortening the 
        //length I have to type for each and every move's data
    }

    private MoveData(string name, Type type, MoveCategory category, byte power, float accuracy, byte pp, MoveEffect effect) : this(name, type, category, power, accuracy, pp, effect, 0f)
    {
        //Same as above
    }

    private MoveData(string name, Type type, MoveCategory category, byte power, float accuracy, byte pp, float recoilDamage) : this(name, type, category, power, accuracy, pp, MoveEffect.none, recoilDamage)
    {
        //Same
    }

    private MoveData(string name, Type type, MoveCategory category, byte power, float accuracy, byte pp, MoveEffect effect, float recoilDamage)
    {
        this.name = name;
        this.type = type;
        this.category = category;
        this.pp = pp;
        this.power = power;
        this.accuracy = accuracy;
        this.effect = effect;
        this.recoilDamage = recoilDamage;
    }
}
