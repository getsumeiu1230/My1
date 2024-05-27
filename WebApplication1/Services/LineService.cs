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
                "https://i.imgur.com/dkFCc6t.jpg",
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
        if (message.Contains("哈啾"))
        {
            string[] imgeUrl = new string[]
            {
                "https://i.imgur.com/Kb2awJm.jpg",//ok
                "https://i.imgur.com/RotTa4A.jpg",
                "https://i.imgur.com/ZkbAuDW.jpg",
                

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
                "https://imgur.com/Tbe3oym",
                "https://imgur.com/dA9MBCC",
                "https://imgur.com/X8sh8uF",
                "https://imgur.com/ZcnddPD",
                "https://imgur.com/kejsGTM",
                "https://imgur.com/cDqJ30Y",
                "https://imgur.com/cFDhQk1",
                "https://imgur.com/lfJT0gb",
                "https://imgur.com/XWCvbIf"
                

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
                "https://imgur.com/7y8uX3H",
                "https://imgur.com/KXi2iIZ",
                "https://imgur.com/QtJXFR3",
                "https://imgur.com/BptBXcx",
                "https://imgur.com/NEXaeFh",
                "https://imgur.com/5cm5oeq",
                "https://imgur.com/7WyrGFH",
                "https://imgur.com/95FxGQN",
                "https://imgur.com/QMBILKF"
                

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
                "https://i.imgur.com/lJIW4wO.jpg"
                
                

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
                "https://imgur.com/u6u7VIf",
                "https://imgur.com/n0FqKOd",
                "https://imgur.com/dA9MBCC",
                "https://imgur.com/X8sh8uF",
                "https://imgur.com/ZcnddPD",
                "https://imgur.com/WO5dM6W",
                "https://imgur.com/dkFCc6t",
                "https://imgur.com/QtJXFR3",
                "https://imgur.com/2JDoUif",
                "https://imgur.com/cFDhQk1",
                "https://imgur.com/cDqJ30Y",
                "https://imgur.com/lfJT0gb",
                "https://imgur.com/ZkbAuDW",
                "https://imgur.com/76lIxKL",
                "https://imgur.com/BptBXcx",
                "https://imgur.com/WzQLNaq",
                "https://imgur.com/7WyrGFH",
                "https://imgur.com/QMBILKF",
                "https://imgur.com/hMtRQaU"
                
                
                
                

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
                "https://i.imgur.com/IHVhoj3.jpg",
                

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
                "https://i.imgur.com/QMBILKF.png"

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
        if (message.Contains("好棒"))
        {
            string[] imgeUrl = new string[]
            {
                "https://imgur.com/7y8uX3H",
                "https://imgur.com/dA9MBCC",
                "https://imgur.com/IVY4oVH",
                "https://imgur.com/Tbe3oym",
                "https://imgur.com/2JDoUif",
                "https://imgur.com/GJZvCMo",
                "https://imgur.com/X8sh8uF",
                "https://imgur.com/ZcnddPD",
                "https://imgur.com/QtJXFR3",
                "https://imgur.com/jMPRfAC",
                "https://imgur.com/WyQznXa",
                "https://imgur.com/BptBXcx",
                "https://imgur.com/WzQLNaq",
                "https://imgur.com/95FxGQN",
                "https://imgur.com/QMBILKF"
                
                

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