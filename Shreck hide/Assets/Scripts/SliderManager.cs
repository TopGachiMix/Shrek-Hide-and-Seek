using UnityEngine;
using UnityEngine.UI;

public class SliderManagers : MonoBehaviour
{

    [SerializeField] private Slider _sliderMusic;
    [SerializeField] public Slider _sliderSound;
    [SerializeField] private AudioSource _audioMusicSource;
    [SerializeField] private AudioSource _audioSoundSource;
    [SerializeField] public AudioSource _audioWinGame;
    [SerializeField] public AudioSource _audioLouseGame;
    [SerializeField] public AudioSource _audioOpenDoor;
    [SerializeField] public AudioSource _audioGrinderEquip;

    



    private void Start()
    {
        LoadAudioSettings();

    }

    private void LoadAudioSettings()
    {
        _sliderSound.value = PlayerPrefs.GetFloat("SoundVolume");
        _sliderMusic.value = PlayerPrefs.GetFloat("MusicVolume");
        float savedSoundVolume1 = PlayerPrefs.GetFloat("SoundVolume1", 1f);
        float savedSoundVolume2 = PlayerPrefs.GetFloat("SoundVolume2", 1f);
        float savedSoundVolume3 = PlayerPrefs.GetFloat("SoundVolume3", 1f);
        float savedSoundVolume4 = PlayerPrefs.GetFloat("SoundVolume4", 1f);





        _audioGrinderEquip.volume = savedSoundVolume1;
        _audioLouseGame.volume = savedSoundVolume2;
        _audioWinGame.volume = savedSoundVolume3;
        _audioOpenDoor.volume = savedSoundVolume4;
    }

    public void SoundVolumeManager()
    {
        _audioSoundSource.volume = _sliderSound.value;
        _audioMusicSource.volume = _sliderMusic.value;
        _audioGrinderEquip.volume = _sliderSound.value;
        _audioLouseGame.volume = _sliderSound.value;
        _audioWinGame.volume = _sliderSound.value;
        _audioOpenDoor.volume = _sliderSound.value;

        PlayerPrefs.SetFloat("MusicVolume", _audioMusicSource.volume);
        PlayerPrefs.SetFloat("SoundVolume", _audioSoundSource.volume);
        PlayerPrefs.SetFloat("SoundVolume1", _audioGrinderEquip.volume);
        PlayerPrefs.SetFloat("SoundVolume2", _audioLouseGame.volume);
        PlayerPrefs.SetFloat("SoundVolume3", _audioWinGame.volume);
        PlayerPrefs.SetFloat("SoundVolume4", _audioOpenDoor.volume);
        
    }

    private void Update()
    {
        PlayerPrefs.SetFloat("MusicVolume", _sliderMusic.value);
        PlayerPrefs.SetFloat("SoundVolume", _sliderSound.value);
        PlayerPrefs.Save();

        SoundVolumeManager();
    }


    
}
