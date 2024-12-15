
using System.Collections.Generic;

public struct GameSet
{
    public int playerCount;
    public int cardMaxCount;
    public int cardCount;
    public CardType cardType;
    
}

public struct PlayerSet
{
    public List<int> cards;
    public ActionType actionType;
    
    
}

public enum GameProcess
{
    Ready,          // 시작 버튼을 누르기 전
    Start,          // 시작 버튼을 누른 후, 카드 셔플
    CardSelect,     // 카드 선택
    PlayerSelect,   // 공격 대상 선택
    
}

public enum CardType
{
    duck,
    penguin,
    sparrow,
    goose,
    crow,
    eagle,
    parrot,
    pelican
}

public enum ActionType
{
    pass,
    give,       // 공격
    take        // 방어
}