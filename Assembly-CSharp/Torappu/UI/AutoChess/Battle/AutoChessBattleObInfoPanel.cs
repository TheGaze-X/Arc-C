using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064E6 RID: 25830
	[Token(Token = "0x20064E6")]
	public class AutoChessBattleObInfoPanel : AutoChessBattleUIPanelBase
	{
		// Token: 0x060251C0 RID: 152000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251C0")]
		[Address(RVA = "0x200ED90", Offset = "0x200D990", VA = "0x18200ED90", Slot = "7")]
		public override void OnValueChanged(AutoChessBattleUIViewModelProperty property)
		{
		}

		// Token: 0x060251C1 RID: 152001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251C1")]
		[Address(RVA = "0x200F2A0", Offset = "0x200DEA0", VA = "0x18200F2A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060251C2 RID: 152002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251C2")]
		[Address(RVA = "0x200EC70", Offset = "0x200D870", VA = "0x18200EC70")]
		public void EventOnLeftArrowClick()
		{
		}

		// Token: 0x060251C3 RID: 152003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251C3")]
		[Address(RVA = "0x200ED00", Offset = "0x200D900", VA = "0x18200ED00")]
		public void EventOnRightArrowClick()
		{
		}

		// Token: 0x060251C4 RID: 152004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251C4")]
		[Address(RVA = "0x200F420", Offset = "0x200E020", VA = "0x18200F420")]
		public AutoChessBattleObInfoPanel()
		{
		}

		// Token: 0x04034027 RID: 213031
		[Token(Token = "0x4034027")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04034028 RID: 213032
		[Token(Token = "0x4034028")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x04034029 RID: 213033
		[Token(Token = "0x4034029")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textNickName;

		// Token: 0x0403402A RID: 213034
		[Token(Token = "0x403402A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textNickNumber;

		// Token: 0x0403402B RID: 213035
		[Token(Token = "0x403402B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _obOtherPartGO;

		// Token: 0x0403402C RID: 213036
		[Token(Token = "0x403402C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _obSelfPartGO;

		// Token: 0x0403402D RID: 213037
		[Token(Token = "0x403402D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _obEmptyPartGO;

		// Token: 0x0403402E RID: 213038
		[Token(Token = "0x403402E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _obOverviewPartGO;

		// Token: 0x0403402F RID: 213039
		[Token(Token = "0x403402F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _leftArrowGo;

		// Token: 0x04034030 RID: 213040
		[Token(Token = "0x4034030")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _rightArrowGo;

		// Token: 0x04034031 RID: 213041
		[Token(Token = "0x4034031")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _obPlayerQuitAlphaHandler;

		// Token: 0x04034032 RID: 213042
		[Token(Token = "0x4034032")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x04034033 RID: 213043
		[Token(Token = "0x4034033")]
		[FieldOffset(Offset = "0x80")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x04034034 RID: 213044
		[Token(Token = "0x4034034")]
		[FieldOffset(Offset = "0x88")]
		private FadeSwitchTween m_obPlayerQuitFadeTween;

		// Token: 0x04034035 RID: 213045
		[Token(Token = "0x4034035")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034036 RID: 213046
		[Token(Token = "0x4034036")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034037 RID: 213047
		[Token(Token = "0x4034037")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034038 RID: 213048
		[Token(Token = "0x4034038")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnLeftArrowClick;

		// Token: 0x04034039 RID: 213049
		[Token(Token = "0x4034039")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnRightArrowClick;

		// Token: 0x0403403A RID: 213050
		[Token(Token = "0x403403A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
