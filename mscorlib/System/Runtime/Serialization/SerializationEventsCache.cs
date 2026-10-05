using System;
using System.Collections.Concurrent;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003F9 RID: 1017
	[Token(Token = "0x20003F9")]
	internal static class SerializationEventsCache
	{
		// Token: 0x06001FA3 RID: 8099 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0x4BAA7E0", Offset = "0x4BA93E0", VA = "0x184BAA7E0")]
		internal static SerializationEvents GetSerializationEventsForType(System.Type t)
		{
			return null;
		}

		// Token: 0x040010AC RID: 4268
		[Token(Token = "0x40010AC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type, SerializationEvents> s_cache;
	}
}
