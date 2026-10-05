using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.CharWord
{
	// Token: 0x0200178B RID: 6027
	[Token(Token = "0x200178B")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class FestivalVoiceUtil
	{
		// Token: 0x06009831 RID: 38961 RVA: 0x0003B2E0 File Offset: 0x000394E0
		[Token(Token = "0x6009831")]
		[Address(RVA = "0x31246C0", Offset = "0x31232C0", VA = "0x1831246C0")]
		public static CharWordShowType LoadRandomVoiceShowType(VoiceQuery query, CharWordShowType defaultShowType)
		{
			return CharWordShowType.HOME_SHOW;
		}

		// Token: 0x06009832 RID: 38962 RVA: 0x0003B2F8 File Offset: 0x000394F8
		[Token(Token = "0x6009832")]
		[Address(RVA = "0x3124450", Offset = "0x3123050", VA = "0x183124450")]
		public static bool CheckIsFesShowTypeAndInvalid(CharWordShowType showType)
		{
			return default(bool);
		}

		// Token: 0x06009833 RID: 38963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009833")]
		[Address(RVA = "0x3124FC0", Offset = "0x3123BC0", VA = "0x183124FC0")]
		private static List<FestivalVoiceWeightData> _LoadValidFesVoiceWeight()
		{
			return null;
		}

		// Token: 0x06009834 RID: 38964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009834")]
		[Address(RVA = "0x3124D90", Offset = "0x3123990", VA = "0x183124D90")]
		private static List<CharWordShowType> _LoadValidFesShowType()
		{
			return null;
		}

		// Token: 0x06009835 RID: 38965 RVA: 0x0003B310 File Offset: 0x00039510
		[Token(Token = "0x6009835")]
		[Address(RVA = "0x3124BE0", Offset = "0x31237E0", VA = "0x183124BE0")]
		private static bool _IsValidFesVoice(FestivalVoiceData fesData)
		{
			return default(bool);
		}

		// Token: 0x06009836 RID: 38966 RVA: 0x0003B328 File Offset: 0x00039528
		[Token(Token = "0x6009836")]
		[Address(RVA = "0x31248A0", Offset = "0x31234A0", VA = "0x1831248A0")]
		private static bool _CheckIsRewardBirthday(long timeStamp)
		{
			return default(bool);
		}

		// Token: 0x06009837 RID: 38967 RVA: 0x0003B340 File Offset: 0x00039540
		[Token(Token = "0x6009837")]
		[Address(RVA = "0x31249E0", Offset = "0x31235E0", VA = "0x1831249E0")]
		private static bool _CheckTimeValid(long validTs, FestivalTimeData timeData)
		{
			return default(bool);
		}

		// Token: 0x04008E1A RID: 36378
		[Token(Token = "0x4008E1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadRandomVoiceShowType;

		// Token: 0x04008E1B RID: 36379
		[Token(Token = "0x4008E1B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIsFesShowTypeAndInvalid;

		// Token: 0x04008E1C RID: 36380
		[Token(Token = "0x4008E1C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadValidFesVoiceWeight;

		// Token: 0x04008E1D RID: 36381
		[Token(Token = "0x4008E1D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadValidFesShowType;

		// Token: 0x04008E1E RID: 36382
		[Token(Token = "0x4008E1E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__IsValidFesVoice;

		// Token: 0x04008E1F RID: 36383
		[Token(Token = "0x4008E1F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckIsRewardBirthday;

		// Token: 0x04008E20 RID: 36384
		[Token(Token = "0x4008E20")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckTimeValid;
	}
}
