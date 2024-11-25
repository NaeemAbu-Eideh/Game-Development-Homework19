using UnityEngine;

public class HandMover : MonoBehaviour
{
    public Transform target;
    public Transform leftColumn;
    public Transform rightColumn;

    public float speed = 5f;
    private bool movingRight = true;

    void Start()
    {
        GameObject targetObject = GameObject.Find("Hand1");
        if (targetObject != null)
        {
            target = targetObject.transform;
        }

        if (leftColumn == null) leftColumn = GameObject.Find("LeftColumn").transform;
        if (rightColumn == null) rightColumn = GameObject.Find("RightColumn").transform;
    }

    void Update()
    {
        if (target != null && leftColumn != null && rightColumn != null)
        {
            float moveStep = speed * Time.deltaTime;
            if (movingRight)
            {
                target.position += Vector3.right * moveStep;
                if (target.position.x >= rightColumn.position.x)
                {
                    movingRight = false;
                }
            }
            else
            {
                target.position += Vector3.left * moveStep;
                if (target.position.x <= leftColumn.position.x)
                {
                    movingRight = true;
                }
            }
        }
    }
}
