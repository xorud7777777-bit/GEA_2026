using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    // 필드 변수 선언
    public int attack = 10; // 필드
    int killCount = 0;      // 필드

    public int gold = 100;
    public int potion = 3;

    // 게임 시작 시 실행
    void Start()
    {
        Debug.Log(attack);
    }

    // 공격 명중 시 실행
    void Hit()
    {
        killCount = killCount + 1;
    }

    // 처치 함수 추가
    [ContextMenu("처치")]
    void CountKill()
    {
        int defense = 3;  // 지역 변수
        killCount = killCount + 1;
        Debug.Log(attack - defense);
        Debug.Log(killCount);
    }

    // ContextMenu 함수 모음
    [ContextMenu("Hello")]
    void Hello()
    {
        Debug.Log("Hello");
    }

    [ContextMenu("테스트 1")]
    void Test1()
    {
        int hp = 10;
        Debug.Log(hp);
    }

    [ContextMenu("테스트 2")]
    void Test2()
    {
        int hp = 7;
        Debug.Log(hp);
    }

    [ContextMenu("골드 보기")]
    void ShowGold()
    {
        Debug.Log(gold);
    }

    [ContextMenu("예측 1")]
    void Predict1()
    {
        int hp = 10;
        hp = hp - 3;
        Debug.Log(hp);

        hp = 20;
        Debug.Log(hp);

        int maxHp = hp;
        hp = 5;
        Debug.Log(maxHp);
    }
}