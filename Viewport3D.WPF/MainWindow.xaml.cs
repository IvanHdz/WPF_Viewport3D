using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Viewport3D.WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MeshGeometry3D triangleMesh = new MeshGeometry3D();
            Point3D point0 = new Point3D(0, 0, 0);
            Point3D point1 = new Point3D(2, -4, 0);
            Point3D point2 = new Point3D(0, 0, 5);
            triangleMesh.Positions.Add(point0);
            triangleMesh.Positions.Add(point1);
            triangleMesh.Positions.Add(point2);
            triangleMesh.TriangleIndices.Add(0);
            triangleMesh.TriangleIndices.Add(2);
            triangleMesh.TriangleIndices.Add(1);

            Vector3D normal = new Vector3D(0, 1, 0);
            triangleMesh.Normals.Add(normal);

            Material material = new DiffuseMaterial(new SolidColorBrush(Colors.Red));

            GeometryModel3D triangleModel = new GeometryModel3D(triangleMesh, material);
            ModelVisual3D model = new ModelVisual3D();

            model.Content = triangleModel;
            this.vpt.Children.Add(model);

            //Camara

            //PerspectiveCamera pCam = new PerspectiveCamera();
            //pCam.FarPlaneDistance = 100;
            //pCam.Position = new Point3D(10, 10, 10);
            //pCam.LookDirection = new Vector3D(-10, -10, -10);
            //vpt.Camera = pCam;
            //this.vpt.Children.Add(model);

            PerspectiveCamera pCam = (PerspectiveCamera)vpt.Camera;
            Point3D pPos = pCam.Position;
            pPos.X = pPos.X + 2;
            pCam.Position = pPos;
        }
    }
}