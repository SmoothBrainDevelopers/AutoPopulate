﻿using FakeTests.Helpers;

namespace FakeTests.Classes
{
    public class ListNullables : ITestableObject
    {
        public List<bool?>? _bool { get; set; }
        public List<int?>? _int { get; set; }
        public List<uint?>? _uint { get; set; }
        public List<char?>? _char { get; set; }
        public List<double?>? _double { get; set; }
        public List<decimal?>? _decimal { get; set; }
        public List<float?>? _float { get; set; }
        public List<byte?>? _byte { get; set; }
        public List<short?>? _short { get; set; }
        public List<long?>? _long { get; set; }
        public List<ulong?>? _ulong { get; set; }
        public List<string?>? _string { get; set; }
        public List<ListPrimitives>? _listPrimitives { get; set; }
        public List<List<int?>>? _listlistint { get; set; }

        public bool ItemsSuccessfullyPopulated(int? depth = 1)
        {
            if (!_bool?.ValidNullablePrimitiveList() ?? false) return false;
            if (!_int?.ValidNullablePrimitiveList() ?? false) return false;
            if (!_ulong?.ValidNullablePrimitiveList() ?? false) return false;
            if (!_char?.ValidNullablePrimitiveList() ?? false) return false;
            if (!_double?.ValidNullablePrimitiveList() ?? false) return false;
            if (!_decimal?.ValidNullablePrimitiveList() ?? false) return false;
            if (!_float?.ValidNullablePrimitiveList() ?? false) return false;
            if (!_byte?.ValidNullablePrimitiveList() ?? false) return false;
            if (!_short?.ValidNullablePrimitiveList() ?? false) return false;
            if (!_long?.ValidNullablePrimitiveList() ?? false) return false;
            if (!_ulong?.ValidNullablePrimitiveList() ?? false) return false;
            if (!_string?.ValidList() ?? false) return false;
            if(!_listPrimitives?.ValidList() ?? false) return false;
            if(!_listlistint?.Where(x => x.ValidNullablePrimitiveList()).Any() ?? false) return false;
            return true;
        }
    }
}
