using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class InfoDTO
    {
        [JsonProperty("userId")]
        private int userId;

        [JsonProperty("id")]
        private int id;

        [JsonProperty("title")]
        private string title;

        [JsonProperty("body")]
        private string body;

        public int GetUserId()
        {
            return userId;
        }
        public int SetUserId(int userId)
        {
            return this.userId = userId;
        }

        public int GetId()
        {
            return id;
        }
        public int SetId(int id)
        {
            return this.id = id;
        }

        public string GetTitle()
        {
            return title;
        }
        public string SetTitle(string title)
        {
            return this.title = title;
        }
        public string GetBody()
        {
            return body;
        }
        public string SetBody(string body)
        {
            return this.body = body;
        }


        public InfoDTO(int userId, int id, string title, string body)
        {
            this.userId = userId;
            this.id = id;
            this.title = title;
            this.body = body;
        }

        public override bool Equals(object obj)
        {
            InfoDTO compared = obj as InfoDTO;
            if (compared == null)
            {
                return false;
            }
            return userId == compared.userId && id == compared.id && title == compared.title && body == compared.body;
        }
    }
}
