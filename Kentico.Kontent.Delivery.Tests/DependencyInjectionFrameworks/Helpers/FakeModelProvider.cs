﻿using System;
using System.Collections;
using System.Threading.Tasks;
using Kentico.Kontent.Delivery.Abstractions;

namespace Kentico.Kontent.Delivery.Tests.DependencyInjectionFrameworks.Helpers
{
    internal class FakeModelProvider : IModelProvider
    {
        public Task<T> GetContentItemModelAsync<T>(object item, IEnumerable modularContent, ITypeProvider typeProvider)
            => throw new NotImplementedException();
    }
}
