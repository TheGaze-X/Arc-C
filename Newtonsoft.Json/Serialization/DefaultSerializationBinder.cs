using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	[Preserve]
	public class DefaultSerializationBinder : SerializationBinder
	{
		// Token: 0x06000524 RID: 1316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x4DA3730", Offset = "0x4DA2330", VA = "0x184DA3730")]
		private static Type GetTypeFromTypeNameKey(DefaultSerializationBinder.TypeNameKey typeNameKey)
		{
			return null;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x4DA3690", Offset = "0x4DA2290", VA = "0x184DA3690", Slot = "5")]
		public override Type BindToType(string assemblyName, string typeName)
		{
			return null;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x4DA3B30", Offset = "0x4DA2730", VA = "0x184DA3B30")]
		public DefaultSerializationBinder()
		{
		}

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly DefaultSerializationBinder Instance;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x10")]
		private readonly ThreadSafeStore<DefaultSerializationBinder.TypeNameKey, Type> _typeCache;

		// Token: 0x02000094 RID: 148
		[Token(Token = "0x2000094")]
		internal struct TypeNameKey
		{
			// Token: 0x06000528 RID: 1320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000528")]
			[Address(RVA = "0xD6AD60", Offset = "0xD69960", VA = "0x180D6AD60")]
			public TypeNameKey(string assemblyName, string typeName)
			{
			}

			// Token: 0x06000529 RID: 1321 RVA: 0x000041B8 File Offset: 0x000023B8
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x4DB6FA0", Offset = "0x4DB5BA0", VA = "0x184DB6FA0", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x0600052A RID: 1322 RVA: 0x000041D0 File Offset: 0x000023D0
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x4DB6EA0", Offset = "0x4DB5AA0", VA = "0x184DB6EA0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x0600052B RID: 1323 RVA: 0x000041E8 File Offset: 0x000023E8
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x4DB6F50", Offset = "0x4DB5B50", VA = "0x184DB6F50")]
			public bool Equals(DefaultSerializationBinder.TypeNameKey other)
			{
				return default(bool);
			}

			// Token: 0x04000249 RID: 585
			[Token(Token = "0x4000249")]
			[FieldOffset(Offset = "0x0")]
			internal readonly string AssemblyName;

			// Token: 0x0400024A RID: 586
			[Token(Token = "0x400024A")]
			[FieldOffset(Offset = "0x8")]
			internal readonly string TypeName;
		}
	}
}
