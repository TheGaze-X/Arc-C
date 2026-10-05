using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C51 RID: 19537
	[Token(Token = "0x2004C51")]
	public abstract class HomeThemeApView : DataBinder<APInfoProperty>
	{
		// Token: 0x0601D51F RID: 120095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D51F")]
		[Address(RVA = "0x16E4180", Offset = "0x16E2D80", VA = "0x1816E4180")]
		protected HomeThemeApView()
		{
		}

		// Token: 0x0402693D RID: 158013
		[Token(Token = "0x402693D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Text _textApCurr;

		// Token: 0x0402693E RID: 158014
		[Token(Token = "0x402693E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Text _textApMax;

		// Token: 0x0402693F RID: 158015
		[Token(Token = "0x402693F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
