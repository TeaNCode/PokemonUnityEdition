public class Move
{ 
    public MoveData moveData;
    public byte ppRemaining;

    public Move(MoveData moveData)
    {
        this.moveData = moveData;
        ppRemaining = moveData.pp;
    }

    public Move(MoveData moveData, byte ppRemaining)
    {
        this.moveData = moveData;
        if(ppRemaining <= moveData.pp)
        this.ppRemaining = ppRemaining;
        else
        this.ppRemaining = moveData.pp;
    }
}
