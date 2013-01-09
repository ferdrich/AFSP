using System.Collections.Generic;
using System.Net;

namespace AFSP.Communication
{
    /**
     * Speichert alle Zuordnungen zwischen IP und Pseudonym
     * Annahme: IP ist eindeutig
     */

    internal class Identifier
    {
        private readonly List<KeyValuePair<IPAddress, string>> _idList;


        //Assertion: pseudonym passende länge
        private Identifier()
        {
            _idList = new List<KeyValuePair<IPAddress, string>>();
        }

        public void AddId(IPAddress ip, string pseudonym)
        {
            //TODO: Duplicate Handling
            _idList.Add(new KeyValuePair<IPAddress, string>(ip, pseudonym));
        }

        public string GetPseudonymByIp(IPAddress ip)
        {
            foreach (var pair in _idList)
            {
                if (pair.Key.Equals(ip))
                {
                    return pair.Value;
                }
            }
            //TODO: Error-Handling
            return "";
        }

        public IPAddress GetIpByPseudonym(string pseudonym)
        {
            foreach (var pair in _idList)
            {
                if (pair.Value.Equals(pseudonym))
                {
                    return pair.Key;
                }
            }
            //TODO: Error-Handling
            return null;
        }
    }
}