public class MoveEffect
{
    public char type;
    public Statistic statistic;
    public sbyte stageChanges;
    public StatusCondition effect;

    public static readonly MoveEffect none = new MoveEffect();

    public MoveEffect(Statistic statistic, sbyte stageChanges)
    {
        type = 's';
        this.statistic = statistic;
        this.stageChanges = stageChanges;
    }

    public MoveEffect(StatusCondition effect)
    {
        type = 'e';
        this.effect = effect;
    }

    public MoveEffect(){}
}
