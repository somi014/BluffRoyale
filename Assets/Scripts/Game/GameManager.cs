


using System;

/// <summary>
/// 게임 진행 관련
/// </summary>
public class GameManager
{
    private GameProcess gameProcess;
    private GameSet gameSet;

    private void GameSet()
    {
        gameSet = new GameSet
        {
            playerCount = 4,
            cardCount = 64 // 8종류 8장씩
        };
        gameSet.cardMaxCount = (int)(gameSet.cardCount / gameSet.playerCount);
    }
    
    private void CardShuffle()
    {
        
    }

    private void CheckGameProcess()
    {
        switch (gameProcess)
        {
            case GameProcess.Ready:
                break;
            case GameProcess.Start:
                break;
            case GameProcess.Attack:
                break;
            case GameProcess.Defence:
                break;
            case GameProcess.CheckCard:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}