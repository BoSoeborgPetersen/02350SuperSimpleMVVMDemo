namespace _02350SuperSimpleMVVMDemo.ViewModel;

public class MainViewModel
{
    public ObservableCollection<Shape> Shapes { get; set; }
    public ObservableCollection<Line> Lines { get; set; }

    public MainViewModel()
    {
        Shapes = new() {
            new(X: 30, Y: 40, Width: 80, Height: 80),
            new(X: 130, Y: 140, Width: 100, Height: 100)
        };
        Lines = new() {
            new(From: Shapes[0], To: Shapes[1])
        };
    }
}
