using UnityEngine;

public class SharkBehavior : MonoBehaviour
{
    public Vector3 velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += velocity * Time.deltaTime;
        // this.transform.rotation = Quaternion.LookRotation(velocity);
    }
}
