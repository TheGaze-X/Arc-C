using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C56 RID: 19542
	[Token(Token = "0x2004C56")]
	public class HomeThemeBlurGenerator : HomeThemeElemBase<HomeThemeBlurGeneratorData>
	{
		// Token: 0x0601D52E RID: 120110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D52E")]
		[Address(RVA = "0x16E60B0", Offset = "0x16E4CB0", VA = "0x1816E60B0", Slot = "12")]
		protected override void OnApply(HomeThemeBlurGeneratorData data, HomeTheme theme)
		{
		}

		// Token: 0x0601D52F RID: 120111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D52F")]
		[Address(RVA = "0x16E6030", Offset = "0x16E4C30", VA = "0x1816E6030", Slot = "13")]
		protected override void OnApplyEmpty()
		{
		}

		// Token: 0x0601D530 RID: 120112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D530")]
		[Address(RVA = "0x16E6280", Offset = "0x16E4E80", VA = "0x1816E6280")]
		private void _ApplyGeneratorParam(int blurLevel, int downSample = -1)
		{
		}

		// Token: 0x0601D531 RID: 120113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D531")]
		[Address(RVA = "0x16E61E0", Offset = "0x16E4DE0", VA = "0x1816E61E0", Slot = "14")]
		protected override void OnFillData(HomeThemeBlurGeneratorData data, AssetPathConvertor pathConvertor)
		{
		}

		// Token: 0x0601D532 RID: 120114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D532")]
		[Address(RVA = "0x16E6160", Offset = "0x16E4D60", VA = "0x1816E6160", Slot = "15")]
		protected override void OnClearRef()
		{
		}

		// Token: 0x0601D533 RID: 120115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D533")]
		[Address(RVA = "0x16E5F10", Offset = "0x16E4B10", VA = "0x1816E5F10")]
		public static void ChangeParam(int blurLevel, int downSample)
		{
		}

		// Token: 0x0601D534 RID: 120116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D534")]
		[Address(RVA = "0x16E64F0", Offset = "0x16E50F0", VA = "0x1816E64F0")]
		public HomeThemeBlurGenerator()
		{
		}

		// Token: 0x04026956 RID: 158038
		[Token(Token = "0x4026956")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(0f, 4f)]
		private int _blurLevel;

		// Token: 0x04026957 RID: 158039
		[Token(Token = "0x4026957")]
		[FieldOffset(Offset = "0x30")]
		private HomeThemeBlurHolder m_blurGenHolder;

		// Token: 0x04026958 RID: 158040
		[Token(Token = "0x4026958")]
		[FieldOffset(Offset = "0x38")]
		private HomeTheme m_cacheTheme;

		// Token: 0x04026959 RID: 158041
		[Token(Token = "0x4026959")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnApply;

		// Token: 0x0402695A RID: 158042
		[Token(Token = "0x402695A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnApplyEmpty;

		// Token: 0x0402695B RID: 158043
		[Token(Token = "0x402695B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ApplyGeneratorParam;

		// Token: 0x0402695C RID: 158044
		[Token(Token = "0x402695C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFillData;

		// Token: 0x0402695D RID: 158045
		[Token(Token = "0x402695D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClearRef;

		// Token: 0x0402695E RID: 158046
		[Token(Token = "0x402695E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ChangeParam;

		// Token: 0x0402695F RID: 158047
		[Token(Token = "0x402695F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
