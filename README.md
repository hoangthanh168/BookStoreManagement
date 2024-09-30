# BookStoreManagement

## Mô tả
BookStoreManagement là một ứng dụng quản lý cửa hàng bán sách CƠ BẢN được thực hiện nhằm đáp ứng yêu cầu môn học Lập trình ứng dụng Desktop, cho phép quản lý danh sách sách, hóa đơn, khách hàng, nhân viên, và doanh thu. Ứng dụng được phát triển bằng WPF (Windows Presentation Foundation) và tuân theo mô hình MVVM.

## Tính năng
- **Quản lý sách:** Thêm, sửa, xóa và tìm kiếm sách trong kho hàng.
- **Quản lý hóa đơn:** Tạo hóa đơn cho khách hàng và theo dõi doanh thu.
- **Quản lý khách hàng:** Tạo, quản lý và chỉnh sửa thông tin khách hàng.
- **Quản lý nhân viên:** Quản lý thông tin và theo dõi hoạt động của nhân viên.
- **Thống kê và báo cáo:** Thống kê doanh thu theo nhân viên, hóa đơn, và theo thời gian.
- **Biểu đồ trực quan:** Hiển thị biểu đồ doanh thu và các sản phẩm bán chạy.
- **Tùy biến giao diện:** Giao diện đẹp mắt, hiện đại và dễ sử dụng, sử dụng thư viện MahApps.Metro.

## Công nghệ sử dụng
- .NET Framework, Entity Framework
- WPF
- MahApps.Metro
- SQL Server

## Yêu cầu hệ thống
- **.NET Framework:** 4.8

## Hướng dẫn cài đặt

### 1. Clone Repository
```bash
git clone https://github.com/hoangthanh168/BookStoreManagement.git
cd BookStoreManagement
```

### 2. Mở Solution với Visual Studio
- Mở file `BookStoreManagement.sln` bằng Visual Studio.

### 3. Cài đặt các Package cần thiết
sử dụng **NuGet Package Manager** để cài đặt các package thiếu.

### 4. Cấu hình chuỗi kết nối
Chỉnh sửa file `App.config` trong dự án `BookStoreManagement` để cấu hình chuỗi kết nối đến SQL Server.
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
