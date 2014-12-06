using UnityEngine;



public class Maze : MonoBehaviour {
	public string mapName;
	void Awake() {
	{



		
		Debug.Log("Awake()");
		// Load a single texture
			Texture2D texture = Resources.Load(mapName) as Texture2D;
		for (int xx=0; xx<texture.width; xx++) {
			for (int yy=0;yy<texture.height;yy++){
				Color color = texture.GetPixel(xx, yy);
				//Debug.Log("Pixel["+xx+","+yy+"]="+color);
				if(color==Color.black){
					//Debug.Log("Create Cube");
					GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
					cube.transform.position = new Vector3(xx-0.5F, yy-0.5F, 0);
					DestroyImmediate(cube.GetComponent("BoxCollider"));
					cube.AddComponent("BoxCollider2D");
		
				}else if(color==Color.blue){
						Debug.Log("Move Player");
					GameObject caracter = GameObject.Find("Caracter");
					caracter.transform.position = new Vector3(xx-0.5F, yy-0.5F, 0);
				}
				else if(color==Color.white){
					//Do Nothing
				}else{
						Debug.Log("Move Player");
						GameObject caracter = GameObject.Find("Caracter");
						caracter.transform.position = new Vector3(xx-0.5F, yy-0.5F, 0);

				}
			} 
		}
	}
	}
}
