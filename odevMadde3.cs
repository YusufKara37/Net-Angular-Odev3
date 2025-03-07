

#region 	Abstract class nedir ?

    //nesne yönelimli programlamada, türetilmiş sınıflar için temel bir sınıf sağlamak amacıyla kullanılan, kendisi doğrudan örneklenemeyen  bir sınıftır.
#endregion


#region interface nedir ?
//Interface, sadece metod imzalarını ve özellikleri tanımlayan, ancak bu metodların nasıl çalışacağını sınıflara bırakan bir yapıdır. Interface'ler, farklı sınıfların aynı davranışları sergilemesini sağlar ve çoklu kalıtım destekler.   
#endregion

#region Abstract class ile interface arasındaki farklar  nelerdir? 
//Abstract class , hem normal metodlar hem de soyut metodlar içerebilir ve bir sınıf yalnızca bir soyut sınıftan türeyebilir. Interface ise sadece metod imzaları içerir ve bir sınıf birden fazla interface'i implement edebilir. Ayrıca, soyut sınıflar alanlar içerebilirken, interface'ler sadece metod ve özellikleri tanımlar.  
#endregion


//	Abstract class ve interface ile 2’şer örnek yapınız.

public abstract class Hayvan
{
    public string Name { get; set; }
    public void Uc()
    {
    }

    public abstract void ses();
}

public class kopek:Hayvan
{
    public override void ses()
    {
        
    }
}

public class kedi:Hayvan
{
    public override void ses()
    {
        
    }
}