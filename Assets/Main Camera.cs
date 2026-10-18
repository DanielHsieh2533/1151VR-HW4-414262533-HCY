using UnityEngine;


public class MainCamera : MonoBehaviour
{
    public GameObject targetObject;
    void Start()
    {
        Vector3 startPos = new Vector3(0, 3, -7);
        transform.position = startPos;
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        Vector3 pos = new Vector3(0, 3, targetObject.transform.position.z - 7);
        transform.position = pos;
    }
}
