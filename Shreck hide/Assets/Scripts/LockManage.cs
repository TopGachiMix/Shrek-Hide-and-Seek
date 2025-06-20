using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CloseCastle : MonoBehaviour
{
    [SerializeField] private GameObject[] _lockSprite;
    [SerializeField] private Button[] _buttonLock;
    [SerializeField] public int[] savelevel;

    public int _levelFinish;


    private void Start()
    {
        _levelFinish = PlayerPrefs.GetInt("_saveLevelFinish");
        savelevel[0] = PlayerPrefs.GetInt("_saveLevel_1");
        savelevel[1] = PlayerPrefs.GetInt("_saveLevel_2");
        savelevel[2] = PlayerPrefs.GetInt("_saveLevel_3");
        savelevel[3] = PlayerPrefs.GetInt("_saveLevel_4");
        savelevel[4] = PlayerPrefs.GetInt("_saveLevel_5");
        savelevel[5] = PlayerPrefs.GetInt("_saveLevel_6");
        savelevel[6] = PlayerPrefs.GetInt("_saveLevel_7");
        savelevel[7] = PlayerPrefs.GetInt("_saveLevel_8");

    }

    private void Update()
    {
        



        if (_levelFinish >= 1)
            {
                _lockSprite[0].SetActive(false);
                _buttonLock[0].interactable = true;

            }

        if (_levelFinish >= 2)
        {
            _lockSprite[1].SetActive(false);
            _buttonLock[1].interactable = true;

        }

        if (_levelFinish >= 3)
        {
            _lockSprite[2].SetActive(false);
            _buttonLock[2].interactable = true;

        }

        if (_levelFinish >= 4)
        {
            _lockSprite[3].SetActive(false);
            _buttonLock[3].interactable = true;

        }

        if (_levelFinish >= 4)
        {
            _lockSprite[4].SetActive(false);
            _buttonLock[4].interactable = true;

        }

        if (_levelFinish >= 5)
        {
            _lockSprite[5].SetActive(false);
            _buttonLock[5].interactable = true;

        }

        if (_levelFinish >= 6)
        {
            _lockSprite[6].SetActive(false);
            _buttonLock[6].interactable = true;

        }

        if (_levelFinish >= 7)
        {
            _lockSprite[7].SetActive(false);
            _buttonLock[7].interactable = true;

        }

        

        PlayerPrefs.SetInt("_saveLevelFinish", _levelFinish);
        PlayerPrefs.SetInt("_saveLevel_1" , savelevel[0]);
        PlayerPrefs.SetInt("_saveLevel_2" ,savelevel[1]);
        PlayerPrefs.SetInt("_saveLevel_3" ,savelevel[2]);
        PlayerPrefs.SetInt("_saveLevel_4" ,savelevel[3]);
        PlayerPrefs.SetInt("_saveLevel_5" ,savelevel[4]);
        PlayerPrefs.SetInt("_saveLevel_6" ,savelevel[5]);
        PlayerPrefs.SetInt("_saveLevel_7" ,savelevel[6]);
        PlayerPrefs.SetInt("_saveLevel_8" ,savelevel[7]);
        PlayerPrefs.SetInt("_saveLevel_9" ,savelevel[8]);
        PlayerPrefs.Save();
    }

    public void CheckScen()
    {
        Time.timeScale = 1f;        
        if (SceneManager.GetActiveScene().buildIndex == 1 && savelevel[0] == 0)
        {
            savelevel[0]++;
            _levelFinish += 1;
            Debug.Log("FFFFFFFF");
        }

        else if (SceneManager.GetActiveScene().buildIndex == 2 && savelevel[1] == 0)
        {
            savelevel[1]++;
            _levelFinish += 1;
            Debug.Log("FFFFFFFF");
        }

        else if (SceneManager.GetActiveScene().buildIndex == 3 && savelevel[2] == 0)
        {
            savelevel[2]++;
            _levelFinish += 1;
            Debug.Log("FFFFFFFF");
        }

        else if (SceneManager.GetActiveScene().buildIndex == 4 && savelevel[3] == 0)
        {
            savelevel[3]++;
            _levelFinish += 1;
            Debug.Log("FFFFFFFF");
        }

        else if (SceneManager.GetActiveScene().buildIndex == 5 && savelevel[4] == 0)
        {
            savelevel[4]++;
            _levelFinish += 1;
            Debug.Log("FFFFFFFF");
        }

        else if (SceneManager.GetActiveScene().buildIndex == 6 && savelevel[5] == 0)
        {
            savelevel[5]++;
            _levelFinish += 1;
            Debug.Log("FFFFFFFF");
        }

        else if (SceneManager.GetActiveScene().buildIndex == 7 && savelevel[6] == 0)
        {
            savelevel[6]++;
            _levelFinish += 1;
            Debug.Log("FFFFFFFF");
        }

        else if (SceneManager.GetActiveScene().buildIndex == 8 && savelevel[7] == 0)
        {
            savelevel[7]++;
            _levelFinish += 1;
            Debug.Log("FFFFFFFF");
        }

        else if (SceneManager.GetActiveScene().buildIndex == 9 && savelevel[8] == 0)
        {
            savelevel[8]++;
            _levelFinish += 1;
            Debug.Log("FFFFFFFF");
        }

      
    }

}
