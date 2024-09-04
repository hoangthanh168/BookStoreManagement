### **1. Khách hàng chọn sách trong cửa hàng**

#### **Mô tả hoạt động**:
- **Bước 1**: Khách hàng đến cửa hàng và duyệt qua các kệ sách.
- **Bước 2**: Khách hàng chọn các sách mình muốn mua từ các kệ và mang đến quầy thanh toán.

#### **Dữ liệu tương ứng**:
- Ở bước này, không có thao tác dữ liệu cụ thể trên hệ thống. Thông tin về sách và số lượng đã được nhập sẵn vào hệ thống trước đó và hiển thị nếu nhân viên cần tra cứu.

---

### **2. Nhân viên thu ngân xử lý đơn hàng**

#### **Mô tả hoạt động**:
- **Bước 3**: Khách hàng đưa các sách đã chọn đến quầy thu ngân.
- **Bước 4**: Nhân viên đăng nhập vào hệ thống để xử lý đơn hàng. Tùy vào quyền hạn (`is_superuser`), nhân viên chỉ có quyền truy cập chức năng bán hàng (nếu không phải quản trị viên).

#### **Thao tác trên hệ thống**:
1. **Nhân viên đăng nhập**:
   - Nhân viên đăng nhập vào hệ thống với tên đăng nhập và mật khẩu.
   - Hệ thống kiểm tra bảng `Employees` để xác nhận quyền đăng nhập và phân quyền nhân viên (`is_superuser`).
   
   ```sql
   SELECT * FROM Employees WHERE Username = 'username' AND Password = 'password';
   ```

2. **Tìm thông tin sách**:
   - Nhân viên quét mã ISBN của từng cuốn sách hoặc tìm kiếm tên sách trong hệ thống.
   - Thông tin sách như giá và số lượng tồn kho được truy xuất từ bảng `Books`.

   ```sql
   SELECT * FROM Books WHERE ISBN = 'mã_ISBN' OR Title LIKE '%tên sách%';
   ```

3. **Kiểm tra tồn kho**:
   - Hệ thống kiểm tra số lượng sách trong kho để đảm bảo có đủ sách cho đơn hàng.

   ```sql
   SELECT StockQuantity FROM Books WHERE BookID = 'BookID';
   ```

4. **Tạo đơn hàng mới**:
   - Nhân viên tạo một bản ghi mới trong bảng `Orders`, bao gồm `CustomerID` (nếu khách hàng có tài khoản), `OrderDate`, `TotalAmount`, và phương thức thanh toán `PaymentMethod` (placeholder như `"Cash"`, `"Card"`, `"Other"`).
   
   ```sql
   INSERT INTO Orders (CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod, Status)
   VALUES ('CustomerID', 'EmployeeID', CURDATE(), 'TotalAmount', 'PaymentMethod', 'Pending');
   ```

5. **Thêm chi tiết đơn hàng**:
   - Mỗi cuốn sách được thêm vào bảng `OrderDetails`, với thông tin `OrderID`, `BookID`, `Quantity`, và `UnitPrice`.

   ```sql
   INSERT INTO OrderDetails (OrderID, BookID, Quantity, UnitPrice)
   VALUES ('OrderID', 'BookID', 'Quantity', 'UnitPrice');
   ```

---

### **3. Thanh toán**

#### **Mô tả hoạt động**:
- **Bước 5**: Sau khi thêm sách vào đơn hàng, nhân viên yêu cầu khách hàng thanh toán.
- **Bước 6**: Khách hàng có thể thanh toán bằng tiền mặt, thẻ tín dụng hoặc phương thức khác (placeholder).

#### **Thao tác trên hệ thống**:
1. **Tính tổng số tiền thanh toán**:
   - Hệ thống tính tổng giá trị đơn hàng dựa trên giá của từng sách và số lượng.

   ```sql
   SELECT SUM(Quantity * UnitPrice) AS TotalAmount
   FROM OrderDetails
   WHERE OrderID = 'OrderID';
   ```

2. **Cập nhật phương thức thanh toán và trạng thái đơn hàng**:
   - Nhân viên cập nhật phương thức thanh toán đã chọn (tiền mặt, thẻ tín dụng, hoặc ví điện tử) vào bảng `Orders`. Trạng thái đơn hàng cũng được cập nhật thành `"Hoàn tất"`.

   ```sql
   UPDATE Orders
   SET PaymentMethod = 'Phương thức thanh toán', TotalAmount = 'Tổng tiền', Status = 'Completed'
   WHERE OrderID = 'OrderID';
   ```

3. **In hóa đơn**:
   - Hệ thống có thể in hóa đơn cho khách hàng bao gồm danh sách sách đã mua và tổng số tiền.

---

### **4. Cập nhật tồn kho**

#### **Mô tả hoạt động**:
- **Bước 7**: Sau khi giao dịch hoàn tất, hệ thống tự động cập nhật số lượng tồn kho.

