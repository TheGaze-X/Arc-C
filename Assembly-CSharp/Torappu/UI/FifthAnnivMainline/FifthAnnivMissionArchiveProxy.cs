using System;
using Il2CppDummyDll;
using Torappu.UI.MissionArchive;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F08 RID: 20232
	[Token(Token = "0x2004F08")]
	public class FifthAnnivMissionArchiveProxy : MissionArchiveDataServiceProxy
	{
		// Token: 0x0601E292 RID: 123538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E292")]
		[Address(RVA = "0x17DCD00", Offset = "0x17DB900", VA = "0x1817DCD00", Slot = "4")]
		public override PlayerMissionArchive LoadPlayerData(string topicId)
		{
			return null;
		}

		// Token: 0x0601E293 RID: 123539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E293")]
		[Address(RVA = "0x17DC860", Offset = "0x17DB460", VA = "0x1817DC860", Slot = "5")]
		public override void ClaimEntryReward(string topicId, Action<MissionArchiveService.IMissionArchiveClaimEntryRewardResponse> onProceed)
		{
		}

		// Token: 0x0601E294 RID: 123540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E294")]
		[Address(RVA = "0x17DCAA0", Offset = "0x17DB6A0", VA = "0x1817DCAA0", Slot = "6")]
		public override void ClaimNodeReward(string topicId, string nodeId, Action<MissionArchiveService.IMissionArchiveClaimNodeRewardResponse> onProceed)
		{
		}

		// Token: 0x0601E295 RID: 123541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E295")]
		[Address(RVA = "0x17DCDE0", Offset = "0x17DB9E0", VA = "0x1817DCDE0")]
		public FifthAnnivMissionArchiveProxy()
		{
		}

		// Token: 0x04028264 RID: 164452
		[Token(Token = "0x4028264")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadPlayerData;

		// Token: 0x04028265 RID: 164453
		[Token(Token = "0x4028265")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ClaimEntryReward;

		// Token: 0x04028266 RID: 164454
		[Token(Token = "0x4028266")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClaimNodeReward;

		// Token: 0x04028267 RID: 164455
		[Token(Token = "0x4028267")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
