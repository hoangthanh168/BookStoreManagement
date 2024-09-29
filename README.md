# BookStoreManagement

## Mô tả
BookStoreManagement là một ứng dụng quản lý cửa hàng bán sách, cho phép quản lý danh sách sách, hóa đơn, khách hàng, nhân viên, và doanh thu. Ứng dụng được phát triển bằng WPF (Windows Presentation Foundation) và tuân theo mô hình MVVM (Model-View-ViewModel) giúp tối ưu hóa trải nghiệm người dùng và đảm bảo khả năng mở rộng cũng như dễ bảo trì. Dự án sử dụng Entity Framework cho việc quản lý dữ liệu và Repository Pattern để phân tách logic nghiệp vụ khỏi lớp dữ liệu.

## Tính năng
- **Quản lý sách:** Thêm, sửa, xóa và tìm kiếm sách trong kho hàng.
- **Quản lý hóa đơn:** Tạo hóa đơn cho khách hàng và theo dõi doanh thu.
- **Quản lý khách hàng:** Tạo, quản lý và chỉnh sửa thông tin khách hàng.
- **Quản lý nhân viên:** Quản lý thông tin và theo dõi hoạt động của nhân viên.
- **Thống kê và báo cáo:** Thống kê doanh thu theo nhân viên, hóa đơn, và theo thời gian.
- **Biểu đồ trực quan:** Hiển thị biểu đồ doanh thu và các sản phẩm bán chạy.
- **Tùy biến giao diện:** Giao diện đẹp mắt, hiện đại và dễ sử dụng, sử dụng thư viện MahApps.Metro.

## Công nghệ sử dụng
- **Backend:** .NET Framework, Entity Framework
- **Frontend:** WPF (Windows Presentation Foundation)
- **Dependency Injection:** Unity
- **Thư viện UI:** MahApps.Metro
- **Quản lý cơ sở dữ liệu:** SQL Server

## Cấu trúc dự án
```
BookStoreManagement/
├── BookStoreManagement/    # Presentation Layer (WPF)
├── BookStoreManagement.Core/  # Core Layer (Models, Repositories, Services)
├── BookStoreManagement.Data/  # Data Access Layer
└── BookStoreManagement.ViewModels/  # MVVM ViewModels
```

## Yêu cầu hệ thống
- **Hệ điều hành:** Windows 10 trở lên
- **.NET Framework:** 4.8
- **Visual Studio:** 2019 hoặc mới hơn
- **SQL Server:** 2017 hoặc mới hơn

## Hướng dẫn cài đặt

### 1. Clone Repository
```bash
git clone https://github.com/hoangthanh168/BookStoreManagement.git
cd BookStoreManagement
```

### 2. Mở Solution với Visual Studio
- Mở file `BookStoreManagement.sln` bằng Visual Studio.

### 3. Cài đặt các Package cần thiết
Trong Visual Studio, mở **Package Manager Console** và chạy:
```powershell
Update-Package -reinstall
```
Hoặc sử dụng **NuGet Package Manager** để cài đặt các package thiếu.

### 4. Cấu hình chuỗi kết nối
Chỉnh sửa file `App.config` trong dự án `BookStoreManagement.Data` để cấu hình chuỗi kết nối đến SQL Server.
```xml
<connectionStrings>
    <add name="DefaultConnection" connectionString="Data Source=YOUR_SERVER;Initial Catalog=BookStoreDB;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 5. Áp dụng Migrations và Tạo Database
Mở **Package Manager Console** và chạy:
```powershell
Enable-Migrations
Add-Migration InitialCreate
Update-Database
```

### 6. Chạy Ứng dụng
- **BookStoreManagement.Data:** Chạy dự án này để khởi động dịch vụ xử lý dữ liệu.
- **BookStoreManagement:** Chạy dự án `BookStoreManagement` để mở giao diện người dùng.

## Sử dụng
1. **Đăng nhập:** Sử dụng tài khoản quản trị viên để đăng nhập vào hệ thống.
2. **Quản lý sách:** Thêm, chỉnh sửa, hoặc xóa các thông tin sách.
3. **Quản lý hóa đơn:** Tạo hóa đơn và ghi nhận doanh thu bán hàng.
4. **Quản lý khách hàng và nhân viên:** Xem và chỉnh sửa thông tin của khách hàng và nhân viên.
5. **Thống kê doanh thu:** Xem thống kê và biểu đồ doanh thu, top sản phẩm bán chạy.

## Đóng góp
1. **Fork Repository**
2. **Tạo Branch Mới**
    ```bash
    git checkout -b feature/your-feature
    ```
3. **Commit Thay đổi**
    ```bash
    git commit -m "Add some feature"
    ```
4. **Push Branch**
    ```bash
    git push origin feature/your-feature
    ```
5. **Mở Pull Request**
