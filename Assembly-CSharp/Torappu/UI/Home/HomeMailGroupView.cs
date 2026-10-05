using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C2F RID: 19503
	[Token(Token = "0x2004C2F")]
	public class HomeMailGroupView : DataBinder<MailItemGroupViewProperty>
	{
		// Token: 0x0601D49E RID: 119966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D49E")]
		[Address(RVA = "0x16D2FD0", Offset = "0x16D1BD0", VA = "0x1816D2FD0")]
		public void TryTriggerDrag()
		{
		}

		// Token: 0x0601D49F RID: 119967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D49F")]
		[Address(RVA = "0x16D2BC0", Offset = "0x16D17C0", VA = "0x1816D2BC0")]
		public void DealWithDrag(Vector2 offset)
		{
		}

		// Token: 0x0601D4A0 RID: 119968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4A0")]
		[Address(RVA = "0x16D2D10", Offset = "0x16D1910", VA = "0x1816D2D10", Slot = "7")]
		public override void OnValueChanged(MailItemGroupViewProperty property)
		{
		}

		// Token: 0x0601D4A1 RID: 119969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4A1")]
		[Address(RVA = "0x16D3180", Offset = "0x16D1D80", VA = "0x1816D3180")]
		public HomeMailGroupView()
		{
		}

		// Token: 0x0402685F RID: 157791
		[Token(Token = "0x402685F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HomeMailRecycleAdapter _dataTarget;

		// Token: 0x04026860 RID: 157792
		[Token(Token = "0x4026860")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textUnreadCount;

		// Token: 0x04026861 RID: 157793
		[Token(Token = "0x4026861")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textNoMails;

		// Token: 0x04026862 RID: 157794
		[Token(Token = "0x4026862")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _mailCount;

		// Token: 0x04026863 RID: 157795
		[Token(Token = "0x4026863")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LoopScrollRect _scrollRect;

		// Token: 0x04026864 RID: 157796
		[Token(Token = "0x4026864")]
		[FieldOffset(Offset = "0x48")]
		private int m_cachedSequenceNum;

		// Token: 0x04026865 RID: 157797
		[Token(Token = "0x4026865")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026866 RID: 157798
		[Token(Token = "0x4026866")]
		[FieldOffset(Offset = "0x60")]
		private int m_count;

		// Token: 0x04026867 RID: 157799
		[Token(Token = "0x4026867")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryTriggerDrag;

		// Token: 0x04026868 RID: 157800
		[Token(Token = "0x4026868")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DealWithDrag;

		// Token: 0x04026869 RID: 157801
		[Token(Token = "0x4026869")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402686A RID: 157802
		[Token(Token = "0x402686A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
