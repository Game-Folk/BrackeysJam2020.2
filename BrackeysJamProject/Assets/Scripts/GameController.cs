using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{   
    public Transform spawnPoint;
    public GameObject customer;
    public float spawnTime = 5f;

    public Transform[] shelfLocations;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnCustomer");   
    }

    private IEnumerator SpawnCustomer()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnTime);

            GameObject c = Instantiate(customer, spawnPoint.position, Quaternion.identity);
            CustomerController cc = c.GetComponent<CustomerController>();
            // TODO: pick a target
            cc.SetTarget(shelfLocations[0]);
        }
    }
}
