using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200329B RID: 12955
	[Token(Token = "0x200329B")]
	public class HalfIdleUIBattleFailedPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06014921 RID: 84257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014921")]
		[Address(RVA = "0xCCF1A0", Offset = "0xCCDDA0", VA = "0x180CCF1A0", Slot = "4")]
		public virtual void OnPanelClick()
		{
		}

		// Token: 0x06014922 RID: 84258 RVA: 0x00087780 File Offset: 0x00085980
		[Token(Token = "0x6014922")]
		[Address(RVA = "0xCCEC60", Offset = "0xCCD860", VA = "0x180CCEC60")]
		public bool BattleFailedPanelHide()
		{
			return default(bool);
		}

		// Token: 0x06014923 RID: 84259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014923")]
		[Address(RVA = "0xCCED60", Offset = "0xCCD960", VA = "0x180CCED60")]
		public RectTransform BattleFailedPanelInit()
		{
			return null;
		}

		// Token: 0x06014924 RID: 84260 RVA: 0x00087798 File Offset: 0x00085998
		[Token(Token = "0x6014924")]
		[Address(RVA = "0xCCEEF0", Offset = "0xCCDAF0", VA = "0x180CCEEF0")]
		public bool BattleFailedPanelShow(string actId)
		{
			return default(bool);
		}

		// Token: 0x06014925 RID: 84261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014925")]
		[Address(RVA = "0xCCF370", Offset = "0xCCDF70", VA = "0x180CCF370")]
		public HalfIdleUIBattleFailedPanel()
		{
		}

		// Token: 0x0401856E RID: 99694
		[Token(Token = "0x401856E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Text> _hintTexts;

		// Token: 0x0401856F RID: 99695
		[Token(Token = "0x401856F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fadeinDuration;

		// Token: 0x04018570 RID: 99696
		[Token(Token = "0x4018570")]
		[FieldOffset(Offset = "0x28")]
		private readonly string HINT_PREFIX;

		// Token: 0x04018571 RID: 99697
		[Token(Token = "0x4018571")]
		[FieldOffset(Offset = "0x30")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x04018572 RID: 99698
		[Token(Token = "0x4018572")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPanelClick;

		// Token: 0x04018573 RID: 99699
		[Token(Token = "0x4018573")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BattleFailedPanelHide;

		// Token: 0x04018574 RID: 99700
		[Token(Token = "0x4018574")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BattleFailedPanelInit;

		// Token: 0x04018575 RID: 99701
		[Token(Token = "0x4018575")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BattleFailedPanelShow;

		// Token: 0x04018576 RID: 99702
		[Token(Token = "0x4018576")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
