1.1 OOP gọn trong game

Composition > Inheritance: Kết hợp nhiều component để tạo hành vi thay vì kế thừa nhiều tầng.

Interface nhỏ, mỗi interface chỉ định nghĩa một nhóm hành vi cụ thể.

SOLID cơ bản:

Single Responsibility: mỗi class chỉ làm một việc.

Open/Closed: mở rộng được nhưng không sửa code gốc.

Liskov Substitution: có thể thay thế class cha bằng class con.

Interface Segregation: nhiều interface nhỏ tốt hơn một interface lớn.

Dependency Inversion: phụ thuộc vào abstraction, không phụ thuộc trực tiếp vào implementation.

struct vs class:

struct: giá trị nhỏ, bất biến, không cần kế thừa.

class: đối tượng phức tạp, cần tham chiếu, kế thừa.

1.2 Delegate, Event, Action<>, Func<>

delegate: Kiểu dữ liệu đại diện cho một hoặc nhiều hàm.

public delegate void MyDelegate(string msg);
MyDelegate d = PrintMessage;
d("Hello");

event: Biến đặc biệt dùng delegate, chỉ cho phép đăng ký/hủy bên ngoài class.

public event Action<int> OnScoreChanged;

Action<>: Delegate có sẵn cho hàm không trả về (void).

Action<int, string> logData = (id, name) => Debug.Log($"{id} - {name}");

Func<>: Delegate có sẵn cho hàm có giá trị trả về.

Func<int, int, int> add = (a, b) => a + b;
int sum = add(3, 5);

Đăng ký (+=) và hủy (-=): Quan trọng để tránh memory leak.

1.3 Coroutine (yield)

Cho phép thực thi bất đồng bộ đơn giản: delay, chờ animation, load dữ liệu.

Dùng StartCoroutine và yield return.

1.4 Tránh GC (Garbage Collection)

Cache reference (GetComponent một lần).

Dùng StringBuilder khi nối chuỗi nhiều lần.

Tránh new trong Update hoặc vòng lặp lớn.
