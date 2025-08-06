using System.Collections;
using UnityEngine;

public class RaycastTrailRenderer : MonoBehaviour
{
    public void RecieveStartData(RaycastHit hit, Vector3 startPosition)
    {
        StartCoroutine(SpawnTrail(hit, startPosition));
    }


    private IEnumerator SpawnTrail(RaycastHit hit, Vector3 startPosition)
    {
        float time = 0;
        TrailRenderer trail = GetComponent<TrailRenderer>();
        while(time < 1)
        {
            transform.position = Vector3.Lerp(startPosition, hit.point, time);
            time += Time.deltaTime / trail.time;

            yield return null;
        }
        transform.position = hit.point;
        Destroy(gameObject, trail.time);
    }

}
