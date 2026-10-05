using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B0D RID: 2829
	[Token(Token = "0x2000B0D")]
	public class PlayerReturnData
	{
		// Token: 0x060067C2 RID: 26562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067C2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerReturnData()
		{
		}

		// Token: 0x04003B3D RID: 15165
		[Token(Token = "0x4003B3D")]
		[FieldOffset(Offset = "0x10")]
		public bool open;

		// Token: 0x04003B3E RID: 15166
		[Token(Token = "0x4003B3E")]
		[FieldOffset(Offset = "0x18")]
		public PlayerReturnData.CurrentV2Data currentV2;

		// Token: 0x04003B3F RID: 15167
		[Token(Token = "0x4003B3F")]
		[FieldOffset(Offset = "0x20")]
		public PlayerReturnData.Version version;

		// Token: 0x02000B0E RID: 2830
		[Token(Token = "0x2000B0E")]
		public enum Version
		{
			// Token: 0x04003B41 RID: 15169
			[Token(Token = "0x4003B41")]
			OLD,
			// Token: 0x04003B42 RID: 15170
			[Token(Token = "0x4003B42")]
			NEW
		}

		// Token: 0x02000B0F RID: 2831
		[Token(Token = "0x2000B0F")]
		public class CurrentV2Data
		{
			// Token: 0x060067C3 RID: 26563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067C3")]
			[Address(RVA = "0x1EE8F70", Offset = "0x1EE7B70", VA = "0x181EE8F70")]
			public CurrentV2Data()
			{
			}

			// Token: 0x04003B43 RID: 15171
			[Token(Token = "0x4003B43")]
			[FieldOffset(Offset = "0x10")]
			public long start;

			// Token: 0x04003B44 RID: 15172
			[Token(Token = "0x4003B44")]
			[FieldOffset(Offset = "0x18")]
			public long finishTs;

			// Token: 0x04003B45 RID: 15173
			[Token(Token = "0x4003B45")]
			[FieldOffset(Offset = "0x20")]
			public long lastOnlineTs;

			// Token: 0x04003B46 RID: 15174
			[Token(Token = "0x4003B46")]
			[FieldOffset(Offset = "0x28")]
			public string groupId;

			// Token: 0x04003B47 RID: 15175
			[Token(Token = "0x4003B47")]
			[FieldOffset(Offset = "0x30")]
			public PlayerReturnData.CheckInV2 checkIn;

			// Token: 0x04003B48 RID: 15176
			[Token(Token = "0x4003B48")]
			[FieldOffset(Offset = "0x38")]
			public PlayerReturnData.FullOpen fullOpen;

			// Token: 0x04003B49 RID: 15177
			[Token(Token = "0x4003B49")]
			[FieldOffset(Offset = "0x40")]
			public PlayerReturnData.CampaignFullOpen campaignFullOpen;

			// Token: 0x04003B4A RID: 15178
			[Token(Token = "0x4003B4A")]
			[FieldOffset(Offset = "0x48")]
			public PlayerReturnData.Gacha gacha;

			// Token: 0x04003B4B RID: 15179
			[Token(Token = "0x4003B4B")]
			[FieldOffset(Offset = "0x50")]
			public PlayerReturnData.MissionV2 mission;

			// Token: 0x04003B4C RID: 15180
			[Token(Token = "0x4003B4C")]
			[FieldOffset(Offset = "0x58")]
			[JsonProperty(PropertyName = "reward")]
			public bool hasOnceRewardGot;

			// Token: 0x04003B4D RID: 15181
			[Token(Token = "0x4003B4D")]
			[FieldOffset(Offset = "0x60")]
			public PlayerReturnData.GiftPackData backGiftPack;

			// Token: 0x04003B4E RID: 15182
			[Token(Token = "0x4003B4E")]
			[FieldOffset(Offset = "0x68")]
			[JsonProperty(PropertyName = "cumulativeLoginPack")]
			public PlayerReturnData.LoginPackData loginPack;
		}

		// Token: 0x02000B10 RID: 2832
		[Token(Token = "0x2000B10")]
		public class GiftPackData
		{
			// Token: 0x060067C4 RID: 26564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067C4")]
			[Address(RVA = "0x1EEAC30", Offset = "0x1EE9830", VA = "0x181EEAC30")]
			public GiftPackData()
			{
			}

			// Token: 0x04003B4F RID: 15183
			[Token(Token = "0x4003B4F")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, PlayerReturnData.GiftPackItemData> packs;
		}

		// Token: 0x02000B11 RID: 2833
		[Token(Token = "0x2000B11")]
		public class GiftPackItemData
		{
			// Token: 0x060067C5 RID: 26565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067C5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GiftPackItemData()
			{
			}

			// Token: 0x04003B50 RID: 15184
			[Token(Token = "0x4003B50")]
			[FieldOffset(Offset = "0x10")]
			public int boughtCount;

			// Token: 0x04003B51 RID: 15185
			[Token(Token = "0x4003B51")]
			[FieldOffset(Offset = "0x18")]
			public long saleEndAt;
		}

		// Token: 0x02000B12 RID: 2834
		[Token(Token = "0x2000B12")]
		public class LoginPackData
		{
			// Token: 0x060067C6 RID: 26566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067C6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LoginPackData()
			{
			}

			// Token: 0x04003B52 RID: 15186
			[Token(Token = "0x4003B52")]
			[FieldOffset(Offset = "0x10")]
			public bool hasBought;

			// Token: 0x04003B53 RID: 15187
			[Token(Token = "0x4003B53")]
			[FieldOffset(Offset = "0x18")]
			public string groupId;

			// Token: 0x04003B54 RID: 15188
			[Token(Token = "0x4003B54")]
			[FieldOffset(Offset = "0x20")]
			public int loginRecord;

			// Token: 0x04003B55 RID: 15189
			[Token(Token = "0x4003B55")]
			[FieldOffset(Offset = "0x24")]
			public int recvStage;

			// Token: 0x04003B56 RID: 15190
			[Token(Token = "0x4003B56")]
			[FieldOffset(Offset = "0x28")]
			public long checkinFinTs;

			// Token: 0x04003B57 RID: 15191
			[Token(Token = "0x4003B57")]
			[FieldOffset(Offset = "0x30")]
			public long gpSaleEndAt;
		}

		// Token: 0x02000B13 RID: 2835
		[Token(Token = "0x2000B13")]
		public class MissionV2
		{
			// Token: 0x060067C7 RID: 26567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067C7")]
			[Address(RVA = "0x1EEC2D0", Offset = "0x1EEAED0", VA = "0x181EEC2D0")]
			public MissionV2()
			{
			}

			// Token: 0x04003B58 RID: 15192
			[Token(Token = "0x4003B58")]
			[FieldOffset(Offset = "0x10")]
			public int point;

			// Token: 0x04003B59 RID: 15193
			[Token(Token = "0x4003B59")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty(PropertyName = "stageAwardSt")]
			public List<int> stageAward;

			// Token: 0x04003B5A RID: 15194
			[Token(Token = "0x4003B5A")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty(PropertyName = "dailySupplySt")]
			public List<int> dailySupply;

			// Token: 0x04003B5B RID: 15195
			[Token(Token = "0x4003B5B")]
			[FieldOffset(Offset = "0x28")]
			[JsonProperty(PropertyName = "long")]
			public Dictionary<string, List<PlayerReturnData.MissionV2Data>> longMission;

			// Token: 0x04003B5C RID: 15196
			[Token(Token = "0x4003B5C")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty(PropertyName = "daily")]
			public Dictionary<string, List<PlayerReturnData.MissionV2Data>> dailyMission;
		}

		// Token: 0x02000B14 RID: 2836
		[Token(Token = "0x2000B14")]
		public class MissionV2Data
		{
			// Token: 0x060067C8 RID: 26568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067C8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MissionV2Data()
			{
			}

			// Token: 0x04003B5D RID: 15197
			[Token(Token = "0x4003B5D")]
			[FieldOffset(Offset = "0x10")]
			public string missionId;

			// Token: 0x04003B5E RID: 15198
			[Token(Token = "0x4003B5E")]
			[FieldOffset(Offset = "0x18")]
			public int current;

			// Token: 0x04003B5F RID: 15199
			[Token(Token = "0x4003B5F")]
			[FieldOffset(Offset = "0x1C")]
			public int target;

			// Token: 0x04003B60 RID: 15200
			[Token(Token = "0x4003B60")]
			[FieldOffset(Offset = "0x20")]
			public int status;
		}

		// Token: 0x02000B15 RID: 2837
		[Token(Token = "0x2000B15")]
		public class CheckInV2
		{
			// Token: 0x060067C9 RID: 26569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067C9")]
			[Address(RVA = "0x1EE79C0", Offset = "0x1EE65C0", VA = "0x181EE79C0")]
			public CheckInV2()
			{
			}

			// Token: 0x04003B61 RID: 15201
			[Token(Token = "0x4003B61")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x04003B62 RID: 15202
			[Token(Token = "0x4003B62")]
			[FieldOffset(Offset = "0x18")]
			public List<int> history;
		}

		// Token: 0x02000B16 RID: 2838
		[Token(Token = "0x2000B16")]
		public class FullOpen
		{
			// Token: 0x060067CA RID: 26570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067CA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FullOpen()
			{
			}

			// Token: 0x04003B63 RID: 15203
			[Token(Token = "0x4003B63")]
			[FieldOffset(Offset = "0x10")]
			public int last;

			// Token: 0x04003B64 RID: 15204
			[Token(Token = "0x4003B64")]
			[FieldOffset(Offset = "0x14")]
			public bool today;

			// Token: 0x04003B65 RID: 15205
			[Token(Token = "0x4003B65")]
			[FieldOffset(Offset = "0x18")]
			public int remain;
		}

		// Token: 0x02000B17 RID: 2839
		[Token(Token = "0x2000B17")]
		public class CampaignFullOpen
		{
			// Token: 0x060067CB RID: 26571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067CB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CampaignFullOpen()
			{
			}

			// Token: 0x04003B66 RID: 15206
			[Token(Token = "0x4003B66")]
			[FieldOffset(Offset = "0x10")]
			public bool today;

			// Token: 0x04003B67 RID: 15207
			[Token(Token = "0x4003B67")]
			[FieldOffset(Offset = "0x14")]
			public int remain;
		}

		// Token: 0x02000B18 RID: 2840
		[Token(Token = "0x2000B18")]
		public class Gacha
		{
			// Token: 0x060067CC RID: 26572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067CC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Gacha()
			{
			}

			// Token: 0x04003B68 RID: 15208
			[Token(Token = "0x4003B68")]
			[FieldOffset(Offset = "0x10")]
			public string poolId;

			// Token: 0x04003B69 RID: 15209
			[Token(Token = "0x4003B69")]
			[FieldOffset(Offset = "0x18")]
			public long endTs;
		}
	}
}
