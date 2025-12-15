using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

List<int> ParsedList { get; set; } // свойства для хранение списка
// метод для возвращение списка
public List<string>  GetList()
{
    return Items;
}

//сохранять список
public void SetList(List<int> list)
{
    Numbers = list;
}
// вернуть список в виде строки
public override string ToString()
{
    return string.Join(" ", Numbers);
}

}
