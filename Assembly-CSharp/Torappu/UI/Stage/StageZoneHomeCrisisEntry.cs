using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067A1 RID: 26529
	[Token(Token = "0x20067A1")]
	public class StageZoneHomeCrisisEntry : StageZoneHomeEntryItemPlugin
	{
		// Token: 0x060260C3 RID: 155843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60260C3")]
		[Address(RVA = "0x211EE70", Offset = "0x211DA70", VA = "0x18211EE70", Slot = "7")]
		protected override Sprite GetFuncIcon()
		{
			return null;
		}

		// Token: 0x060260C4 RID: 155844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260C4")]
		[Address(RVA = "0x211EED0", Offset = "0x211DAD0", VA = "0x18211EED0", Slot = "5")]
		protected override void OnDataUpdated()
		{
		}

		// Token: 0x060260C5 RID: 155845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60260C5")]
		[Address(RVA = "0x211F0C0", Offset = "0x211DCC0", VA = "0x18211F0C0")]
		private Sprite _LoadRankIcon(CrisisV2AppraiseType rankType)
		{
			return null;
		}

		// Token: 0x060260C6 RID: 155846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260C6")]
		[Address(RVA = "0x211F1B0", Offset = "0x211DDB0", VA = "0x18211F1B0")]
		public StageZoneHomeCrisisEntry()
		{
		}

		// Token: 0x040358B9 RID: 219321
		[Token(Token = "0x40358B9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _funcSprite;

		// Token: 0x040358BA RID: 219322
		[Token(Token = "0x40358BA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textPoint;

		// Token: 0x040358BB RID: 219323
		[Token(Token = "0x40358BB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelNoRank;

		// Token: 0x040358BC RID: 219324
		[Token(Token = "0x40358BC")]
		[FieldOffset(Offset = "0x48")]
		private ZoneHomeEntryCrisisV2Model m_viewModel;

		// Token: 0x040358BD RID: 219325
		[Token(Token = "0x40358BD")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040358BE RID: 219326
		[Token(Token = "0x40358BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncIcon;

		// Token: 0x040358BF RID: 219327
		[Token(Token = "0x40358BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x040358C0 RID: 219328
		[Token(Token = "0x40358C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadRankIcon;

		// Token: 0x040358C1 RID: 219329
		[Token(Token = "0x40358C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
