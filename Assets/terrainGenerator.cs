using UnityEngine;

public class terrainGenerator : MonoBehaviour {


	public int depth = 40;
	public int width = 1000;
	public int height=1000;

	public float scale = 50f;

	public float offsetX=500f;
	public float offsetY=500f;

	void Start()
	{
		offsetX = Random.Range (0f, 99999f);
		offsetY = Random.Range (0f,99999f);
	}
	void Update()
	{
		Terrain terrain = GetComponent<Terrain> ();
		terrain.terrainData = GenerateTerrain (terrain.terrainData);

		//offsetX += Time.deltaTime * 5f; 
	}

	TerrainData GenerateTerrain(TerrainData terrainData)
	{
		terrainData.heightmapResolution = width + 1; 
		terrainData.size = new Vector3 (width, depth, height);

		terrainData.SetHeights (0, 0, GenerateHeights ());
		return terrainData; 
	}

	float[,] GenerateHeights()
	{
		float[,] heights = new float[width, height];
		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {
				heights [x, y] = CalculateHeight (x, y);
			}
		}
		return heights;
	}

	float CalculateHeight(int x, int y)
	{
		float xCoord = (float)x / width*scale +offsetX;
		float yCoord =(float) y / height*scale+offsetY;

		return Mathf.PerlinNoise (xCoord, yCoord);
	}
}
