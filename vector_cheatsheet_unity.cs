//adding and subtracting

Vector3 v1 = new Vector3(5,6,7); 
Vector3 v2 = new Vector3(1,2,3); 
Vector3 v3 = v1 + v2;

//adding and subtracting alternative

cat.transform.position = new Vector3(10,15,5); 
dog.transform.position = new Vector3(20,15,20); 
Vector3 directionToDog = dog.transform.position - cat.transform.position; 
cat.transform.position += directionToDog;

//scaling vectors: multiplication

Vector3 v1 = new Vector3(5,6,7); 
Vector3 v2 = v1 * 0.5f;

Vector3 v1 = new Vector3(5,6,7); 
float scalingFactor = 2.0f; 
Vector3 v2 = v1 * scalingFactor;

//finding the length of a vector by accessing its magnitude property

Vector3 v1 = new Vector3(20,35,56); 
float length = v1.magnitude;

cat.transform.position = new Vector3(10,15,5); 
dog.transform.position = new Vector3(20,15,20); 
Vector3 directionToDog = dog.transform.position - cat.transform.position;
float distanceBetweenCatDog = directionToDog.magnitude;

//calculate the distance between two points using the Vector3.Distance() method

float distanceBetweenCatDog = Vector3.Distance(cat.transform.position, dog.transform.position);

//Without the use of angle, Unity can snap a character around to face in a particular direction with LookAt() method

cat.transform.LookAt(dog.transform.position);

//apply a Slerp() to see the character turning little by little - not desirable

vector3 direction = dog.transform.position - cat.transform.position;
cat.transform.rotation = Quaternion.Slerp(cat.transform.rotation,
Quaternion.LookRotation(direction), Time.deltaTime * rotationSpeed);

//useful angle() for working out how a character should turn and in preparing for AI behaviour. 

Vector3 direction = dog.transform.position - cat.transform.position; 
float angleOfRotation = Vector3.Angle(cat.transform.forward, direction);

