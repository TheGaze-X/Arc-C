using System;
using Il2CppDummyDll;

namespace Mono
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	internal struct RuntimeEventHandle
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		internal RuntimeEventHandle(System.IntPtr v)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x17000009")]
		public System.IntPtr Value
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x4AB0E20", Offset = "0x4AAFA20", VA = "0x184AB0E20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x0")]
		private System.IntPtr value;
	}
}
