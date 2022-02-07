using UnityEngine;

//Struktur af koden er fra: https://www.youtube.com/watch?v=Ey8MHswqzko
//TO-DO Kommenter og skriv koden fra bunden

[ExecuteInEditMode]


public class mirrorPosition : MonoBehaviour
{
    Vector3 vectorRot;

    public GameObject mainCamera;
    public GameObject mirror;

    
    
    void Update()
    {
        Vector3 direction = (mainCamera.transform.position - mirror.transform.position);
        Quaternion rotation = Quaternion.LookRotation(direction);
        rotation.eulerAngles = mirror.transform.eulerAngles - rotation.eulerAngles;
        transform.rotation = rotation;
    }
}