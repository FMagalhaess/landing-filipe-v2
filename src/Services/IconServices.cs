using Model;
namespace Services;

public class IconServices{
    static string size = "80";
    List<Icon> IconList = new List<Icon>{
        new Icon{
            Id = 3,
            Name = "C#",
            Url = $"https://img.icons8.com/?size={size}&id=Fycm8TUhWmFU&format=png&color=000000"
        },
        new Icon()
        {
            Id = 11,
            Name = ".NET",
            Url = $"https://img.icons8.com/?size={size}&id=1BC75jFEBED6&format=png&color=000000"
        },
        new Icon()
        {
            Id = 9,
            Name = "PHP",
            Url = $"https://img.icons8.com/?size={size}&id=JybIpZjjXT0F&format=png&color=000000"
        },
        new Icon()
        {
            Id = 12,
            Name = "Laravel",
            Url = $"https://img.icons8.com/?size={size}&id=lRjcvhvtR81o&format=png&color=000000"
        },
        new Icon{
            Id = 1,
            Name = "Javascript",
            Url = $"https://img.icons8.com/?size={size}&id=108784&format=png&color=000000"
        },
        new Icon{
            Id = 2,
            Name = "Typescript",
            Url = $"https://img.icons8.com/?size={size}&id=uJM6fQYqDaZK&format=png&color=000000"
        },
        new Icon{
            Id = 4,
            Name = "Python",
            Url = $"https://img.icons8.com/?size={size}&id=13441&format=png&color=000000"
        },
        new Icon{
            Id = 5,
            Name = "Html",
            Url = $"https://img.icons8.com/?size={size}&id=20909&format=png&color=000000"
        },
        new Icon{
            Id = 6,
            Name = "Css",
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
        new Icon()
        {
            Id = 10,
            Name = "Docker",
            Url = $"https://img.icons8.com/?size={size}&id=22813&format=png&color=000000"
        },
        new Icon()
        {
            Id = 13,
            Name = "MySql",
            Url = $"https://img.icons8.com/?size={size}&id=39855&format=png&color=000000"
        },
        new Icon()
        {
            Id = 14,
            Name = "Bootstrap",
            Url = $"https://img.icons8.com/?size={size}&id=g9mmSxx3SwAI&format=png&color=000000"
        },
        new Icon()
        {
            Id = 15,
            Name = "Flutter",
            Url = $"https://img.icons8.com/?size={size}&id=5pu47piHKg1I&format=png&color=000000"
        },
        
    };
    public List<Icon> GetIcons(){
        return IconList;
    }
    public Icon GetIconByName(string name)
    {
        Icon? icon = IconList.Find(x => x.Name == name);
        if (icon == null)
        {
            icon = new Icon()
            {
                Id = 9999999,
                Name = "not found",
                Url = $"https://img.icons8.com/?size={size}&id=45967&format=png&color=000000"
            };
        }

        return icon;
    }
}