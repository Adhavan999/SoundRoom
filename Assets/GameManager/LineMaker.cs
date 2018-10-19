using UnityEngine;

public class LineMaker : MonoBehaviour
{

    public GameObject linePrefab;
    GameObject prevlines;
    bool ispressed = false;
    LineDrawer activeLine;
    float nooflines = 0;
    public AudioClip CurrentBeat;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(nooflines == 0)
            {
                GameObject lineGO = Instantiate(linePrefab);
                activeLine = lineGO.GetComponent<LineDrawer>();
                lineGO.GetComponent<MakeBeat>().beat = CurrentBeat; 
                ispressed = true;
                prevlines = lineGO;
                ++nooflines;
            }
            else
            {
                ++nooflines;
                GameObject lineGO = Instantiate(linePrefab);
                activeLine = lineGO.GetComponent<LineDrawer>();
                lineGO.GetComponent<MakeBeat>().beat = CurrentBeat;
                ispressed = true;
                activeLine.prevline = prevlines;
                prevlines = lineGO;
            }
            
        }

        else if (ispressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePos);
        }

        if (Input.GetMouseButtonUp(0))
        {
            ispressed = false;
        }
    }

    public void linedeleter()
    {
        //Deleting the line that pops up every click for some reason
        ghostlinedeleter();
       
        //Deleting the ACTUAL previous line while it exists
        if (prevlines != null)
        {
            GameObject temp = prevlines.GetComponent<LineDrawer>().prevline;
            Destroy(prevlines);
            prevlines = temp;
        }
    }

    public void ghostlinedeleter()
    {
        GameObject temp = prevlines.GetComponent<LineDrawer>().prevline;
        Destroy(prevlines);
        prevlines = temp;
    }

}