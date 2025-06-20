using UnityEngine;
using UnityEngine.SceneManagement;
public class Door : MonoBehaviour
{
    private Animator _animator;
    private PlayerController _playerController;
    private Shreck _shreck;
    private SliderManagers _sliderManagers;

    [SerializeField] public bool _scenes;
    // private CloseCastle _lockLevel;



    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerController = FindAnyObjectByType<PlayerController>();
        _shreck = FindAnyObjectByType<Shreck>();
        // _lockLevel = FindAnyObjectByType<CloseCastle>();

        _scenes = false;

    }

    private void Update()
    {
        if (_playerController._grinder == 3)
        {
            _animator.SetTrigger("_isOpen");
            GetComponent<BoxCollider>().enabled = false;
            _sliderManagers._audioOpenDoor.Play();

        }
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
           
        }
    }



}
