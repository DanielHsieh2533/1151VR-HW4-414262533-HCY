using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI times;
    public static int hit = 0;
   
    void Start()
    {
        hit = 0;
        times.text = "Hit Count:\n" + hit.ToString("D");
        Application.targetFrameRate = 60;
    }

        void Update()
    {
        
        times.text = "Hit Count:\n" + hit.ToString("D");
    }
}
