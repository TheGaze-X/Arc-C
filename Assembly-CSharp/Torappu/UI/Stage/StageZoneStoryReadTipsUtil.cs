using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068A3 RID: 26787
	[Token(Token = "0x20068A3")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class StageZoneStoryReadTipsUtil
	{
		// Token: 0x06026642 RID: 157250 RVA: 0x000CACB0 File Offset: 0x000C8EB0
		[Token(Token = "0x6026642")]
		[Address(RVA = "0x218CDB0", Offset = "0x218B9B0", VA = "0x18218CDB0")]
		public static bool NeedShowStoryReadTips(string key, out StoryReadTipsData tipsData)
		{
			return default(bool);
		}

		// Token: 0x06026643 RID: 157251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026643")]
		[Address(RVA = "0x218D060", Offset = "0x218BC60", VA = "0x18218D060")]
		public static void StoryReadTipsConsumeTrack(string key)
		{
		}

		// Token: 0x06026644 RID: 157252 RVA: 0x000CACC8 File Offset: 0x000C8EC8
		[Token(Token = "0x6026644")]
		[Address(RVA = "0x218D100", Offset = "0x218BD00", VA = "0x18218D100")]
		public static bool StoryReadTipsHasTrack(string key)
		{
			return default(bool);
		}

		// Token: 0x06026645 RID: 157253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026645")]
		[Address(RVA = "0x218CCB0", Offset = "0x218B8B0", VA = "0x18218CCB0")]
		public static Sprite LoadReadTipsPic(string picId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06026646 RID: 157254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026646")]
		[Address(RVA = "0x218D1A0", Offset = "0x218BDA0", VA = "0x18218D1A0")]
		private static StoryReadTipsData _GetStoryReadTipsData(string key)
		{
			return null;
		}

		// Token: 0x06026647 RID: 157255 RVA: 0x000CACE0 File Offset: 0x000C8EE0
		[Token(Token = "0x6026647")]
		[Address(RVA = "0x218D270", Offset = "0x218BE70", VA = "0x18218D270")]
		private static bool _IsPlayerMatchShowCondition(StoryReadTipsData tipsData)
		{
			return default(bool);
		}

		// Token: 0x04036101 RID: 221441
		[Token(Token = "0x4036101")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NeedShowStoryReadTips;

		// Token: 0x04036102 RID: 221442
		[Token(Token = "0x4036102")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StoryReadTipsConsumeTrack;

		// Token: 0x04036103 RID: 221443
		[Token(Token = "0x4036103")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_StoryReadTipsHasTrack;

		// Token: 0x04036104 RID: 221444
		[Token(Token = "0x4036104")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadReadTipsPic;

		// Token: 0x04036105 RID: 221445
		[Token(Token = "0x4036105")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetStoryReadTipsData;

		// Token: 0x04036106 RID: 221446
		[Token(Token = "0x4036106")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IsPlayerMatchShowCondition;
	}
}
