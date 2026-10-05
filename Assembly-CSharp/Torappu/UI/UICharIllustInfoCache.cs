using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034EC RID: 13548
	[Token(Token = "0x20034EC")]
	public class UICharIllustInfoCache : IHotfixable
	{
		// Token: 0x06015985 RID: 88453 RVA: 0x0008CBE0 File Offset: 0x0008ADE0
		[Token(Token = "0x6015985")]
		[Address(RVA = "0xE3A040", Offset = "0xE38C40", VA = "0x180E3A040")]
		public UIIllustLayoutInfo GetUserIllustInfo(string illustId, UICharIllustInfoCache.DisplayType type)
		{
			return default(UIIllustLayoutInfo);
		}

		// Token: 0x06015986 RID: 88454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015986")]
		[Address(RVA = "0xE3A420", Offset = "0xE39020", VA = "0x180E3A420")]
		public void SaveUserIllustInfo(string illustId, UICharIllustInfoCache.DisplayType type, UIIllustLayoutInfo info)
		{
		}

		// Token: 0x06015987 RID: 88455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015987")]
		[Address(RVA = "0xE3A1E0", Offset = "0xE38DE0", VA = "0x180E3A1E0")]
		public void RecordDefault(string illustId, UICharacterIllust illust)
		{
		}

		// Token: 0x06015988 RID: 88456 RVA: 0x0008CBF8 File Offset: 0x0008ADF8
		[Token(Token = "0x6015988")]
		[Address(RVA = "0xE39F40", Offset = "0xE38B40", VA = "0x180E39F40")]
		public UIIllustLayoutInfo GetDefault(string illustId)
		{
			return default(UIIllustLayoutInfo);
		}

		// Token: 0x06015989 RID: 88457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015989")]
		[Address(RVA = "0xE3A770", Offset = "0xE39370", VA = "0x180E3A770")]
		public void TryUpdateCharRotationForLogin()
		{
		}

		// Token: 0x0601598A RID: 88458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601598A")]
		[Address(RVA = "0xE39D60", Offset = "0xE38960", VA = "0x180E39D60")]
		public void GenerateSkinListWithSpecifiedSkinNotFirst(string instId, string skinTag)
		{
		}

		// Token: 0x0601598B RID: 88459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601598B")]
		[Address(RVA = "0xE39C60", Offset = "0xE38860", VA = "0x180E39C60")]
		public void GenerateSkinListWithSpecifiedSkinFirst(string instId, string skinTag)
		{
		}

		// Token: 0x0601598C RID: 88460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601598C")]
		[Address(RVA = "0xE3A5F0", Offset = "0xE391F0", VA = "0x180E3A5F0")]
		public void SetDisplaySkin(string instId, string skinTag)
		{
		}

		// Token: 0x0601598D RID: 88461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601598D")]
		[Address(RVA = "0xE39E60", Offset = "0xE38A60", VA = "0x180E39E60")]
		public string GetCurrentDisplaySkinTag(string instId)
		{
			return null;
		}

		// Token: 0x0601598E RID: 88462 RVA: 0x0008CC10 File Offset: 0x0008AE10
		[Token(Token = "0x601598E")]
		[Address(RVA = "0xE3B1B0", Offset = "0xE39DB0", VA = "0x180E3B1B0")]
		private UIIllustLayoutInfo _GetUserIllustForHome(string illustId)
		{
			return default(UIIllustLayoutInfo);
		}

		// Token: 0x0601598F RID: 88463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601598F")]
		[Address(RVA = "0xE3B2D0", Offset = "0xE39ED0", VA = "0x180E3B2D0")]
		private static void _InitIllusts(string key, out Dictionary<string, UIIllustLayoutInfo> illusts)
		{
		}

		// Token: 0x06015990 RID: 88464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015990")]
		[Address(RVA = "0xE3B680", Offset = "0xE3A280", VA = "0x180E3B680")]
		private void _SaveUserIllustForHome(string illustId, UIIllustLayoutInfo info)
		{
		}

		// Token: 0x06015991 RID: 88465 RVA: 0x0008CC28 File Offset: 0x0008AE28
		[Token(Token = "0x6015991")]
		[Address(RVA = "0xE3BA10", Offset = "0xE3A610", VA = "0x180E3BA10")]
		private bool _UpdateCondCheck()
		{
			return default(bool);
		}

		// Token: 0x06015992 RID: 88466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015992")]
		[Address(RVA = "0xE3B3E0", Offset = "0xE39FE0", VA = "0x180E3B3E0")]
		private void _LoadCharRotationInfoIfNot()
		{
		}

		// Token: 0x06015993 RID: 88467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015993")]
		[Address(RVA = "0xE3B540", Offset = "0xE3A140", VA = "0x180E3B540")]
		private void _SaveUserCharRotationSkinList(string instId, List<string> skinList, int displayIndex)
		{
		}

		// Token: 0x06015994 RID: 88468 RVA: 0x0008CC40 File Offset: 0x0008AE40
		[Token(Token = "0x6015994")]
		[Address(RVA = "0xE3AAF0", Offset = "0xE396F0", VA = "0x180E3AAF0")]
		private bool _CheckIfCacheMatchWithPlayerData(string instId)
		{
			return default(bool);
		}

		// Token: 0x06015995 RID: 88469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015995")]
		[Address(RVA = "0xE3AE30", Offset = "0xE39A30", VA = "0x180E3AE30")]
		private static List<string> _GetSkinTagListFromPlayerPreset(string instId)
		{
			return null;
		}

		// Token: 0x06015996 RID: 88470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015996")]
		[Address(RVA = "0xE3B7D0", Offset = "0xE3A3D0", VA = "0x180E3B7D0")]
		private static void _ShuffleAndSetSpecifiedSkinFirst(List<string> list, string skinId)
		{
		}

		// Token: 0x06015997 RID: 88471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015997")]
		[Address(RVA = "0xE3B8E0", Offset = "0xE3A4E0", VA = "0x180E3B8E0")]
		private static void _ShuffleAndSetSpecifiedSkinNotFirst(List<string> list, string skinId)
		{
		}

		// Token: 0x06015998 RID: 88472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015998")]
		[Address(RVA = "0xE3AD50", Offset = "0xE39950", VA = "0x180E3AD50")]
		private void _GenerateSkinList(string instId, string specifiedSkinId, UICharIllustInfoCache.CharRotationGenerateHandler handler)
		{
		}

		// Token: 0x06015999 RID: 88473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015999")]
		[Address(RVA = "0xE3BB60", Offset = "0xE3A760", VA = "0x180E3BB60")]
		public UICharIllustInfoCache()
		{
		}

		// Token: 0x04019E50 RID: 106064
		[Token(Token = "0x4019E50")]
		private const int HOME_ILLUST_VER = 1;

		// Token: 0x04019E51 RID: 106065
		[Token(Token = "0x4019E51")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, UIIllustLayoutInfo> m_homeIllusts;

		// Token: 0x04019E52 RID: 106066
		[Token(Token = "0x4019E52")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, UIIllustLayoutInfo> m_defaultIllusts;

		// Token: 0x04019E53 RID: 106067
		[Token(Token = "0x4019E53")]
		[FieldOffset(Offset = "0x20")]
		private string m_presetInstId;

		// Token: 0x04019E54 RID: 106068
		[Token(Token = "0x4019E54")]
		[FieldOffset(Offset = "0x28")]
		private int m_displaySkinIndex;

		// Token: 0x04019E55 RID: 106069
		[Token(Token = "0x4019E55")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_rotateSkinList;

		// Token: 0x04019E56 RID: 106070
		[Token(Token = "0x4019E56")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetUserIllustInfo;

		// Token: 0x04019E57 RID: 106071
		[Token(Token = "0x4019E57")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SaveUserIllustInfo;

		// Token: 0x04019E58 RID: 106072
		[Token(Token = "0x4019E58")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RecordDefault;

		// Token: 0x04019E59 RID: 106073
		[Token(Token = "0x4019E59")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDefault;

		// Token: 0x04019E5A RID: 106074
		[Token(Token = "0x4019E5A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryUpdateCharRotationForLogin;

		// Token: 0x04019E5B RID: 106075
		[Token(Token = "0x4019E5B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GenerateSkinListWithSpecifiedSkinNotFirst;

		// Token: 0x04019E5C RID: 106076
		[Token(Token = "0x4019E5C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GenerateSkinListWithSpecifiedSkinFirst;

		// Token: 0x04019E5D RID: 106077
		[Token(Token = "0x4019E5D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetDisplaySkin;

		// Token: 0x04019E5E RID: 106078
		[Token(Token = "0x4019E5E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetCurrentDisplaySkinTag;

		// Token: 0x04019E5F RID: 106079
		[Token(Token = "0x4019E5F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetUserIllustForHome;

		// Token: 0x04019E60 RID: 106080
		[Token(Token = "0x4019E60")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIllusts;

		// Token: 0x04019E61 RID: 106081
		[Token(Token = "0x4019E61")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SaveUserIllustForHome;

		// Token: 0x04019E62 RID: 106082
		[Token(Token = "0x4019E62")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateCondCheck;

		// Token: 0x04019E63 RID: 106083
		[Token(Token = "0x4019E63")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadCharRotationInfoIfNot;

		// Token: 0x04019E64 RID: 106084
		[Token(Token = "0x4019E64")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SaveUserCharRotationSkinList;

		// Token: 0x04019E65 RID: 106085
		[Token(Token = "0x4019E65")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CheckIfCacheMatchWithPlayerData;

		// Token: 0x04019E66 RID: 106086
		[Token(Token = "0x4019E66")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GetSkinTagListFromPlayerPreset;

		// Token: 0x04019E67 RID: 106087
		[Token(Token = "0x4019E67")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ShuffleAndSetSpecifiedSkinFirst;

		// Token: 0x04019E68 RID: 106088
		[Token(Token = "0x4019E68")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ShuffleAndSetSpecifiedSkinNotFirst;

		// Token: 0x04019E69 RID: 106089
		[Token(Token = "0x4019E69")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GenerateSkinList;

		// Token: 0x04019E6A RID: 106090
		[Token(Token = "0x4019E6A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034ED RID: 13549
		[Token(Token = "0x20034ED")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum DisplayType
		{
			// Token: 0x04019E6C RID: 106092
			[Token(Token = "0x4019E6C")]
			HOME
		}

		// Token: 0x020034EE RID: 13550
		[Token(Token = "0x20034EE")]
		public enum CharRotationUpdateStrategy
		{
			// Token: 0x04019E6E RID: 106094
			[Token(Token = "0x4019E6E")]
			FIRST_TIME_IN_DAY,
			// Token: 0x04019E6F RID: 106095
			[Token(Token = "0x4019E6F")]
			EVERY_TIME
		}

		// Token: 0x020034EF RID: 13551
		[Token(Token = "0x20034EF")]
		private struct IllustInfoSet
		{
			// Token: 0x04019E70 RID: 106096
			[Token(Token = "0x4019E70")]
			[FieldOffset(Offset = "0x0")]
			public int version;

			// Token: 0x04019E71 RID: 106097
			[Token(Token = "0x4019E71")]
			[FieldOffset(Offset = "0x8")]
			public Dictionary<string, UIIllustLayoutInfo> content;
		}

		// Token: 0x020034F0 RID: 13552
		[Token(Token = "0x20034F0")]
		public struct CharRotationInfoSet
		{
			// Token: 0x04019E72 RID: 106098
			[Token(Token = "0x4019E72")]
			[FieldOffset(Offset = "0x0")]
			public string presetInstId;

			// Token: 0x04019E73 RID: 106099
			[Token(Token = "0x4019E73")]
			[FieldOffset(Offset = "0x8")]
			public List<string> skinList;

			// Token: 0x04019E74 RID: 106100
			[Token(Token = "0x4019E74")]
			[FieldOffset(Offset = "0x10")]
			public int displaySkinIndex;
		}

		// Token: 0x020034F1 RID: 13553
		// (Invoke) Token: 0x0601599B RID: 88475
		[Token(Token = "0x20034F1")]
		private delegate void CharRotationGenerateHandler(List<string> skinList, string specifiedSkinId);
	}
}
