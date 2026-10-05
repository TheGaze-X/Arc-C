using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E8C RID: 24204
	[Token(Token = "0x2005E8C")]
	public class ItemRepoClassifyBtnPartView : DataBinder<ItemCardGroupViewProperty>, IHotfixable
	{
		// Token: 0x06023129 RID: 143657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023129")]
		[Address(RVA = "0x1D93610", Offset = "0x1D92210", VA = "0x181D93610")]
		public void _InitIfNot()
		{
		}

		// Token: 0x0602312A RID: 143658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602312A")]
		[Address(RVA = "0x1D93180", Offset = "0x1D91D80", VA = "0x181D93180", Slot = "7")]
		public override void OnValueChanged(ItemCardGroupViewProperty property)
		{
		}

		// Token: 0x0602312B RID: 143659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602312B")]
		[Address(RVA = "0x1D93740", Offset = "0x1D92340", VA = "0x181D93740")]
		private void _OnTimeExceed()
		{
		}

		// Token: 0x0602312C RID: 143660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602312C")]
		[Address(RVA = "0x1D937E0", Offset = "0x1D923E0", VA = "0x181D937E0")]
		public ItemRepoClassifyBtnPartView()
		{
		}

		// Token: 0x040304D6 RID: 197846
		[Token(Token = "0x40304D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<ItemRepoClassifyBtnPartView.ClassifyBtnView> _btnView;

		// Token: 0x040304D7 RID: 197847
		[Token(Token = "0x40304D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _onTimeContainer;

		// Token: 0x040304D8 RID: 197848
		[Token(Token = "0x40304D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemScaler;

		// Token: 0x040304D9 RID: 197849
		[Token(Token = "0x40304D9")]
		[FieldOffset(Offset = "0x38")]
		private UIItemTimeCountDown m_countDown;

		// Token: 0x040304DA RID: 197850
		[Token(Token = "0x40304DA")]
		[FieldOffset(Offset = "0x40")]
		private bool m_initFlag;

		// Token: 0x040304DB RID: 197851
		[Token(Token = "0x40304DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040304DC RID: 197852
		[Token(Token = "0x40304DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040304DD RID: 197853
		[Token(Token = "0x40304DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnTimeExceed;

		// Token: 0x040304DE RID: 197854
		[Token(Token = "0x40304DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E8D RID: 24205
		[Token(Token = "0x2005E8D")]
		[Serializable]
		public class ClassifyBtnView
		{
			// Token: 0x0602312D RID: 143661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602312D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ClassifyBtnView()
			{
			}

			// Token: 0x040304DF RID: 197855
			[Token(Token = "0x40304DF")]
			[FieldOffset(Offset = "0x10")]
			public ClassifyFilter filter;

			// Token: 0x040304E0 RID: 197856
			[Token(Token = "0x40304E0")]
			[FieldOffset(Offset = "0x18")]
			public TwoStateToggle twoStateToggle;
		}
	}
}
