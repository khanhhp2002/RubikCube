using UnityEngine;

public class WaitForPlayer : MonoBehaviour
{
    private void Update()   
    {
        if ((Input.GetKeyDown(KeyCode.Return)))
        {
            Rotate.rotateAllowed = true;
        }
    }
}
