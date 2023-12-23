namespace _02350SuperSimpleMVVMDemo.ViewModel;

public class MainViewModel
{
    public ObservableCollection<Shape> Shapes { get; set; }
    public ObservableCollection<Line> Lines { get; set; }

    public MainViewModel()
    {
        Shapes = [
            new(X: 30, Y: 40, Width: 80, Height: 80),
            new(X: 230, Y: 340, Width: 100, Height: 100),
            new(X: 330, Y: 40, Width: 90, Height: 90)
        ];
        Lines = [
            new(From: Shapes[0], To: Shapes[1]),
            new(From: Shapes[1], To: Shapes[2])
        ];
    }
}
