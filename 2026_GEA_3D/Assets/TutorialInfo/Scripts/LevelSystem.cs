using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int expPerKill = 35000; // 몬스터 한 마리의 경험치
    public int killCount = 3;      // 잡은 마릿수

    [ContextMenu("레벨 계산")]
    void CalculateLevel()
    {
        int level = 1;
        int exp = 0;

        // 1. 기본 레벨업 계산
        for (int i = 1; i <= killCount; i++)
        {
            exp += expPerKill;

            while (exp >= level * 10000)
            {
                exp -= level * 10000;
                level++;
                Debug.Log($"레벨업! Lv {level} ({i} 마리째)");
            }
        }

        int requiredExp = level * 10000;

        // [업그레이드 1] 경험치 막대 (10칸)
        int barLength = 10;
        int filledCount = exp * barLength / requiredExp; // 정수 나눗셈으로 소수점 버림
        string expBar = "";

        for (int i = 0; i < barLength; i++)
        {
            if (i < filledCount)
            {
                expBar += "■";
            }
            else
            {
                expBar += "□";
            }
        }

        Debug.Log($"최종 Lv {level} {expBar} {exp} / {requiredExp}");

        // [업그레이드 2] 남은 마릿수 (expPerKill이 0이면 출력 안 함 & 0 나누기 방지)
        if (expPerKill > 0)
        {
            int remainExp = requiredExp - exp;
            // 올림 나눗셈 공식: (남은 경험치 + 한 마리당 경험치 - 1) / 한 마리당 경험치
            int remainKills = (remainExp + expPerKill - 1) / expPerKill;
            Debug.Log($"같은 몬스터를 {remainKills} 마리 더 잡으면 레벨업");
        }

        // [업그레이드 3] 천 단위 쉼표 (ToString 없이 직접 구현)
        int totalExp = expPerKill * killCount;
        string formattedTotalExp = "";

        if (totalExp == 0)
        {
            formattedTotalExp = "0";
        }
        else
        {
            int temp = totalExp;
            int digitCount = 0;

            while (temp > 0)
            {
                // 3자리마다 쉼표 추가 (맨 앞자리 제외)
                if (digitCount > 0 && digitCount % 3 == 0)
                {
                    formattedTotalExp = "," + formattedTotalExp;
                }

                // 일의 자리 숫자를 꺼내 문자열 앞에 붙임
                int lastDigit = temp % 10;
                formattedTotalExp = lastDigit + formattedTotalExp;

                temp /= 10;
                digitCount++;
            }
        }

        Debug.Log($"얻은 경험치 합계 {formattedTotalExp}");
    }
}