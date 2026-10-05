using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C05 RID: 23557
	[Token(Token = "0x2005C05")]
	public abstract class CommonCharSelectCardPanelPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022253 RID: 139859
		[Token(Token = "0x6022253")]
		public abstract void Render(CommonCharSelectCardDefaultViewModel viewModel, CommonCharSelectCardDefaultPanel.Options options);

		// Token: 0x06022254 RID: 139860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022254")]
		[Address(RVA = "0x1C883E0", Offset = "0x1C86FE0", VA = "0x181C883E0")]
		protected CommonCharSelectCardPanelPlugin()
		{
		}

		// Token: 0x0402ED12 RID: 191762
		[Token(Token = "0x402ED12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
