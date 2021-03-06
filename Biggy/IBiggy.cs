﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Biggy
{
    public interface IBiggy<T> : IEnumerable<T>
    {
        void Clear();
        int Count();
        T Update(T item);
        T Remove(T item);
        List<T> Remove(List<T> items);
        T Add(T item);
        List<T> Add(List<T> items);
        IQueryable<T> AsQueryable();
        bool InMemory { get; set; }

        event EventHandler<BiggyEventArgs<T>> ItemRemoved;
        event EventHandler<BiggyEventArgs<T>> ItemAdded;
        event EventHandler<BiggyEventArgs<T>> ItemsAdded;

        event EventHandler<BiggyEventArgs<T>> Changed;
        event EventHandler<BiggyEventArgs<T>> Loaded;
        event EventHandler<BiggyEventArgs<T>> Saved;
    }
}