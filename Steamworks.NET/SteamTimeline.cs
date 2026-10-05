using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public static class SteamTimeline
	{
		// Token: 0x060003D9 RID: 985 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x4ED2880", Offset = "0x4ED1480", VA = "0x184ED2880")]
		public static void SetTimelineStateDescription(string pchDescription, float flTimeDelta)
		{
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x4ED27D0", Offset = "0x4ED13D0", VA = "0x184ED27D0")]
		public static void ClearTimelineStateDescription(float flTimeDelta)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x4ED2520", Offset = "0x4ED1120", VA = "0x184ED2520")]
		public static void AddTimelineEvent(string pchIcon, string pchTitle, string pchDescription, uint unPriority, float flStartOffsetSeconds, float flDurationSeconds, ETimelineEventClipPriority ePossibleClip)
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x4ED2830", Offset = "0x4ED1430", VA = "0x184ED2830")]
		public static void SetTimelineGameMode(ETimelineGameMode eMode)
		{
		}
	}
}
