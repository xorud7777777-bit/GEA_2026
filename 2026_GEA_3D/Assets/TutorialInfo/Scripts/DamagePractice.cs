using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    public int attack;
    public int defense;
    public bool isCritical;
    public bool targetIsBoss;

    [ContextMenu("데미지")]
    void Calc()
    {
        int damage = attack - defense;
        damage = Mathf.Max(damage, 1);

        if (isCritical)
        {
            damage = damage * 2;
        }

        if (targetIsBoss)
        {
            damage = damage / 2;
        }

        // 최종 데미지 출력
        Debug.Log(damage);
    }
}