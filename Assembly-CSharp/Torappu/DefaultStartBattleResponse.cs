using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008BB RID: 2235
	[Token(Token = "0x20008BB")]
	public class DefaultStartBattleResponse : CommonStartBattleResponse
	{
		// Token: 0x06006568 RID: 25960 RVA: 0x000306D8 File Offset: 0x0002E8D8
		[Token(Token = "0x6006568")]
		[Address(RVA = "0x926F80", Offset = "0x925B80", VA = "0x180926F80", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x06006569 RID: 25961 RVA: 0x000306F0 File Offset: 0x0002E8F0
		[Token(Token = "0x6006569")]
		[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x00030708 File Offset: 0x0002E908
		[Token(Token = "0x600656A")]
		[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x00030720 File Offset: 0x0002E920
		[Token(Token = "0x600656B")]
		[Address(RVA = "0x1793F60", Offset = "0x1792B60", VA = "0x181793F60", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656C")]
		[Address(RVA = "0x1EE8270", Offset = "0x1EE6E70", VA = "0x181EE8270")]
		public DefaultStartBattleResponse()
		{
		}

		// Token: 0x040032A6 RID: 12966
		[Token(Token = "0x40032A6")]
		[FieldOffset(Offset = "0x38")]
		public bool isApProtect;

		// Token: 0x040032A7 RID: 12967
		[Token(Token = "0x40032A7")]
		[FieldOffset(Offset = "0x3C")]
		public int apFailReturn;

		// Token: 0x040032A8 RID: 12968
		[Token(Token = "0x40032A8")]
		[FieldOffset(Offset = "0x40")]
		public bool notifyPowerScoreNotEnoughIfFailed;

		// Token: 0x040032A9 RID: 12969
		[Token(Token = "0x40032A9")]
		[FieldOffset(Offset = "0x41")]
		public bool inApProtectPeriod;
	}
}
