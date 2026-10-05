using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B81 RID: 19329
	[Token(Token = "0x2004B81")]
	public class HomeThemeChangeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601D177 RID: 119159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D177")]
		[Address(RVA = "0x16A8EE0", Offset = "0x16A7AE0", VA = "0x1816A8EE0")]
		public void ApplySelectTheme(string selectTheme)
		{
		}

		// Token: 0x0601D178 RID: 119160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D178")]
		[Address(RVA = "0x16A9550", Offset = "0x16A8150", VA = "0x1816A9550")]
		public void ResortList(bool ascend)
		{
		}

		// Token: 0x0601D179 RID: 119161 RVA: 0x000AA5F8 File Offset: 0x000A87F8
		[Token(Token = "0x601D179")]
		[Address(RVA = "0x16A96D0", Offset = "0x16A82D0", VA = "0x1816A96D0")]
		private static int _CompareUpdateTimeAscend(HomeThemeItemModel left, HomeThemeItemModel right)
		{
			return 0;
		}

		// Token: 0x0601D17A RID: 119162 RVA: 0x000AA610 File Offset: 0x000A8810
		[Token(Token = "0x601D17A")]
		[Address(RVA = "0x16A97D0", Offset = "0x16A83D0", VA = "0x1816A97D0")]
		private static int _CompareUpdateTimeDescend(HomeThemeItemModel left, HomeThemeItemModel right)
		{
			return 0;
		}

		// Token: 0x0601D17B RID: 119163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D17B")]
		[Address(RVA = "0x16A98D0", Offset = "0x16A84D0", VA = "0x1816A98D0")]
		private void _ConsumeNew(string bgId)
		{
		}

		// Token: 0x0601D17C RID: 119164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D17C")]
		[Address(RVA = "0x16A9950", Offset = "0x16A8550", VA = "0x1816A9950")]
		private string _GetCurUsingThemeId()
		{
			return null;
		}

		// Token: 0x0601D17D RID: 119165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D17D")]
		[Address(RVA = "0x16A9170", Offset = "0x16A7D70", VA = "0x1816A9170")]
		public void InitData(string routedHomeThemeId)
		{
		}

		// Token: 0x0601D17E RID: 119166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D17E")]
		[Address(RVA = "0x16A94C0", Offset = "0x16A80C0", VA = "0x1816A94C0")]
		public void OnPlayerDataChange()
		{
		}

		// Token: 0x0601D17F RID: 119167 RVA: 0x000AA628 File Offset: 0x000A8828
		[Token(Token = "0x601D17F")]
		[Address(RVA = "0x16A9A90", Offset = "0x16A8690", VA = "0x1816A9A90")]
		private bool _UpdateItems()
		{
			return default(bool);
		}

		// Token: 0x0601D180 RID: 119168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D180")]
		[Address(RVA = "0x16A90C0", Offset = "0x16A7CC0", VA = "0x1816A90C0")]
		public void ChangeHideState()
		{
		}

		// Token: 0x0601D181 RID: 119169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D181")]
		[Address(RVA = "0x16A9D00", Offset = "0x16A8900", VA = "0x1816A9D00")]
		public HomeThemeChangeStateBean()
		{
		}

		// Token: 0x040262E0 RID: 156384
		[Token(Token = "0x40262E0")]
		[FieldOffset(Offset = "0x10")]
		public HomeThemeChangeViewProperty themeChangeProperty;

		// Token: 0x040262E1 RID: 156385
		[Token(Token = "0x40262E1")]
		[FieldOffset(Offset = "0x18")]
		public string presetInstId;

		// Token: 0x040262E2 RID: 156386
		[Token(Token = "0x40262E2")]
		[FieldOffset(Offset = "0x20")]
		private string m_curSelectThemeId;

		// Token: 0x040262E3 RID: 156387
		[Token(Token = "0x40262E3")]
		[FieldOffset(Offset = "0x28")]
		private int m_routedSequenceNum;

		// Token: 0x040262E4 RID: 156388
		[Token(Token = "0x40262E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplySelectTheme;

		// Token: 0x040262E5 RID: 156389
		[Token(Token = "0x40262E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResortList;

		// Token: 0x040262E6 RID: 156390
		[Token(Token = "0x40262E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CompareUpdateTimeAscend;

		// Token: 0x040262E7 RID: 156391
		[Token(Token = "0x40262E7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CompareUpdateTimeDescend;

		// Token: 0x040262E8 RID: 156392
		[Token(Token = "0x40262E8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ConsumeNew;

		// Token: 0x040262E9 RID: 156393
		[Token(Token = "0x40262E9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetCurUsingThemeId;

		// Token: 0x040262EA RID: 156394
		[Token(Token = "0x40262EA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040262EB RID: 156395
		[Token(Token = "0x40262EB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChange;

		// Token: 0x040262EC RID: 156396
		[Token(Token = "0x40262EC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateItems;

		// Token: 0x040262ED RID: 156397
		[Token(Token = "0x40262ED")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ChangeHideState;

		// Token: 0x040262EE RID: 156398
		[Token(Token = "0x40262EE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004B82 RID: 19330
		[Token(Token = "0x2004B82")]
		public class RoutedHomeThemeParam : IHotfixable
		{
			// Token: 0x0601D182 RID: 119170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D182")]
			[Address(RVA = "0x16AFAD0", Offset = "0x16AE6D0", VA = "0x1816AFAD0")]
			public RoutedHomeThemeParam()
			{
			}

			// Token: 0x040262EF RID: 156399
			[Token(Token = "0x40262EF")]
			[FieldOffset(Offset = "0x10")]
			public string routedHomeThemeId;

			// Token: 0x040262F0 RID: 156400
			[Token(Token = "0x40262F0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
