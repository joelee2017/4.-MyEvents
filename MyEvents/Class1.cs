using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEvents
{
    class Class1
    {

        //Step 1 : declare event
        public delegate void MyDelegate(int Price);
        public event MyDelegate InvalidPrice;


        public void OnInvalidPrice(int Price)//方法：當事件產生時委派到這個方法之中
        {
            if (Price > 1000)
            {

                //Step 2 : Fire Event
                // Invoke 呼叫 client 所註冊的事件方法 執行
                if(this.InvalidPrice != null)
                {
                    //this.InvalidPrice.Invoke(Price);
                    InvalidPrice(Price);
                }
                
            }
        }
    }
}
