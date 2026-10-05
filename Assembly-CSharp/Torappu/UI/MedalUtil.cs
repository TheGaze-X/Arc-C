using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Medal;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AD2 RID: 15058
	[Token(Token = "0x2003AD2")]
	[Hotfix(HotfixFlag.Stateless)]
	public class MedalUtil
	{
		// Token: 0x06017BEF RID: 97263 RVA: 0x00097E30 File Offset: 0x00096030
		[Token(Token = "0x6017BEF")]
		[Address(RVA = "0xFFFCC0", Offset = "0xFFE8C0", VA = "0x180FFFCC0")]
		public MedalGetState GetMedalGetState(string medalId)
		{
			return MedalGetState.NOTGET;
		}

		// Token: 0x06017BF0 RID: 97264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BF0")]
		[Address(RVA = "0xFFFD50", Offset = "0xFFE950", VA = "0x180FFFD50")]
		public static Sprite GetMedalIcon(string medalId, string pageName)
		{
			return null;
		}

		// Token: 0x06017BF1 RID: 97265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BF1")]
		[Address(RVA = "0xFFFDF0", Offset = "0xFFE9F0", VA = "0x180FFFDF0")]
		public static Sprite GetMedalIcon(string medalId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06017BF2 RID: 97266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BF2")]
		[Address(RVA = "0xFFFFD0", Offset = "0xFFEBD0", VA = "0x180FFFFD0")]
		public static Sprite GetMedalTitle(string groupId, string pageName)
		{
			return null;
		}

		// Token: 0x06017BF3 RID: 97267 RVA: 0x00097E48 File Offset: 0x00096048
		[Token(Token = "0x6017BF3")]
		[Address(RVA = "0xFFFA70", Offset = "0xFFE670", VA = "0x180FFFA70")]
		public static int GetAvailMedalCount(IList<string> medalIdList)
		{
			return 0;
		}

		// Token: 0x06017BF4 RID: 97268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BF4")]
		[Address(RVA = "0x1000470", Offset = "0xFFF070", VA = "0x181000470")]
		public static UIMedalGroupView LoadMedalGroupViewPrefab(ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06017BF5 RID: 97269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BF5")]
		[Address(RVA = "0x10005E0", Offset = "0xFFF1E0", VA = "0x1810005E0")]
		public static UIMedalGroupView LoadMedalGroupViewPrefab(string pageName)
		{
			return null;
		}

		// Token: 0x06017BF6 RID: 97270 RVA: 0x00097E60 File Offset: 0x00096060
		[Token(Token = "0x6017BF6")]
		[Address(RVA = "0xFFEE90", Offset = "0xFFDA90", VA = "0x180FFEE90")]
		public static bool CheckIfMedalAchieved(string medalId)
		{
			return default(bool);
		}

		// Token: 0x06017BF7 RID: 97271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BF7")]
		[Address(RVA = "0x10001E0", Offset = "0xFFEDE0", VA = "0x1810001E0")]
		public static Dictionary<string, HexPoint> LoadDIYInfo(PlayerMedalCustomLayout customLayout)
		{
			return null;
		}

		// Token: 0x06017BF8 RID: 97272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BF8")]
		[Address(RVA = "0x1000070", Offset = "0xFFEC70", VA = "0x181000070")]
		public static Dictionary<string, HexPoint> LoadCurrentDIYInfo()
		{
			return null;
		}

		// Token: 0x06017BF9 RID: 97273 RVA: 0x00097E78 File Offset: 0x00096078
		[Token(Token = "0x6017BF9")]
		[Address(RVA = "0xFFEF90", Offset = "0xFFDB90", VA = "0x180FFEF90")]
		public static bool CheckIfSameDIYInfo(IDictionary<string, HexPoint> lhs, IDictionary<string, HexPoint> rhs)
		{
			return default(bool);
		}

		// Token: 0x06017BFA RID: 97274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BFA")]
		[Address(RVA = "0xFFF700", Offset = "0xFFE300", VA = "0x180FFF700")]
		public static MedalGroupViewModel CreateMedalGroupModel4Display(string groupId)
		{
			return null;
		}

		// Token: 0x06017BFB RID: 97275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BFB")]
		[Address(RVA = "0xFFF440", Offset = "0xFFE040", VA = "0x180FFF440")]
		public static MedalGroupViewModel CreateMedalGroupModel4Display(FriendMedalTemplateGroupInfo info)
		{
			return null;
		}

		// Token: 0x06017BFC RID: 97276 RVA: 0x00097E90 File Offset: 0x00096090
		[Token(Token = "0x6017BFC")]
		[Address(RVA = "0xFFF2E0", Offset = "0xFFDEE0", VA = "0x180FFF2E0")]
		public static MedalExpireStatus CheckMedalExpireStatus(long targetTs, List<MedalExpireTime> expireTimes)
		{
			return default(MedalExpireStatus);
		}

		// Token: 0x06017BFD RID: 97277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BFD")]
		[Address(RVA = "0xFFFE90", Offset = "0xFFEA90", VA = "0x180FFFE90")]
		public static string GetMedalProgressDesc(int value, int target)
		{
			return null;
		}

		// Token: 0x06017BFE RID: 97278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BFE")]
		[Address(RVA = "0x10006B0", Offset = "0xFFF2B0", VA = "0x1810006B0")]
		public MedalUtil()
		{
		}

		// Token: 0x0401CAC4 RID: 117444
		[Token(Token = "0x401CAC4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color ORANGE_LIGHT_COLOR;

		// Token: 0x0401CAC5 RID: 117445
		[Token(Token = "0x401CAC5")]
		public const float COMMON_SCALE = 0.77f;

		// Token: 0x0401CAC6 RID: 117446
		[Token(Token = "0x401CAC6")]
		public const float COMMON_DETAIL_SCALE = 1.17f;

		// Token: 0x0401CAC7 RID: 117447
		[Token(Token = "0x401CAC7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetMedalGetState;

		// Token: 0x0401CAC8 RID: 117448
		[Token(Token = "0x401CAC8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetMedalIcon;

		// Token: 0x0401CAC9 RID: 117449
		[Token(Token = "0x401CAC9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_GetMedalIcon;

		// Token: 0x0401CACA RID: 117450
		[Token(Token = "0x401CACA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetMedalTitle;

		// Token: 0x0401CACB RID: 117451
		[Token(Token = "0x401CACB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetAvailMedalCount;

		// Token: 0x0401CACC RID: 117452
		[Token(Token = "0x401CACC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadMedalGroupViewPrefab;

		// Token: 0x0401CACD RID: 117453
		[Token(Token = "0x401CACD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_LoadMedalGroupViewPrefab;

		// Token: 0x0401CACE RID: 117454
		[Token(Token = "0x401CACE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfMedalAchieved;

		// Token: 0x0401CACF RID: 117455
		[Token(Token = "0x401CACF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadDIYInfo;

		// Token: 0x0401CAD0 RID: 117456
		[Token(Token = "0x401CAD0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadCurrentDIYInfo;

		// Token: 0x0401CAD1 RID: 117457
		[Token(Token = "0x401CAD1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckIfSameDIYInfo;

		// Token: 0x0401CAD2 RID: 117458
		[Token(Token = "0x401CAD2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CreateMedalGroupModel4Display;

		// Token: 0x0401CAD3 RID: 117459
		[Token(Token = "0x401CAD3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_CreateMedalGroupModel4Display;

		// Token: 0x0401CAD4 RID: 117460
		[Token(Token = "0x401CAD4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckMedalExpireStatus;

		// Token: 0x0401CAD5 RID: 117461
		[Token(Token = "0x401CAD5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetMedalProgressDesc;

		// Token: 0x0401CAD6 RID: 117462
		[Token(Token = "0x401CAD6")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
