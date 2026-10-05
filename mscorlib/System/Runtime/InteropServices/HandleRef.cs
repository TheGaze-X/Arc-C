using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000455 RID: 1109
	[Token(Token = "0x2000455")]
	public readonly struct HandleRef
	{
		// Token: 0x060021FB RID: 8699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FB")]
		[Address(RVA = "0x4006960", Offset = "0x4005560", VA = "0x184006960")]
		public HandleRef(object wrapper, System.IntPtr handle)
		{
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x00013A58 File Offset: 0x00011C58
		[Token(Token = "0x17000467")]
		public System.IntPtr Handle
		{
			[Token(Token = "0x60021FC")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04001317 RID: 4887
		[Token(Token = "0x4001317")]
		[FieldOffset(Offset = "0x0")]
		private readonly object _wrapper;

		// Token: 0x04001318 RID: 4888
		[Token(Token = "0x4001318")]
		[FieldOffset(Offset = "0x8")]
		private readonly System.IntPtr _handle;
	}
}
