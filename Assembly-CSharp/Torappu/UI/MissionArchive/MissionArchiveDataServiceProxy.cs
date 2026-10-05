using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.MissionArchive
{
	// Token: 0x02004846 RID: 18502
	[Token(Token = "0x2004846")]
	public abstract class MissionArchiveDataServiceProxy : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BF2D RID: 114477
		[Token(Token = "0x601BF2D")]
		public abstract PlayerMissionArchive LoadPlayerData(string topicId);

		// Token: 0x0601BF2E RID: 114478
		[Token(Token = "0x601BF2E")]
		public abstract void ClaimEntryReward(string topicId, Action<MissionArchiveService.IMissionArchiveClaimEntryRewardResponse> onProceed);

		// Token: 0x0601BF2F RID: 114479
		[Token(Token = "0x601BF2F")]
		public abstract void ClaimNodeReward(string topic, string nodeId, Action<MissionArchiveService.IMissionArchiveClaimNodeRewardResponse> onProceed);

		// Token: 0x0601BF30 RID: 114480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF30")]
		[Address(RVA = "0x154FEC0", Offset = "0x154EAC0", VA = "0x18154FEC0")]
		protected MissionArchiveDataServiceProxy()
		{
		}

		// Token: 0x04024726 RID: 149286
		[Token(Token = "0x4024726")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
