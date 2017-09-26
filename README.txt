Graphics Shaders

Comment out the shader options in Renderer to test them.

Shaders Implemented:

1. Gouraud shader: The vertex color is computed using a Phong reflection model also as discussed in class. The color inside a triangle should be interpolated.

2. Texture-modulated Smooth Shader: Each triangle is shaded using a color value from either of the above shaders and multiplying the resulting color value by the current texture. The texture coordinate (given by gl TexCoord[0].st in GLSL) for each vertex are used to index into the texture.

3. Checkerboard texture : Using GLSL, applied a checkerboard pattern as a simple procedural texture on an object surface . Can be implemented in shader and combined with Gourand or Blinn-Phong shading model to show checkboard patterns.

4. Wireframe texture: Implemented a shader to highlight the mesh wireframes together with color shading. For example, it could look like a Blinn-Phong shader with the triangle edges highlighted by red color (uses the barycentric coordinates to determine how far a point is away from a triangle edge).

5. Normal map: Load a image and use its 3 color channels to specify the geometry normals. Uses the normals specified by textures to modulate shaded surface colors.

6. CEL (Toon) Shader: CEL shading is a type of non- photorealistic rendering to make 3D objects appear to be flat by using less shading color instead of a shade gradient.
