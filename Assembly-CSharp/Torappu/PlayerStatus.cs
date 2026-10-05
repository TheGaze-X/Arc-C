using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Torappu.UI;
using XLua;

namespace Torappu
{
	// Token: 0x020008E5 RID: 2277
	[Token(Token = "0x20008E5")]
	public class PlayerStatus : IHotfixable, IPlayerStatus
	{
		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x0600659A RID: 26010 RVA: 0x00030750 File Offset: 0x0002E950
		[Token(Token = "0x17000CE1")]
		[JsonIgnore]
		public int diamond
		{
			[Token(Token = "0x600659A")]
			[Address(RVA = "0x1EFF590", Offset = "0x1EFE190", VA = "0x181EFF590")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600659B RID: 26011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600659B")]
		[Address(RVA = "0x1EFF120", Offset = "0x1EFDD20", VA = "0x181EFF120")]
		public string GetNickNameWithNumber()
		{
			return null;
		}

		// Token: 0x0600659C RID: 26012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600659C")]
		[Address(RVA = "0x1EFF0C0", Offset = "0x1EFDCC0", VA = "0x181EFF0C0", Slot = "4")]
		public AvatarInfo GetAvatarInfo()
		{
			return null;
		}

		// Token: 0x0600659D RID: 26013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600659D")]
		[Address(RVA = "0x1EFF1D0", Offset = "0x1EFDDD0", VA = "0x181EFF1D0", Slot = "5")]
		public string GetSecretarySkinId()
		{
			return null;
		}

		// Token: 0x0600659E RID: 26014 RVA: 0x00030768 File Offset: 0x0002E968
		[Token(Token = "0x600659E")]
		[Address(RVA = "0x1EFF230", Offset = "0x1EFDE30", VA = "0x181EFF230", Slot = "6")]
		public bool GetSecretarySkinSp()
		{
			return default(bool);
		}

		// Token: 0x0600659F RID: 26015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600659F")]
		[Address(RVA = "0x1EFF290", Offset = "0x1EFDE90", VA = "0x181EFF290")]
		public PlayerStatus()
		{
		}

		// Token: 0x040032F7 RID: 13047
		[Token(Token = "0x40032F7")]
		[FieldOffset(Offset = "0x10")]
		public string nickName;

		// Token: 0x040032F8 RID: 13048
		[Token(Token = "0x40032F8")]
		[FieldOffset(Offset = "0x18")]
		public string nickNumber;

		// Token: 0x040032F9 RID: 13049
		[Token(Token = "0x40032F9")]
		[FieldOffset(Offset = "0x20")]
		public string serverName;

		// Token: 0x040032FA RID: 13050
		[Token(Token = "0x40032FA")]
		[FieldOffset(Offset = "0x28")]
		public int ap;

		// Token: 0x040032FB RID: 13051
		[Token(Token = "0x40032FB")]
		[FieldOffset(Offset = "0x30")]
		public DateTime lastApAddTime;

		// Token: 0x040032FC RID: 13052
		[Token(Token = "0x40032FC")]
		[FieldOffset(Offset = "0x38")]
		public DateTime lastRefreshTs;

		// Token: 0x040032FD RID: 13053
		[Token(Token = "0x40032FD")]
		[FieldOffset(Offset = "0x40")]
		public DateTime lastOnlineTs;

		// Token: 0x040032FE RID: 13054
		[Token(Token = "0x40032FE")]
		[FieldOffset(Offset = "0x48")]
		public int level;

		// Token: 0x040032FF RID: 13055
		[Token(Token = "0x40032FF")]
		[FieldOffset(Offset = "0x4C")]
		public int exp;

		// Token: 0x04003300 RID: 13056
		[Token(Token = "0x4003300")]
		[FieldOffset(Offset = "0x50")]
		public int maxAp;

		// Token: 0x04003301 RID: 13057
		[Token(Token = "0x4003301")]
		[FieldOffset(Offset = "0x54")]
		public int practiceTicket;

		// Token: 0x04003302 RID: 13058
		[Token(Token = "0x4003302")]
		[FieldOffset(Offset = "0x58")]
		public long gold;

		// Token: 0x04003303 RID: 13059
		[Token(Token = "0x4003303")]
		[FieldOffset(Offset = "0x60")]
		public int diamondShard;

		// Token: 0x04003304 RID: 13060
		[Token(Token = "0x4003304")]
		[FieldOffset(Offset = "0x64")]
		public int recruitLicense;

		// Token: 0x04003305 RID: 13061
		[Token(Token = "0x4003305")]
		[FieldOffset(Offset = "0x68")]
		public int gachaTicket;

		// Token: 0x04003306 RID: 13062
		[Token(Token = "0x4003306")]
		[FieldOffset(Offset = "0x6C")]
		public int tenGachaTicket;

		// Token: 0x04003307 RID: 13063
		[Token(Token = "0x4003307")]
		[FieldOffset(Offset = "0x70")]
		public int instantFinishTicket;

		// Token: 0x04003308 RID: 13064
		[Token(Token = "0x4003308")]
		[FieldOffset(Offset = "0x74")]
		public int hggShard;

		// Token: 0x04003309 RID: 13065
		[Token(Token = "0x4003309")]
		[FieldOffset(Offset = "0x78")]
		public int lggShard;

		// Token: 0x0400330A RID: 13066
		[Token(Token = "0x400330A")]
		[FieldOffset(Offset = "0x7C")]
		public int classicShard;

		// Token: 0x0400330B RID: 13067
		[Token(Token = "0x400330B")]
		[FieldOffset(Offset = "0x80")]
		public int socialPoint;

		// Token: 0x0400330C RID: 13068
		[Token(Token = "0x400330C")]
		[FieldOffset(Offset = "0x84")]
		public int buyApRemainTimes;

		// Token: 0x0400330D RID: 13069
		[Token(Token = "0x400330D")]
		[FieldOffset(Offset = "0x88")]
		public bool apLimitUpFlag;

		// Token: 0x0400330E RID: 13070
		[Token(Token = "0x400330E")]
		[FieldOffset(Offset = "0x8C")]
		public int classicGachaTicket;

		// Token: 0x0400330F RID: 13071
		[Token(Token = "0x400330F")]
		[FieldOffset(Offset = "0x90")]
		public int classicTenGachaTicket;

		// Token: 0x04003310 RID: 13072
		[Token(Token = "0x4003310")]
		[FieldOffset(Offset = "0x98")]
		public long registerTs;

		// Token: 0x04003311 RID: 13073
		[Token(Token = "0x4003311")]
		[FieldOffset(Offset = "0xA0")]
		public string secretary;

		// Token: 0x04003312 RID: 13074
		[Token(Token = "0x4003312")]
		[FieldOffset(Offset = "0xA8")]
		public string secretarySkinId;

		// Token: 0x04003313 RID: 13075
		[Token(Token = "0x4003313")]
		[FieldOffset(Offset = "0xB0")]
		public bool secretarySkinSp;

		// Token: 0x04003314 RID: 13076
		[Token(Token = "0x4003314")]
		[FieldOffset(Offset = "0xB8")]
		public string resume;

		// Token: 0x04003315 RID: 13077
		[Token(Token = "0x4003315")]
		[FieldOffset(Offset = "0xC0")]
		public PlayerBirthday birthday;

		// Token: 0x04003316 RID: 13078
		[Token(Token = "0x4003316")]
		[FieldOffset(Offset = "0xC8")]
		public DateTime monthlySubscriptionEndTime;

		// Token: 0x04003317 RID: 13079
		[Token(Token = "0x4003317")]
		[FieldOffset(Offset = "0xD0")]
		public DateTime monthlySubscriptionStartTime;

		// Token: 0x04003318 RID: 13080
		[Token(Token = "0x4003318")]
		[FieldOffset(Offset = "0xD8")]
		public int progress;

		// Token: 0x04003319 RID: 13081
		[Token(Token = "0x4003319")]
		[FieldOffset(Offset = "0xE0")]
		public string mainStageProgress;

		// Token: 0x0400331A RID: 13082
		[Token(Token = "0x400331A")]
		[FieldOffset(Offset = "0xE8")]
		public AvatarInfo avatar;

		// Token: 0x0400331B RID: 13083
		[Token(Token = "0x400331B")]
		[FieldOffset(Offset = "0xF0")]
		public VoiceLangType globalVoiceLan;

		// Token: 0x0400331C RID: 13084
		[Token(Token = "0x400331C")]
		[FieldOffset(Offset = "0xF4")]
		public int iosDiamond;

		// Token: 0x0400331D RID: 13085
		[Token(Token = "0x400331D")]
		[FieldOffset(Offset = "0xF8")]
		public int androidDiamond;

		// Token: 0x0400331E RID: 13086
		[Token(Token = "0x400331E")]
		[FieldOffset(Offset = "0xFC")]
		public int payDiamond;

		// Token: 0x0400331F RID: 13087
		[Token(Token = "0x400331F")]
		[FieldOffset(Offset = "0x100")]
		public int freeDiamond;

		// Token: 0x04003320 RID: 13088
		[Token(Token = "0x4003320")]
		[FieldOffset(Offset = "0x108")]
		public Dictionary<string, bool> flags;

		// Token: 0x04003321 RID: 13089
		[Token(Token = "0x4003321")]
		[FieldOffset(Offset = "0x110")]
		public List<PlayerFriendAssist> friendAssist;

		// Token: 0x04003322 RID: 13090
		[Token(Token = "0x4003322")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_diamond;

		// Token: 0x04003323 RID: 13091
		[Token(Token = "0x4003323")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetNickNameWithNumber;

		// Token: 0x04003324 RID: 13092
		[Token(Token = "0x4003324")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetAvatarInfo;

		// Token: 0x04003325 RID: 13093
		[Token(Token = "0x4003325")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinId;

		// Token: 0x04003326 RID: 13094
		[Token(Token = "0x4003326")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinSp;

		// Token: 0x04003327 RID: 13095
		[Token(Token = "0x4003327")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
