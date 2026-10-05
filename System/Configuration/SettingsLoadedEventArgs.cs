using System;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x0200041A RID: 1050
	[Token(Token = "0x200041A")]
	public class SettingsLoadedEventArgs : EventArgs
	{
		// Token: 0x06001C26 RID: 7206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C26")]
		[Address(RVA = "0x50BF2A0", Offset = "0x50BDEA0", VA = "0x1850BF2A0")]
		public SettingsLoadedEventArgs(SettingsProvider provider)
		{
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000679")]
		public SettingsProvider Provider
		{
			[Token(Token = "0x6001C27")]
			[Address(RVA = "0x50BF2D0", Offset = "0x50BDED0", VA = "0x1850BF2D0")]
			get
			{
				return null;
			}
		}
	}
}
