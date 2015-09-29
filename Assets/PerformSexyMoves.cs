using UnityEngine;
using System.Collections;

public class PerformSexyMoves : MonoBehaviour
{
    private void Update()
    {
        transform.position = 
            new Vector3(
                Mathf.Sin(4 * Time.time), 
                Mathf.Cos(5 * Time.time), 
                Mathf.Sin(6 * Time.time)
                );
    }
}
