using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B16 RID: 31510
	[Token(Token = "0x2007B16")]
	public class Act10D5ResUtil
	{
		// Token: 0x17006754 RID: 26452
		// (get) Token: 0x0602C1C2 RID: 180674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006754")]
		public static string activityId
		{
			[Token(Token = "0x602C1C2")]
			[Address(RVA = "0x2807330", Offset = "0x2805F30", VA = "0x182807330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006755 RID: 26453
		// (get) Token: 0x0602C1C3 RID: 180675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006755")]
		public static StateEngine floatStateEngine
		{
			[Token(Token = "0x602C1C3")]
			[Address(RVA = "0x28073E0", Offset = "0x2805FE0", VA = "0x1828073E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C1C4 RID: 180676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C1C4")]
		[Address(RVA = "0x2806FC0", Offset = "0x2805BC0", VA = "0x182806FC0")]
		public static CommonTopMenu CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x17006756 RID: 26454
		// (get) Token: 0x0602C1C5 RID: 180677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006756")]
		public static SpriteHub act10d5SpriteHub
		{
			[Token(Token = "0x602C1C5")]
			[Address(RVA = "0x2807250", Offset = "0x2805E50", VA = "0x182807250")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006757 RID: 26455
		// (get) Token: 0x0602C1C6 RID: 180678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006757")]
		public static UIItemCard uiItemCard
		{
			[Token(Token = "0x602C1C6")]
			[Address(RVA = "0x23336C0", Offset = "0x23322C0", VA = "0x1823336C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C1C7 RID: 180679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1C7")]
		[Address(RVA = "0x28070D0", Offset = "0x2805CD0", VA = "0x1828070D0")]
		public static void SetFavorUpCharWatched(string charId)
		{
		}

		// Token: 0x0602C1C8 RID: 180680 RVA: 0x000DE240 File Offset: 0x000DC440
		[Token(Token = "0x602C1C8")]
		[Address(RVA = "0x2807470", Offset = "0x2806070", VA = "0x182807470")]
		public static bool isFavorUpCharWatched(string charId)
		{
			return default(bool);
		}

		// Token: 0x0602C1C9 RID: 180681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1C9")]
		[Address(RVA = "0x2807160", Offset = "0x2805D60", VA = "0x182807160")]
		public static void SetZoneAccessed(string zoneId)
		{
		}

		// Token: 0x0602C1CA RID: 180682 RVA: 0x000DE258 File Offset: 0x000DC458
		[Token(Token = "0x602C1CA")]
		[Address(RVA = "0x2807500", Offset = "0x2806100", VA = "0x182807500")]
		public static bool isZoneAccessed(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x0602C1CB RID: 180683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C1CB")]
		[Address(RVA = "0x28071F0", Offset = "0x2805DF0", VA = "0x1828071F0")]
		private static string _GenerateActLocalCacheKey(string prefix, string id)
		{
			return null;
		}

		// Token: 0x0602C1CC RID: 180684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1CC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act10D5ResUtil()
		{
		}

		// Token: 0x0403FF41 RID: 261953
		[Token(Token = "0x403FF41")]
		public const string ACT_LOCAL_CACHE_PREFIX_WATCHED_FAVOR_UP_CHAR_ID = "watched_favor_up_char_id";

		// Token: 0x0403FF42 RID: 261954
		[Token(Token = "0x403FF42")]
		public const string ACT_LOCAL_CACHE_PREFIX_ACCESSED_ZONE_ID = "accessed_zone_id";

		// Token: 0x0403FF43 RID: 261955
		[Token(Token = "0x403FF43")]
		private const string CHAR_HUB_PATH = "Activity/[UC]{0}/Prefabs/{0}_sprite";
	}
}
