using UnityEngine;
using UnityEngine.AI;

public class Shreck : MonoBehaviour
{
    [SerializeField] private GameObject[] _pos;
    private NavMeshAgent _agent;
    private int _rand;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        SetNewDestination();
    }

    private void FixedUpdate()
    {

        if (Vector3.Distance(transform.position, _pos[_rand].transform.position) < 1.5f)
        {
            SetNewDestination();
        }
    }

    private void SetNewDestination()
    {
        _rand = Random.Range(0, _pos.Length);
        _agent.SetDestination(_pos[_rand].transform.position);
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            Debug.Log("Вас Поймали");
        }
    }
}
