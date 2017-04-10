using UnityEngine;
using System.Collections;

public class CatchCat : MonoBehaviour
{
    public GameObject catPrefab;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cat")
        {
            Debug.Log("You Win!");
            audio.Play();
            Destroy(catPrefab);
        }
    }
}