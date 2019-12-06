using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Transfer");
    }

    IEnumerator Transfer() {
        Debug.Log("collider is triggered");

        yield return new WaitForSeconds(1);// waits for a player

        Debug.Log("Collider 1 sec");

        gameObject.transform.parent.position = new Vector3(0, 0, gameObject.transform.position.z + 200);
    }
}
