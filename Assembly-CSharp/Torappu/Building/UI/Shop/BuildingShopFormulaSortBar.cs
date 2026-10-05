using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CFC RID: 7420
	[Token(Token = "0x2001CFC")]
	public class BuildingShopFormulaSortBar : DataBinder<SFormulaGroupProperty>
	{
		// Token: 0x0600B74D RID: 46925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B74D")]
		[Address(RVA = "0x333FFD0", Offset = "0x333EBD0", VA = "0x18333FFD0", Slot = "7")]
		public override void OnValueChanged(SFormulaGroupProperty property)
		{
		}

		// Token: 0x0600B74E RID: 46926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B74E")]
		[Address(RVA = "0x3340210", Offset = "0x333EE10", VA = "0x183340210")]
		private void _Init()
		{
		}

		// Token: 0x0600B74F RID: 46927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B74F")]
		[Address(RVA = "0x3340340", Offset = "0x333EF40", VA = "0x183340340")]
		private void _OnSortClicked(FormulaSortType sortType)
		{
		}

		// Token: 0x0600B750 RID: 46928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B750")]
		[Address(RVA = "0x33403C0", Offset = "0x333EFC0", VA = "0x1833403C0")]
		public BuildingShopFormulaSortBar()
		{
		}

		// Token: 0x0400B535 RID: 46389
		[Token(Token = "0x400B535")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingShopFormulaSortItem[] _sortItems;

		// Token: 0x0400B536 RID: 46390
		[Token(Token = "0x400B536")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<FormulaSortType> onSortClicked;

		// Token: 0x0400B537 RID: 46391
		[Token(Token = "0x400B537")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0400B538 RID: 46392
		[Token(Token = "0x400B538")]
		[FieldOffset(Offset = "0x34")]
		private FormulaSortType m_sortType;

		// Token: 0x0400B539 RID: 46393
		[Token(Token = "0x400B539")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInverse;

		// Token: 0x0400B53A RID: 46394
		[Token(Token = "0x400B53A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B53B RID: 46395
		[Token(Token = "0x400B53B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0400B53C RID: 46396
		[Token(Token = "0x400B53C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnSortClicked;

		// Token: 0x0400B53D RID: 46397
		[Token(Token = "0x400B53D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
