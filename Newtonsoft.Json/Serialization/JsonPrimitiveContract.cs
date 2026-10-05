using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	[Preserve]
	public class JsonPrimitiveContract : JsonContract
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00003F48 File Offset: 0x00002148
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000CB")]
		internal PrimitiveTypeCode TypeCode
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x4D67380", Offset = "0x4D65F80", VA = "0x184D67380")]
			[CompilerGenerated]
			get
			{
				return PrimitiveTypeCode.Empty;
			}
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x4D67390", Offset = "0x4D65F90", VA = "0x184D67390")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x4DA8CF0", Offset = "0x4DA78F0", VA = "0x184DA8CF0")]
		public JsonPrimitiveContract(Type underlyingType)
		{
		}

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, ReadType> ReadTypeMap;
	}
}
