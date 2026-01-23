# Space Shooter 2D - Demo Part 2

**Thông tin sinh viên:**
- **Họ và tên:** Dư Văn Sang
- **Mã sinh viên:** BIT230361
- **Lớp:** 23IT-SOFT5

## Mô tả dự án
Đây là dự án game **Space Shooter 2D** được phát triển trên Unity engine. Bài nộp này bao gồm các chức năng đã hoàn thành đến hết giai đoạn **Demo Part 2** (Cơ chế bắn súng).

## Các tính năng

### 🚀 Demo Part 2 (Mới cập nhật)
- **Hệ thống Bullet (Đạn):**
  - Tạo và tối ưu hóa Prefab cho viên đạn.
  - Script điều khiển đạn tự động bay lên theo trục Y.
- **Cơ chế chiến đấu (Combat):**
  - Xử lý sự kiện chuột: Nhấn giữ chuột trái để bắn liên tục (Auto-fire).
  - Tích hợp **Shooting Interval** (Tốc độ bắn) để kiểm soát nhịp độ ra đạn.
  - Sử dụng `Instantiate` để sinh đạn từ vị trí của Player.

### 🛸 Demo Part 1 (Cơ bản)
- **Thiết lập Player:** Tàu vũ trụ với tỷ lệ hiển thị (Scale) phù hợp.
- **Cơ chế di chuyển:** Tàu di chuyển mượt mà theo vị trí con trỏ chuột trên màn hình (Screen to World Point).
- **Hiệu ứng (VFX):** Hiệu ứng lửa đuôi tàu (Exhaust) nhấp nháy tự động bằng Script.
- **Cấu hình:** Tối ưu hiển thị cho độ phân giải **1920x1080 (Portrait)**.

## Công nghệ sử dụng
- **Engine:** Unity (Phiên bản 2021.x hoặc mới hơn)
- **Ngôn ngữ:** C#
- **Assets:** 2D Space Shooter Resources (Basic GUI, Sprites, FX).

## Hướng dẫn cài đặt và chạy
1. Clone repository này về máy tính.
2. Mở **Unity Hub** và chọn **Add** để thêm thư mục project vào danh sách.
3. Khởi động project (chờ Unity import assets).
4. Trong thư mục `Assets/Scenes`, mở Scene tên là **"Battle"** (hoặc Scene chính bạn đang làm việc).
5. Nhấn nút **Play** (▶) phía trên để chạy thử.
   - *Lưu ý:* Đảm bảo tỷ lệ màn hình Game view là **1920x1080 Portrait** và Scale là **1x** để có trải nghiệm đúng nhất.

## Nhật ký thay đổi (Changelog)
- **Part 1:** Hoàn thiện setup nhân vật và di chuyển.
- **Part 2:** Hoàn thiện tính năng bắn đạn cơ bản.