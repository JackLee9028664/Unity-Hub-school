using UnityEngine;


public class NewMonoBehaviourScript : MonoBehaviour
{
[SerializeField] float movespeed = 10f;
    void Start()
    {
     PrintInstructions();
    }

    void Update()
    {
       float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
       float yValue = 0;
       float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
       transform.Translate(xValue, yValue, zValue); 
    }

    void PrintInstructions()
    {
        Debug.Log("welcome to the game player");
        Debug.Log("move using wasD or arrow keys");
        Debug.Log("dont bump into objects");
    }

void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
       float yValue = 0;
       float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
       transform.Translate(xValue, yValue, zValue); 
    }

}
