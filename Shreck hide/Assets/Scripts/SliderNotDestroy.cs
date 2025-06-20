using UnityEngine;

public class SliderNotDestroy : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    } 
}
