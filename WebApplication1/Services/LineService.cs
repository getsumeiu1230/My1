using System.Drawing;
using Line.Messaging;
using Line.Messaging.Webhooks;

public class LineService : ILineService
{
    public LineService()
    {
    }

    public async Task<List<ISendMessage>> ProcessTextEventMessageAsync(string channelId, string userId, string message)
    {
        var result = null as List<ISendMessage>;
        if (message.Contains("商店"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/zaLXpkp.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("小美冰淇淋"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/rHBdLMz.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("11冰淇淋"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/A47GG43.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("冰淇淋$"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/X46oF3T.jpg",//OK
                
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("冰淇淋＄"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/X46oF3T.jpg",//OK
                
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("冰淇淋"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/0RcyQuN.jpg",
                "https://i.imgur.com/100Vqif.jpg",
                "https://i.imgur.com/INZS57H.jpg"//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("水或飲料$"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/Em5D5Pm.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("水或飲料＄"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/Em5D5Pm.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("水或飲料"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/zTMlunz.jpg",
                "https://i.imgur.com/DIlD1i8.jpg",
                "https://i.imgur.com/PR0Aa2z.jpg"//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("汽水"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/MpRhlNE.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("水"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/1bUvTIV.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("無糖綠"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/ruXzZ8d.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("養樂多"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/jBnZICe.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("舒跑"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/3MEHYsR.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("鑽戒"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/XE8I99q.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("小電風扇"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/J48bZd0.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
       
        if (message.Contains("思樂冰"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/2wV7ld8.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("拿包包"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/iB4oX1f.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("我跟我兄弟出軌了"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/FvSQ4Ho.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("我覺得我配不上你"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/0YZrd57.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("分手"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/UNbMvIv.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("天氣真好"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/M4vrF9h.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("是不是胖了"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/8lUtm7I.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("開房間"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/AMdt2Ui.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("寶貝你今天真好看"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/EGGWDSh.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("做體操"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/7cgfKYR.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("遞衛生紙"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/zAjWlXY.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("悲劇"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/CmIIz2b.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("親下去"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/6k6cVLZ.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("盯著她看"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/XbFob18.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("睡覺"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/zhfJ6W5.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("愛情電影"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/kV1dDXo.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("爆米花機關槍"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/tiC3ztB.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("把自己的也給她"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/5irnx3O.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("爆米花"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/K3khJWi.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("親她"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/TJQ6kdy.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("牽她的手"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/j5FscLL.jpg",
                "https://i.imgur.com/rDTzRsd.jpg"
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("恐怖電影"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/pqed7IX.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("看電影"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/VwO6ipz.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("當馬"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/AmxDakZ.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("抓馬"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/ZehOe5O.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("旋轉木馬"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/GPADivp.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("雲霄飛車"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/DrEpKrC.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("摩天輪"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/L0K90GH.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("遊樂園"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/A0lXC4h.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("學生泳衣"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/HXvoii0.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("去關心小南"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/1eEG5bG.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("過去扁他們!!!"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/0dk6vR7.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("過去扁他們！！！"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/vz9pLE6.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("過去扁他們!"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/vz9pLE6.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("過去扁他們！"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/vz9pLE6.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("過去扁他們"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/KIz8mSx.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("比基尼"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/aqx2gy9.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("白色連衣裙"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/6m9UfG3.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("海邊"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/Np6q0uA.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("自己寫的"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/0LpY2vQ.jpg",
                "https://i.imgur.com/BriQF3l.jpg",
                "https://i.imgur.com/IwvP2Ar.jpg"//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("小南寫的"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/2FCZYKo.jpg"//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("放天燈"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/kyVTPbx.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("上來吧"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/QglOjSW.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("去公車站接他"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/48FO5vD.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("開車"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/TEYKCBW.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("黑蘋果"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/IvMA53l.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("戀愛"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/fq7oCyh.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("冒險"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/a40zOVC.jpg",//ok
                
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("睏"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/FY5E5PC.jpg",//ok
                "https://i.imgur.com/pHB8qQU.jpg",
                "https://i.imgur.com/aJxQKaX.jpg",
                "https://i.imgur.com/xLv4W7y.jpg",
                "https://i.imgur.com/5GGgykE.jpg",
                "https://i.imgur.com/UqqqhsI.jpg"
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("呀咧"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/9Zuk8ck.jpg",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("中獎"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/AyEIwLu.jpg",
                "https://i.imgur.com/PQET5Vk.jpg"//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("傳說"))
        {
            string[] imgeUrl = new string[]
            {
                "0https://i.imgur.com/NwrUEiS.jpg",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("阿北鮪魚"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/tC8ocnT.png",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("新年快樂"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/NRM3mBO.jpg",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("燒腦"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/cFDhQk1.jpg",
                "https://i.imgur.com/VcEr4yp.jpg"//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("壯"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/hRws3tb.jpg",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("沒錢"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/4z3p6zX.jpg",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("不想做設計"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/IVY4oVH.jpg",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("蘑菇"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/GbiGScM.jpg",
                "https://i.imgur.com/gdCW2MG.jpg"//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("泰拉瑞亞"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/WzQLNaq.jpg",
                "https://i.imgur.com/BptBXcx.jpg",
                "https://i.imgur.com/WyQznXa.jpg"//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("芒果"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/2JDoUif.jpg",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("蘋果"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/KXi2iIZ.jpg",
                "https://i.imgur.com/CEK4UxW.jpg",
                "https://i.imgur.com/FRmiFXn.png",
                "https://i.imgur.com/P9eoz3Z.png"//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("香蕉"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/2zdfufV.png",
                "https://i.imgur.com/A1YlxBs.jpg",
                "https://i.imgur.com/KXi2iIZ.jpg"//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("色色"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/u7MLyH5.png",
                "https://i.imgur.com/9T13oBf.jpg",
                "https://i.imgur.com/StozIu2.jpg",
                "https://i.imgur.com/A1YlxBs.jpg",
                "https://i.imgur.com/dA9MBCC.jpg"//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("聰明"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/rySPOVW.jpg",
                "https://i.imgur.com/X8sh8uF.jpg"//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("丟包"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/FnzEOdj.jpg",
                "https://i.imgur.com/zine7dd.jpg"//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("垃圾"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/S3oAH5p.jpg",
                "https://i.imgur.com/ohN7afM.jpg",
                "https://i.imgur.com/PQET5Vk.jpg",
                "https://i.imgur.com/lGHnxGG.jpg",
                "https://i.imgur.com/AyEIwLu.jpg",
                "https://i.imgur.com/N5hHPWT.jpg",
                "https://i.imgur.com/0BMARrD.jpg"//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("地震"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/6X148po.jpg",
                "https://i.imgur.com/SItw0Ml.jpg"//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("指甲"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/2L4Z2XG.jpg",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("品客"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/QMBILKF.png",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("鬍子"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/QMBILKF.png",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("間諜家家酒"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/QMBILKF.png",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("好多魚"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/kDxAMQ4.jpg",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("蜘蛛絲"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/GvsMEJS.jpg",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("屁股"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/dkFCc6t.jpg",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("愛你"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/bZVq6Vc.jpg",
                "https://i.imgur.com/5cm5oeq.jpg",
                "https://i.imgur.com/cDqJ30Y.jpg",
                "https://i.imgur.com/XWCvbIf.jpg",
                "https://i.imgur.com/7y8uX3H.jpg",
                "https://i.imgur.com/NAbE9io.jpg"//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("花花"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/V15zjOb.jpg",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("發票"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/OPx4FxQ.jpg",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("毛毛小怪獸"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/95FxGQN.jpg",
                "https://i.imgur.com/ew0NusO.jpg"//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("萬聖節"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/4H8dkF1.jpg",//OK
                "https://i.imgur.com/iHqpOih.jpg",

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("我看了什麼"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/hMtRQaU.jpg",//ok
               
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("哈嗕"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/cDqJ30Y.jpg",
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("哼"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/tJvcxkt.jpg",//ok
                "https://i.imgur.com/n1xHl36.jpg",
                "https://i.imgur.com/4wNC7Cn.jpg",
                "https://i.imgur.com/LgF6L5C.jpg",
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("臭臭"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/jMPRfAC.jpg",//ok
                "https://i.imgur.com/5GGgykE.jpg",
                "https://i.imgur.com/UqqqhsI.jpg",
                "https://i.imgur.com/ZG7RtGu.jpg",
                "https://i.imgur.com/bZVq6Vc.jpg"
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("腳腳"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/dkFCc6t.jpg",//ok
                "https://i.imgur.com/Wdp1iU8.jpg",
                "https://i.imgur.com/HAvgPuv.jpg",
                "https://i.imgur.com/4wNC7Cn.jpg",
                "https://i.imgur.com/xe3yeYa.jpg",
                "https://i.imgur.com/CXGJane.jpg",
                "https://i.imgur.com/FLAMQMJ.jpg",
                
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("咕咕"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/76lIxKL.jpg",
                "https://i.imgur.com/jAwWgk2.jpg", //ok
                "https://i.imgur.com/FY5E5PC.jpg",
                ""
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("ㄆㄨㄧ"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/5MeakDT.gif",//ok
                
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("冷"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/Kb2awJm.jpg",//ok
                "https://i.imgur.com/RotTa4A.jpg",
                "https://i.imgur.com/ZkbAuDW.jpg",
                "https://i.imgur.com/TemtB9T.jpg"
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("哈啾"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/Kb2awJm.jpg",//ok
                "https://i.imgur.com/RotTa4A.jpg",
                "https://i.imgur.com/ZkbAuDW.jpg",
                "https://i.imgur.com/TemtB9T.jpg"
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("耶"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/Tbe3oym.jpg",//ok
                "https://i.imgur.com/dA9MBCC.jpg",
                "https://i.imgur.com/X8sh8uF.jpg",
                "https://i.imgur.com/ZcnddPD.jpg",
                "https://i.imgur.com/kejsGTM.jpg",
                "https://i.imgur.com/cDqJ30Y.jpg",
                "https://i.imgur.com/cFDhQk1.jpg",
                "https://i.imgur.com/lfJT0gb.jpg",
                "https://i.imgur.com/XWCvbIf.jpg",
                "https://i.imgur.com/sZWy0j8.png"
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("ㄤㄇㄇ"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/A1YlxBs.jpg",//ok
                "https://i.imgur.com/sK5FBlZ.jpg",
                "https://i.imgur.com/cDObwbj.jpg",
                "https://i.imgur.com/GJZvCMo.jpg",
                "https://i.imgur.com/NEXaeFh.jpg",
                "https://i.imgur.com/CrkJ8X5.jpg",
                "https://i.imgur.com/2fEPmMe.jpg",
                "https://i.imgur.com/2ZAkZKq.png",
                "https://i.imgur.com/7WyrGFH.png",
                "https://i.imgur.com/EzYbIv1.png",
                "https://i.imgur.com/cqQDJaJ.jpg"
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("哭"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/7mMvMvZ.jpg",//ok
                "https://i.imgur.com/iFeWZfc.jpg",
                "https://i.imgur.com/FLAMQMJ.jpg",
                "https://i.imgur.com/CXGJane.jpg"
               
                
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("葡"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/bZVq6Vc.jpg",//ok
                "https://i.imgur.com/jMPRfAC.jpg",
               
                
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("可愛"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/NAbE9io.jpg",//ok
                "https://i.imgur.com/7y8uX3H.jpg",
                "https://i.imgur.com/5cm5oeq.jpg",
                "https://i.imgur.com/kejsGTM.jpg",
                "https://i.imgur.com/QtJXFR3.jpg",
                "https://i.imgur.com/V15zjOb.jpg",
                "https://i.imgur.com/95FxGQN.jpg",
                "https://i.imgur.com/cDqJ30Y.jpg",
                
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("胖"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/V24tq5Z.jpg",//ok
                "https://i.imgur.com/GJZvCMo.jpg",
                "https://i.imgur.com/QtJXFR3.jpg",
                "https://i.imgur.com/cDqJ30Y.jpg",
                "https://i.imgur.com/hc1cdQl.jpg",
                "https://i.imgur.com/NEXaeFh.jpg",
                "https://i.imgur.com/lJIW4wO.jpg",
                "https://i.imgur.com/LOMcogS.jpg",
                
                
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("笨"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/u6u7VIf.jpg",//ok
                "https://i.imgur.com/n0FqKOd.jpg",
                "https://i.imgur.com/LOMcogS.jpg",
                "https://i.imgur.com/X8sh8uF.jpg",
                "https://i.imgur.com/ZcnddPD.jpg",
                "https://i.imgur.com/WO5dM6W.jpg",
                "https://i.imgur.com/dkFCc6t.jpg",
                "https://i.imgur.com/QtJXFR3.jpg",
                "https://i.imgur.com/cDqJ30Y.jpg",
                "https://i.imgur.com/lfJT0gb.jpg",
                "https://i.imgur.com/ZkbAuDW.jpg",
                "https://i.imgur.com/76lIxKL.jpg",
                "https://i.imgur.com/7WyrGFH.png",
                "https://i.imgur.com/E8RG6b0.jpg"
                
                
                
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("秀"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/zeQ7tWc.jpg",//ok
                "https://i.imgur.com/dkFCc6t.jpg",
                "https://i.imgur.com/RzBbSIA.jpg",
                "https://i.imgur.com/iFeWZfc.jpg",
                
                
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("抱"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/zeQ7tWc.jpg",//ok
                "https://i.imgur.com/RzBbSIA.jpg",
                "https://i.imgur.com/WzQLNaq.jpg",
                "https://i.imgur.com/5cm5oeq.jpg",
                "https://i.imgur.com/G8vAD5y.jpg",
                
                
                
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        
        if (message.Contains("飛"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/IHVhoj3.jpg",//ok
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        
        if (message.Contains("駝駝"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/ePUje2b.jpg",//OK
                "https://i.imgur.com/2Hn6W1l.jpg",
                "https://i.imgur.com/pUaD3ps.jpg",
                "https://i.imgur.com/5zi1NBI.jpg",
                "https://i.imgur.com/OsF0sml.jpg",
                "https://i.imgur.com/fEMncuT.jpg",
                "https://i.imgur.com/Wx7i1Jd.jpg",
                "https://i.imgur.com/jOzjUtU.jpg",
                "https://i.imgur.com/tJvcxkt.jpg",
                "https://i.imgur.com/NEXaeFh.jpg",
                "https://i.imgur.com/IHVhoj3.jpg",
                "https://i.imgur.com/OeJElfs.jpg",
                "https://i.imgur.com/G8vAD5y.jpg",
                "https://i.imgur.com/zeGb1vS.jpg",
                "https://i.imgur.com/QMBILKF.png",
                "https://i.imgur.com/5MeakDT.gif"

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        
        
        if (message.Contains("好棒"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/7y8uX3H.jpg",//ok
                "https://i.imgur.com/Tbe3oym.jpg",
                "https://i.imgur.com/X8sh8uF.jpg",
                "https://i.imgur.com/QtJXFR3.jpg",
                "https://i.imgur.com/95FxGQN.jpg",
                "https://i.imgur.com/cDqJ30Y.jpg"
                
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        if (message.Contains("好嗎"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/cDqJ30Y.jpg",//ok
                "https://i.imgur.com/lfJT0gb.jpg"
               
                

            };
            Random rnd =new Random((int)DateTime.Now.TimeOfDay.TotalSeconds);
            int index = rnd.Next(0, imgeUrl.Length);

            return new List<ISendMessage>
            {
                new ImageMessage(imgeUrl[index], imgeUrl[index],null),
            };
        }
        result = new List<ISendMessage>
        {
            new TextMessage($"蘋果超人聽不懂")
        };
        return result;
    }
    

    public async Task<List<ISendMessage>> ProcessStickerEventMessageAsync(string channelId, string userId,string packageId, string stickerId)
    {
        var result = null as List<ISendMessage>;
        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a sticker event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId,string originalContentUrl,
        string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId, Image image)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessVideoEventMessageAsync(string channelId, string userId,string originalContentUrl, string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a video event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessAudioEventMessageAsync(string channelId, string userId,string originalContentUrl, int duration)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a audio event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessLocationEventMessageAsync(string channelId, string userId,string title, string address, float latitude, float longitude)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a location event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
}