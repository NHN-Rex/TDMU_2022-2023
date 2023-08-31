using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI
{
    public class Excute
    {
        public static bool Write(List<Computer> dscpt, string path)
        {
            try
            {
                foreach (Computer cpt in dscpt)
                {
                    string s = cpt.hsx + '|' + cpt.dsp + '|' + cpt.tsp + '|' + cpt.thongso + '|' + cpt.gia;
                    if (File.Exists(path))//kiểm tra xem path được truyền vào có tồn tại hay không. Trả về True nếu có và ngược lại.
                    {
                            File.AppendAllText(path, s+"\n");//nếu file đã tồn tại thì chỉ cần thêm vào đoạn s.
                    }
                    else
                    {
                        //Nếu chưa tồn tại thì tạo một StreamWriter mới theo path được tryền vào.
                        StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                        sw.WriteLine(s);//ghi chuỗi s vào file.
                        sw.Close();//đóng streamwriter sau khi viết xong.
                    }
                }
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool Read(List<Computer> dscpt,string path)
        {
            try
            {
                //tạo một streamreader mới với đường dẫn được truyền vào.
                StreamReader sw = new StreamReader(path);
                string line = sw.ReadLine();//đọc dòng đầu tiên vào biến line có kiểu string.
                while(line != null)//vòng lặp này sẽ đọc hết các line trong file. Tới khi không đọc được nữa thì line được gán == null.
                {
                    string[] s = line.Split('|'); //split chuỗi line thành mảng s theo ký tự chia cắt là '|'.
                    Computer cpt = new Computer(); //tạo 1 biến computer mới để hứng giá trị tương ứng sau khi chia cắt line.
                    //gán lần lượt từng phần tử trong s tương ứng với từng biến trong computer.
                    cpt.hsx = s[0];
                    cpt.dsp = s[1];
                    cpt.tsp = s[2];
                    cpt.thongso = s[3];
                    cpt.gia = s[4];
                    dscpt.Add(cpt);//thêm computer vào listcomputer.
                    line = sw.ReadLine();// đọc dòng tiếp theo.
                }
                sw.Close();// đóng streamreader sau khi đọc xong.
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
