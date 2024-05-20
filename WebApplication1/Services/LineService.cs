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
        if (message.Contains("哈嗕"))
        {
            string[] imgeUrl = new string[]
            {
                "https://imgur.com/4wNC7Cn",
                "https://imgur.com/5GGgykE",
                "https://imgur.com/UqqqhsI",
                "https://imgur.com/ZG7RtGu",
                "https://imgur.com/bZVq6Vc"
                

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
                "https://imgur.com/4wNC7Cn",
                "https://imgur.com/5GGgykE",
                "https://imgur.com/UqqqhsI",
                "https://imgur.com/ZG7RtGu",
                "https://imgur.com/bZVq6Vc"
                

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
                "https://imgur.com/jMPRfAC",
                "https://imgur.com/5GGgykE",
                "https://imgur.com/UqqqhsI",
                "https://imgur.com/ZG7RtGu",
                "https://imgur.com/bZVq6Vc"
                

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
                "https://imgur.com/76lIxKL",
                "https://imgur.com/dkFCc6t",
                "https://imgur.com/Wdp1iU8",
                "https://imgur.com/HAvgPuv"
               
                

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
                "https://imgur.com/76lIxKL",
               
                

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
                "https://imgur.com/Kb2awJm",
                "https://imgur.com/RotTa4A",
                "https://imgur.com/ZkbAuDW",
                

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
                "https://imgur.com/A1YlxBs",
                "https://imgur.com/sK5FBlZ",
                "https://imgur.com/cDObwbj",
                "https://imgur.com/GJZvCMo",
                "https://imgur.com/NEXaeFh",
                "https://imgur.com/CrkJ8X5",
                "https://imgur.com/2fEPmMe",
                "https://imgur.com/2ZAkZKq"
                

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
                "https://imgur.com/ZG7RtGu",
                "https://imgur.com/jMPRfAC",
                "https://imgur.com/bZVq6Vc",
                "",
                ""
                
                

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
                "https://imgur.com/V24tq5Z",
                "https://imgur.com/hc1cdQl",
                "https://imgur.com/n0FqKOd",
                "https://imgur.com/LOMcogS",
                "https://imgur.com/lJIW4wO"
                
                

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
                "https://imgur.com/RzBbSIA",
                "https://imgur.com/iFeWZfc",
                
                

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
                "https://imgur.com/zeQ7tWc",
                "https://imgur.com/WzQLNaq",
                "https://imgur.com/5cm5oeq",
                "https://imgur.com/G8vAD5y",
                
                
                

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
                "https://imgur.com/IHVhoj3",
                

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
                "https://imgur.com/ePUje2b",
                "https://imgur.com/2Hn6W1l",
                "https://imgur.com/pUaD3ps",
                "https://imgur.com/5zi1NBI",
                "https://imgur.com/OsF0sml",
                "https://imgur.com/fEMncuT",
                "https://imgur.com/Wx7i1Jd",
                "https://imgur.com/jOzjUtU",
                "https://imgur.com/tJvcxkt",
                "https://imgur.com/IHVhoj3",
                "https://imgur.com/QMBILKF"

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
                "https://i.imgur.com/4H8dkF1.jpg",
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