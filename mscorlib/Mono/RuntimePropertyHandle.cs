using System;
using Il2CppDummyDll;

namespace Mono
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	internal struct RuntimePropertyHandle
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		internal RuntimePropertyHandle(System.IntPtr v)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x1700000A")]
		public System.IntPtr Value
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x4AB1520", Offset = "0x4AB0120", VA = "0x184AB1520", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x4AB0F20", Offset = "0x4AAFB20", VA = "0x184AB0F20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x0")]
		private System.IntPtr value;
	}
}
