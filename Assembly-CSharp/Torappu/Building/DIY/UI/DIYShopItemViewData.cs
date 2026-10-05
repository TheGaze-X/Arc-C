using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200194C RID: 6476
	[Token(Token = "0x200194C")]
	public class DIYShopItemViewData
	{
		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x0600A2CE RID: 41678 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A2CF RID: 41679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170012E2")]
		public DIYItemViewData itemViewData
		{
			[Token(Token = "0x600A2CE")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A2CF")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x0600A2D0 RID: 41680 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A2D1 RID: 41681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170012E3")]
		public IDIYShopItem shopItem
		{
			[Token(Token = "0x600A2D0")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A2D1")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600A2D2 RID: 41682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2D2")]
		[Address(RVA = "0x31C1D80", Offset = "0x31C0980", VA = "0x1831C1D80")]
		public void Uninitialize()
		{
		}

		// Token: 0x0600A2D3 RID: 41683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2D3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DIYShopItemViewData()
		{
		}

		// Token: 0x04009945 RID: 39237
		[Token(Token = "0x4009945")]
		[FieldOffset(Offset = "0x20")]
		public int count;

		// Token: 0x04009946 RID: 39238
		[Token(Token = "0x4009946")]
		[FieldOffset(Offset = "0x24")]
		public int comfort;
	}
}
