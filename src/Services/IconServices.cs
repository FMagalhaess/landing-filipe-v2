using Model;
namespace Services;

public class IconServices{
    static string size = "80";
    List<Icon> IconList = new List<Icon>{
        new Icon{
            Id = 1,
            Name = "Javascript",
            Url = $"https://img.icons8.com/?size={size}&id=108784&format=png&color=000000"
        },
        new Icon{
            Id = 2,
            Name = "TypeScript",
            Url = $"https://img.icons8.com/?size={size}&id=uJM6fQYqDaZK&format=png&color=000000"
        },
        new Icon{
            Id = 3,
            Name = "C#",
            Url = $"https://img.icons8.com/?size={size}&id=Fycm8TUhWmFU&format=png&color=000000"
        },
        new Icon{
            Id = 4,
            Name = "Python",
            Url = $"https://img.icons8.com/?size={size}&id=13441&format=png&color=000000"
        },
        new Icon{
            Id = 5,
            Name = "html",
            Url = $"https://img.icons8.com/?size={size}&id=20909&format=png&color=000000"
        },
        new Icon{
            Id = 6,
            Name = "css",
            Url = $"https://img.icons8.com/?size={size}&id=21278&format=png&color=000000"
        },
        new Icon{
            Id = 7,
            Name = "SqlServer",
            Url = $"https://img.icons8.com/?size={size}&id=7r81vNSlvJe6&format=png&color=000000",
        },
        new Icon{
            Id = 8,
            Name = "Git",
            Url = $"https://img.icons8.com/?size={size}&id=20906&format=png&color=000000",
        },
    };
    public List<Icon> GetIcons(){
        return IconList;
    }
    public Icon GetIconByName(string name){
        return IconList.Find(x => x.Name == name);
    }
}