using System;

class Clock
{
    // 定义滴答事件
    public event EventHandler Tiktok;
    // 定义响铃事件
    public event EventHandler Alarm;

    // 触发滴答事件
    protected virtual void OnTink(EventArgs e)
    {
        Tiktok?.Invoke(this, e);
    }

    // 触发响铃事件
    protected virtual void OnAlarm(EventArgs e)
    {
        Alarm?.Invoke(this, e);
    }

    // 启动闹钟
    public void Start()
    {
        // 模拟时间流逝
        for (int i = 0; i < 10; i++)
        {
            // 触发滴答事件
            OnTink(EventArgs.Empty);

            // 模拟响铃：五秒响一次铃
            if (i == 5)
            {
                // 触发响铃事件
                OnAlarm(EventArgs.Empty);
            }

            // 等待一秒钟
            System.Threading.Thread.Sleep(1000);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Clock clock = new Clock();

        // 订阅滴答事件的处理方法
        clock.Tiktok += (sender, e) =>
        {
            Console.WriteLine("滴答");
        };

        // 订阅响铃事件的处理方法
        clock.Alarm += (sender, e) =>
        {
            Console.WriteLine("响铃");
        };

        // 启动闹钟
        clock.Start();
    }
}