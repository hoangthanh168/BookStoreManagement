Mô phỏng chi tiết **workflow** thực tế diễn ra trong một cửa hàng sách nhỏ, nơi khách hàng đến trực tiếp, chọn sách và giao dịch với nhân viên bán hàng. Dưới đây là các bước mô tả hoạt động chi tiết từ lúc khách hàng bước vào cửa hàng đến khi kết thúc giao dịch.

---

### **1. Khách hàng chọn sách trong cửa hàng**

#### **Mô tả hoạt động:**
- **Bước 1**: Khách hàng đến cửa hàng và duyệt qua các kệ sách.
- **Bước 2**: Khách hàng chọn các sách mình muốn mua từ các kệ và mang đến quầy thanh toán.

#### **Dữ liệu tương ứng:**
- Tại bước này, không có thao tác dữ liệu thực hiện trên hệ thống. Thông tin về sách hiện có (số lượng và chi tiết sách) đã được nhập sẵn từ trước và được hiển thị trên hệ thống bán hàng nếu nhân viên cần tra cứu.

### **2. Nhân viên quầy thu ngân xử lý đơn hàng**

#### **Mô tả hoạt động:**
- **Bước 3**: Khách hàng đưa sách đã chọn đến quầy thu ngân.
- **Bước 4**: Nhân viên sử dụng hệ thống để bắt đầu quá trình xử lý đơn hàng.

#### **Thao tác trên hệ thống:**
1. **Tìm thông tin sách**:
   - Nhân viên sẽ quét mã ISBN của từng cuốn sách hoặc tìm kiếm theo tên sách trong hệ thống. Thông tin sách sẽ được truy xuất từ bảng `Books`.
   
   ```sql
   SELECT * FROM Books WHERE ISBN = 'mã_ISBN' OR Title LIKE '%tên sách%';
   ```

2. **Kiểm tra tồn kho**:
   - Hệ thống kiểm tra số lượng sách hiện có trong kho (cột `StockQuantity` trong bảng `Books`). Nếu sách không đủ số lượng, nhân viên sẽ thông báo cho khách hàng.

   ```sql
   SELECT StockQuantity FROM Books WHERE BookID = 'BookID';
   ```

3. **Tạo đơn hàng mới**:
   - Nhân viên sẽ tạo một bản ghi mới trong bảng `Orders` để lưu thông tin về đơn hàng của khách hàng, bao gồm `CustomerID` (nếu khách hàng có tài khoản), `OrderDate`, `TotalAmount` (sẽ tính sau khi chọn xong tất cả sách), và `PaymentMethod`.

   ```sql
   INSERT INTO Orders (CustomerID, OrderDate, TotalAmount, PaymentMethod, Status)
   VALUES ('CustomerID', CURDATE(), 'TotalAmount', 'PaymentMethod', 'Pending');
   ```

4. **Thêm chi tiết đơn hàng (OrderDetails)**:
   - Mỗi cuốn sách được chọn sẽ được thêm vào bảng `OrderDetails`, với thông tin `OrderID`, `BookID`, `Quantity`, và `UnitPrice`.

   ```sql
   INSERT INTO OrderDetails (OrderID, BookID, Quantity, UnitPrice)
   VALUES ('OrderID', 'BookID', 'Quantity', 'UnitPrice');
   ```

### **3. Thanh toán**

#### **Mô tả hoạt động:**
- **Bước 5**: Sau khi chọn sách và tạo đơn hàng, nhân viên quầy thanh toán sẽ yêu cầu khách hàng thanh toán.
- **Bước 6**: Khách hàng có thể thanh toán bằng tiền mặt, thẻ tín dụng hoặc ví điện tử.

#### **Thao tác trên hệ thống:**
1. **Tính tổng số tiền thanh toán**:
   - Hệ thống tính toán tổng giá trị của đơn hàng, bao gồm giá của từng cuốn sách và số lượng tương ứng.

   ```sql
   SELECT SUM(Quantity * UnitPrice) AS TotalAmount
   FROM OrderDetails
   WHERE OrderID = 'OrderID';
   ```

2. **Cập nhật phương thức thanh toán**:
   - Nhân viên ghi nhận phương thức thanh toán mà khách hàng sử dụng (tiền mặt, thẻ tín dụng, ví điện tử) và cập nhật vào bảng `Orders`.

   ```sql
   UPDATE Orders
   SET PaymentMethod = 'Phương thức thanh toán', TotalAmount = 'Tổng tiền', Status = 'Hoàn tất'
   WHERE OrderID = 'OrderID';
   ```

3. **In hóa đơn**:
   - Sau khi thanh toán, hệ thống có thể in hóa đơn bán hàng cho khách hàng, bao gồm danh sách sách đã mua, tổng tiền và phương thức thanh toán.

### **4. Cập nhật tồn kho**

