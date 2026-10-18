using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameObject Plane;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Plane = GameObject.Find("Plane");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Plane planescript = Plane.GetComponent<Plane>();
        
        
        Vector3 sphereCenter = transform.position;
        Vector3 planeCenter = Plane.transform.position;
        Vector3 dir = sphereCenter - planeCenter;
        float d = dir.magnitude;
        float sr = 1.0f;
        float pr = 0.4f;
        if(d < sr + pr)
        { 
            UI.hit++;
            Destroy(gameObject);     
            
            AudioSource.PlayClipAtPoint(planescript.crash, transform.position);
               
        }
        else if(transform.position.z == Plane.transform.position.z)
        {

            AudioSource.PlayClipAtPoint(planescript.avoid, transform.position);
        }

        if(transform.position.z < Plane.transform.position.z - 8)
        {
            Destroy(gameObject);
        }
    }
}
