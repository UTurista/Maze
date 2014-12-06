using UnityEngine;



public class Maze : MonoBehaviour {
	public string mapName;
	//Color that identifies were the caracter should start
	public Color startColor=Color.blue;
	//Name of the gameObject that is the Caracter
	public string caracterName = "Caracter";
	
	
	void Awake() {
		// Load a single texture
		Texture2D texture = Resources.Load(mapName) as Texture2D;
		
		for (int xx=0; xx<texture.width; xx++) {
			for (int yy=0;yy<texture.height;yy++){
				//Get the color of the current Pixel
				Color color = texture.GetPixel(xx, yy);
				
				if(color==Color.black){
					GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
					//Sets the Cube in the right position
					cube.transform.position = new Vector3(xx-0.5F, yy-0.5F, 0);
					
					//Replaces 3D Collision for a 2D one
					DestroyImmediate(cube.GetComponent("BoxCollider"));
					cube.AddComponent("BoxCollider2D");
		
				}else if(color==startColor){
					//Special Color
					GameObject caracter = GameObject.Find(caracterName);
					caracter.transform.position = new Vector3(xx-0.5F, yy-0.5F, 0);
				}
				else if(color==Color.white){
					//Do Nothing
				}else{
					//hack: Color.blue is not working
					GameObject caracter = GameObject.Find(caracterName);
					caracter.transform.position = new Vector3(xx-0.5F, yy-0.5F, 0);

				}
			} 
		}
	}
}


