using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006129 RID: 24873
	[Token(Token = "0x2006129")]
	public class CampaignBreakDetailView : DataBinder<CampaignBreakDetailProperty>, IHotfixable
	{
		// Token: 0x06023EC0 RID: 147136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EC0")]
		[Address(RVA = "0x1E85F00", Offset = "0x1E84B00", VA = "0x181E85F00", Slot = "7")]
		public override void OnValueChanged(CampaignBreakDetailProperty property)
		{
		}

		// Token: 0x06023EC1 RID: 147137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EC1")]
		[Address(RVA = "0x1E85E70", Offset = "0x1E84A70", VA = "0x181E85E70")]
		public void EventOnConfirmAllClicked()
		{
		}

		// Token: 0x06023EC2 RID: 147138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EC2")]
		[Address(RVA = "0x1E86110", Offset = "0x1E84D10", VA = "0x181E86110")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023EC3 RID: 147139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EC3")]
		[Address(RVA = "0x1E86240", Offset = "0x1E84E40", VA = "0x181E86240")]
		public CampaignBreakDetailView()
		{
		}

		// Token: 0x04031DBA RID: 204218
		[Token(Token = "0x4031DBA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04031DBB RID: 204219
		[Token(Token = "0x4031DBB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelConfirmAll;

		// Token: 0x04031DBC RID: 204220
		[Token(Token = "0x4031DBC")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x04031DBD RID: 204221
		[Token(Token = "0x4031DBD")]
		[FieldOffset(Offset = "0x38")]
		private List<CampaignBreakDetailItemViewModel> m_cachedList;

		// Token: 0x04031DBE RID: 204222
		[Token(Token = "0x4031DBE")]
		[FieldOffset(Offset = "0x40")]
		private CampaignBreakDetailView.Adapter m_adapter;

		// Token: 0x04031DBF RID: 204223
		[Token(Token = "0x4031DBF")]
		[FieldOffset(Offset = "0x48")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04031DC0 RID: 204224
		[Token(Token = "0x4031DC0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04031DC1 RID: 204225
		[Token(Token = "0x4031DC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnConfirmAllClicked;

		// Token: 0x04031DC2 RID: 204226
		[Token(Token = "0x4031DC2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031DC3 RID: 204227
		[Token(Token = "0x4031DC3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200612A RID: 24874
		[Token(Token = "0x200612A")]
		private class Adapter : SimpleLayoutAdapter<CampaignBreakDetailItemView>, IHotfixable
		{
			// Token: 0x06023EC4 RID: 147140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023EC4")]
			[Address(RVA = "0x1E82F80", Offset = "0x1E81B80", VA = "0x181E82F80")]
			public Adapter(CampaignBreakDetailView closure)
			{
			}

			// Token: 0x170054D1 RID: 21713
			// (get) Token: 0x06023EC5 RID: 147141 RVA: 0x000C2640 File Offset: 0x000C0840
			[Token(Token = "0x170054D1")]
			public override int count
			{
				[Token(Token = "0x6023EC5")]
				[Address(RVA = "0x1E83160", Offset = "0x1E81D60", VA = "0x181E83160", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023EC6 RID: 147142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023EC6")]
			[Address(RVA = "0x1E82B00", Offset = "0x1E81700", VA = "0x181E82B00", Slot = "9")]
			protected override void OnRender(int position, CampaignBreakDetailItemView view, bool isNewlyCreated)
			{
			}

			// Token: 0x04031DC4 RID: 204228
			[Token(Token = "0x4031DC4")]
			[FieldOffset(Offset = "0x20")]
			private CampaignBreakDetailView m_closure;

			// Token: 0x04031DC5 RID: 204229
			[Token(Token = "0x4031DC5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031DC6 RID: 204230
			[Token(Token = "0x4031DC6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031DC7 RID: 204231
			[Token(Token = "0x4031DC7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnRender;
		}
	}
}
