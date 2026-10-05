using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x0200614F RID: 24911
	[Token(Token = "0x200614F")]
	public class CampaignZoneMapStageViewModel : IHotfixable, IComparable
	{
		// Token: 0x06023F6E RID: 147310 RVA: 0x000C2820 File Offset: 0x000C0A20
		[Token(Token = "0x6023F6E")]
		[Address(RVA = "0x1EAD3F0", Offset = "0x1EABFF0", VA = "0x181EAD3F0")]
		public bool LoadData(string id, CampaignStageMapData stageMapData, long inputEndTs)
		{
			return default(bool);
		}

		// Token: 0x06023F6F RID: 147311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F6F")]
		[Address(RVA = "0x1EAD770", Offset = "0x1EAC370", VA = "0x181EAD770")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06023F70 RID: 147312 RVA: 0x000C2838 File Offset: 0x000C0A38
		[Token(Token = "0x6023F70")]
		[Address(RVA = "0x1EAD230", Offset = "0x1EABE30", VA = "0x181EAD230", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06023F71 RID: 147313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F71")]
		[Address(RVA = "0x1EAD950", Offset = "0x1EAC550", VA = "0x181EAD950")]
		public CampaignZoneMapStageViewModel()
		{
		}

		// Token: 0x04031F0E RID: 204558
		[Token(Token = "0x4031F0E")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04031F0F RID: 204559
		[Token(Token = "0x4031F0F")]
		[FieldOffset(Offset = "0x18")]
		public bool isClosed;

		// Token: 0x04031F10 RID: 204560
		[Token(Token = "0x4031F10")]
		[FieldOffset(Offset = "0x19")]
		public bool isUnlocked;

		// Token: 0x04031F11 RID: 204561
		[Token(Token = "0x4031F11")]
		[FieldOffset(Offset = "0x1A")]
		public bool isComplete;

		// Token: 0x04031F12 RID: 204562
		[Token(Token = "0x4031F12")]
		[FieldOffset(Offset = "0x1C")]
		public CampaignStageType stageType;

		// Token: 0x04031F13 RID: 204563
		[Token(Token = "0x4031F13")]
		[FieldOffset(Offset = "0x20")]
		public CampaignStateViewModel stateViewModel;

		// Token: 0x04031F14 RID: 204564
		[Token(Token = "0x4031F14")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 position;

		// Token: 0x04031F15 RID: 204565
		[Token(Token = "0x4031F15")]
		[FieldOffset(Offset = "0x30")]
		public long endTs;

		// Token: 0x04031F16 RID: 204566
		[Token(Token = "0x4031F16")]
		[FieldOffset(Offset = "0x38")]
		public bool hasUnconfirmedReward;

		// Token: 0x04031F17 RID: 204567
		[Token(Token = "0x4031F17")]
		[FieldOffset(Offset = "0x40")]
		public string unlockTip;

		// Token: 0x04031F18 RID: 204568
		[Token(Token = "0x4031F18")]
		[FieldOffset(Offset = "0x48")]
		private int m_sortId;

		// Token: 0x04031F19 RID: 204569
		[Token(Token = "0x4031F19")]
		[FieldOffset(Offset = "0x4C")]
		private int m_maxKillCount;

		// Token: 0x04031F1A RID: 204570
		[Token(Token = "0x4031F1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031F1B RID: 204571
		[Token(Token = "0x4031F1B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x04031F1C RID: 204572
		[Token(Token = "0x4031F1C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04031F1D RID: 204573
		[Token(Token = "0x4031F1D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
