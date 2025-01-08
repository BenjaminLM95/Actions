using UnityEngine;

public class CylinderScript : MonoBehaviour
{
    public Material nMaterial; 

    public void materialChange() 
    {
        this.GetComponent<Renderer>().material = nMaterial;
    }

    private void OnEnable()
    {
        Actions.MyEvent += materialChange; 
    }

    private void OnDisable()
    {
        Actions.MyEvent -= materialChange;
    }


}
