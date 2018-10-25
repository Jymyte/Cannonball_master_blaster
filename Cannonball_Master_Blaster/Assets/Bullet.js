#pragma strict

var rb : Rigidbody;
var power : int = 5;

function Start () {

 	rb = GetComponent(Rigidbody);
	rb.AddForce(transform.forward * power, ForceMode.Impulse);
    Destroy(gameObject, 5);

}

function OnCollisionEnter (collision: Collision) {
    print("collision");

    if(collision.gameObject.tag == "Target") {
        var mc = GameObject.Find("Main Camera");
        mc.SendMessage("IncreaseScore");
    }
}
   