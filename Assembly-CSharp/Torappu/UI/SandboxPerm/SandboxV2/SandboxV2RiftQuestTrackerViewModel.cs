using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004237 RID: 16951
	[Token(Token = "0x2004237")]
	public class SandboxV2RiftQuestTrackerViewModel : IHotfixable
	{
		// Token: 0x17003E25 RID: 15909
		// (get) Token: 0x0601A224 RID: 107044 RVA: 0x000A05C0 File Offset: 0x0009E7C0
		[Token(Token = "0x17003E25")]
		public int enterSeq
		{
			[Token(Token = "0x601A224")]
			[Address(RVA = "0x1310B80", Offset = "0x130F780", VA = "0x181310B80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601A225 RID: 107045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A225")]
		[Address(RVA = "0x130FCC0", Offset = "0x130E8C0", VA = "0x18130FCC0")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x0601A226 RID: 107046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A226")]
		[Address(RVA = "0x130FF40", Offset = "0x130EB40", VA = "0x18130FF40")]
		public void NotifyEnterSeq()
		{
		}

		// Token: 0x0601A227 RID: 107047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A227")]
		[Address(RVA = "0x13100B0", Offset = "0x130ECB0", VA = "0x1813100B0")]
		private void _LoadMainTargetPart(SandboxV2Data gameData, List<string> fixFinish, PlayerSandboxV2.RiftInfo.Reservation riftReservation, PlayerSandboxV2.RiftInfo.GameInfo riftGameInfo)
		{
		}

		// Token: 0x0601A228 RID: 107048 RVA: 0x000A05D8 File Offset: 0x0009E7D8
		[Token(Token = "0x601A228")]
		[Address(RVA = "0x130FFA0", Offset = "0x130EBA0", VA = "0x18130FFA0")]
		private SandboxV2DungeonMiscRiftMainMissionState _GetMainMissionState(PlayerSandboxV2.RiftInfo.GameInfo playerRiftGameInfo)
		{
			return SandboxV2DungeonMiscRiftMainMissionState.FAIL;
		}

		// Token: 0x0601A229 RID: 107049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A229")]
		[Address(RVA = "0x13107C0", Offset = "0x130F3C0", VA = "0x1813107C0")]
		private void _LoadSubTargetPart(SandboxV2Data gameData, PlayerSandboxV2.RiftInfo.Reservation riftReservation, PlayerSandboxV2.RiftInfo.GameInfo riftGameInfo)
		{
		}

		// Token: 0x0601A22A RID: 107050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A22A")]
		[Address(RVA = "0x1310A90", Offset = "0x130F690", VA = "0x181310A90")]
		public SandboxV2RiftQuestTrackerViewModel()
		{
		}

		// Token: 0x04020FF4 RID: 135156
		[Token(Token = "0x4020FF4")]
		[FieldOffset(Offset = "0x10")]
		public string mainTitlePrefix;

		// Token: 0x04020FF5 RID: 135157
		[Token(Token = "0x4020FF5")]
		[FieldOffset(Offset = "0x18")]
		public string mainTitle;

		// Token: 0x04020FF6 RID: 135158
		[Token(Token = "0x4020FF6")]
		[FieldOffset(Offset = "0x20")]
		public string mainStoryDesc;

		// Token: 0x04020FF7 RID: 135159
		[Token(Token = "0x4020FF7")]
		[FieldOffset(Offset = "0x28")]
		public string mainTargetDesc;

		// Token: 0x04020FF8 RID: 135160
		[Token(Token = "0x4020FF8")]
		[FieldOffset(Offset = "0x30")]
		public SandboxV2DungeonMiscRiftMainMissionState mainMissionState;

		// Token: 0x04020FF9 RID: 135161
		[Token(Token = "0x4020FF9")]
		[FieldOffset(Offset = "0x34")]
		public int mainTargetProgress;

		// Token: 0x04020FFA RID: 135162
		[Token(Token = "0x4020FFA")]
		[FieldOffset(Offset = "0x38")]
		public int mainTargetTotal;

		// Token: 0x04020FFB RID: 135163
		[Token(Token = "0x4020FFB")]
		[FieldOffset(Offset = "0x40")]
		public List<UIItemViewModel> mainTargetRewards;

		// Token: 0x04020FFC RID: 135164
		[Token(Token = "0x4020FFC")]
		[FieldOffset(Offset = "0x48")]
		public bool hasSubTarget;

		// Token: 0x04020FFD RID: 135165
		[Token(Token = "0x4020FFD")]
		[FieldOffset(Offset = "0x50")]
		public string subTargetName;

		// Token: 0x04020FFE RID: 135166
		[Token(Token = "0x4020FFE")]
		[FieldOffset(Offset = "0x58")]
		public string subTargetDesc;

		// Token: 0x04020FFF RID: 135167
		[Token(Token = "0x4020FFF")]
		[FieldOffset(Offset = "0x60")]
		public int subTargetProgress;

		// Token: 0x04021000 RID: 135168
		[Token(Token = "0x4021000")]
		[FieldOffset(Offset = "0x64")]
		public int subTargetTotal;

		// Token: 0x04021001 RID: 135169
		[Token(Token = "0x4021001")]
		[FieldOffset(Offset = "0x68")]
		public bool isSubTargetComplete;

		// Token: 0x04021002 RID: 135170
		[Token(Token = "0x4021002")]
		[FieldOffset(Offset = "0x70")]
		public List<UIItemViewModel> subTargetRewards;

		// Token: 0x04021003 RID: 135171
		[Token(Token = "0x4021003")]
		[FieldOffset(Offset = "0x78")]
		private string m_riftId;

		// Token: 0x04021004 RID: 135172
		[Token(Token = "0x4021004")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isRandomRift;

		// Token: 0x04021005 RID: 135173
		[Token(Token = "0x4021005")]
		[FieldOffset(Offset = "0x81")]
		private bool m_isPreyRift;

		// Token: 0x04021006 RID: 135174
		[Token(Token = "0x4021006")]
		[FieldOffset(Offset = "0x84")]
		private int m_enterSeq;

		// Token: 0x04021007 RID: 135175
		[Token(Token = "0x4021007")]
		private const int DEFAULT_ITEM_COUNT_FOR_DISPLAY = 1;

		// Token: 0x04021008 RID: 135176
		[Token(Token = "0x4021008")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_enterSeq;

		// Token: 0x04021009 RID: 135177
		[Token(Token = "0x4021009")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402100A RID: 135178
		[Token(Token = "0x402100A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_NotifyEnterSeq;

		// Token: 0x0402100B RID: 135179
		[Token(Token = "0x402100B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadMainTargetPart;

		// Token: 0x0402100C RID: 135180
		[Token(Token = "0x402100C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetMainMissionState;

		// Token: 0x0402100D RID: 135181
		[Token(Token = "0x402100D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadSubTargetPart;

		// Token: 0x0402100E RID: 135182
		[Token(Token = "0x402100E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
