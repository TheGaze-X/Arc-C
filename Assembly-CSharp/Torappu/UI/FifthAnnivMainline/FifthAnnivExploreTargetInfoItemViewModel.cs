using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F28 RID: 20264
	[Token(Token = "0x2004F28")]
	public class FifthAnnivExploreTargetInfoItemViewModel
	{
		// Token: 0x170046C7 RID: 18119
		// (get) Token: 0x0601E309 RID: 123657 RVA: 0x000ADC40 File Offset: 0x000ABE40
		[Token(Token = "0x170046C7")]
		public bool completeTarget
		{
			[Token(Token = "0x601E309")]
			[Address(RVA = "0x17F2CA0", Offset = "0x17F18A0", VA = "0x1817F2CA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601E30A RID: 123658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E30A")]
		[Address(RVA = "0x17F26B0", Offset = "0x17F12B0", VA = "0x1817F26B0")]
		public void LoadData(FifthAnnivExploreTargetData targetData)
		{
		}

		// Token: 0x0601E30B RID: 123659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E30B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FifthAnnivExploreTargetInfoItemViewModel()
		{
		}

		// Token: 0x0402836D RID: 164717
		[Token(Token = "0x402836D")]
		[FieldOffset(Offset = "0x10")]
		public bool hasRequireEvent;

		// Token: 0x0402836E RID: 164718
		[Token(Token = "0x402836E")]
		[FieldOffset(Offset = "0x11")]
		public bool completeRequireEvent;

		// Token: 0x0402836F RID: 164719
		[Token(Token = "0x402836F")]
		[FieldOffset(Offset = "0x12")]
		public bool completeTargetValue;

		// Token: 0x04028370 RID: 164720
		[Token(Token = "0x4028370")]
		[FieldOffset(Offset = "0x18")]
		public string targetName;

		// Token: 0x04028371 RID: 164721
		[Token(Token = "0x4028371")]
		[FieldOffset(Offset = "0x20")]
		public string descForRequireEvent;

		// Token: 0x04028372 RID: 164722
		[Token(Token = "0x4028372")]
		[FieldOffset(Offset = "0x28")]
		public List<string> valueOrders;

		// Token: 0x04028373 RID: 164723
		[Token(Token = "0x4028373")]
		[FieldOffset(Offset = "0x30")]
		public ListDict<string, KeyValuePair<bool, int>> exploreValueInfos;
	}
}
