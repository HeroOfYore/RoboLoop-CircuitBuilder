using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloverMechanic : MonoBehaviour
{
    Progression progression;
    public int level;
    void Awake()
    {
        progression = FindObjectOfType<Progression>();
        level = 1;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        progression.encounters[progression.currEnemyRef].GetComponent<ItemDrop>().dropBoost += 0.05f + (0.02f * (level - 1));
    }
}
