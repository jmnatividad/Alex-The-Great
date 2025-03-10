using UnityEngine;

[ExecuteInEditMode]
public class Shooter2 : MonoBehaviour
{
    public Mesh mesh;
    public Material material;
    void Update()
    {
        for(int i = 0; i < 10000 ; i++) {
        Vector3 position = new Vector3(UnityEngine.Random.Range(0,100),UnityEngine.Random.Range(0,100),UnityEngine.Random.Range(0,100));
        Graphics.DrawMesh(mesh,position,Quaternion.identity,material,0);
        }
    }
}
