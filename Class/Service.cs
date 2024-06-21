using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hobook_Software.Class
{
    public class Service
    {
        private String db_name;
        private String name;
        private int Soluong;
        private int Add = 0;
        private decimal gia = 0;
        private String Category;
        private Image img;
        public String MaDV;

        public string Db_name { get => db_name; set => db_name = value; }
        public string Name { get => name; set => name = value; }
        public int Soluong1 { get => Soluong; set => Soluong = value; }
        public int Add1 { get => Add; set => Add = value; }
        public decimal Gia { get => gia; set => gia = value; }
        public Image Img { get => img; set => img = value; }
        public string Category1 { get => Category; set => Category = value; }

        public Service(String db_name, int Soluong,decimal gia)
        {
            this.Db_name = db_name;
            this.Soluong1 = Soluong;
            this.Gia = gia;
            String path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName;
            string filePath = Path.Combine(path, "img/service/" + this.Db_name + ".png");
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // Tạo đối tượng Image từ luồng
                    this.img = Image.FromStream(fs);
                }
            }
            else
            {
                this.Img = Hobook_Software.Properties.Resources.Artboard4;
            }

            filePath = Path.Combine(path, "img/service/Service.txt");
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    String line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        String[] name = line.Split('-');
                        if (this.Db_name == name[0].Trim())
                        {
                            this.Name = name[1].Trim();
                            this.Category = name[2].Trim();
                            break;
                        }
                    }
                    reader.Close();
                }
            }
            else
            {
                this.Name = this.Db_name;
            }
        }

        
        public static int Add_to_Filetxt_Service(String name_service,String categoryy,String path_image)
        {
            String path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName;
            string filePath = Path.Combine(path, "img/service/Service.txt");
            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        String nameDB = ChuyenChuoi(name_service);
                        String Line = nameDB + " - " + name_service + " - " + categoryy;
                        writer.WriteLine(Line);
                        writer.Close();
                    }

                    if (File.Exists(path_image)) 
                    {
                        File.Copy(path_image, Path.Combine(path,"img/service/" + ChuyenChuoi(name_service)+".png"), true);
                    }
                    return 1;
                } catch (Exception e)
                {
                    MessageBox.Show("Có lỗi xảy ra khi truy cập file\n" + e.Message, "Lỗi");
                    return 0;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng liên hệ kỹ thuật viên để sửa chữa lỗi thiếu file Service này!", "Lỗi!!!");
                return 0;
            }
        }

        public static int Delete_to_Filetxt_Service(String old_nameDB)
        {
            String path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName;
            string filePath = Path.Combine(path, "img/service/Service.txt");
            if (File.Exists(filePath))
            {
                try
                {
                    List<String> lstr = new List<String>();
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        String line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            String[] name = line.Split('-');
                            if (name.Length > 0)
                            {
                                if (name[0].Trim() != old_nameDB)
                                {
                                    lstr.Add(line);
                                }
                            }
                        }
                    }

                    using (StreamWriter writer = new StreamWriter(filePath, false))
                    {
                        foreach (String s in lstr)
                        {
                            writer.WriteLine(s);
                        }
                    }

                    string filePath2 = Path.Combine(path, "img/service/" + old_nameDB + ".png");
                    File.Delete(filePath2);
                    return 1;

                } catch (Exception e)
                {
                    MessageBox.Show("Có lỗi xảy ra khi truy cập file\n" + e.Message, "Lỗi");
                    return 0;
                }
            } else
            {
                MessageBox.Show("Vui lòng liên hệ kỹ thuật viên để sửa chữa lỗi thiếu file Service này!", "Lỗi!!!");
                return 0;
            }
        }


        public static int Fix_to_Filetxt_Service(String old_nameDB,String name_service, String categoryy)
        {
            String path = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName;
            string filePath = Path.Combine(path, "img/service/Service.txt");
            if (File.Exists(filePath))
            {
                try
                {
                    List<String> lstr = new List<String>();
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        String line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            String[] name = line.Split('-');
                            if (name.Length > 0)
                            {
                                if (name[0].Trim() == old_nameDB)
                                {
                                    String nameDB = ChuyenChuoi(name_service);
                                    String line2 = nameDB + " - " + name_service + " - " + categoryy;
                                    lstr.Add(line2);
                                }
                                else
                                {
                                    lstr.Add(line);
                                }
                            }
                        }
                    }
                    using (StreamWriter writer = new StreamWriter(filePath, false))
                    {
                        foreach (String s in lstr)
                        {
                            writer.WriteLine(s);
                        }
                    }

                    string filePath2 = Path.Combine(path, "img/service/" + old_nameDB + ".png");
                    string newname = ChuyenChuoi(name_service) + ".png";
                    string newFilePath = Path.Combine(Path.GetDirectoryName(filePath2), newname);
                    File.Move(filePath2, newFilePath);


                    return 1;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Có lỗi xảy ra khi truy cập file\n" + e.Message, "Lỗi");
                    return 0;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng liên hệ kỹ thuật viên để sửa chữa lỗi thiếu file Service này!", "Lỗi!!!");
                return 0;
            }
        }

        public static string ChuyenChuoi(string input)
        {
            // Chuyển đổi thành chữ thường và loại bỏ dấu
            input = BoDau(input.ToLower());

            // Loại bỏ khoảng trắng và chuyển đổi thành chuỗi camel case
            string[] words = input.Split(' ');
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                result.Append(char.ToUpper(word[0])).Append(word.Substring(1));
            }

            return result.ToString();
        }

        static string BoDau(string input)
        {
            // Chuyển đổi chuỗi có dấu thành chuỗi không dấu
            string normalizedString = input.Normalize(NormalizationForm.FormKD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString();
        }


    }
}
