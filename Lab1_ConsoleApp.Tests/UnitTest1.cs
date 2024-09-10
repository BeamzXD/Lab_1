namespace Lab1_ConsoleApp.Tests;

public class UnitTest1
{
    [Fact]
    public void TestArea()
    {
        // Arrange
        Rectangle rect = new Rectangle(3, 4);

        // Act
        double area = rect.Area;

        // Assert
        Assert.Equal(12, area);
    }

    [Fact]
    public void TestPerimeter()
    {
        // Arrange
        Rectangle rect = new Rectangle(3, 4);

        // Act
        double perimeter = rect.Perimeter;

        // Assert
        Assert.Equal(14, perimeter);
    }

        [Fact]
    public void TestPerimeterCalculator_Triangle()
    {
        // Arrange
        Point p1 = new Point(0, 0);
        Point p2 = new Point(4, 0);
        Point p3 = new Point(4, 3);
        Figure triangle = new Figure("Треугольник", p1, p2, p3);

        // Act
        double perimeter = triangle.PerimeterCalculator();

        // Assert
        Assert.Equal(12, perimeter);
    }
}