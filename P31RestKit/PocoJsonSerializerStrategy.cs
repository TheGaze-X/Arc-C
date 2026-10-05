using System;
using Il2CppDummyDll;
using Prime31.Reflection;

namespace Prime31
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public class PocoJsonSerializerStrategy : IJsonSerializerStrategy
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x4E0F960", Offset = "0x4E0E560", VA = "0x184E0F960")]
		public PocoJsonSerializerStrategy()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x4E0FB80", Offset = "0x4E0E780", VA = "0x184E0FB80", Slot = "6")]
		protected virtual void buildMap(Type type, SafeDictionary<string, CacheResolver.MemberMap> memberMaps)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x4E113C0", Offset = "0x4E0FFC0", VA = "0x184E113C0", Slot = "7")]
		public virtual bool serializeNonPrimitiveObject(object input, out object output)
		{
			return default(bool);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x4E0FDD0", Offset = "0x4E0E9D0", VA = "0x184E0FDD0", Slot = "8")]
		public virtual object deserializeObject(object value, Type type)
		{
			return null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x4E11310", Offset = "0x4E0FF10", VA = "0x184E11310", Slot = "9")]
		protected virtual object serializeEnum(Enum p)
		{
			return null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x4E11460", Offset = "0x4E10060", VA = "0x184E11460", Slot = "10")]
		protected virtual bool trySerializeKnownTypes(object input, out object output)
		{
			return default(bool);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x4E11720", Offset = "0x4E10320", VA = "0x184E11720", Slot = "11")]
		protected virtual bool trySerializeUnknownTypes(object input, out object output)
		{
			return default(bool);
		}

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x10")]
		internal CacheResolver cacheResolver;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] Iso8601Format;
	}
}
