using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05.Node
{
	// Token: 0x0200564D RID: 22093
	[Token(Token = "0x200564D")]
	public class RL05DungeonNodeViewLogic : RoguelikeDungeonNodeDefaultLogic
	{
		// Token: 0x06020685 RID: 132741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020685")]
		[Address(RVA = "0x1A75420", Offset = "0x1A74020", VA = "0x181A75420", Slot = "4")]
		public override void RenderBossWidgets()
		{
		}

		// Token: 0x06020686 RID: 132742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020686")]
		[Address(RVA = "0x1A76F80", Offset = "0x1A75B80", VA = "0x181A76F80", Slot = "5")]
		public override void RenderNonBossWidigets()
		{
		}

		// Token: 0x06020687 RID: 132743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020687")]
		[Address(RVA = "0x1A77D40", Offset = "0x1A76940", VA = "0x181A77D40", Slot = "7")]
		public override void RenderOtherWidgets()
		{
		}

		// Token: 0x06020688 RID: 132744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020688")]
		[Address(RVA = "0x1A77EE0", Offset = "0x1A76AE0", VA = "0x181A77EE0")]
		private void _RenderOtherBaseWidgets()
		{
		}

		// Token: 0x06020689 RID: 132745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020689")]
		[Address(RVA = "0x1A758A0", Offset = "0x1A744A0", VA = "0x181A758A0", Slot = "6")]
		public override void RenderCurves()
		{
		}

		// Token: 0x0602068A RID: 132746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602068A")]
		[Address(RVA = "0x1A751E0", Offset = "0x1A73DE0", VA = "0x181A751E0")]
		public void EventOnShowStashedRecruitDialog()
		{
		}

		// Token: 0x0602068B RID: 132747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602068B")]
		[Address(RVA = "0x1A786A0", Offset = "0x1A772A0", VA = "0x181A786A0")]
		public RL05DungeonNodeViewLogic()
		{
		}

		// Token: 0x0602068C RID: 132748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602068C")]
		[Address(RVA = "0x1A77EA0", Offset = "0x1A76AA0", VA = "0x181A77EA0")]
		private void <>xLuaBaseProxy_RenderBossWidgets()
		{
		}

		// Token: 0x0602068D RID: 132749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602068D")]
		[Address(RVA = "0x1A77EC0", Offset = "0x1A76AC0", VA = "0x181A77EC0")]
		private void <>xLuaBaseProxy_RenderNonBossWidigets()
		{
		}

		// Token: 0x0602068E RID: 132750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602068E")]
		[Address(RVA = "0x1A77ED0", Offset = "0x1A76AD0", VA = "0x181A77ED0")]
		private void <>xLuaBaseProxy_RenderOtherWidgets()
		{
		}

		// Token: 0x0602068F RID: 132751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602068F")]
		[Address(RVA = "0x1A77EB0", Offset = "0x1A76AB0", VA = "0x181A77EB0")]
		private void <>xLuaBaseProxy_RenderCurves()
		{
		}

		// Token: 0x0402BE12 RID: 179730
		[Token(Token = "0x402BE12")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _unactiveImg;

		// Token: 0x0402BE13 RID: 179731
		[Token(Token = "0x402BE13")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _mask;

		// Token: 0x0402BE14 RID: 179732
		[Token(Token = "0x402BE14")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _bossEffect;

		// Token: 0x0402BE15 RID: 179733
		[Token(Token = "0x402BE15")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _finalBossEffect;

		// Token: 0x0402BE16 RID: 179734
		[Token(Token = "0x402BE16")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _normalGroupObj;

		// Token: 0x0402BE17 RID: 179735
		[Token(Token = "0x402BE17")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _verCountNum;

		// Token: 0x0402BE18 RID: 179736
		[Token(Token = "0x402BE18")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objVerCopperFreePart;

		// Token: 0x0402BE19 RID: 179737
		[Token(Token = "0x402BE19")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _objVerCostPart;

		// Token: 0x0402BE1A RID: 179738
		[Token(Token = "0x402BE1A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelStashedRecruit;

		// Token: 0x0402BE1B RID: 179739
		[Token(Token = "0x402BE1B")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402BE1C RID: 179740
		[Token(Token = "0x402BE1C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderBossWidgets;

		// Token: 0x0402BE1D RID: 179741
		[Token(Token = "0x402BE1D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderNonBossWidigets;

		// Token: 0x0402BE1E RID: 179742
		[Token(Token = "0x402BE1E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderOtherWidgets;

		// Token: 0x0402BE1F RID: 179743
		[Token(Token = "0x402BE1F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderOtherBaseWidgets;

		// Token: 0x0402BE20 RID: 179744
		[Token(Token = "0x402BE20")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderCurves;

		// Token: 0x0402BE21 RID: 179745
		[Token(Token = "0x402BE21")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnShowStashedRecruitDialog;

		// Token: 0x0402BE22 RID: 179746
		[Token(Token = "0x402BE22")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
