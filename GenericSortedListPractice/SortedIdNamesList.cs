using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GenericSortedListPractice
{
    internal class SortedIdNamesList<IdParam, NameParam>
    {
        public delegate void AccountOperation();
        private SortedList<IdParam, NameParam> _sortedList = new SortedList<IdParam, NameParam>();
        public int Count { get { return _sortedList.Count; } }
        public void GetList()
        {
            foreach (var kvp in _sortedList)
                Console.WriteLine("ID: {0}, Student Name: {1}", kvp.Key, kvp.Value);
        }
        //
        public void Add(IdParam id, NameParam name)
        {
            _sortedList.Add(id, name);
        }
        //
        public void Remove(IdParam number)
        {
            _sortedList.Remove(number);
        }
        //
        public bool Contains(NameParam name)
        {
            return _sortedList.ContainsValue(name);
        }
        public void Clear()
        {
            _sortedList.Clear();
        }
    }
}
