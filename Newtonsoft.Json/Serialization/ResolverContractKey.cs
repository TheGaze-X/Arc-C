using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000088 RID: 136
	[Token(Token = "0x2000088")]
	[Preserve]
	internal struct ResolverContractKey
	{
		// Token: 0x060004CF RID: 1231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xD6AD60", Offset = "0xD69960", VA = "0x180D6AD60")]
		public ResolverContractKey(Type resolverType, Type contractType)
		{
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x4D9AFD0", Offset = "0x4D99BD0", VA = "0x184D9AFD0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00003F90 File Offset: 0x00002190
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x4DB6B70", Offset = "0x4DB5770", VA = "0x184DB6B70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x4D9AFB0", Offset = "0x4D99BB0", VA = "0x184D9AFB0")]
		public bool Equals(ResolverContractKey other)
		{
			return default(bool);
		}

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x0")]
		private readonly Type _resolverType;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x8")]
		private readonly Type _contractType;
	}
}
