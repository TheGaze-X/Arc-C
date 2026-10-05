using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200472A RID: 18218
	[Token(Token = "0x200472A")]
	public class RecruitBuildUseView : PageSingleComponent
	{
		// Token: 0x0601B9C3 RID: 113091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9C3")]
		[Address(RVA = "0x14F9A50", Offset = "0x14F8650", VA = "0x1814F9A50")]
		public void OnClick()
		{
		}

		// Token: 0x0601B9C4 RID: 113092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9C4")]
		[Address(RVA = "0x14F9BF0", Offset = "0x14F87F0", VA = "0x1814F9BF0")]
		public static void OnEnterStatic(int slotId)
		{
		}

		// Token: 0x0601B9C5 RID: 113093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9C5")]
		[Address(RVA = "0x14F99C0", Offset = "0x14F85C0", VA = "0x1814F99C0")]
		public void Dismiss()
		{
		}

		// Token: 0x0601B9C6 RID: 113094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9C6")]
		[Address(RVA = "0x14F9AD0", Offset = "0x14F86D0", VA = "0x1814F9AD0")]
		public static void OnDismissStatic()
		{
		}

		// Token: 0x0601B9C7 RID: 113095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9C7")]
		[Address(RVA = "0x14F9CB0", Offset = "0x14F88B0", VA = "0x1814F9CB0")]
		public void OnEnter(int slotId)
		{
		}

		// Token: 0x0601B9C8 RID: 113096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9C8")]
		[Address(RVA = "0x14F9EE0", Offset = "0x14F8AE0", VA = "0x1814F9EE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B9C9 RID: 113097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9C9")]
		[Address(RVA = "0x14FA230", Offset = "0x14F8E30", VA = "0x1814FA230")]
		public RecruitBuildUseView()
		{
		}

		// Token: 0x04023C9D RID: 146589
		[Token(Token = "0x4023C9D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _useText;

		// Token: 0x04023C9E RID: 146590
		[Token(Token = "0x4023C9E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIItemCard _itemPrefab;

		// Token: 0x04023C9F RID: 146591
		[Token(Token = "0x4023C9F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04023CA0 RID: 146592
		[Token(Token = "0x4023CA0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _costItemHolder;

		// Token: 0x04023CA1 RID: 146593
		[Token(Token = "0x4023CA1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _costItemHolder_2;

		// Token: 0x04023CA2 RID: 146594
		[Token(Token = "0x4023CA2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIBlurFloatPanel _float;

		// Token: 0x04023CA3 RID: 146595
		[Token(Token = "0x4023CA3")]
		[FieldOffset(Offset = "0x50")]
		private int m_slotId;

		// Token: 0x04023CA4 RID: 146596
		[Token(Token = "0x4023CA4")]
		[FieldOffset(Offset = "0x58")]
		private UIItemCard m_costItem;

		// Token: 0x04023CA5 RID: 146597
		[Token(Token = "0x4023CA5")]
		[FieldOffset(Offset = "0x60")]
		private UIItemCard m_costItem_2;

		// Token: 0x04023CA6 RID: 146598
		[Token(Token = "0x4023CA6")]
		[FieldOffset(Offset = "0x68")]
		private UIItemViewModel m_costModel;

		// Token: 0x04023CA7 RID: 146599
		[Token(Token = "0x4023CA7")]
		[FieldOffset(Offset = "0x70")]
		private UIItemViewModel m_costModel_2;

		// Token: 0x04023CA8 RID: 146600
		[Token(Token = "0x4023CA8")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x04023CA9 RID: 146601
		[Token(Token = "0x4023CA9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIIntEvent _onClickFast;

		// Token: 0x04023CAA RID: 146602
		[Token(Token = "0x4023CAA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04023CAB RID: 146603
		[Token(Token = "0x4023CAB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnterStatic;

		// Token: 0x04023CAC RID: 146604
		[Token(Token = "0x4023CAC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Dismiss;

		// Token: 0x04023CAD RID: 146605
		[Token(Token = "0x4023CAD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDismissStatic;

		// Token: 0x04023CAE RID: 146606
		[Token(Token = "0x4023CAE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04023CAF RID: 146607
		[Token(Token = "0x4023CAF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023CB0 RID: 146608
		[Token(Token = "0x4023CB0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
