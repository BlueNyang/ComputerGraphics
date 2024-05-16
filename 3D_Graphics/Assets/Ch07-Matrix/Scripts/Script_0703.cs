using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_0703 : MonoBehaviour
{
    public List<Vector3> mVertices = new();
    public List<float> mWeights = new();
    
    public void CreateGridVertices(int width, int height, float cellSize){
        mVertices.Clear();
        mWeights.Clear();
        for(int y = 0; y < height; y++){
            for(int x = 0; x < width; x++){
                mVertices.Add(new(x * cellSize - width * cellSize / 2f, y * cellSize - height * cellSize / 2f, 0f));
                mWeights.Add(1f);
            }
        }
    }

    /// <summary>
    /// Callback to draw gizmos that are pickable and always drawn.
    /// </summary>
    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        for(int i = 0; i < mVertices.Count; i++){
            Vector3 originalVertex = mVertices[i];

            Vector3 targetVertex = transform.TransformPoint(originalVertex);
            Vector3 finalVertex = Vector3.Lerp(originalVertex, targetVertex, mWeights[i]);
            
            Gizmos.DrawSphere(finalVertex, 0.1f);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
