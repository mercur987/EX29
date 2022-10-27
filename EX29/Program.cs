using System;
public class Test
{
	public static void Main()
	{

		float height = 3;
		float width = height;
		float depth = height;
		float radius = 5;
		float bottom = 5;//三角形の底辺
		float triHeight = 12;//三角形の高さ

		Console.WriteLine("立方体\n体積:" +Box.GetVolume(width, height, depth));
		Console.WriteLine("表面積:" + Box.GetSurface(width,height,depth) + "\n");

		Console.WriteLine("円柱\n体積:" + Cylinder.GetVolume(radius, height));
		Console.WriteLine("表面積:" + Cylinder.GetSurface(radius, height) + "\n");

		Console.WriteLine("球\n体積:" + Sphere.GetVolume(radius));
		Console.WriteLine("表面積:" + Sphere.GetSurface(radius) + "\n");

		Console.WriteLine("三角柱\n体積:" + TriangularPrism.GetVolume(bottom, triHeight, height));
		Console.WriteLine("表面積:" + TriangularPrism.GetSurface(bottom, triHeight, height));
	}
}
public static class Box
{
	public static float GetSurface(float width, float height, float depth)
	{

		return  (width * height + height * depth + depth * width) * 2;
	}
	public static float GetVolume(float width, float height, float depth)
	{
		return width * height * depth;
	}
}
public static class Cylinder
{
	public static float GetSurface(float radius, float height)
	{
		return (float)(2 * Math.PI * radius * radius + 2 * Math.PI * height * radius);
	}
	public static float GetVolume(float radius, float height)//
	{
		return (float)(radius * radius * Math.PI * height);
	}
}
public static class Sphere
{
	
	public static float GetSurface(float radius)
	{
		return (float)(4 * radius *radius * Math.PI );//
	}
	public static float GetVolume(float radius)
	{
		return (float)(4 * Math.PI * radius * radius * radius /3);
	}
}
public static class TriangularPrism
{
	
	public static float GetSurface(float bottom, float triHeight, float height)//hyoumennseki
	{
		return  triHeight * bottom / 2 * 2 + (bottom * height) + (triHeight * height) + (float)Math.Sqrt(bottom * bottom + triHeight * triHeight) * height;
	}
	public static float GetVolume(float bottom, float triHeight, float height)//taiseki
	{
		return triHeight * bottom / 2 * height;
	}
}