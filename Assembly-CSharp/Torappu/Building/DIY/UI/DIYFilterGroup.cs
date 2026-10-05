using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200197C RID: 6524
	[Token(Token = "0x200197C")]
	public class DIYFilterGroup : DataBinder<DIYFilterGroupProperty>
	{
		// Token: 0x0600A3B6 RID: 41910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3B6")]
		[Address(RVA = "0x31D8D20", Offset = "0x31D7920", VA = "0x1831D8D20")]
		private void _InitIfNot(DIYFilterGroupModel filterGroupModel)
		{
		}

		// Token: 0x0600A3B7 RID: 41911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3B7")]
		[Address(RVA = "0x31D88F0", Offset = "0x31D74F0", VA = "0x1831D88F0")]
		private void _InitALLFilter(DIYFilterGroupModel filterGroupModel)
		{
		}

		// Token: 0x0600A3B8 RID: 41912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3B8")]
		[Address(RVA = "0x31D8AB0", Offset = "0x31D76B0", VA = "0x1831D8AB0")]
		private void _InitFilters(DIYFilterGroupModel filterGroupModel)
		{
		}

		// Token: 0x0600A3B9 RID: 41913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3B9")]
		[Address(RVA = "0x31D83D0", Offset = "0x31D6FD0", VA = "0x1831D83D0", Slot = "7")]
		public override void OnValueChanged(DIYFilterGroupProperty property)
		{
		}

		// Token: 0x0600A3BA RID: 41914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3BA")]
		[Address(RVA = "0x31D8F50", Offset = "0x31D7B50", VA = "0x1831D8F50")]
		public DIYFilterGroup()
		{
		}

		// Token: 0x04009A6C RID: 39532
		[Token(Token = "0x4009A6C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04009A6D RID: 39533
		[Token(Token = "0x4009A6D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DIYFilterToggleView _filterView;

		// Token: 0x04009A6E RID: 39534
		[Token(Token = "0x4009A6E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DIYFilterToggleView _allFilterView;

		// Token: 0x04009A6F RID: 39535
		[Token(Token = "0x4009A6F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DIYFilterGroup.DIYFilterPressedEvent _onFilterPressed;

		// Token: 0x04009A70 RID: 39536
		[Token(Token = "0x4009A70")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DIYFilterGroup.DIYSubTypePressedEvent _onSubTypePressed;

		// Token: 0x04009A71 RID: 39537
		[Token(Token = "0x4009A71")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _filterCanvasGroup;

		// Token: 0x04009A72 RID: 39538
		[Token(Token = "0x4009A72")]
		[FieldOffset(Offset = "0x50")]
		private List<DIYFilterToggleView> m_filters;

		// Token: 0x04009A73 RID: 39539
		[Token(Token = "0x4009A73")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInit;

		// Token: 0x04009A74 RID: 39540
		[Token(Token = "0x4009A74")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04009A75 RID: 39541
		[Token(Token = "0x4009A75")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitALLFilter;

		// Token: 0x04009A76 RID: 39542
		[Token(Token = "0x4009A76")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitFilters;

		// Token: 0x04009A77 RID: 39543
		[Token(Token = "0x4009A77")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04009A78 RID: 39544
		[Token(Token = "0x4009A78")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200197D RID: 6525
		[Token(Token = "0x200197D")]
		[Serializable]
		public class DIYFilterPressedEvent : UnityEvent<DIYFilterType>
		{
			// Token: 0x0600A3BF RID: 41919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3BF")]
			[Address(RVA = "0x31D9020", Offset = "0x31D7C20", VA = "0x1831D9020")]
			public DIYFilterPressedEvent()
			{
			}
		}

		// Token: 0x0200197E RID: 6526
		[Token(Token = "0x200197E")]
		[Serializable]
		public class DIYSubTypePressedEvent : UnityEvent<BuildingData.FurnitureSubType>
		{
			// Token: 0x0600A3C0 RID: 41920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3C0")]
			[Address(RVA = "0x31E4190", Offset = "0x31E2D90", VA = "0x1831E4190")]
			public DIYSubTypePressedEvent()
			{
			}
		}
	}
}
