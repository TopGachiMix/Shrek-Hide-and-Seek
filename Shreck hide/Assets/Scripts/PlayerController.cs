using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _speedJoystick;
    [SerializeField] private Joystick _joystick;
    [SerializeField] public int _grinder;
    [SerializeField] public TextMesh _grinderText;
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _lousePanel;

    private CloseCastle _lockLevel;
    private bool _isJoy = false; 

    private SliderManagers _sliderManagers;
    private Rigidbody _rigidBody;
    private Animator _animator;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        _sliderManagers = FindAnyObjectByType<SliderManagers>();
        _grinderText.text = $"{_grinder} / 3";
        _lockLevel = FindAnyObjectByType<CloseCastle>();
    }

    private void Update()
    {
        _grinderText.text = $"{_grinder} / 3";

        if (_grinder == 3)
        {
            _sliderManagers._audioOpenDoor.Play();
            Debug.Log("FFFFFFFFF");
        }

        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
            {
                _isJoy = true;
            }
            else if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                _isJoy = false;
            }
    }

    private void FixedUpdate()
    {
        Vector3 moveInput = Vector3.zero;

        if (_isJoy)
        {
            Vector3 moveInputJoystick = new Vector3(_joystick.Horizontal, 0, _joystick.Vertical);
            moveInput = moveInputJoystick * _speedJoystick;
            _rigidBody.velocity = moveInput; 
        }
        else
        {
            Vector3 moveInputKeyboard = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            moveInput = moveInputKeyboard * _speed * Time.fixedDeltaTime;
            _rigidBody.MovePosition(_rigidBody.transform.position + moveInput); // Применяем скорость для клавиатуры
        }

        if (moveInput.x != 0 || moveInput.z != 0)
        {
            _animator.SetBool("_isRun", true);
            Vector3 direction = Vector3.RotateTowards(transform.forward, moveInput.normalized, (_isJoy ? _speedJoystick : _speed), 0.0f);
            transform.rotation = Quaternion.LookRotation(direction);
        }
        else
        {
            _animator.SetBool("_isRun", false);
        }
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Grinder"))
        {
            _grinder++;
            Destroy(coll.gameObject);
            _sliderManagers._audioGrinderEquip.Play();
        }
        else if (coll.CompareTag("Shreck"))
        {
            _animator.SetTrigger("_isFall");
            GetComponent<PlayerController>().enabled = false;
            _lousePanel.SetActive(true);
            _sliderManagers._audioLouseGame.Play();
        }
        else if (coll.CompareTag("Door"))
        {
            Debug.Log("Вы покинули комнату");
            GetComponent<PlayerController>().enabled = false;
            GetComponent<Animator>().enabled = false;
            Time.timeScale = 0f;
            _winPanel.SetActive(true);
        }
    }
}