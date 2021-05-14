using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavepointindex = 0;
    void Start()
    {
        target = waypoints.points[0];
    }
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }
    void GetNextWaypoint(){
        if (wavepointindex >= waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        
        wavepointindex++ ;
        target = waypoints.points[wavepointindex];
    }
}
