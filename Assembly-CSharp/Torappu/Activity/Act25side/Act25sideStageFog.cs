using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074DE RID: 29918
	[Token(Token = "0x20074DE")]
	public class Act25sideStageFog : StageFogOnMapBase
	{
		// Token: 0x0602A2D0 RID: 172752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2D0")]
		[Address(RVA = "0x25CE770", Offset = "0x25CD370", VA = "0x1825CE770", Slot = "5")]
		protected override void OnFogDismiss()
		{
		}

		// Token: 0x0602A2D1 RID: 172753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2D1")]
		[Address(RVA = "0x25CE820", Offset = "0x25CD420", VA = "0x1825CE820", Slot = "4")]
		public override void RenderView(StageFogOnMapBase.Param renderParam)
		{
		}

		// Token: 0x0602A2D2 RID: 172754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2D2")]
		[Address(RVA = "0x25CE5A0", Offset = "0x25CD1A0", VA = "0x1825CE5A0")]
		public void EventOnFogClicked()
		{
		}

		// Token: 0x0602A2D3 RID: 172755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2D3")]
		[Address(RVA = "0x25CEE40", Offset = "0x25CDA40", VA = "0x1825CEE40")]
		private void _OnUnlockableFogClicked(StageFogOnMapBase.Param param)
		{
		}

		// Token: 0x0602A2D4 RID: 172756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2D4")]
		[Address(RVA = "0x25CECA0", Offset = "0x25CD8A0", VA = "0x1825CECA0")]
		private void _OnFogUnlockItemNotEnough(StageFogOnMapBase.Param param)
		{
		}

		// Token: 0x0602A2D5 RID: 172757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2D5")]
		[Address(RVA = "0x25CED60", Offset = "0x25CD960", VA = "0x1825CED60")]
		private void _OnFogUnlockStageNotPass(StageFogOnMapBase.Param param, StageData prevStage)
		{
		}

		// Token: 0x0602A2D6 RID: 172758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2D6")]
		[Address(RVA = "0x25CEF00", Offset = "0x25CDB00", VA = "0x1825CEF00")]
		public Act25sideStageFog()
		{
		}

		// Token: 0x0602A2D7 RID: 172759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2D7")]
		[Address(RVA = "0x25CEC90", Offset = "0x25CD890", VA = "0x1825CEC90")]
		private void <>xLuaBaseProxy_OnFogDismiss()
		{
		}

		// Token: 0x0403C976 RID: 248182
		[Token(Token = "0x403C976")]
		private const string PROGRESS_FORMAT = "/{0}";

		// Token: 0x0403C977 RID: 248183
		[Token(Token = "0x403C977")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTotalCount;

		// Token: 0x0403C978 RID: 248184
		[Token(Token = "0x403C978")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCurrCount;

		// Token: 0x0403C979 RID: 248185
		[Token(Token = "0x403C979")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _unlockableColor;

		// Token: 0x0403C97A RID: 248186
		[Token(Token = "0x403C97A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _lockedColor;

		// Token: 0x0403C97B RID: 248187
		[Token(Token = "0x403C97B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pnlLocked;

		// Token: 0x0403C97C RID: 248188
		[Token(Token = "0x403C97C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _pnlUnlockable;

		// Token: 0x0403C97D RID: 248189
		[Token(Token = "0x403C97D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _btnUnlock;

		// Token: 0x0403C97E RID: 248190
		[Token(Token = "0x403C97E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _pnlContent;

		// Token: 0x0403C97F RID: 248191
		[Token(Token = "0x403C97F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _pnlNormal;

		// Token: 0x0403C980 RID: 248192
		[Token(Token = "0x403C980")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _pnlStageLocked;

		// Token: 0x0403C981 RID: 248193
		[Token(Token = "0x403C981")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0403C982 RID: 248194
		[Token(Token = "0x403C982")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _dismissAnim;

		// Token: 0x0403C983 RID: 248195
		[Token(Token = "0x403C983")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cachedStageId;

		// Token: 0x0403C984 RID: 248196
		[Token(Token = "0x403C984")]
		[FieldOffset(Offset = "0xA8")]
		private StageFogOnMapBase.Param m_cachedParam;

		// Token: 0x0403C985 RID: 248197
		[Token(Token = "0x403C985")]
		[FieldOffset(Offset = "0xC0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403C986 RID: 248198
		[Token(Token = "0x403C986")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnFogDismiss;

		// Token: 0x0403C987 RID: 248199
		[Token(Token = "0x403C987")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403C988 RID: 248200
		[Token(Token = "0x403C988")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnFogClicked;

		// Token: 0x0403C989 RID: 248201
		[Token(Token = "0x403C989")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnUnlockableFogClicked;

		// Token: 0x0403C98A RID: 248202
		[Token(Token = "0x403C98A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnFogUnlockItemNotEnough;

		// Token: 0x0403C98B RID: 248203
		[Token(Token = "0x403C98B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnFogUnlockStageNotPass;

		// Token: 0x0403C98C RID: 248204
		[Token(Token = "0x403C98C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
