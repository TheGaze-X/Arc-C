using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002383 RID: 9091
	[Token(Token = "0x2002383")]
	public static class MapThemeFactory
	{
		// Token: 0x0600E6B4 RID: 59060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E6B4")]
		[Address(RVA = "0x5C3E00", Offset = "0x5C2A00", VA = "0x1805C3E00")]
		public static MapThemeController CreateMapThemeController(string themeId, Map map)
		{
			return null;
		}

		// Token: 0x0400FE15 RID: 65045
		[Token(Token = "0x400FE15")]
		private const string WATER_THEME_TYPE = "WATER";

		// Token: 0x02002384 RID: 9092
		[Token(Token = "0x2002384")]
		private class DefaultThemeController : MapThemeController
		{
			// Token: 0x0600E6B5 RID: 59061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E6B5")]
			[Address(RVA = "0x5BBA70", Offset = "0x5BA670", VA = "0x1805BBA70")]
			public DefaultThemeController(MapThemeData data, Map map)
			{
			}

			// Token: 0x0600E6B6 RID: 59062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E6B6")]
			[Address(RVA = "0x5BBA10", Offset = "0x5BA610", VA = "0x1805BBA10", Slot = "4")]
			public override void OnInit()
			{
			}

			// Token: 0x0400FE16 RID: 65046
			[Token(Token = "0x400FE16")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400FE17 RID: 65047
			[Token(Token = "0x400FE17")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnInit;
		}

		// Token: 0x02002385 RID: 9093
		[Token(Token = "0x2002385")]
		private class WaterThemeController : MapThemeController
		{
			// Token: 0x0600E6B7 RID: 59063 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E6B7")]
			[Address(RVA = "0x5CCEF0", Offset = "0x5CBAF0", VA = "0x1805CCEF0")]
			public WaterThemeController(MapThemeData data, Map map)
			{
			}

			// Token: 0x0600E6B8 RID: 59064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E6B8")]
			[Address(RVA = "0x5CCE20", Offset = "0x5CBA20", VA = "0x1805CCE20", Slot = "4")]
			public override void OnInit()
			{
			}

			// Token: 0x0400FE18 RID: 65048
			[Token(Token = "0x400FE18")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400FE19 RID: 65049
			[Token(Token = "0x400FE19")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnInit;
		}
	}
}
