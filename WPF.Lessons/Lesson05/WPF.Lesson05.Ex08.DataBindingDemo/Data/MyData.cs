using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBindingDemo
{
  public class MyData
  {
    public MyData()
    {
      this.ColorName = "Red";
      this.Description = "Button background color";
      this.ForeColorName = "Blue";
    }

    public string ColorName { get; set; }
    public string Description { get; set; }
    public string ForeColorName { get; set; }
  }
}
