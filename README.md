# WEB

Lập trình web

TẠO SOLUTION GỒM CÁC PROJECT SAU:

DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

----------------------------------------
Thiết kế xây dựng web đếm ngày yêu đơn giản , thực hiện 4 project lần lượt như sau:
PROJECT 1 – Love.dll
Bước 1: Tạo project Class Library

Mở Visual Studio → File → New → Project

Chọn:

Project type: Visual C# → Windows

Template: Class Library (.NET Framework)

Đặt Name: Love

Chọn .NET Framework 2.0

Nhấn OK → Visual Studio tạo project

Bước 2: Tạo class tính ngày yêu

Chuột phải Love → Add → Class → Name: LoveCalculator.cs

## ẢNH:

Bước 3: Build DLL

-> Build → Build Solution

PROJECT 2 – LoveConsole
Bước 1: Tạo project Console Application

File → New → Project → Visual C# → Console Application (.NET Framework)

Name: LoveConsole

Chọn .NET Framework 2.0

Nhấn OK → Visual Studio tạo project

Bước 2: Thêm reference đến DLL

Chuột phải References → Add Reference → Browse…

Chọn file Love.dll từ Project 1 (bin\Debug\Love.dll)

Nhấn OK → bây giờ project console đã nhận DLL

<img width="1746" height="923" alt="image" src="https://github.com/user-attachments/assets/6c1ddade-2861-4d79-95f9-783cc5e4dbc0" />

Bước 4: Chạy thử

F5 → Run

Console hiển thị:

<img width="659" height="198" alt="image" src="https://github.com/user-attachments/assets/de881b05-3f1f-480e-8c85-65781e05d69f" />

## PROJECT 3 – LoveWinForm
Bước 1: Tạo project Windows Form

File → New → Project → Visual C# → Windows Forms Application (.NET Framework)

Name: LoveWinForm

Chọn .NET Framework 2.0

Nhấn OK → Visual Studio tạo project

<img width="1286" height="837" alt="image" src="https://github.com/user-attachments/assets/55de7065-05c9-46f4-8aa5-e619ab08c3ef" />

Tạo MainForm.cs

Chuột phải project → Add → Class → Name: MainForm.cs

Thêm reference DLL

Chuột phải References → Add Reference → Browse…

Chọn Love.dll từ Project 1 (bin\Debug\Love.dll)

Nhấn OK

<img width="456" height="423" alt="image" src="https://github.com/user-attachments/assets/d85c02ae-2404-4af8-823e-169491773aba" />

Chạy thử

Nhấn F5 → Run

Form hiển thị, chọn ngày → bấm “Tính số ngày”

Kết quả hiển thị với emoji và thông điệp cá nhân

<img width="613" height="370" alt="image" src="https://github.com/user-attachments/assets/d5cd9eeb-be9a-4114-bbd4-71bdf354362b" />

## PROJECT 4 – LoveWeb
Bước 1: Tạo project Web

File → New → Project → Visual C# → ASP.NET Web Application (.NET Framework)

Name: LoveWeb

Chọn .NET Framework 2.0 → OK

<img width="1257" height="839" alt="image" src="https://github.com/user-attachments/assets/443dd9b0-2112-4555-950c-6fc182ca1247" />

Bước 2: Chuẩn bị thư mục bin

Trong project, tạo folder bin nếu chưa có

Copy Love.dll vào folder bin

<img width="1033" height="198" alt="image" src="https://github.com/user-attachments/assets/0bb770ed-712e-48df-8874-34e2296f3807" />

Bước 3: Tạo file index.html (front-end)

Chuột phải project → Add → New Item → HTML Page → Name: index.html

<img width="1693" height="915" alt="image" src="https://github.com/user-attachments/assets/0a408971-b1ec-4b17-b64f-fe29573dbc3b" />

Bước 4: Tạo api.aspx (backend)

Chuột phải project → Add → New Item → Web Form → Name: api.aspx

Chọn Place code in separate file (code-behind) → OK

<img width="1701" height="933" alt="image" src="https://github.com/user-attachments/assets/ad827463-476c-48ca-ae56-81eeb6a98469" />

Bước 5: Cấu hình chạy bằng Visual Studio Development Server

Chuột phải project → Properties → Web

Chọn Local IIS và chọn domain ảo:

Nhấn Save

<img width="1051" height="556" alt="image" src="https://github.com/user-attachments/assets/3f0f413d-0dad-40b3-b5de-899c6cd8cc20" />

Bước tiếp theo: kiểm tra cấu hình để chạy DLL

App Pool

Vào IIS Manager → Application Pools → tìm pool của site LoveWeb

.NET Framework Version → v2.0

Managed pipeline → Classic

<img width="399" height="349" alt="image" src="https://github.com/user-attachments/assets/0b102f08-183a-41da-883f-7cf9bb960cc9" />

Gán site LoveWeb vào App Pool

Trong IIS Manager → Sites → LoveWeb

Chuột phải site → Manage Website → Advanced Settings…

Tìm Application Pool → chọn LoveWebPool

Nhấn OK

<img width="448" height="300" alt="image" src="https://github.com/user-attachments/assets/176ad1eb-de34-47f2-b9d7-fcd01df7a5bb" />

Bước 4: Kiểm tra

Pool LoveWebPool đang chạy → màu xanh

Site LoveWeb trỏ đúng folder project, folder bin có Love.dll

Test bằng trình duyệt:

http://localhost/LoveWeb/index.html

<img width="472" height="209" alt="image" src="https://github.com/user-attachments/assets/f19daa5f-8057-4c1f-871a-bf342d34d58f" />

→ Nhập ngày → bấm “Tính ngay” → kết quả hiển thị đúng

<img width="532" height="303" alt="image" src="https://github.com/user-attachments/assets/7cd8849b-9e9e-43da-a103-5afc393b1234" />














