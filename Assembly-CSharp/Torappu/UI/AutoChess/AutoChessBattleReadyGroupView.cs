using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062A1 RID: 25249
	[Token(Token = "0x20062A1")]
	public class AutoChessBattleReadyGroupView : DataBinder<AutoChessBattleReadyProperty>, IHotfixable
	{
		// Token: 0x0602466C RID: 149100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602466C")]
		[Address(RVA = "0x1F29310", Offset = "0x1F27F10", VA = "0x181F29310", Slot = "7")]
		public override void OnValueChanged(AutoChessBattleReadyProperty property)
		{
		}

		// Token: 0x0602466D RID: 149101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602466D")]
		[Address(RVA = "0x1F294E0", Offset = "0x1F280E0", VA = "0x181F294E0")]
		private void _InitIfNot(AutoChessBattleReadyViewModel model)
		{
		}

		// Token: 0x0602466E RID: 149102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602466E")]
		[Address(RVA = "0x1F29750", Offset = "0x1F28350", VA = "0x181F29750")]
		public AutoChessBattleReadyGroupView()
		{
		}

		// Token: 0x04032A69 RID: 207465
		[Token(Token = "0x4032A69")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessBattleReadyGroupView.AnimPanelStruct[] _panelAnimList;

		// Token: 0x04032A6A RID: 207466
		[Token(Token = "0x4032A6A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSingle;

		// Token: 0x04032A6B RID: 207467
		[Token(Token = "0x4032A6B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelMulti;

		// Token: 0x04032A6C RID: 207468
		[Token(Token = "0x4032A6C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AutoChessBattleReadyPlayerCardView _playerCardPrefab;

		// Token: 0x04032A6D RID: 207469
		[Token(Token = "0x4032A6D")]
		[FieldOffset(Offset = "0x40")]
		private GameObject m_usedPanelAnim;

		// Token: 0x04032A6E RID: 207470
		[Token(Token = "0x4032A6E")]
		[FieldOffset(Offset = "0x48")]
		private RectTransform[] m_playerCardContainer;

		// Token: 0x04032A6F RID: 207471
		[Token(Token = "0x4032A6F")]
		[FieldOffset(Offset = "0x50")]
		private List<AutoChessBattleReadyPlayerCardView> m_playerCardList;

		// Token: 0x04032A70 RID: 207472
		[Token(Token = "0x4032A70")]
		[FieldOffset(Offset = "0x58")]
		private AutoChessBattleReadyPlayerCardView m_singlePlayerCard;

		// Token: 0x04032A71 RID: 207473
		[Token(Token = "0x4032A71")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04032A72 RID: 207474
		[Token(Token = "0x4032A72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04032A73 RID: 207475
		[Token(Token = "0x4032A73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032A74 RID: 207476
		[Token(Token = "0x4032A74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020062A2 RID: 25250
		[Token(Token = "0x20062A2")]
		[Serializable]
		public struct AnimPanelStruct
		{
			// Token: 0x04032A75 RID: 207477
			[Token(Token = "0x4032A75")]
			[FieldOffset(Offset = "0x0")]
			public int playerCount;

			// Token: 0x04032A76 RID: 207478
			[Token(Token = "0x4032A76")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panelAnim;
		}
	}
}
