using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace TrelloDesktop.Library
{
    public class TrelloManager
    {
        private static volatile TrelloManager _instance;
        private static readonly object SyncRoot = new object();
        private TrelloUserData _trelloUserData;

        private TrelloManager()
        {
        }

        public static TrelloManager Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (SyncRoot)
                {
                    if (_instance == null)
                        _instance = new TrelloManager();
                }

                return _instance;
            }
        }

        public List<string> GetAllBoards()
        {
            return GetUserData().IdBoards.ToList();
        }

        public string FormatUrl(string url)
        {
            return string.Format(CultureInfo.InvariantCulture, url,
                "428c8b5253c738979224f25fefc743104a1821bc54fbb09c27d4a87b025d9f7f");
        }

        public TrelloUserData GetUserData()
        {
            if (_trelloUserData != null) return _trelloUserData;
            using (WebClient wc = new WebClient())
            {
                string json =
                    wc.DownloadString(FormatUrl(
                        "https://api.trello.com/1/members/me/?key=8171b4a95a9615a64ad5fa779539f015&token={0}"));
                _trelloUserData = JsonConvert.DeserializeObject<TrelloUserData>(json);
            }

            return _trelloUserData;
        }
    }
}