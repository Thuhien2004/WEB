using System;

namespace Love
{
    public class LoveCalculator
    {
        // Ngày bắt đầu yêu
        public DateTime StartDate { get; set; }

        // Kết quả hiển thị
        public string Message { get; private set; }

        // Hàm tính số ngày yêu
        public void Calculate()
        {
            TimeSpan diff = DateTime.Now.Date - StartDate.Date;
            int days = diff.Days;

            if (days < 0)
            {
                Message = "Ngay bat dau chua toi";
                return;
            }

            // Nếu đúng bội số 100 ngày, hiển thị thông điệp đặc biệt
            if (days % 100 == 0 && days != 0)
                Message = $"Chuc mung {days} ngay yeu! ❤️";
            else
                Message = $"Ban da yeu duoc {days} ngay. Keep loving! 💕";
        }
    }
}
