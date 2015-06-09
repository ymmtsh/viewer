using UnityEngine;
using System.Collections;
using System.IO; //System.IO.FileInfo, System.IO.StreamReader, System.IO.StreamWriter
using System; //Exception
using System.Text; //Encoding


public class MainCamera : MonoBehaviour {
	public ArrayList lines = new ArrayList();
	
	// Use this for initialization
	void Start () {
		FileInfo inpf = new FileInfo (Application.dataPath + "/Scripts/data/" + "test.txt");
		try {
			using (StreamReader sr = new StreamReader(inpf.OpenRead(), Encoding.UTF8)){
				string line = sr.ReadLine();
				while(line != null){
					lines.Add(line);
					line = sr.ReadToEnd();
				}
			}
		} catch (Exception e){
			Debug.Log(e);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
