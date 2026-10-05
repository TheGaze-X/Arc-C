using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001A1 RID: 417
	[Token(Token = "0x20001A1")]
	public class HandledEventArgs : EventArgs
	{
		// Token: 0x06000ACD RID: 2765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x5146CD0", Offset = "0x51458D0", VA = "0x185146CD0")]
		public HandledEventArgs()
		{
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x5146C70", Offset = "0x5145870", VA = "0x185146C70")]
		public HandledEventArgs(bool defaultHandledValue)
		{
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x000062E8 File Offset: 0x000044E8
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000226")]
		public bool Handled
		{
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
