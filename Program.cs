//In the name of Allah


string pwd = Directory.GetCurrentDirectory();
var dir = Directory.CreateDirectory(pwd + "/demo");
var demo = dir.FullName + "/demo.txt";
StreamWriter? file = !File.Exists(demo)? File.CreateText(dir.FullName + "/demo.txt"):null;
if(file != null ){
    file.WriteLine("In the name of Allah");
}//if
