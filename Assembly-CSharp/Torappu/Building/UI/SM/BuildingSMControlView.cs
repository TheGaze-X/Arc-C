using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CD6 RID: 7382
	[Token(Token = "0x2001CD6")]
	public class BuildingSMControlView : BuildingSMSingleRoomTypeView
	{
		// Token: 0x0600B6B7 RID: 46775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B7")]
		[Address(RVA = "0x333E090", Offset = "0x333CC90", VA = "0x18333E090", Slot = "4")]
		public override void Render(SelectedRoomDetailViewModel roomModel)
		{
		}

		// Token: 0x0600B6B8 RID: 46776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B8")]
		[Address(RVA = "0x333E290", Offset = "0x333CE90", VA = "0x18333E290")]
		private void _FormatControlBuffedValue(long buffVal, SimpleLayoutContent layout, ref BuildingBuffedValueView.ListAdapter refAdapter, Color bkgColor, Color textColor)
		{
		}

		// Token: 0x0600B6B9 RID: 46777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B9")]
		[Address(RVA = "0x333E4D0", Offset = "0x333D0D0", VA = "0x18333E4D0")]
		public BuildingSMControlView()
		{
		}

		// Token: 0x0400B438 RID: 46136
		[Token(Token = "0x400B438")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textMpCost;

		// Token: 0x0400B439 RID: 46137
		[Token(Token = "0x400B439")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textMpReduce;

		// Token: 0x0400B43A RID: 46138
		[Token(Token = "0x400B43A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _mpCostLayout;

		// Token: 0x0400B43B RID: 46139
		[Token(Token = "0x400B43B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _mpReduceLayout;

		// Token: 0x0400B43C RID: 46140
		[Token(Token = "0x400B43C")]
		[FieldOffset(Offset = "0x58")]
		private BuildingBuffedValueView.ListAdapter m_mpCostAdapter;

		// Token: 0x0400B43D RID: 46141
		[Token(Token = "0x400B43D")]
		[FieldOffset(Offset = "0x60")]
		private BuildingBuffedValueView.ListAdapter m_mpReduceAdapter;

		// Token: 0x0400B43E RID: 46142
		[Token(Token = "0x400B43E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B43F RID: 46143
		[Token(Token = "0x400B43F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FormatControlBuffedValue;

		// Token: 0x0400B440 RID: 46144
		[Token(Token = "0x400B440")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
