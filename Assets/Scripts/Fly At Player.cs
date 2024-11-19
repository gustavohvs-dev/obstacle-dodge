using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] float speed = 1f;
    Vector3 playerPosition;

    //Awake is called when openning the scene
    void Awake()
    {
        gameObject.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime * 10f);
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if(transform.position == playerPosition){
            Destroy(gameObject);
        }
    }

}
