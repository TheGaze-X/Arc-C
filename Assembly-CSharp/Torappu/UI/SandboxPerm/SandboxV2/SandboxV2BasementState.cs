using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004147 RID: 16711
	[Token(Token = "0x2004147")]
	public class SandboxV2BasementState : SandboxV2TransparentState, IValueMsgReceiver
	{
		// Token: 0x06019CED RID: 105709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CED")]
		[Address(RVA = "0x12A1BC0", Offset = "0x12A07C0", VA = "0x1812A1BC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019CEE RID: 105710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019CEE")]
		[Address(RVA = "0x12A10A0", Offset = "0x129FCA0", VA = "0x1812A10A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019CEF RID: 105711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CEF")]
		[Address(RVA = "0x12A11E0", Offset = "0x129FDE0", VA = "0x1812A11E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06019CF0 RID: 105712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CF0")]
		[Address(RVA = "0x12A1890", Offset = "0x12A0490", VA = "0x1812A1890", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06019CF1 RID: 105713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019CF1")]
		[Address(RVA = "0x12A1900", Offset = "0x12A0500", VA = "0x1812A1900", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06019CF2 RID: 105714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CF2")]
		[Address(RVA = "0x12A20A0", Offset = "0x12A0CA0", VA = "0x1812A20A0")]
		private void _OnJumpToDungeonState(IStateBean stateBean)
		{
		}

		// Token: 0x06019CF3 RID: 105715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CF3")]
		[Address(RVA = "0x12A24D0", Offset = "0x12A10D0", VA = "0x1812A24D0")]
		private void _OnJumpToNodeStagePreview(IStateBean stateBean)
		{
		}

		// Token: 0x06019CF4 RID: 105716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CF4")]
		[Address(RVA = "0x12A2200", Offset = "0x12A0E00", VA = "0x1812A2200")]
		private void _OnJumpToNodeDropDetail(IStateBean stateBean)
		{
		}

		// Token: 0x06019CF5 RID: 105717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CF5")]
		[Address(RVA = "0x12A1E40", Offset = "0x12A0A40", VA = "0x1812A1E40")]
		private void _OnJumpToDungeonSquad(IStateBean stateBean)
		{
		}

		// Token: 0x06019CF6 RID: 105718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CF6")]
		[Address(RVA = "0x12A1310", Offset = "0x129FF10", VA = "0x1812A1310", Slot = "33")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06019CF7 RID: 105719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CF7")]
		[Address(RVA = "0x12A1CB0", Offset = "0x12A08B0", VA = "0x1812A1CB0")]
		private void _OnBasementUpgradeBtnClicked()
		{
		}

		// Token: 0x06019CF8 RID: 105720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CF8")]
		[Address(RVA = "0x12A1100", Offset = "0x129FD00", VA = "0x1812A1100")]
		public void OnBtnBackClicked()
		{
		}

		// Token: 0x06019CF9 RID: 105721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CF9")]
		[Address(RVA = "0x12A1530", Offset = "0x12A0130", VA = "0x1812A1530")]
		public void OnMonthBtnClick()
		{
		}

		// Token: 0x06019CFA RID: 105722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CFA")]
		[Address(RVA = "0x12A2650", Offset = "0x12A1250", VA = "0x1812A2650")]
		private void _RaiseAVGSignal()
		{
		}

		// Token: 0x06019CFB RID: 105723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CFB")]
		[Address(RVA = "0x12A2810", Offset = "0x12A1410", VA = "0x1812A2810")]
		public SandboxV2BasementState()
		{
		}

		// Token: 0x06019CFC RID: 105724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CFC")]
		[Address(RVA = "0x12A1BB0", Offset = "0x12A07B0", VA = "0x1812A1BB0")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06019CFD RID: 105725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CFD")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06019CFE RID: 105726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019CFE")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402063C RID: 132668
		[Token(Token = "0x402063C")]
		[NonSerialized]
		public const int ON_BASEMENT_UPGRADE = 0;

		// Token: 0x0402063D RID: 132669
		[Token(Token = "0x402063D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2BasementView _basementView;

		// Token: 0x0402063E RID: 132670
		[Token(Token = "0x402063E")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x0402063F RID: 132671
		[Token(Token = "0x402063F")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2DungeonController m_dungeonController;

		// Token: 0x04020640 RID: 132672
		[Token(Token = "0x4020640")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020641 RID: 132673
		[Token(Token = "0x4020641")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020642 RID: 132674
		[Token(Token = "0x4020642")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020643 RID: 132675
		[Token(Token = "0x4020643")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020644 RID: 132676
		[Token(Token = "0x4020644")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04020645 RID: 132677
		[Token(Token = "0x4020645")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04020646 RID: 132678
		[Token(Token = "0x4020646")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnJumpToDungeonState;

		// Token: 0x04020647 RID: 132679
		[Token(Token = "0x4020647")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnJumpToNodeStagePreview;

		// Token: 0x04020648 RID: 132680
		[Token(Token = "0x4020648")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpToNodeDropDetail;

		// Token: 0x04020649 RID: 132681
		[Token(Token = "0x4020649")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnJumpToDungeonSquad;

		// Token: 0x0402064A RID: 132682
		[Token(Token = "0x402064A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402064B RID: 132683
		[Token(Token = "0x402064B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnBasementUpgradeBtnClicked;

		// Token: 0x0402064C RID: 132684
		[Token(Token = "0x402064C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBtnBackClicked;

		// Token: 0x0402064D RID: 132685
		[Token(Token = "0x402064D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnMonthBtnClick;

		// Token: 0x0402064E RID: 132686
		[Token(Token = "0x402064E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RaiseAVGSignal;

		// Token: 0x0402064F RID: 132687
		[Token(Token = "0x402064F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
