# Jwt
.Net Core web API Token example (In-Memory)

# Jwt
What is a REST API?

Due to the increasing number of different varieties of clients (mobile apps, browser-based SPAs, desktop apps, IOT apps, etc.), we need better ways fortransferring data 
from servers to clients, independent of technology and server stacks.REST APIs solve this problem. REST stands for representational state transfer.REST APIs are HTTP-based 
and provide applications the ability to communicate using lightweight JSON format. They run on web servers.

REST consists of the following entities:

Resource: Resources are uniquely identifiable entities (for example: data from a database, images, or any data).

Endpoint: A resource can be accessed through a URL identifier.

HTTP method: HTTP method is the type of request a client sends to a server.Operations we perform on the resource should follow this.

HTTP header: An HTTP header is a key-value pair used to share additional information between a client and server, such as:

Type of data being sent to server (JSON, XML).
Type of encryption supported by client.
Authentication-related token.
Customer data based on application need.

Data format: JSON is a common format to send and receive data through REST APIs.

What is a JWT Token?

In the previous section, we saw what a REST API is, and here we will see what a JWT bearer token is, which secures the REST APIs. JWT stands for JSON Web Token. 
It is open standard and defines a better way for transferring data securely between two entities (client and server).
A JWT is digitally signed using a secret key by a token provider or authentication server. A JWT helps the resource server verify the token data using the same secret key, 
so that you can trust the data.

JWT consists of the following three parts:

Header: encoded data of token type and the algorithm used to sign the data.

Payload: encoded data of claims intended to share.

Signature: created by signing (encoded header + encoded payload) using a secret key.

The final JWT token will be like this: Header.Payload.Signature. Please find the token workflow in the following.

Step 1: Client requesting token 

The client sends a request to the authentication server with the necessary information to prove its identity.

Step 2: Token creation

The authentication server receives the token request and verifies the identity. If it is found valid, a token will be created (as explained previously) with the necessary
claims, and a JWT token will be sent back to the client.

Step 3: Client sends token to resource server

For each request to Resource or the API server, the client needs to include a token in the header and request the resource using its URI.

Step 4: Resource server verifies the token

Follow these steps to verify the token:

Read the token from authentication header.

Split the header, payload, and signature from token.

Create signature of received header and payload using the same secret key used when creating the token.

Check whether both newly created signature and signature received from token are valid.

If the signatures are the same, the tokens are valid (not altered in the middle) and they provide access to the requested resource.

If the signatures are different, an unauthorized response will be sent back to the client. (In the middle, if claims are alerted, they will generate a different signature, hence resource access will be restricted.)

Don’t share confidential information using a JWT, since a JWT can be decoded and the claims or data it possesses can be viewed.