#### **Mô tả hoạt động:**
- **Bước 7**: Sau khi đơn hàng hoàn tất, hệ thống tự động cập nhật số lượng tồn kho để phản ánh số lượng sách đã bán ra.

#### **Thao tác trên hệ thống:**
1. **Cập nhật bảng `Books`**:
   - Hệ thống trừ số lượng sách đã bán từ kho.

   ```sql
   UPDATE Books
   SET StockQuantity = StockQuantity - 'Quantity'
   WHERE BookID = 'BookID';
   ```

### **5. Quản lý trả hàng (nếu có)**

#### **Mô tả hoạt động:**
- **Bước 8**: Nếu khách hàng quay lại với yêu cầu trả hàng (ví dụ: do sách bị lỗi hoặc không đúng mong đợi), nhân viên sẽ xử lý trả hàng theo yêu cầu.
- **Bước 9**: Nhân viên kiểm tra điều kiện trả hàng và tiến hành hoàn tiền hoặc đổi sản phẩm cho khách hàng.

#### **Thao tác trên hệ thống:**
1. **Ghi nhận yêu cầu trả hàng**:
   - Nhân viên tạo một bản ghi mới trong bảng `Returns` để lưu thông tin về đơn hàng trả lại, bao gồm `OrderID`, `ReturnDate`, `TotalRefund`, và lý do trả hàng.

   ```sql
   INSERT INTO Returns (OrderID, ReturnDate, TotalRefund, Status, Reason)
   VALUES ('OrderID', CURDATE(), 'TotalRefund', 'Pending', 'Lý do');
   ```

2. **Thêm chi tiết trả hàng**:
   - Nếu khách hàng trả lại từng cuốn sách, thông tin này sẽ được thêm vào bảng `ReturnDetails`.

   ```sql
   INSERT INTO ReturnDetails (ReturnID, BookID, Quantity, RefundAmount)
   VALUES ('ReturnID', 'BookID', 'Số lượng trả', 'Tiền hoàn lại');
   ```

3. **Cập nhật tồn kho**:
   - Nếu sách được trả lại và có thể bán tiếp, hệ thống sẽ cập nhật số lượng tồn kho trong bảng `Books`.

   ```sql
   UPDATE Books
   SET StockQuantity = StockQuantity + 'Số lượng trả'
   WHERE BookID = 'BookID';
   ```

### **6. Quản lý thẻ thành viên (Membership)**

#### **Mô tả hoạt động:**
- **Bước 10**: Nếu khách hàng có thẻ thành viên, hệ thống sẽ áp dụng mức giảm giá tương ứng với cấp bậc thẻ của khách hàng.
- **Bước 11**: Nhân viên có thể đăng ký hoặc nâng cấp thẻ thành viên cho khách hàng.

#### **Thao tác trên hệ thống:**
1. **Kiểm tra cấp bậc thẻ thành viên**:
   - Hệ thống truy vấn bảng `Memberships` để kiểm tra thông tin thẻ của khách hàng và mức giảm giá.

   ```sql
   SELECT MembershipLevel, DiscountRate
   FROM Memberships
   WHERE CustomerID = 'CustomerID';
   ```

2. **Áp dụng giảm giá**:
   - Hệ thống tự động tính toán tổng số tiền phải trả sau khi áp dụng giảm giá dựa trên `DiscountRate`.

   ```sql
   UPDATE Orders
   SET TotalAmount = TotalAmount - (TotalAmount * DiscountRate / 100)
   WHERE OrderID = 'OrderID';
   ```

3. **Đăng ký hoặc gia hạn thẻ thành viên**:
   - Nếu khách hàng đăng ký thẻ mới, hệ thống sẽ tạo một bản ghi trong bảng `Memberships`. Nếu thẻ hết hạn, nhân viên có thể gia hạn thẻ cho khách hàng.

   ```sql
   INSERT INTO Memberships (CustomerID, MembershipLevel, IssueDate, ExpirationDate, DiscountRate)
   VALUES ('CustomerID', 'Gold', CURDATE(), DATE_ADD(CURDATE(), INTERVAL 1 YEAR), 10);
   ```

### **7. Báo cáo doanh thu**

#### **Mô tả hoạt động:**
- **Bước 12**: Quản lý cửa hàng có thể xem báo cáo doanh thu hàng ngày, hàng tháng, hoặc theo kỳ.

#### **Thao tác trên hệ thống:**
1. **Tính doanh thu theo ngày**:
   - Hệ thống tính toán tổng doanh thu, tổng hoàn tiền và doanh thu ròng cho mỗi ngày từ các bảng `Orders`, `OrderDetails` và `Returns`.

   ```sql
   SELECT OrderDate, SUM(TotalAmount) AS TotalSales
   FROM Orders
   WHERE Status = 'Completed'
   GROUP BY OrderDate;
   ```

2. **Hiển thị báo cáo**:
   - Hệ thống hiển thị báo cáo doanh thu ròng theo ngày, tháng hoặc năm dựa trên các truy vấn dữ liệu.
