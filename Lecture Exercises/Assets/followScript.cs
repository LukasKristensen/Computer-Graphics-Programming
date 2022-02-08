using UnityEngine;

public class followScript : MonoBehaviour
{
    public GameObject followed;



        void Update()
        {
        GetComponent<Rigidbody>().velocity = 0.95f * GetComponent<Rigidbody>().velocity + 0.05f * (followed.transform.position - transform.position);
        }
}