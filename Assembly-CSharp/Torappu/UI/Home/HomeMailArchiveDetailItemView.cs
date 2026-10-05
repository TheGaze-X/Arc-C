using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C38 RID: 19512
	[Token(Token = "0x2004C38")]
	public class HomeMailArchiveDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D4C0 RID: 120000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4C0")]
		[Address(RVA = "0x16CF9B0", Offset = "0x16CE5B0", VA = "0x1816CF9B0")]
		public void Render(UIItemViewModel item)
		{
		}

		// Token: 0x0601D4C1 RID: 120001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4C1")]
		[Address(RVA = "0x16CFB10", Offset = "0x16CE710", VA = "0x1816CFB10")]
		public HomeMailArchiveDetailItemView()
		{
		}

		// Token: 0x040268A1 RID: 157857
		[Token(Token = "0x40268A1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040268A2 RID: 157858
		[Token(Token = "0x40268A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x040268A3 RID: 157859
		[Token(Token = "0x40268A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _text;

		// Token: 0x040268A4 RID: 157860
		[Token(Token = "0x40268A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040268A5 RID: 157861
		[Token(Token = "0x40268A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
