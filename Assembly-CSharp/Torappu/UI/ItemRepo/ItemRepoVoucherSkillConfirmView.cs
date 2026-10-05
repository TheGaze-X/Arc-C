using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EB8 RID: 24248
	[Token(Token = "0x2005EB8")]
	public class ItemRepoVoucherSkillConfirmView : DataBinder<ItemRepoVoucherSkillViewProperty>
	{
		// Token: 0x060231CC RID: 143820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231CC")]
		[Address(RVA = "0x1DB7970", Offset = "0x1DB6570", VA = "0x181DB7970", Slot = "7")]
		public override void OnValueChanged(ItemRepoVoucherSkillViewProperty property)
		{
		}

		// Token: 0x060231CD RID: 143821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231CD")]
		[Address(RVA = "0x1DB7900", Offset = "0x1DB6500", VA = "0x181DB7900")]
		public void OnConfirmUpgrade()
		{
		}

		// Token: 0x060231CE RID: 143822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231CE")]
		[Address(RVA = "0x1DB7890", Offset = "0x1DB6490", VA = "0x181DB7890")]
		public void OnBackOrCancelClick()
		{
		}

		// Token: 0x060231CF RID: 143823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231CF")]
		[Address(RVA = "0x1DB8060", Offset = "0x1DB6C60", VA = "0x181DB8060")]
		private void _RenderConfirmPart(SkillItemViewModel skillModel, ILoadAsset assetLoader)
		{
		}

		// Token: 0x060231D0 RID: 143824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60231D0")]
		[Address(RVA = "0x1DB7A90", Offset = "0x1DB6690", VA = "0x181DB7A90")]
		private SkillItemViewModel _GetSpecialMaxData(SkillItemViewModel skill)
		{
			return null;
		}

		// Token: 0x060231D1 RID: 143825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231D1")]
		[Address(RVA = "0x1DB7CB0", Offset = "0x1DB68B0", VA = "0x181DB7CB0")]
		private void _RefreshItemCardView(UIItemViewModel itemModel)
		{
		}

		// Token: 0x060231D2 RID: 143826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231D2")]
		[Address(RVA = "0x1DB7BC0", Offset = "0x1DB67C0", VA = "0x181DB7BC0")]
		private void _OnItemClick(int index)
		{
		}

		// Token: 0x060231D3 RID: 143827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231D3")]
		[Address(RVA = "0x1DB8310", Offset = "0x1DB6F10", VA = "0x181DB8310")]
		public ItemRepoVoucherSkillConfirmView()
		{
		}

		// Token: 0x0403066E RID: 198254
		[Token(Token = "0x403066E")]
		private const int REQUIRE_ITEM_COUNT = 1;

		// Token: 0x0403066F RID: 198255
		[Token(Token = "0x403066F")]
		private const string ITEM_CNT_FORMAT_ENOUGH = "<color=#{2}>{0}</color>/{1}";

		// Token: 0x04030670 RID: 198256
		[Token(Token = "0x4030670")]
		private const string ITEM_CNT_FORMAT_NOT_ENOUGH = "{0}/{1}";

		// Token: 0x04030671 RID: 198257
		[Token(Token = "0x4030671")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterInfoSkillView _nowLevel;

		// Token: 0x04030672 RID: 198258
		[Token(Token = "0x4030672")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _nowSpecialIcon;

		// Token: 0x04030673 RID: 198259
		[Token(Token = "0x4030673")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CharacterInfoSkillView _maxLevel;

		// Token: 0x04030674 RID: 198260
		[Token(Token = "0x4030674")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _maxSpecialIcon;

		// Token: 0x04030675 RID: 198261
		[Token(Token = "0x4030675")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _specialLvl;

		// Token: 0x04030676 RID: 198262
		[Token(Token = "0x4030676")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _specialLvlGlow;

		// Token: 0x04030677 RID: 198263
		[Token(Token = "0x4030677")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x04030678 RID: 198264
		[Token(Token = "0x4030678")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("The scale to show an item card")]
		private float _itemCardScale;

		// Token: 0x04030679 RID: 198265
		[Token(Token = "0x4030679")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _itemCountText;

		// Token: 0x0403067A RID: 198266
		[Token(Token = "0x403067A")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action onConfirmUpgrade;

		// Token: 0x0403067B RID: 198267
		[Token(Token = "0x403067B")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action onBackOrCancel;

		// Token: 0x0403067C RID: 198268
		[Token(Token = "0x403067C")]
		[FieldOffset(Offset = "0x78")]
		private UIItemCard m_itemCard;

		// Token: 0x0403067D RID: 198269
		[Token(Token = "0x403067D")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403067E RID: 198270
		[Token(Token = "0x403067E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403067F RID: 198271
		[Token(Token = "0x403067F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnConfirmUpgrade;

		// Token: 0x04030680 RID: 198272
		[Token(Token = "0x4030680")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBackOrCancelClick;

		// Token: 0x04030681 RID: 198273
		[Token(Token = "0x4030681")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderConfirmPart;

		// Token: 0x04030682 RID: 198274
		[Token(Token = "0x4030682")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetSpecialMaxData;

		// Token: 0x04030683 RID: 198275
		[Token(Token = "0x4030683")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshItemCardView;

		// Token: 0x04030684 RID: 198276
		[Token(Token = "0x4030684")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x04030685 RID: 198277
		[Token(Token = "0x4030685")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
