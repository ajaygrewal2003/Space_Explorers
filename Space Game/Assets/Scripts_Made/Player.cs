using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{

    private Vector2 targetPos;
    public float YIncrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health=5;

    private void Update()
    {
        if (health < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow)&& transform.position.y<maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y+ YIncrement);
            

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos =new Vector2(transform.position.x, transform.position.y - YIncrement);
            
        }
        
    }
}
