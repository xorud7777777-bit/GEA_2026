using UnityEngine;
using UnityEngine.UI;

public class StatPractice : MonoBehaviour
{
    // Health 스크립트 및 체력 계산용 필드
    public Slider hpSlider;
    public int currentHp = 7;
    public int maxHp = 10;

    // 2. public 필드 4개 선언
    public string playerName;
    public int level;
    public float attack = 12.5f;
    public bool isBoss;

    // 3. [ContextMenu("스탯")] 함수 ShowStat 작성
    [ContextMenu("스탯")]
    void ShowStat()
    {
        Debug.Log("플레이어 이름" + playerName);
        Debug.Log("레벨" + level);
        Debug.Log("공격력" + attack);
        Debug.Log("보스 유무" + isBoss);
    }

    public string itemName = "포션";
    public int price = 30;
    public float discount = 0.5f;
    public bool isSoldOut = false;

    [ContextMenu("가격")]
    void ShowPrice()
    {
        float finalPrice = price * discount;
        Debug.Log(itemName + " " + finalPrice);
    }

    // 오버플로 테스트 함수
    [ContextMenu("오버플로")]
    void Overflow()
    {
        int gold = int.MaxValue;
        Debug.Log(gold);
        gold = gold + 1;
        Debug.Log(gold);

        byte red = 255;
        red++;
        Debug.Log(red);
    }

    // 정밀도 테스트 함수
    [ContextMenu("정밀도")]
    void Precision()
    {
        double d = 0.1 + 0.2;
        Debug.Log(d == 0.3);

        float big = 16777216f;
        float sum = big + 1f;
        Debug.Log(sum == big);

        float half = 1 / 2;
        Debug.Log(half);
    }

    // 자료형 테스트 함수
    [ContextMenu("자료형")]
    void Types()
    {
        int level = 30;
        byte red = 255;
        char grade = 'S';
        float speed = 5.5f;
        bool isHigh = level >= 10;

        Debug.Log(level + " " + red + " " + grade);
        Debug.Log(speed + " " + isHigh);
    }

    // 예측 2 함수
    [ContextMenu("예측 2")]
    void Predict2()
    {
        int hp = 7;
        int maxHp = 10;
        Debug.Log(hp / maxHp);
        Debug.Log((float)hp / maxHp);
        Debug.Log(hp / 2);
        Debug.Log(hp / 2f);
        Debug.Log(hp % 2);
    }

    // 나머지 연산 함수
    [ContextMenu("나머지")]
    void Remainder()
    {
        int shotCount = 6;
        int totalSeconds = 135;

        bool isEven = shotCount % 2 == 0;
        bool strongShot = shotCount % 3 == 0;
        int min = totalSeconds / 60;
        int sec = totalSeconds % 60;
        Debug.Log(min + ":" + sec);
    }

    // 예측 3 함수
    [ContextMenu("예측 3")]
    void Predict3()
    {
        int a = 1;
        int b = 2;
        Debug.Log("합: " + a + b);
        Debug.Log("합: " + (a + b));
        Debug.Log(a + b + "점");
        Debug.Log("HP " + 7 / 2);
    }

    // 새로 추가된 체력 퍼센트 출력 함수
    [ContextMenu("체력")]
    void PrintHp()
    {
        int a = (int)((float)currentHp / maxHp * 100);
        Debug.Log("HP " + a + "%");

        int b = currentHp * 100 / maxHp;
        Debug.Log("HP " + b + "%");
    }

    // 체력바 업데이트 함수
    void UpdateBar()
    {
        if (hpSlider != null)
        {
            hpSlider.value = (float)currentHp / maxHp;
        }
    }
}