### 1. Khách hàng chọn sách trong cửa hàng
**Mô tả hoạt động:**
- **Bước 1**: Khách hàng đến cửa hàng và duyệt qua các kệ sách.
- **Bước 2**: Khách hàng chọn các sách mình muốn mua từ các kệ và mang đến quầy thanh toán.

**Dữ liệu tương ứng:**
- Ở bước này, không có thao tác dữ liệu cụ thể trên hệ thống. Thông tin về sách và số lượng đã được nhập sẵn vào hệ thống trước đó và hiển thị nếu nhân viên cần tra cứu.

---

### 2. Nhân viên thu ngân xử lý đơn hàng
**Mô tả hoạt động:**
- **Bước 3**: Khách hàng đưa các sách đã chọn đến quầy thu ngân.
- **Bước 4**: Nhân viên đăng nhập vào hệ thống để xử lý đơn hàng.

**Thao tác trên hệ thống:**

1. **Nhân viên đăng nhập:**
   - Nhân viên đăng nhập vào hệ thống với tên đăng nhập và mật khẩu.
   - Hệ thống kiểm tra bảng `Employees` để xác nhận quyền đăng nhập và phân quyền nhân viên (is_superuser).
   ```sql
   SELECT * FROM Employees WHERE Username = 'username' AND Password = 'password';
   ```

2. **Tìm thông tin sách:**
   - Nhân viên quét mã ISBN của từng cuốn sách hoặc tìm kiếm tên sách trong hệ thống.
   - Thông tin sách như giá và số lượng tồn kho được truy xuất từ bảng `Books`.
   ```sql
   SELECT * FROM Books WHERE ISBN = 'mã_ISBN' OR Title LIKE '%tên sách%';
   ```

3. **Kiểm tra tồn kho:**
   - Hệ thống kiểm tra số lượng sách trong kho để đảm bảo có đủ sách cho đơn hàng.
   ```sql
   SELECT StockQuantity FROM Books WHERE BookID = 'BookID';
   ```

4. **Tạo đơn hàng mới:**
   - Nhân viên tạo một bản ghi mới trong bảng `Orders`, bao gồm thông tin cần thiết như `CustomerID`, `OrderDate`, `TotalAmount`, và phương thức thanh toán.
   ```sql
   INSERT INTO Orders (CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod, Status)
   VALUES ('CustomerID', 'EmployeeID', CURDATE(), 'TotalAmount', 'PaymentMethod', 'Pending');
   ```

5. **Thêm chi tiết đơn hàng:**
   - Mỗi cuốn sách được thêm vào bảng `OrderDetails` với thông tin `OrderID`, `BookID`, `Quantity`, và `UnitPrice`.
   ```sql
   INSERT INTO OrderDetails (OrderID, BookID, Quantity, UnitPrice)
   VALUES ('OrderID', 'BookID', 'Quantity', 'UnitPrice');
   ```

---

### 3. Thanh toán
**Mô tả hoạt động:**
- **Bước 5**: Sau khi thêm sách vào đơn hàng, nhân viên yêu cầu khách hàng thanh toán.
- **Bước 6**: Khách hàng có thể thanh toán bằng tiền mặt, thẻ tín dụng, hoặc phương thức khác.

**Thao tác trên hệ thống:**

1. **Tính tổng số tiền thanh toán:**
   - Hệ thống tính tổng giá trị đơn hàng dựa trên giá của từng sách và số lượng.
   ```sql
   SELECT SUM(Quantity * UnitPrice) AS TotalAmount
   FROM OrderDetails
   WHERE OrderID = 'OrderID';
   ```

2. **Cập nhật phương thức thanh toán và trạng thái đơn hàng:**
   - Nhân viên cập nhật phương thức thanh toán và trạng thái đơn hàng thành "Completed".
   ```sql
   UPDATE Orders
   SET PaymentMethod = 'Phương thức thanh toán', TotalAmount = 'Tổng tiền', Status = 'Completed'
   WHERE OrderID = 'OrderID';
   ```

3. **In hóa đơn:**
   - Hệ thống có thể in hóa đơn cho khách hàng bao gồm danh sách sách đã mua và tổng số tiền.

---

### 4. Cập nhật tồn kho
**Mô tả hoạt động:**
- **Bước 7**: Sau khi giao dịch hoàn tất, hệ thống tự động cập nhật số lượng tồn kho.

**Thao tác trên hệ thống:**
- Hệ thống trừ số lượng sách đã bán từ kho.
```sql
UPDATE Books
SET StockQuantity = StockQuantity - 'Quantity'
WHERE BookID = 'BookID';
```

---

### 5. Báo cáo doanh thu
**Mô tả hoạt động:**
- **Bước 8**: Quản lý cửa hàng có thể xem báo cáo doanh thu hàng ngày hoặc theo kỳ.

**Thao tác trên hệ thống:**

1. **Tính doanh thu theo ngày:**
   - Hệ thống tính tổng doanh thu và hoàn tiền từ các đơn hàng đã hoàn tất.
   ```sql
   SELECT OrderDate, SUM(TotalAmount) AS TotalSales
   FROM Orders
   WHERE Status = 'Completed'
   GROUP BY OrderDate;
   ```

2. **Hiển thị báo cáo:**
   - Hệ thống hiển thị báo cáo doanh thu tổng hợp theo ngày hoặc tháng.

