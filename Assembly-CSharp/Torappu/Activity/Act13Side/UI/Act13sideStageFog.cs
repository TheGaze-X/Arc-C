using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side.UI
{
	// Token: 0x02007A48 RID: 31304
	[Token(Token = "0x2007A48")]
	public class Act13sideStageFog : StageFogOnMapBase
	{
		// Token: 0x0602BDB4 RID: 179636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDB4")]
		[Address(RVA = "0x27D0920", Offset = "0x27CF520", VA = "0x1827D0920", Slot = "4")]
		public override void RenderView(StageFogOnMapBase.Param renderParam)
		{
		}

		// Token: 0x0602BDB5 RID: 179637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDB5")]
		[Address(RVA = "0x27D0800", Offset = "0x27CF400", VA = "0x1827D0800", Slot = "5")]
		protected override void OnFogDismiss()
		{
		}

		// Token: 0x0602BDB6 RID: 179638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDB6")]
		[Address(RVA = "0x27D0B80", Offset = "0x27CF780", VA = "0x1827D0B80")]
		private void _RenderViewImpl(StageFogOnMapBase.Param renderParam)
		{
		}

		// Token: 0x0602BDB7 RID: 179639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDB7")]
		[Address(RVA = "0x27D05A0", Offset = "0x27CF1A0", VA = "0x1827D05A0")]
		public void EventOnFogClicked()
		{
		}

		// Token: 0x0602BDB8 RID: 179640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDB8")]
		[Address(RVA = "0x27D0AD0", Offset = "0x27CF6D0", VA = "0x1827D0AD0")]
		private void _OnUnlockableFogClicked(StageFogOnMapBase.Param param)
		{
		}

		// Token: 0x0602BDB9 RID: 179641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDB9")]
		[Address(RVA = "0x27D09B0", Offset = "0x27CF5B0", VA = "0x1827D09B0")]
		private void _OnFogUnlockItemNotEnough(StageFogOnMapBase.Param param)
		{
		}

		// Token: 0x0602BDBA RID: 179642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDBA")]
		[Address(RVA = "0x27D0EA0", Offset = "0x27CFAA0", VA = "0x1827D0EA0")]
		public Act13sideStageFog()
		{
		}

		// Token: 0x0602BDBC RID: 179644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDBC")]
		[Address(RVA = "0x25CEC90", Offset = "0x25CD890", VA = "0x1825CEC90")]
		private void <>xLuaBaseProxy_OnFogDismiss()
		{
		}

		// Token: 0x0403F821 RID: 260129
		[Token(Token = "0x403F821")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _lockedObjs;

		// Token: 0x0403F822 RID: 260130
		[Token(Token = "0x403F822")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] _unlockObjs;

		// Token: 0x0403F823 RID: 260131
		[Token(Token = "0x403F823")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textUnlockCount;

		// Token: 0x0403F824 RID: 260132
		[Token(Token = "0x403F824")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textUnlockDesc;

		// Token: 0x0403F825 RID: 260133
		[Token(Token = "0x403F825")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _iconUnlockItem;

		// Token: 0x0403F826 RID: 260134
		[Token(Token = "0x403F826")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _fogCanvasGroup;

		// Token: 0x0403F827 RID: 260135
		[Token(Token = "0x403F827")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedStageId;

		// Token: 0x0403F828 RID: 260136
		[Token(Token = "0x403F828")]
		[FieldOffset(Offset = "0x60")]
		private StageFogOnMapBase.Param m_cachedParam;

		// Token: 0x0403F829 RID: 260137
		[Token(Token = "0x403F829")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403F82A RID: 260138
		[Token(Token = "0x403F82A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFogDismiss;

		// Token: 0x0403F82B RID: 260139
		[Token(Token = "0x403F82B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderViewImpl;

		// Token: 0x0403F82C RID: 260140
		[Token(Token = "0x403F82C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnFogClicked;

		// Token: 0x0403F82D RID: 260141
		[Token(Token = "0x403F82D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnUnlockableFogClicked;

		// Token: 0x0403F82E RID: 260142
		[Token(Token = "0x403F82E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnFogUnlockItemNotEnough;

		// Token: 0x0403F82F RID: 260143
		[Token(Token = "0x403F82F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
