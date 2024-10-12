using System.Text;
using System.Security.Cryptography;

namespace fileor
{


    public class Hashing
    {
        private static readonly string key = "0X3F3F3F3F3F3F3F";

        private static string Encrypt(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[16]; // Use IV for added security, initialized to zeros here for simplicity

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                byte[] encryptedBytes = encryptor.TransformFinalBlock(Encoding.UTF8.GetBytes(plainText), 0, plainText.Length);

                return Convert.ToBase64String(encryptedBytes);
            }
        }

        private static string Decrypt(string cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[16]; // Use IV for added security, initialized to zeros here for simplicity

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                byte[] encryptedBytes = Convert.FromBase64String(cipherText);

                string decryptedText = Encoding.UTF8.GetString(decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length));

                return decryptedText;
            }
        }

        public static employee EncryptEmp(employee emp)
        {
            emp.id = Encrypt(emp.id);
            emp.fname = Encrypt(emp.fname);
            emp.lname = Encrypt(emp.lname);
            emp.gender = Encrypt(emp.gender);
            emp.address = Encrypt(emp.address);
            emp.tel = Encrypt(emp.tel);
            emp.position = Encrypt(emp.position);
            emp.department = Encrypt(emp.department);
            emp.manager = Encrypt(emp.manager);
            emp.salary = Encrypt(emp.salary);
            return emp;
        }

        public static employee DecryptEmp(employee emp)
        {
            emp.id = Decrypt(emp.id);
            emp.fname = Decrypt(emp.fname);
            emp.lname = Decrypt(emp.lname);
            emp.gender = Decrypt(emp.gender);
            emp.address = Decrypt(emp.address);
            emp.tel = Decrypt(emp.tel);
            emp.position = Decrypt(emp.position);
            emp.department = Decrypt(emp.department);
            emp.manager = Decrypt(emp.manager);
            emp.salary = Decrypt(emp.salary);
            return emp; 
        }

        /*
         public static void Main()
         {
             // Example usage
             int id = 123;
             int salary = 50000;
             string fname = "Mahmoud";
             string lname = "Mahmoud";
             string gender = "Male";
             string address = "123 Main St";
             string tel = "555-1234";
             string position = "Developer";
             string department = "IT";
             string manager = "Jane Smith";

             // Encrypt
             string encryptedId = Encrypt(id.ToString());
             string encryptedSalary = Encrypt(salary.ToString());
             string encryptedFname = Encrypt(fname);
             string encryptedLname = Encrypt(lname);
             string encryptedGender = Encrypt(gender);
             string encryptedAddress = Encrypt(address);
             string encryptedTel = Encrypt(tel);
             string encryptedPosition = Encrypt(position);
             string encryptedDepartment = Encrypt(department);
             string encryptedManager = Encrypt(manager);

             Console.WriteLine($"Encrypted ID: {encryptedId}");
             Console.WriteLine($"ID {encryptedId.Length}");
             Console.WriteLine($"Encrypted Salary: {encryptedSalary}");
             Console.WriteLine($"Salary {encryptedSalary.Length}");
             Console.WriteLine($"Encrypted First Name: {encryptedFname}");
             Console.WriteLine($"Encrypted Last Name: {encryptedLname}");
             Console.WriteLine($"Encrypted Gender: {encryptedGender}");
             Console.WriteLine($"Encrypted Address: {encryptedAddress}");
             Console.WriteLine($"Encrypted Telephone: {encryptedTel}");
             Console.WriteLine($"Encrypted Position: {encryptedPosition}");
             Console.WriteLine($"Encrypted Department: {encryptedDepartment}");
             Console.WriteLine($"Encrypted Manager: {encryptedManager}");

             // Decrypt
             string decryptedId = Decrypt(encryptedId);
             string decryptedSalary = Decrypt(encryptedSalary);
             string decryptedFname = Decrypt(encryptedFname);
             string decryptedLname = Decrypt(encryptedLname);
             string decryptedGender = Decrypt(encryptedGender);
             string decryptedAddress = Decrypt(encryptedAddress);
             string decryptedTel = Decrypt(encryptedTel);
             string decryptedPosition = Decrypt(encryptedPosition);
             string decryptedDepartment = Decrypt(encryptedDepartment);
             string decryptedManager = Decrypt(encryptedManager);

             Console.WriteLine($"Decrypted ID: {decryptedId}");
             Console.WriteLine($"Decrypted Salary: {decryptedSalary}");
             Console.WriteLine($"Decrypted First Name: {decryptedFname}");
             Console.WriteLine($"Decrypted Last Name: {decryptedLname}");
             Console.WriteLine($"Decrypted Gender: {decryptedGender}");
             Console.WriteLine($"Decrypted Address: {decryptedAddress}");
             Console.WriteLine($"Decrypted Telephone: {decryptedTel}");
             Console.WriteLine($"Decrypted Position: {decryptedPosition}");
             Console.WriteLine($"Decrypted Department: {decryptedDepartment}");
             Console.WriteLine($"Decrypted Manager: {decryptedManager}");
         }
        */
    }

}
