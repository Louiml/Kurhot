using System.Threading.Tasks;
using UnityEngine;

public class TargetScript2 : MonoBehaviour
{
    public GameObject killedObject;

    async void Update()
    {
        await Task.Delay(11500);
        gameObject.transform.position = new Vector3(4.8f, 0.0630002f, 18.67f);
        gameObject.SetActive(false);
        Afterkill();
        await Task.Delay(11500);
    }

    async void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            killedObject.SetActive(true);
            await Task.Delay(2500);
            killedObject.SetActive(false);
            gameObject.transform.position = new Vector3(4.8f, 0.0630002f, 18.67f);
            Afterkill();
        }
    }

    async void Afterkill()
    {
        await Task.Delay(5500);
        gameObject.SetActive(true);
    }
}
