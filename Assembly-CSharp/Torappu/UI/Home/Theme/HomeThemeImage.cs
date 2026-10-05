using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C60 RID: 19552
	[Token(Token = "0x2004C60")]
	public class HomeThemeImage : HomeThemeUIElem<HomeThemeImageData>
	{
		// Token: 0x0601D55B RID: 120155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D55B")]
		[Address(RVA = "0x16E71C0", Offset = "0x16E5DC0", VA = "0x1816E71C0", Slot = "16")]
		protected override void OnUIApply(HomeThemeImageData data, HomeTheme theme)
		{
		}

		// Token: 0x0601D55C RID: 120156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D55C")]
		[Address(RVA = "0x16E6FA0", Offset = "0x16E5BA0", VA = "0x1816E6FA0", Slot = "17")]
		protected override void OnFillUIData(HomeThemeImageData data, AssetPathConvertor pathConvertor)
		{
		}

		// Token: 0x0601D55D RID: 120157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D55D")]
		[Address(RVA = "0x16E6F00", Offset = "0x16E5B00", VA = "0x1816E6F00", Slot = "15")]
		protected override void OnClearRef()
		{
		}

		// Token: 0x0601D55E RID: 120158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D55E")]
		[Address(RVA = "0x16E7420", Offset = "0x16E6020", VA = "0x1816E7420")]
		public HomeThemeImage()
		{
		}

		// Token: 0x04026982 RID: 158082
		[Token(Token = "0x4026982")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _image;

		// Token: 0x04026983 RID: 158083
		[Token(Token = "0x4026983")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUIApply;

		// Token: 0x04026984 RID: 158084
		[Token(Token = "0x4026984")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFillUIData;

		// Token: 0x04026985 RID: 158085
		[Token(Token = "0x4026985")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClearRef;

		// Token: 0x04026986 RID: 158086
		[Token(Token = "0x4026986")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
