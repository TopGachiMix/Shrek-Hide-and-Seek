using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    Vector3 _posEnd, _posSmooth;
    [SerializeField] private GameObject _player;

    private void Update()
    {
        _posEnd = new Vector3(_player.transform.position.x, 18, _player.transform.position.z - 8f);
        _posSmooth = Vector3.Lerp(transform.position, _posEnd, 0.1f);

        transform.position = _posSmooth;
    }
}
