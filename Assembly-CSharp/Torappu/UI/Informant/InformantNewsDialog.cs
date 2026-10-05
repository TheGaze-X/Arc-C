using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A1E RID: 18974
	[Token(Token = "0x2004A1E")]
	public class InformantNewsDialog : UICompDialog<InformantDialogCommonInput>, IHotfixable
	{
		// Token: 0x0601C8AF RID: 116911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8AF")]
		[Address(RVA = "0x15FFCA0", Offset = "0x15FE8A0", VA = "0x1815FFCA0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601C8B0 RID: 116912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8B0")]
		[Address(RVA = "0x15FFD70", Offset = "0x15FE970", VA = "0x1815FFD70", Slot = "18")]
		protected override void OnRender(InformantDialogCommonInput input)
		{
		}

		// Token: 0x0601C8B1 RID: 116913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8B1")]
		[Address(RVA = "0x15FFBD0", Offset = "0x15FE7D0", VA = "0x1815FFBD0")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x0601C8B2 RID: 116914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8B2")]
		[Address(RVA = "0x15FFE20", Offset = "0x15FEA20", VA = "0x1815FFE20")]
		public InformantNewsDialog()
		{
		}

		// Token: 0x0601C8B3 RID: 116915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8B3")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x040256EA RID: 153322
		[Token(Token = "0x40256EA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private InformantNewsTabView _newsTabPrefab;

		// Token: 0x040256EB RID: 153323
		[Token(Token = "0x40256EB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _newsTabContainer;

		// Token: 0x040256EC RID: 153324
		[Token(Token = "0x40256EC")]
		[FieldOffset(Offset = "0x80")]
		private InformantNewsTabView m_newsTabView;

		// Token: 0x040256ED RID: 153325
		[Token(Token = "0x40256ED")]
		[FieldOffset(Offset = "0x88")]
		private InformantNewsTabViewModel m_newsViewModel;

		// Token: 0x040256EE RID: 153326
		[Token(Token = "0x40256EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040256EF RID: 153327
		[Token(Token = "0x40256EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040256F0 RID: 153328
		[Token(Token = "0x40256F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x040256F1 RID: 153329
		[Token(Token = "0x40256F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
