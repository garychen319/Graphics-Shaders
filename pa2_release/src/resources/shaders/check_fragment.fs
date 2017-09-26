#version 330

in vec2 outTexCoord;
in vec3 mvVertexNormal;
in vec3 mvVertexPos;

out vec4 fragColor;

struct Material
{
    vec3 colour;
    int useColour;
    float reflectance;
};

uniform vec3 ambientLight;
uniform Material material;

void main()
{
	//from skeleton
    vec4 baseColour = vec4(material.colour, 1.0);
    vec4 redTint = vec4(0.5, 0.0, 0.0, 1.0);
    vec4 totalLight = vec4(ambientLight, 1.0);
    
    //black and white colors for checkerboard
    vec4 black = vec4(0.0, 0.0, 0.0, 1.0);
    vec4 white = vec4(1.0, 1.0, 1.0, 1.0);
    float fpx = floor(10*outTexCoord.x);
    float fpy = floor(10*outTexCoord.y);
    
    //mod 2 to color in each check a different color
    float fp = (int(fpx+fpy) % 2);
    if(fp==0) fragColor = black;
    else fragColor = white;
}
