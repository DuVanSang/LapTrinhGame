# Space Shooter 2D - Demo Part 3

**Thông tin sinh viên:**
- **Họ và tên:** Dư Văn Sang
- **Mã sinh viên:** BIT230361
- **Lớp:** 23IT-SOFT5

## Mô tả dự án
Đây là dự án game **Space Shooter 2D** được phát triển trên Unity engine. Bài nộp này bao gồm các chức năng đã hoàn thành đến hết giai đoạn **Demo Part 3** (Kẻ địch, Va chạm vật lý và Hiệu ứng nổ).

## Các tính năng

### 💥 Demo Part 3 (Mới cập nhật)
- **Cải tiến cơ chế bắn:**
  - [cite_start]Điều chỉnh **Bullet Offset** (Vị trí xuất hiện đạn) để đạn bắn ra từ mũi tàu chính xác hơn[cite: 981].
- **Hệ thống Kẻ địch (Enemy):**
  - [cite_start]Tạo và tối ưu hóa **Prefab Enemy**[cite: 1043].
  - [cite_start]Thiết lập thành phần vật lý (`Rigidbody 2D`, `Box Collider 2D`) cho cả Đạn và Kẻ địch[cite: 1101, 1217].
- **Xử lý Va chạm (Physics & Collision):**
  - [cite_start]Thiết lập **Layers** (Player vs Enemy) và cấu hình **Collision Matrix** để tránh bắn nhầm đồng đội[cite: 1305, 1484].
  - [cite_start]Xử lý sự kiện `OnTriggerEnter2D`: Tự động tiêu diệt Enemy và xóa viên đạn khi xảy ra va chạm[cite: 1599, 1600].
- **Hiệu ứng (VFX):**
  - [cite_start]Thêm hiệu ứng nổ (**Explosion Prefab**) kích hoạt ngay khi Enemy bị tiêu diệt[cite: 1745].

### 🚀 Demo Part 2 (Cơ chế bắn)
- **Hệ thống Bullet:** Tạo Prefab đạn và Script điều khiển đạn bay thẳng theo trục Y.
- **Combat:**
  - Xử lý Input: Nhấn giữ chuột trái để bắn tự động (Auto-fire).
  - Tích hợp **Shooting Interval** (Tốc độ bắn) để kiểm soát nhịp độ ra đạn.
  - Sử dụng `Instantiate` để sinh đạn từ vị trí của Player.

### 🛸 Demo Part 1 (Core)
- **Thiết lập Player:** Tàu vũ trụ với tỷ lệ hiển thị (Scale) phù hợp.
- **Cơ chế di chuyển:** Tàu di chuyển mượt mà theo vị trí con trỏ chuột (Screen to World Point).
- **Hiệu ứng lửa:** Hiệu ứng đuôi tàu (Exhaust) nhấp nháy tự động.
- **Cấu hình:** Tối ưu hiển thị cho độ phân giải **1920x1080 (Portrait)**.

## Công nghệ sử dụng
- **Engine:** Unity (Phiên bản 2021.x)
- **Ngôn ngữ:** C#
- **Assets:** 2D Space Shooter Resources (Basic GUI, Sprites, FX, Explosions).

## Hướng dẫn cài đặt và chạy
1. Clone repository này về máy tính.
2. Mở **Unity Hub** và chọn **Add** để thêm thư mục project vào danh sách.
3. Khởi động project (chờ Unity import assets).
4. Trong thư mục `Assets/Scenes`, mở Scene tên là **"SpaceShooter"**.
5. Nhấn nút **Play** (▶) phía trên để chạy thử.
   - *Lưu ý:* Đảm bảo tỷ lệ màn hình Game view là **1920x1080 Portrait** và Scale là **1x** (hoặc fit screen) để có trải nghiệm đúng nhất.

## Nhật ký thay đổi (Changelog)
- **Part 1:** Hoàn thiện setup nhân vật và di chuyển.
- **Part 2:** Hoàn thiện tính năng bắn đạn cơ bản.
- **Part 3:** Hoàn thiện hệ thống kẻ địch, xử lý va chạm và hiệu ứng nổ.