using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200020E RID: 526
	[Token(Token = "0x200020E")]
	public class ProgressChangedEventArgs : EventArgs
	{
		// Token: 0x06000DE5 RID: 3557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x515F8F0", Offset = "0x515E4F0", VA = "0x18515F8F0")]
		public ProgressChangedEventArgs(int progressPercentage, object userState)
		{
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00007620 File Offset: 0x00005820
		[Token(Token = "0x170002ED")]
		[SRDescription("Percentage progress made in operation.")]
		public int ProgressPercentage
		{
			[Token(Token = "0x6000DE6")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EE")]
		[SRDescription("User-supplied state to identify operation.")]
		public object UserState
		{
			[Token(Token = "0x6000DE7")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		[FieldOffset(Offset = "0x10")]
		private readonly int progressPercentage;

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0x18")]
		private readonly object userState;
	}
}
