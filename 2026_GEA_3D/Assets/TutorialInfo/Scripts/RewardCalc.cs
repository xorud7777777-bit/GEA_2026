using UnityEngine;

public class ResultPractice : MonoBehaviour
{
    // 필드 선언 (이미지 조건 기본값)
    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;
    public float expRate = 1.5f;

    [ContextMenu("결과 출력")]
    void ShowResult()
    {
        // 1. 플레이 시간 (시:분:초, 분/초 두 자리 포맷팅 조건: ToString 없이 /, % 로만 처리)
        int hours = playSeconds / 3600;
        int minutes = (playSeconds % 3600) / 60;
        int seconds = playSeconds % 60;

        string minStr = (minutes < 10 ? "0" : "") + minutes;
        string secStr = (seconds < 10 ? "0" : "") + seconds;
        Debug.Log("플레이 시간 " + hours + ":" + minStr + ":" + secStr);

        // 2. 골드 분배
        int goldPerMember = gold / members;
        int leaderBonus = gold % members;
        Debug.Log("1인당 " + goldPerMember + "G, 리더 보너스 " + leaderBonus + "G");

        // 3. 경험치 계산 (소수점 버림)
        int baseExp = kills * expPerKill;
        int finalExp = (int)(baseExp * expRate);
        Debug.Log("경험치 " + finalExp + " (기본 " + baseExp + ")");

        // 4. 레벨 및 다음 레벨까지 남은 경험치 (레벨은 1부터 시작, 100 당 1레벨)
        int level = 1 + (finalExp / 100);
        int expNext = 100 - (finalExp % 100);
        Debug.Log("Lv " + level + ", 다음 레벨까지 " + expNext);

        // 5. 평균 데미지 (소수점까지 구하기 위해 형변환)
        float avgDamage = (float)totalDamage / hits;
        Debug.Log("평균 데미지 " + avgDamage);
    }
}