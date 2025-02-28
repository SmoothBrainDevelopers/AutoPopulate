﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AutoPopulate.Interfaces
{
    public interface IEntityValueProvider
    {
        public IEntityGenerationConfig Config { get; }
        public void RegisterAttributeHandler<T>(IAttributeHandler handler) where T : Attribute;
        public void RegisterTypeInterceptor(Type type, Func<object> valueProvider);
        public bool HasDefaultValue(Type type);
        public object GetDefaultValue(Type type, bool isIndex);
        public object CreateInstance(Type type);
        public object? HandleAttributes(PropertyInfo property, object instance);
        public object? HandleAttribute(Attribute property, object instance);
    }
}
