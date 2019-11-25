using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public GameObject AttackPrefab;
    public int AttackRange = 1;
    
    void Update()
    {
        Debug.DrawLine(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), Color.white);

        Vector3 newDir = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);


    }
}
