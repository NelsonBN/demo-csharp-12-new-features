int[] arr = [1, 2, 3, 4, 5];
int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

List<char> list = ['a', 'b', 'c', 'd', 'e'];
Dictionary<string, int> dict = [];
IEnumerable<int> y = [];
Span<string> span = ["Fa", "Sol", "La", "Si"];


int[] arr1 = [4, 5, 6];
int[] arr2 = [1, 2, 3, ..arr1, 7, 8, 9];
foreach (var r in arr2)
{
    Console.Write($"{r} ");
}

static ReadOnlySpan<T> AsSpan3<T>(T x, T y, T z)
{
    return (T[])[x, y, z]; // ok: span refers to T[] on heap
}