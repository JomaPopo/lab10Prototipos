using UnityEngine;

public class ChangueColor : MonoBehaviour
{
    private Renderer _renderer;

    void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _propBlock = new MaterialPropertyBlock();  
    }

   // void Update()
   // {
     //   _renderer.material.color = GetRandomColor();
   //     _renderer.material.SetColor(name: "_Color", value: GetRandomColor());
   // }

    private Color GetRandomColor()
    {
        return new Color(
            r: Random.Range(0f, 1f),
            g: Random.Range(0f, 1f),
            b: Random.Range(0f, 1f));
    }
    private MaterialPropertyBlock _propBlock;

     void Update()
    {
        _renderer.GetPropertyBlock(_propBlock);
        _propBlock.SetColor(name: "_BaseColor", value: GetRandomColor());
        _renderer.SetPropertyBlock(_propBlock);
    }
}
