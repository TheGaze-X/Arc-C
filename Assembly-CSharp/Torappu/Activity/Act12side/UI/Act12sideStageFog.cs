using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A92 RID: 31378
	[Token(Token = "0x2007A92")]
	public class Act12sideStageFog : StageFogOnMapBase
	{
		// Token: 0x0602BF44 RID: 180036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF44")]
		[Address(RVA = "0x27E2330", Offset = "0x27E0F30", VA = "0x1827E2330", Slot = "4")]
		public override void RenderView(StageFogOnMapBase.Param renderParam)
		{
		}

		// Token: 0x0602BF45 RID: 180037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF45")]
		[Address(RVA = "0x27E2170", Offset = "0x27E0D70", VA = "0x1827E2170", Slot = "5")]
		protected override void OnFogDismiss()
		{
		}

		// Token: 0x0602BF46 RID: 180038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF46")]
		[Address(RVA = "0x27E2210", Offset = "0x27E0E10", VA = "0x1827E2210", Slot = "6")]
		protected override void OnStageNotOpen(StageFogInfo fogInfo)
		{
		}

		// Token: 0x0602BF47 RID: 180039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF47")]
		[Address(RVA = "0x27E23D0", Offset = "0x27E0FD0", VA = "0x1827E23D0")]
		private void _FakeRenderViewOnStageNotOpen(StageFogInfo fogInfo)
		{
		}

		// Token: 0x0602BF48 RID: 180040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF48")]
		[Address(RVA = "0x27E2750", Offset = "0x27E1350", VA = "0x1827E2750")]
		private void _RenderViewImpl(StageFogOnMapBase.Param renderParam)
		{
		}

		// Token: 0x0602BF49 RID: 180041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF49")]
		[Address(RVA = "0x27E2C30", Offset = "0x27E1830", VA = "0x1827E2C30")]
		private void _ResetAnimState()
		{
		}

		// Token: 0x0602BF4A RID: 180042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF4A")]
		[Address(RVA = "0x27E1FA0", Offset = "0x27E0BA0", VA = "0x1827E1FA0")]
		public void EventOnFogClicked()
		{
		}

		// Token: 0x0602BF4B RID: 180043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF4B")]
		[Address(RVA = "0x27E26A0", Offset = "0x27E12A0", VA = "0x1827E26A0")]
		private void _OnUnlockableFogClicked(StageFogOnMapBase.Param param)
		{
		}

		// Token: 0x0602BF4C RID: 180044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF4C")]
		[Address(RVA = "0x27E24A0", Offset = "0x27E10A0", VA = "0x1827E24A0")]
		private void _OnFogUnlockItemNotEnough(StageFogOnMapBase.Param param)
		{
		}

		// Token: 0x0602BF4D RID: 180045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF4D")]
		[Address(RVA = "0x27E25C0", Offset = "0x27E11C0", VA = "0x1827E25C0")]
		private void _OnFogUnlockStageNotPass(StageFogOnMapBase.Param param, StageData prevStage)
		{
		}

		// Token: 0x0602BF4E RID: 180046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF4E")]
		[Address(RVA = "0x27E2CA0", Offset = "0x27E18A0", VA = "0x1827E2CA0")]
		public Act12sideStageFog()
		{
		}

		// Token: 0x0602BF4F RID: 180047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF4F")]
		[Address(RVA = "0x25CEC90", Offset = "0x25CD890", VA = "0x1825CEC90")]
		private void <>xLuaBaseProxy_OnFogDismiss()
		{
		}

		// Token: 0x0602BF50 RID: 180048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF50")]
		[Address(RVA = "0x27E23C0", Offset = "0x27E0FC0", VA = "0x1827E23C0")]
		private void <>xLuaBaseProxy_OnStageNotOpen(StageFogInfo P0)
		{
		}

		// Token: 0x0403FAB7 RID: 260791
		[Token(Token = "0x403FAB7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Act12sideStageFog.UnlockableItem> _unlockableItems;

		// Token: 0x0403FAB8 RID: 260792
		[Token(Token = "0x403FAB8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textUnlockCount;

		// Token: 0x0403FAB9 RID: 260793
		[Token(Token = "0x403FAB9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textUnlockDesc;

		// Token: 0x0403FABA RID: 260794
		[Token(Token = "0x403FABA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _iconUnlockItem;

		// Token: 0x0403FABB RID: 260795
		[Token(Token = "0x403FABB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _btnUnlock;

		// Token: 0x0403FABC RID: 260796
		[Token(Token = "0x403FABC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject[] _lockedObjs;

		// Token: 0x0403FABD RID: 260797
		[Token(Token = "0x403FABD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject[] _unlockObjs;

		// Token: 0x0403FABE RID: 260798
		[Token(Token = "0x403FABE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _dismissAnim;

		// Token: 0x0403FABF RID: 260799
		[Token(Token = "0x403FABF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelInfo;

		// Token: 0x0403FAC0 RID: 260800
		[Token(Token = "0x403FAC0")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedStageId;

		// Token: 0x0403FAC1 RID: 260801
		[Token(Token = "0x403FAC1")]
		[FieldOffset(Offset = "0x80")]
		private StageFogOnMapBase.Param m_cachedParam;

		// Token: 0x0403FAC2 RID: 260802
		[Token(Token = "0x403FAC2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403FAC3 RID: 260803
		[Token(Token = "0x403FAC3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFogDismiss;

		// Token: 0x0403FAC4 RID: 260804
		[Token(Token = "0x403FAC4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStageNotOpen;

		// Token: 0x0403FAC5 RID: 260805
		[Token(Token = "0x403FAC5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FakeRenderViewOnStageNotOpen;

		// Token: 0x0403FAC6 RID: 260806
		[Token(Token = "0x403FAC6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderViewImpl;

		// Token: 0x0403FAC7 RID: 260807
		[Token(Token = "0x403FAC7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetAnimState;

		// Token: 0x0403FAC8 RID: 260808
		[Token(Token = "0x403FAC8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnFogClicked;

		// Token: 0x0403FAC9 RID: 260809
		[Token(Token = "0x403FAC9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnUnlockableFogClicked;

		// Token: 0x0403FACA RID: 260810
		[Token(Token = "0x403FACA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnFogUnlockItemNotEnough;

		// Token: 0x0403FACB RID: 260811
		[Token(Token = "0x403FACB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnFogUnlockStageNotPass;

		// Token: 0x0403FACC RID: 260812
		[Token(Token = "0x403FACC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A93 RID: 31379
		[Token(Token = "0x2007A93")]
		[Serializable]
		private struct UnlockableItem
		{
			// Token: 0x0403FACD RID: 260813
			[Token(Token = "0x403FACD")]
			[FieldOffset(Offset = "0x0")]
			public Image image;

			// Token: 0x0403FACE RID: 260814
			[Token(Token = "0x403FACE")]
			[FieldOffset(Offset = "0x8")]
			public Sprite unlockable;

			// Token: 0x0403FACF RID: 260815
			[Token(Token = "0x403FACF")]
			[FieldOffset(Offset = "0x10")]
			public Sprite locked;
		}
	}
}
