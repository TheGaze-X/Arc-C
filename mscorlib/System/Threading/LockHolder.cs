using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x0200020E RID: 526
	[Token(Token = "0x200020E")]
	[ReflectionBlocked]
	public struct LockHolder : System.IDisposable
	{
		// Token: 0x06001224 RID: 4644 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		[Token(Token = "0x6001224")]
		[Address(RVA = "0x4D553D0", Offset = "0x4D53FD0", VA = "0x184D553D0")]
		[MethodImpl(256)]
		public static LockHolder Hold(Lock l)
		{
			return default(LockHolder);
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001225")]
		[Address(RVA = "0x4D553B0", Offset = "0x4D53FB0", VA = "0x184D553B0", Slot = "4")]
		[MethodImpl(256)]
		public void Dispose()
		{
		}

		// Token: 0x04000A47 RID: 2631
		[Token(Token = "0x4000A47")]
		[FieldOffset(Offset = "0x0")]
		private Lock _lock;
	}
}
