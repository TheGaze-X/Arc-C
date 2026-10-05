using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B49 RID: 27465
	[Token(Token = "0x2006B49")]
	public class ArchiveChatPageItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027413 RID: 160787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027413")]
		[Address(RVA = "0x226DBC0", Offset = "0x226C7C0", VA = "0x18226DBC0")]
		public void Render(bool isSelected)
		{
		}

		// Token: 0x06027414 RID: 160788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027414")]
		[Address(RVA = "0x226DC50", Offset = "0x226C850", VA = "0x18226DC50")]
		public ArchiveChatPageItemView()
		{
		}

		// Token: 0x040378E1 RID: 227553
		[Token(Token = "0x40378E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x040378E2 RID: 227554
		[Token(Token = "0x40378E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUnselected;

		// Token: 0x040378E3 RID: 227555
		[Token(Token = "0x40378E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040378E4 RID: 227556
		[Token(Token = "0x40378E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
