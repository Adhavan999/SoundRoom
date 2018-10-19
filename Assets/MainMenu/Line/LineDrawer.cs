using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    EdgeCollider2D edgecol;
    LineRenderer lineRenderer;
    Vector2[] temparray = new Vector2[2];

    [HideInInspector]
    public GameObject prevline = null;

    private void Start()
    {
        lineRenderer = this.GetComponent<LineRenderer>();
        edgecol = this.GetComponent<EdgeCollider2D>();
        Vector2 startpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lineRenderer.SetPosition(0,startpos);
        temparray[0] = startpos;
        
    }

    public void UpdateLine(Vector2 MousePos)
    {
        lineRenderer.SetPosition(1, MousePos);
        temparray[1] = MousePos;
        edgecol.points = temparray;
    }

    public Vector2 Returnormal()
    {
        Vector2 line = temparray[1] - temparray[0], normal;
        normal.x = -line.y;
        normal.y = line.x;
        return normal;
    }
}