using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit2 : Unit
{
    [SerializeField]
    private GameObject standardUnit;
    protected override void PlayerCollision()
    {
        GameObject unit = Instantiate(standardUnit, transform.position + Vector3.up * 2, Quaternion.Euler(0, 0, Random.Range(-45f, 45f)));
        unit.GetComponent<Rigidbody>().AddForce(unit.transform.up* 10, ForceMode.Impulse);
        scoreManager.AddScore(10);

    }
}
