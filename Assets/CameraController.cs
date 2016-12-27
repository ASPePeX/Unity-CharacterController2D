using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool FollowPlayerY;
    public float FollowYat;

    private Transform _player;
    private Vector3 _position;

	// Use this for initialization
	void Start ()
	{
	    _player = GameObject.FindGameObjectWithTag("Player").transform;

	    _position = new Vector3();

	    if (FollowPlayerY)
	    {
	        _position.x = _player.position.x;
	        _position.y = _player.position.y;
	        _position.z = transform.position.z;
	    }
	    else
	    {
	        _position.x = _player.position.x;
	        _position.y = FollowYat;
	        _position.z = transform.position.z;
	    }

	    transform.position = _position;
	}
	
	// Update is called once per frame
	void Update () {
	    if (FollowPlayerY)
	    {
	        _position.x = _player.position.x;
	        _position.y = _player.position.y;
	    }
	    else
	    {
	        _position.x = _player.position.x;
	    }
	}
}
