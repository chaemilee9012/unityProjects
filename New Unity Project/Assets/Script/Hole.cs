using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public GameObject monster;

    IEnumerator Start()
    {
        monster.SetActive(false);
        while (true)
        {
            // 3초마다 두더지 active 상태로
            yield return new WaitForSeconds(Random.Range(2.0f, 4.0f));
            monster.SetActive(true);
        }
    }

    public void OnClick()
    {
        // setActive true일때만 활성화
        if (monster.activeSelf)
        {
            Score.value += 1;
        }
        monster.SetActive(false);
    }
}
