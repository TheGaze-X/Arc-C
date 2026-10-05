using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000215 RID: 533
	[Token(Token = "0x2000215")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class EventWaitHandle : WaitHandle
	{
		// Token: 0x0600124C RID: 4684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124C")]
		[Address(RVA = "0x4D531B0", Offset = "0x4D51DB0", VA = "0x184D531B0")]
		public EventWaitHandle(bool initialState, EventResetMode mode)
		{
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124D")]
		[Address(RVA = "0x4D531D0", Offset = "0x4D51DD0", VA = "0x184D531D0")]
		public EventWaitHandle(bool initialState, EventResetMode mode, string name)
		{
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x0000E898 File Offset: 0x0000CA98
		[Token(Token = "0x600124E")]
		[Address(RVA = "0x4D530D0", Offset = "0x4D51CD0", VA = "0x184D530D0")]
		public bool Reset()
		{
			return default(bool);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		[Token(Token = "0x600124F")]
		[Address(RVA = "0x4D53140", Offset = "0x4D51D40", VA = "0x184D53140")]
		public bool Set()
		{
			return default(bool);
		}
	}
}
