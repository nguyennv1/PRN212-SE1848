﻿using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
String ho = "Nguyễn";
String tenlot = "Thị";
String ten = "Tủn";
String full_name = ho +" "+ tenlot +" " +ten;
Console.WriteLine(full_name);

StringBuilder sb = new StringBuilder();
sb.Append(ho);
sb.Append(" ");
sb.Append(tenlot);
sb.Append(" ");
sb.Append(ten);
Console.WriteLine(sb.ToString());
