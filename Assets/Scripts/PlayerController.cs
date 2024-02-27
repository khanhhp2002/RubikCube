using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rotate _rotate;

    private Transform _startPiece = null;
    private Transform _endPiece = null;
    private bool _isRotating;

    // Update is called once per frame
    void Update()
    {
        if (_isRotating) return;
        if (Input.GetMouseButtonDown(0))
        {
            Transform temp = Shoot();
            if (temp != null && _startPiece == null)
            {
                _startPiece = temp;
            }
        }
        else if (Input.GetMouseButton(0))
        {
            Transform temp = Shoot();
            if (temp != null && temp != _startPiece && _endPiece == null && _startPiece != null)
            {
                _endPiece = temp;
                if (_rotate.CheckTwoPiece(_startPiece.parent.transform, _endPiece.parent.transform))
                {
                    Debug.Log("=D");
                    _startPiece = null;
                    _endPiece = null;
                }
            }
        }
    }

    private Transform Shoot()
    {
        Debug.DrawRay(Camera.main.ScreenPointToRay(Input.mousePosition).origin, Camera.main.ScreenPointToRay(Input.mousePosition).direction * 100f, Color.red);
        RaycastHit hitInfo;

        Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, Mathf.Infinity);
        if (hitInfo.transform == null) return null;

        if (6 <= hitInfo.transform.gameObject.layer && hitInfo.transform.gameObject.layer <= 11)
        {
            Debug.Log(hitInfo.normal);
            return hitInfo.transform;
        }
        return null;
    }
}
