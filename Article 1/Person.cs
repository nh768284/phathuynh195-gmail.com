using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public string Name { get; set; }
    public int Number { get; set; }
    public bool IsChecked { get; set; }
    public string RadioChoice { get; set; }
    public string Day { get; set; }
    public List<string> Items { get; set; }

    public Person()
    {
        Items = new List<string>();
    }
}