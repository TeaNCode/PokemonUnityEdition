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

    public static readonly MoveData struggle = new MoveData("Struggle", Type.Struggle, MoveCategory.Physical, 50, 1, 1, .25f);
    public static readonly MoveData tackle = new MoveData("Tackle", Type.Normal, MoveCategory.Physical, 50, 1, 35);
    public static readonly MoveData growl = new MoveData("Growl", Type.Normal, MoveCategory.Status, 0, 1, 40, new MoveEffect(Statistic.Attack, -1, Target.Enemies));
    public static readonly MoveData leechSeed = new MoveData("Leech Seed", Type.Grass, MoveCategory.Status, 0, .9f, 10, new MoveEffect(Status.Seeding));
    public static readonly MoveData vineWhip = new MoveData("Vine Whip", Type.Grass, MoveCategory.Physical, 45, 1, 25);
    public static readonly MoveData poisonPowder = new MoveData("Poison Powder", Type.Poison, MoveCategory.Status, 0, .75f, 35, new MoveEffect(Status.Poison));
    public static readonly MoveData sleepPowder = new MoveData("Sleep Powder", Type.Grass, MoveCategory.Status, 0, .75f, 15, new MoveEffect(Status.Sleep));
    public static readonly MoveData takeDown = new MoveData("Take Down", Type.Normal, MoveCategory.Physical, 90, .85f, 20, .25f);
    public static readonly MoveData razorLeaf = new MoveData("Razor Leaf", Type.Grass, MoveCategory.Physical, 55, .95f, 25, new MoveEffect(Status.CritBoost));
    public static readonly MoveData sweetScent = new MoveData("Sweet Scent", Type.Normal, MoveCategory.Status, 0, 1, 20, new MoveEffect(Statistic.Evasion, -1, Target.Enemies));

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
