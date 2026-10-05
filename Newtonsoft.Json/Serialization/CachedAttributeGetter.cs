using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	[Preserve]
	internal static class CachedAttributeGetter<T> where T : Attribute
	{
		// Token: 0x060006BA RID: 1722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BA")]
		public static T GetAttribute(object type)
		{
			return null;
		}

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<object, T> TypeAttributeCache;
	}
}
