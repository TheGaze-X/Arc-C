using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x0200020F RID: 527
	[Token(Token = "0x200020F")]
	public class Lock
	{
		// Token: 0x06001226 RID: 4646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001226")]
		[Address(RVA = "0x4D55540", Offset = "0x4D54140", VA = "0x184D55540")]
		public void Acquire()
		{
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001227")]
		[Address(RVA = "0x4D55550", Offset = "0x4D54150", VA = "0x184D55550")]
		public void Release()
		{
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001228")]
		[Address(RVA = "0x4D55560", Offset = "0x4D54160", VA = "0x184D55560")]
		public Lock()
		{
		}

		// Token: 0x04000A48 RID: 2632
		[Token(Token = "0x4000A48")]
		[FieldOffset(Offset = "0x10")]
		private object _lock;
	}
}
