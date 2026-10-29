# Top-down Tiles — chế độ xem ô vuông

Top-down Tiles vẽ các bản đồ ô thẳng từ trên xuống, trên lưới ô vuông, theo phong cách các game nhập vai 2D cổ điển. Đây là một trong hai chế độ xem bản đồ của nền chung Tile Rendering; chế độ kia là Isometric Tiles. RPG Plus dùng chế độ này.

![Làng RPG Plus lúc trưa trong chế độ nhìn từ trên: những ngôi nhà, quảng trường có đèn, dân làng, chiếc ao và nhân vật chính.](assets/village-topdown.jpg)

## Thay đổi gì, không đổi gì

Mod này chỉ quyết định **một ô bản đồ biến thành điểm ảnh trên màn hình như thế nào**: mỗi ô là một hình vuông đúng cỡ ô của tileset, còn vật thể được nhô lên sẽ vẽ cao hơn trên màn hình nhưng vẫn nằm đúng ô của nó.

Mọi thứ còn lại thuộc về các mod khác và không đổi khi chuyển chế độ xem:

- **bản đồ và nội dung của nó** — ô, nhà cửa, con người, rương — đến từ các mod nội dung (ví dụ RPG Demo và Village Pack);
- **đi lại, va chạm, sự kiện, chiến đấu và save** thuộc về mod RPG, dùng cùng một lưới ở cả hai chế độ;
- **vẽ, chiếu sáng và thời gian trong ngày** do Tile Rendering đảm nhiệm.

Phím mũi tên và WASD di chuyển theo hướng lên, xuống, trái, phải của màn hình.

![Cùng bản đồ làng ở hai chế độ: nhìn từ trên bên trái, đẳng cự bên phải.](assets/same-map-two-projections.jpg)

## Cách bật

Trong sơ đồ game (**Mod & Bộ sưu tập → Bộ sưu tập → game → Sửa sơ đồ**), đưa mod này vào và đặt **Phép chiếu bản đồ** thành **Nhìn từ trên**. Giá trị của cài đặt `tile.renderer` là `topdown`:

```json
"settings": { "tile.renderer": "topdown" }
```

Chỉ chạy một lần thì thêm `--tile-renderer=topdown` vào dòng lệnh. Nếu game chỉ có riêng trình kết xuất này và để cài đặt trống, nó sẽ được dùng tự động.

## Khi có trục trặc

1. **Bản đồ trống trơn.** **Phép chiếu bản đồ** của game yêu cầu một trình kết xuất không có trong game; hãy đưa mod này vào hoặc chọn phép chiếu khác.
