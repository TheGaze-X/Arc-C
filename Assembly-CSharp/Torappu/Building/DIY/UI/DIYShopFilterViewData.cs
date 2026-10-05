using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001945 RID: 6469
	[Token(Token = "0x2001945")]
	public class DIYShopFilterViewData
	{
		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x0600A2AE RID: 41646 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A2AF RID: 41647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170012DE")]
		public DIYItemViewData itemViewData
		{
			[Token(Token = "0x600A2AE")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A2AF")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600A2B0 RID: 41648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2B0")]
		[Address(RVA = "0x31C1D80", Offset = "0x31C0980", VA = "0x1831C1D80")]
		public void Uninitialize()
		{
		}

		// Token: 0x0600A2B1 RID: 41649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2B1")]
		[Address(RVA = "0x31C1DC0", Offset = "0x31C09C0", VA = "0x1831C1DC0")]
		public DIYShopFilterViewData()
		{
		}

		// Token: 0x0400991D RID: 39197
		[Token(Token = "0x400991D")]
		[FieldOffset(Offset = "0x18")]
		public bool selected;

		// Token: 0x0400991E RID: 39198
		[Token(Token = "0x400991E")]
		[FieldOffset(Offset = "0x19")]
		public bool showDesc;

		// Token: 0x0400991F RID: 39199
		[Token(Token = "0x400991F")]
		[FieldOffset(Offset = "0x20")]
		public string description;
	}
}
