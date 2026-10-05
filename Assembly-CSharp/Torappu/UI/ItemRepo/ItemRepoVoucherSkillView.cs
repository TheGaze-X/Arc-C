using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EBA RID: 24250
	[Token(Token = "0x2005EBA")]
	public class ItemRepoVoucherSkillView : DataBinder<ItemRepoVoucherSkillViewProperty>
	{
		// Token: 0x060231D6 RID: 143830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231D6")]
		[Address(RVA = "0x1DB8680", Offset = "0x1DB7280", VA = "0x181DB8680", Slot = "7")]
		public override void OnValueChanged(ItemRepoVoucherSkillViewProperty property)
		{
		}

		// Token: 0x060231D7 RID: 143831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231D7")]
		[Address(RVA = "0x1DB8600", Offset = "0x1DB7200", VA = "0x181DB8600")]
		public void OnChooseSkillClick(int selectedIdx)
		{
		}

		// Token: 0x060231D8 RID: 143832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231D8")]
		[Address(RVA = "0x1DB8590", Offset = "0x1DB7190", VA = "0x181DB8590")]
		public void OnBackOrCancelClick()
		{
		}

		// Token: 0x060231D9 RID: 143833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231D9")]
		[Address(RVA = "0x1DB8740", Offset = "0x1DB7340", VA = "0x181DB8740")]
		private void _RenderSelectPart(SkillGroupViewModel skillGroup, ILoadAsset assetLoader)
		{
		}

		// Token: 0x060231DA RID: 143834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231DA")]
		[Address(RVA = "0x1DB8990", Offset = "0x1DB7590", VA = "0x181DB8990")]
		public ItemRepoVoucherSkillView()
		{
		}

		// Token: 0x0403068D RID: 198285
		[Token(Token = "0x403068D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ItemRepoVoucherSkillSingleView[] _skillViews;

		// Token: 0x0403068E RID: 198286
		[Token(Token = "0x403068E")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<int> onChooseSkill;

		// Token: 0x0403068F RID: 198287
		[Token(Token = "0x403068F")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action onBackOrCancel;

		// Token: 0x04030690 RID: 198288
		[Token(Token = "0x4030690")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04030691 RID: 198289
		[Token(Token = "0x4030691")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030692 RID: 198290
		[Token(Token = "0x4030692")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnChooseSkillClick;

		// Token: 0x04030693 RID: 198291
		[Token(Token = "0x4030693")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBackOrCancelClick;

		// Token: 0x04030694 RID: 198292
		[Token(Token = "0x4030694")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderSelectPart;

		// Token: 0x04030695 RID: 198293
		[Token(Token = "0x4030695")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
