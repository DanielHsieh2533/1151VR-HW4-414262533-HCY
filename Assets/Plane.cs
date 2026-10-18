using UnityEngine;

public class Plane : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Camera mainCamera;
    private float initialZDistance;
    
    private float V = 30f;
    private float current_posZ;
    
    [SerializeField] public AudioClip crash;
    [SerializeField] public AudioClip avoid;
    void Start()
    {
        mainCamera = Camera.main;
        initialZDistance = mainCamera.transform.InverseTransformPoint(transform.position).z;
        current_posZ = initialZDistance;
        Application.targetFrameRate = 60;
    }


    // Update is called once per frame
    void Update()
    {
        if(!GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().Play();
        }
        
        current_posZ += V / 60;
        Vector3 mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = initialZDistance;
        Vector3 targetWorldPos = mainCamera.ScreenToWorldPoint(mouseScreenPos);
        transform.position = new Vector3(targetWorldPos.x, targetWorldPos.y, current_posZ);
    }
}
