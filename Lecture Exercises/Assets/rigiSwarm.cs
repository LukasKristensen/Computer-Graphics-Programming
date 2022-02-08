using UnityEngine;
using System.Collections;
public class rigiSwarm : MonoBehaviour
{
    public GameObject follower;
    public GameObject spawnPosition;

    public Vector3 newPos = new Vector3(0.0f, 100.0f, 100.0f);
    public int amountSpawn = 100;
    private float calcColor;
    int countTotal = 0;
    float localCount = 0;
    float multiplyFade = 1;

    void Start() { 
        StartCoroutine("Spawn");
        
    }


    IEnumerator Spawn()
    {
        for (int i = 0; i < amountSpawn; i++)
        {
            countTotal += 1;
            newPos.Normalize();
            spawnPosition.transform.Translate(newPos.y*new Vector3(Mathf.Sin(i) * 4, Mathf.Sin(i)*4, 0));


            calcColor = i * 1.0f / amountSpawn;
            calcColor = 1.0f - calcColor;
            follower.GetComponent<Renderer>().material.color = new Color(0, calcColor, 0);

            Instantiate(follower, spawnPosition.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
        }
    }

    void Update()
    {
        StartCoroutine("ExampleCoroutine");
    }



    IEnumerator ExampleCoroutine()
    {
        if (countTotal == amountSpawn)
        {
            localCount += (0.001f * multiplyFade);

            if (localCount >= 1.0f | localCount <= 0.0f)
            {
                multiplyFade *= -1;
            }

            follower.GetComponent<Renderer>().material.color = new Color(localCount, localCount, localCount);

            yield return new WaitForSeconds(0.1f);
        }
    }

}