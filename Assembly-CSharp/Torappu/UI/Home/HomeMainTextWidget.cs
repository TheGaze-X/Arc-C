using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C48 RID: 19528
	[Token(Token = "0x2004C48")]
	public class HomeMainTextWidget : HomeMainWidgetBase
	{
		// Token: 0x0601D504 RID: 120068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D504")]
		[Address(RVA = "0x16E1EB0", Offset = "0x16E0AB0", VA = "0x1816E1EB0")]
		public void SetText(string text)
		{
		}

		// Token: 0x0601D505 RID: 120069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D505")]
		[Address(RVA = "0x16E1FE0", Offset = "0x16E0BE0", VA = "0x1816E1FE0")]
		public HomeMainTextWidget()
		{
		}

		// Token: 0x04026916 RID: 157974
		[Token(Token = "0x4026916")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text[] _labels;

		// Token: 0x04026917 RID: 157975
		[Token(Token = "0x4026917")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetText;

		// Token: 0x04026918 RID: 157976
		[Token(Token = "0x4026918")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
