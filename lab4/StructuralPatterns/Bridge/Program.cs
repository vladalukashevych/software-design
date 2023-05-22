using BridgePattern.Library;

IRenderer raster = new RasterRenderer();
raster.Render(new Circle(3, "red"));

IRenderer vector = new VectorRenderer();
vector.Render(new Triangle(4, 2, 7, "blue"));


