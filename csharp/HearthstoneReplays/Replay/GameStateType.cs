namespace HearthstoneReplays.Replay
{
	public enum GameStateType
	{
		UNKNOWN,
		ATTACK,
		JOUST,
		POWER,
		TRIGGER,
		DEATHS,
		PLAY,
		FATIGUE
	}

	public enum GameStateSubType
	{
		DRAW
	}

	public enum MetaDataType
	{
		TARGET,
		DAMAGE,
		HEALING,
		JOUST
	}

    public enum ActionType
    {
        Unknown,
        TurnStart,
        Mulligan,
        Draw,
        Play,
        HandDiscard,
        Attack,
        Damage,
        Death,
        Victory,
        Loss,
        Tie,
        Deaths,
        Fatigue,
        ActionPlay,
        ActionAttack,
        ActionDeaths,
        ActionFatigue,
        ActionJust,
        ActionPower,
        ActionTrigger
    }
}