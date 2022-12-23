using QuestionsAPI.Models;

namespace QuestionsAPI.Services
{
    public class QuestionsRepository
    {
        public List<Questions> GetAllQuestions()
        {
            return new List<Questions>
            {
                new Questions(1, "Siapa yang bertanggung jawab atas app ini?", "Giga, Difta, dan Daffa. Semuanya mahasiswa TIF angkatan 2021.", "Anonymous"),
                new Questions(2, "Kenapa aplikasi ini dibuat?", "Untuk projet akhir PBO oleh Pak Nasikun", "Anonymous"),
                new Questions(3, "Menggunakan apa aplikasi ini dibuat?", "C#, Windows Form", "Anonymous"),
                new Questions(4, "Bagaimana cara menggunakan app ini?", "Buat akun pada tab account, lalu pesan di tab Rooms.", "Anonymous"),
                new Questions(5, "Apakah aplikasi ini bisa digunakan di handphone?", "Untuk saat ini, belum.", "Anonymous"),
                new Questions(6, "Jika sudah memesan, apakah perlu konfirmasi lagi?", "Tidak perlu. Namun jika ada masalah bisa mengontak Front Office.", "Anonymous")
            };
        }

        public Questions GetQuestionsByID(int id)
        {
            Questions returnQuest = new Questions();

            List<Questions> question = new List<Questions>
            {
                new Questions(1, "Siapa yang bertanggung jawab atas app ini?", "Giga, Difta, dan Daffa. Semuanya mahasiswa TIF angkatan 2021.", "Anonymous"),
                new Questions(2, "Kenapa aplikasi ini dibuat?", "Untuk projet akhir PBO oleh Pak Nasikun", "Anonymous"),
                new Questions(3, "Menggunakan apa aplikasi ini dibuat?", "C#, Windows Form", "Anonymous"),
                new Questions(4, "Bagaimana cara menggunakan app ini?", "Buat akun pada tab account, lalu pesan di tab Rooms.", "Anonymous"),
                new Questions(5, "Apakah aplikasi ini bisa digunakan di handphone?", "Untuk saat ini, belum.", "Anonymous"),
                new Questions(6, "Jika sudah memesan, apakah perlu konfirmasi lagi?", "Tidak perlu. Namun jika ada masalah bisa mengontak Front Office.", "Anonymous")
            };

            foreach(Questions qst in question)
            {
                if(qst.id == id)
                {
                    returnQuest = qst;
                }
            }
            return returnQuest;
        }

        public int EditQuesionsByID(int id, Questions question)
        {
            Questions returnQuest = new Questions();

            List<Questions> qst = new List<Questions>
            {
                new Questions(1, "Siapa yang bertanggung jawab atas app ini?", "Giga, Difta, dan Daffa. Semuanya mahasiswa TIF angkatan 2021.", "Anonymous"),
                new Questions(2, "Kenapa aplikasi ini dibuat?", "Untuk projet akhir PBO oleh Pak Nasikun", "Anonymous"),
                new Questions(3, "Menggunakan apa aplikasi ini dibuat?", "C#, Windows Form", "Anonymous"),
                new Questions(4, "Bagaimana cara menggunakan app ini?", "Buat akun pada tab account, lalu pesan di tab Rooms.", "Anonymous"),
                new Questions(5, "Apakah aplikasi ini bisa digunakan di handphone?", "Untuk saat ini, belum.", "Anonymous"),
                new Questions(6, "Jika sudah memesan, apakah perlu konfirmasi lagi?", "Tidak perlu. Namun jika ada masalah bisa mengontak Front Office.", "Anonymous")
            };

            foreach(Questions quest in qst)
            {
                if(quest.id == id)
                {
                    qst[qst.IndexOf(quest)] = question;
                    return 1;
                }
            }
            return 0;
        }

        public List<Questions> DeleteQuestion(int id)
        {
            List<Questions> qst = new List<Questions>
            {
                new Questions(1, "Siapa yang bertanggung jawab atas app ini?", "Giga, Difta, dan Daffa. Semuanya mahasiswa TIF angkatan 2021.", "Anonymous"),
                new Questions(2, "Kenapa aplikasi ini dibuat?", "Untuk projet akhir PBO oleh Pak Nasikun", "Anonymous"),
                new Questions(3, "Menggunakan apa aplikasi ini dibuat?", "C#, Windows Form", "Anonymous"),
                new Questions(4, "Bagaimana cara menggunakan app ini?", "Buat akun pada tab account, lalu pesan di tab Rooms.", "Anonymous"),
                new Questions(5, "Apakah aplikasi ini bisa digunakan di handphone?", "Untuk saat ini, belum.", "Anonymous"),
                new Questions(6, "Jika sudah memesan, apakah perlu konfirmasi lagi?", "Tidak perlu. Namun jika ada masalah bisa mengontak Front Office.", "Anonymous")
            };

            qst.Remove(qst.Find(match: x => x.id == id));
            return qst;
        }
    }
}
