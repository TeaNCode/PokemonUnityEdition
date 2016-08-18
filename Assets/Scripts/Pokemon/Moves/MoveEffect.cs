public class MoveEffect
{
    public char type;
    public Statistic statistic;
    public sbyte stageChanges;
    public Status effect;
    public Target target;

    public static readonly MoveEffect none = new MoveEffect();

    public MoveEffect(Statistic statistic, sbyte stageChanges, Target target)
    {
        type = 's';
        this.statistic = statistic;
        this.stageChanges = stageChanges;
        this.target = target;
    }

    public MoveEffect(Status effect)
    {
        type = 'e';
        this.effect = effect;
    }

    public MoveEffect(){}
}
