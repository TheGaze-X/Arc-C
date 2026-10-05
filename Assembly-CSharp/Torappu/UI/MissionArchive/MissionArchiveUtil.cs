using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.MissionArchive
{
	// Token: 0x02004855 RID: 18517
	[Token(Token = "0x2004855")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class MissionArchiveUtil
	{
		// Token: 0x0601BF98 RID: 114584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF98")]
		[Address(RVA = "0x1554EE0", Offset = "0x1553AE0", VA = "0x181554EE0")]
		public static void OpenMissionArchivePage(UIPage from, string topicId, MissionArchiveDataServiceProxy proxy)
		{
		}

		// Token: 0x0601BF99 RID: 114585 RVA: 0x000A6BC0 File Offset: 0x000A4DC0
		[Token(Token = "0x601BF99")]
		[Address(RVA = "0x1554D50", Offset = "0x1553950", VA = "0x181554D50")]
		public static bool CheckIfHasReward(PlayerMissionArchive playerData)
		{
			return default(bool);
		}

		// Token: 0x0601BF9A RID: 114586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF9A")]
		[Address(RVA = "0x1555240", Offset = "0x1553E40", VA = "0x181555240")]
		private static IEnumerator _MissionArchiveClaimEntryRewardCoroutine(string topicId, List<ItemGet> rewards)
		{
			return null;
		}

		// Token: 0x040247C8 RID: 149448
		[Token(Token = "0x40247C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OpenMissionArchivePage;

		// Token: 0x040247C9 RID: 149449
		[Token(Token = "0x40247C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfHasReward;

		// Token: 0x040247CA RID: 149450
		[Token(Token = "0x40247CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__MissionArchiveClaimEntryRewardCoroutine;
	}
}
