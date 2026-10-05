using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006298 RID: 25240
	[Token(Token = "0x2006298")]
	public class AutoChessBandChooseTopBarView : DataBinder<AutoChessBandChooseProperty>, IHotfixable
	{
		// Token: 0x0602464E RID: 149070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602464E")]
		[Address(RVA = "0x1F27610", Offset = "0x1F26210", VA = "0x181F27610", Slot = "7")]
		public override void OnValueChanged(AutoChessBandChooseProperty property)
		{
		}

		// Token: 0x0602464F RID: 149071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602464F")]
		[Address(RVA = "0x1F274F0", Offset = "0x1F260F0", VA = "0x181F274F0")]
		public void EventOnDetailBtnClicked()
		{
		}

		// Token: 0x06024650 RID: 149072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024650")]
		[Address(RVA = "0x1F27580", Offset = "0x1F26180", VA = "0x181F27580")]
		public void EventOnSkipBtnClicked()
		{
		}

		// Token: 0x06024651 RID: 149073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024651")]
		[Address(RVA = "0x1F27900", Offset = "0x1F26500", VA = "0x181F27900")]
		public AutoChessBandChooseTopBarView()
		{
		}

		// Token: 0x04032A13 RID: 207379
		[Token(Token = "0x4032A13")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessStageInfoView.DifficultyInfo[] _difficultyInfoList;

		// Token: 0x04032A14 RID: 207380
		[Token(Token = "0x4032A14")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textMode;

		// Token: 0x04032A15 RID: 207381
		[Token(Token = "0x4032A15")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelTurn;

		// Token: 0x04032A16 RID: 207382
		[Token(Token = "0x4032A16")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelOther;

		// Token: 0x04032A17 RID: 207383
		[Token(Token = "0x4032A17")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelConfirm;

		// Token: 0x04032A18 RID: 207384
		[Token(Token = "0x4032A18")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textOther;

		// Token: 0x04032A19 RID: 207385
		[Token(Token = "0x4032A19")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelSelf;

		// Token: 0x04032A1A RID: 207386
		[Token(Token = "0x4032A1A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelSkip;

		// Token: 0x04032A1B RID: 207387
		[Token(Token = "0x4032A1B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelSkipEnable;

		// Token: 0x04032A1C RID: 207388
		[Token(Token = "0x4032A1C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TwoStateFadeSwitcher _switcherSkip;

		// Token: 0x04032A1D RID: 207389
		[Token(Token = "0x4032A1D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelSkipBanned;

		// Token: 0x04032A1E RID: 207390
		[Token(Token = "0x4032A1E")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04032A1F RID: 207391
		[Token(Token = "0x4032A1F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04032A20 RID: 207392
		[Token(Token = "0x4032A20")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnDetailBtnClicked;

		// Token: 0x04032A21 RID: 207393
		[Token(Token = "0x4032A21")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnSkipBtnClicked;

		// Token: 0x04032A22 RID: 207394
		[Token(Token = "0x4032A22")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
