using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private Camera mainCamera;
    public GameObject Plane;
    private float initialZDistance;
    public GameObject ObstaclesPrefab;
    private float span = 1.0f;
    private float delta = 0;

    void Start()
    {
        mainCamera = Camera.main;
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span)
        {
            delta = 0;
            GameObject gen = Instantiate(ObstaclesPrefab);

            float px = Random.Range(Plane.transform.position.x - 2, Plane.transform.position.x + 2);
            float py = Random.Range(Plane.transform.position.y - 2, Plane.transform.position.y + 2);
            gen.transform.position = new Vector3(px, py, Plane.transform.position.z + 100);

        }
    }
}
