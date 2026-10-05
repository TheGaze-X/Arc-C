using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Assist
{
	// Token: 0x02001E06 RID: 7686
	[Token(Token = "0x2001E06")]
	public class AssistReportFavorItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600BDCB RID: 48587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDCB")]
		[Address(RVA = "0x339C170", Offset = "0x339AD70", VA = "0x18339C170")]
		public void Render(BuildingFavorReport report)
		{
		}

		// Token: 0x0600BDCC RID: 48588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDCC")]
		[Address(RVA = "0x339C500", Offset = "0x339B100", VA = "0x18339C500")]
		public AssistReportFavorItem()
		{
		}

		// Token: 0x0400BE73 RID: 48755
		[Token(Token = "0x400BE73")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _charName;

		// Token: 0x0400BE74 RID: 48756
		[Token(Token = "0x400BE74")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _charPrevFavor;

		// Token: 0x0400BE75 RID: 48757
		[Token(Token = "0x400BE75")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _charCurrFavor;

		// Token: 0x0400BE76 RID: 48758
		[Token(Token = "0x400BE76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400BE77 RID: 48759
		[Token(Token = "0x400BE77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