#### **Thao tác trên hệ thống**:
1. **Cập nhật bảng `Books`**:
   - Hệ thống trừ số lượng sách đã bán từ kho.

   ```sql
   UPDATE Books
   SET StockQuantity = StockQuantity - 'Quantity'
   WHERE BookID = 'BookID';
   ```

---

### **5. Quản lý trả hàng (nếu có)**

#### **Mô tả hoạt động**:
- **Bước 8**: Nếu khách hàng quay lại trả sách (do lỗi hoặc không đúng yêu cầu), nhân viên xử lý trả hàng theo yêu cầu.
- **Bước 9**: Nhân viên kiểm tra điều kiện trả hàng và tiến hành hoàn tiền hoặc đổi sản phẩm.

#### **Thao tác trên hệ thống**:
1. **Ghi nhận yêu cầu trả hàng**:
   - Nhân viên tạo một bản ghi trong bảng `Returns`, bao gồm `OrderID`, `ReturnDate`, `TotalRefund`, và lý do trả hàng.

   ```sql
   INSERT INTO Returns (OrderID, EmployeeID, ReturnDate, TotalRefund, Status, Reason)
   VALUES ('OrderID', 'EmployeeID', CURDATE(), 'TotalRefund', 'Pending', 'Lý do');
   ```

2. **Thêm chi tiết trả hàng**:
   - Nhân viên ghi nhận từng sách trả lại trong bảng `ReturnDetails`.

   ```sql
   INSERT INTO ReturnDetails (ReturnID, BookID, Quantity, RefundAmount)
   VALUES ('ReturnID', 'BookID', 'Số lượng trả', 'Tiền hoàn lại');
   ```

3. **Cập nhật tồn kho**:
   - Nếu sách có thể bán lại, hệ thống cập nhật số lượng tồn kho.

   ```sql
   UPDATE Books
   SET StockQuantity = StockQuantity + 'Số lượng trả'
   WHERE BookID = 'BookID';
   ```

---

### **6. Quản lý thẻ thành viên (Membership)**

#### **Mô tả hoạt động**:
- **Bước 10**: Nếu khách hàng có thẻ thành viên, hệ thống áp dụng mức giảm giá tương ứng với cấp bậc thẻ.
- **Bước 11**: Nhân viên có thể đăng ký hoặc gia hạn thẻ thành viên cho khách hàng.

#### **Thao tác trên hệ thống**:
1. **Kiểm tra cấp bậc thẻ thành viên**:
   - Hệ thống kiểm tra bảng `Memberships` để lấy thông tin thẻ và mức giảm giá.

   ```sql
   SELECT MembershipLevel, DiscountRate
   FROM Memberships
   WHERE CustomerID = 'CustomerID';
   ```

2. **Áp dụng giảm giá**:
   - Hệ thống tính lại tổng số tiền sau khi áp dụng giảm giá.

   ```sql
   UPDATE Orders
   SET TotalAmount = TotalAmount - (TotalAmount * DiscountRate / 100)
   WHERE OrderID = 'OrderID';
   ```

3. **Đăng ký hoặc gia hạn thẻ**:
   - Nhân viên có thể đăng ký hoặc gia hạn thẻ thành viên cho khách hàng.

   ```sql
   INSERT INTO Memberships (CustomerID, MembershipLevel, IssueDate, ExpirationDate, DiscountRate)
   VALUES ('CustomerID', 'Gold', CURDATE(), DATE_ADD(CURDATE(), INTERVAL 1 YEAR), 10);
   ```

---

### **7. Báo cáo doanh thu**

#### **Mô tả hoạt động**:
- **Bước 12**: Quản lý cửa hàng có thể xem báo cáo doanh thu hàng ngày hoặc theo kỳ.

#### **Thao tác trên hệ thống**:
1. **Tính doanh thu theo ngày**:
   - Hệ thống tính tổng doanh thu và hoàn tiền từ các đơn hàng.

   ```sql
   SELECT OrderDate, SUM(TotalAmount) AS TotalSales
   FROM Orders
   WHERE Status = 'Completed'
   GROUP BY OrderDate;
   ```

2. **Hiển thị báo cáo**:
   - Hệ thống hiển thị báo cáo doanh thu tổng hợp theo ngày hoặc tháng.

---

### **Tóm tắt luồng hoạt động**:

1. **Khách hàng chọn sách và đến quầy thanh toán**.
2. **Nhân viên đăng nhập và xử lý đơn hàng** (quét sách, tạo đơn hàng, tính toán số tiền).
3. **Thanh toán** (với placeholder phương thức thanh toán đơn giản).
4

. **Cập nhật tồn kho sau khi bán**.
5. **Xử lý trả hàng** (nếu có).
6. **Quản lý và áp dụng thẻ thành viên** (nếu có).
7. **Báo cáo doanh thu**.
