using RePrjClinicAppoint.Models.Entity;
using System;
using System.Collections.Generic;
//預約 服務 處理
namespace RePrjClinicAppoint.Service
{ //時間軸
    public class Timeline
    {
        //每次看診時間 
        public static int SlotDurationMiuntes = 60;
        //早上時段
        public static int MorningShiftStarts = 9;
        public static int MorningShiftEnds = 12;
        //下午時段
        public static int AfternoonShiftStarts = 13;
        public static int AfternoonShiftEnds = 15;
        //晚上時段
        public static int NightShiftStarts = 18;
         public static int NightShiftEnds = 20;

        //產生預約的時間槽
        public static List<Appointment> GenerateSlots(DateTime start, DateTime end,string scale)
        {// 建立新的物件
            var result = new List<Appointment>();
            var timeline = GenerateTimeline(start, end, scale);

            foreach (var block in timeline)
            {
                if (start<=block.Start&&block.End<=end)
                {
                    for (var slotStart = block.Start; slotStart <block.End; slotStart=slotStart.AddMinutes(SlotDurationMiuntes))
                    {
                        var slotEnd = slotStart.AddMinutes(SlotDurationMiuntes);

                        var slot = new Appointment();
                        slot.startDate = slotStart;
                        slot.endDate = slotEnd;
                        slot.isFinish = true;

                        result.Add(slot);
                    }
                }
            }
                return result;
        }
        //產生預約的時間軸
        public static List<TimeBlock> GenerateTimeline(DateTime start, DateTime end, string scale)
        {
            // 建立新的物件
            var result = new List<TimeBlock>();
            //產生時段初始直
            var incrementMorning = 1;
            var incrementAfternoon = 1;
            var incrementNight = 1;
            
            var days = (end.Date - start.Date).TotalDays;

            if (end>end.Date)
            {
                days += 1;
            }
           
            if (scale=="shifts")
            {
                incrementMorning = MorningShiftEnds - MorningShiftStarts;
                incrementAfternoon = AfternoonShiftEnds - AfternoonShiftStarts;
                incrementNight = NightShiftEnds - NightShiftStarts;
            }

            for (var i = 0; i < days; i++)
            {
                var day = start.Date.AddDays(i);

                for (var x = MorningShiftStarts; x < MorningShiftEnds; x+=incrementMorning)
                {
                    var block = new TimeBlock();
                    block.Start = day.AddHours(x);
                    block.End = day.AddHours(x + incrementMorning);

                    result.Add(block);
                }
                for (var x = AfternoonShiftStarts; x < AfternoonShiftEnds; x += incrementAfternoon)
                {
                    var block = new TimeBlock();
                    block.Start = day.AddHours(x);
                    block.End = day.AddHours(x + incrementAfternoon);

                    result.Add(block);
                }
                for (var x = NightShiftStarts; x < NightShiftEnds; x += incrementNight)
                {
                    var block = new TimeBlock();
                    block.Start = day.AddHours(x);
                    block.End = day.AddHours(x + incrementNight);

                    result.Add(block);
                }

            }          
            return result;

        }

    }
}
