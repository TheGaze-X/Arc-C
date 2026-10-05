using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001DB RID: 475
	[Token(Token = "0x20001DB")]
	public class RefreshEventArgs : EventArgs
	{
		// Token: 0x06000CC0 RID: 3264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x51737F0", Offset = "0x51723F0", VA = "0x1851737F0")]
		public RefreshEventArgs(object componentChanged)
		{
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x5173780", Offset = "0x5172380", VA = "0x185173780")]
		public RefreshEventArgs(Type typeChanged)
		{
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A3")]
		public object ComponentChanged
		{
			[Token(Token = "0x6000CC2")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A4")]
		public Type TypeChanged
		{
			[Token(Token = "0x6000CC3")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
