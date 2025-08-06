using System.Collections;
using UnityEngine;

public class RaycastTrailRenderer : MonoBehaviour
{
    public void RecieveStartData(RaycastHit hit, Transform startPosition)
    {
        StartCoroutine(SpawnTrail(hit, startPosition));
    }


    private IEnumerator SpawnTrail(RaycastHit hit, Transform startPosition)
    {
        float time = 0;
        TrailRenderer trail = GetComponent<TrailRenderer>();
        while(time < 1)
        {
            transform.position = Vector3.Lerp(startPosition.position, hit.point, time);
            time += Time.deltaTime / trail.time;

            yield return null;
        }
        transform.position = hit.point;
        Destroy(gameObject, trail.time);
    }

}
