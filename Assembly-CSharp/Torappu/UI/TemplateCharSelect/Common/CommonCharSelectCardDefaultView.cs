using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C08 RID: 23560
	[Token(Token = "0x2005C08")]
	public class CommonCharSelectCardDefaultView : TemplateCharSelectCardView
	{
		// Token: 0x0602225C RID: 139868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602225C")]
		[Address(RVA = "0x1C880B0", Offset = "0x1C86CB0", VA = "0x181C880B0", Slot = "6")]
		protected override void DoRender(TemplateCharSelectCardViewModel viewModel)
		{
		}

		// Token: 0x0602225D RID: 139869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602225D")]
		[Address(RVA = "0x1C88330", Offset = "0x1C86F30", VA = "0x181C88330")]
		public CommonCharSelectCardDefaultView()
		{
		}

		// Token: 0x0402ED26 RID: 191782
		[Token(Token = "0x402ED26")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _transPanelHolder;

		// Token: 0x0402ED27 RID: 191783
		[Token(Token = "0x402ED27")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CommonCharSelectCardDefaultPanel _defaultPanelPrefab;

		// Token: 0x0402ED28 RID: 191784
		[Token(Token = "0x402ED28")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIColorGraphic _graphic;

		// Token: 0x0402ED29 RID: 191785
		[Token(Token = "0x402ED29")]
		[FieldOffset(Offset = "0x60")]
		private CommonCharSelectCardDefaultPanel m_defaultPanel;

		// Token: 0x0402ED2A RID: 191786
		[Token(Token = "0x402ED2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x0402ED2B RID: 191787
		[Token(Token = "0x402ED2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
