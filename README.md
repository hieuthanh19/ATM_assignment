# ATM_assignment

Link onedirve project: https://1drv.ms/u/s!AiFVLPRBePKonNhyDyhLufvMKa14dg?e=wmk98A \
**Cập nhật DB 13/03** \
Mọi người tải DB mới từ onedrive của project về. Sau đó xóa DataSet cũ trong Solution Explorer rồi vào Data Source add lại.
Thay đổi:
- ID tự tăng (DB cũ quên check vụ tự tăng ID sau khi convert từ MySQL sang SQL server)
- Bỏ 2 cột không cần thiết trong Product
- Thêm giá trị mặc định cho product_updatedAt, order_deliveredAt và order_updatedAt
- Còn sửa linh tinh vài cái...

## Account List:
-Role: Admin\
	username: admin	\
	password: admin\
-Role: Manager\
	username: thanhkh\
	password: 11022000\
-Role: User \
	username: test1234 \
	password: test1234 
## About the Database
1. Dùng sql server để có thể kéo thả bảng -> nhanh
2. Dùng file sql rời
### Thêm file sql rời vào Project
1. Tải 2 file database trong folder Database
2. Bấm show icon Show all file trong Solution Explorer (hàng trên cùng)
3. Vào Server Explorer -> Connect to Database. Data source: chọn Microsoft SQL Server Database File. Rồi Browse file database ở bước 1
4. Vào Advanced -> Source/Data source -> chọn SQLExpress (Nhớ tải sql express nhe mn) rồi Test connection. Nếu ổn thì OK thôi.
5. Vào Data source -> Add new -> database -> dataset -> chọn data connection đã tạo ở bước 4. Check vào tables rồi Finish

**Do file sql chuyển từ mysql sang sql server bằng tool + sửa lỗi bằng tay nên có thể có sai sót**

