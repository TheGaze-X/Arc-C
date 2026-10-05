using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E6E RID: 24174
	[Token(Token = "0x2005E6E")]
	public class ItemRepoItemDetailState : PopupFloatState
	{
		// Token: 0x06023092 RID: 143506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023092")]
		[Address(RVA = "0x1D99C90", Offset = "0x1D98890", VA = "0x181D99C90", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023093 RID: 143507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023093")]
		[Address(RVA = "0x1D9A1B0", Offset = "0x1D98DB0", VA = "0x181D9A1B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023094 RID: 143508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023094")]
		[Address(RVA = "0x1D99CF0", Offset = "0x1D988F0", VA = "0x181D99CF0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023095 RID: 143509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023095")]
		[Address(RVA = "0x1D99EB0", Offset = "0x1D98AB0", VA = "0x181D99EB0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06023096 RID: 143510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023096")]
		[Address(RVA = "0x1D9A300", Offset = "0x1D98F00", VA = "0x181D9A300")]
		private void _UpdateItemDropInfo(UIItemViewModel itemModel, UIItemDescViewModel descModel)
		{
		}

		// Token: 0x06023097 RID: 143511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023097")]
		[Address(RVA = "0x1D99F40", Offset = "0x1D98B40", VA = "0x181D99F40")]
		public void Render(UIItemViewModel itemViewModel)
		{
		}

		// Token: 0x06023098 RID: 143512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023098")]
		[Address(RVA = "0x1D9A6C0", Offset = "0x1D992C0", VA = "0x181D9A6C0")]
		public ItemRepoItemDetailState()
		{
		}

		// Token: 0x06023099 RID: 143513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023099")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602309A RID: 143514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602309A")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040303F5 RID: 197621
		[Token(Token = "0x40303F5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected ItemRepoItemDetailStateBean _stateBean;

		// Token: 0x040303F6 RID: 197622
		[Token(Token = "0x40303F6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ItemRepoItemDetailLeftView _leftView;

		// Token: 0x040303F7 RID: 197623
		[Token(Token = "0x40303F7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ItemRepoItemDetailRightDescView _descView;

		// Token: 0x040303F8 RID: 197624
		[Token(Token = "0x40303F8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _dropInfoContainer;

		// Token: 0x040303F9 RID: 197625
		[Token(Token = "0x40303F9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ItemRepoItemDetailPackContentInfoPlugin _packContentInfoPlugin;

		// Token: 0x040303FA RID: 197626
		[Token(Token = "0x40303FA")]
		[FieldOffset(Offset = "0x98")]
		private bool m_dropInfoInitFlag;

		// Token: 0x040303FB RID: 197627
		[Token(Token = "0x40303FB")]
		[FieldOffset(Offset = "0xA0")]
		private ItemRepoDropInfoView m_dropItemInfo;

		// Token: 0x040303FC RID: 197628
		[Token(Token = "0x40303FC")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x040303FD RID: 197629
		[Token(Token = "0x40303FD")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040303FE RID: 197630
		[Token(Token = "0x40303FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040303FF RID: 197631
		[Token(Token = "0x40303FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030400 RID: 197632
		[Token(Token = "0x4030400")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04030401 RID: 197633
		[Token(Token = "0x4030401")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04030402 RID: 197634
		[Token(Token = "0x4030402")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateItemDropInfo;

		// Token: 0x04030403 RID: 197635
		[Token(Token = "0x4030403")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030404 RID: 197636
		[Token(Token = "0x4030404")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
