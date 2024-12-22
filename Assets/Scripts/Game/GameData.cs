
using System;
using System.Collections.Generic;
using UnityEngine.UIElements;

public struct GameSet
{
    public int playerCount;
    public int cardMaxCount;
    public int cardCount;

    
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
    Attack,         // 공격 대상, 카드 + 참/거짓 (ui 로 선택한 대상, 카드, 참/거짓 표시해두고 바꾸기 편하게)
    Defence,        // 공격 받은 사람 (정답을 맞추거나 패스) / 패스하면 다시 Attack(카드는 정해져있음)  
    CheckCard      // 성공/실패 확인(공격 성공 시 상대 덱에 카드 추가, 실패하면 공격자의 덱에 카드 추가) -> 카드가 4장 이상 있는지 체크 / 다시 Attack 시작
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
    pelican,
    END
}

public enum ActionType
{
    pass,
    give,       // 공격
    take        // 방어
}