using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadGen : BaseMeshGenerator
{
    protected override void FillMesh(Mesh mesh)
    {
        List<Vector3> positions = new List<Vector3>();
        List<int>     indexes = new List<int>();

        positions.Add(new Vector3(-1, -1, 0));
        positions.Add(new Vector3(-1,  1, 0));
        positions.Add(new Vector3( 1,  1, 0));
        positions.Add(new Vector3( 1, -1, 0));

        indexes.Add(0);
        indexes.Add(1);
        indexes.Add(2);
        indexes.Add(0);
        indexes.Add(2);
        indexes.Add(3);

        mesh.SetVertices(positions);
        mesh.SetIndices(indexes, MeshTopology.Triangles, 0, true);
    }
}
