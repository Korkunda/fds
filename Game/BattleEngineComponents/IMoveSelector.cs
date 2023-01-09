using Script_Print.Characters.Moves;

namespace Script_Print.Game.BattleEngineComponents
{
    public interface IMoveSelector
    {
        Moveset PlayerMoveSet { get; set; }

        Move SelectMove();

        void SetMoves(Moveset moves);
    }
}