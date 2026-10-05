using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004407 RID: 17415
	[Token(Token = "0x2004407")]
	public class SandboxV2RacingBattleStartResponse : CommonStartBattleResponse
	{
		// Token: 0x0601A9BD RID: 108989 RVA: 0x000A27E0 File Offset: 0x000A09E0
		[Token(Token = "0x601A9BD")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x0601A9BE RID: 108990 RVA: 0x000A27F8 File Offset: 0x000A09F8
		[Token(Token = "0x601A9BE")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x0601A9BF RID: 108991 RVA: 0x000A2810 File Offset: 0x000A0A10
		[Token(Token = "0x601A9BF")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x0601A9C0 RID: 108992 RVA: 0x000A2828 File Offset: 0x000A0A28
		[Token(Token = "0x601A9C0")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x0601A9C1 RID: 108993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9C1")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public SandboxV2RacingBattleStartResponse()
		{
		}

		// Token: 0x04021EB8 RID: 138936
		[Token(Token = "0x4021EB8")]
		[FieldOffset(Offset = "0x38")]
		public string myRacer;

		// Token: 0x04021EB9 RID: 138937
		[Token(Token = "0x4021EB9")]
		[FieldOffset(Offset = "0x40")]
		public List<SandboxV2RacingBattleStartResponse.RacerInfo> racers;

		// Token: 0x04021EBA RID: 138938
		[Token(Token = "0x4021EBA")]
		[FieldOffset(Offset = "0x48")]
		public List<string> extraRunes;

		// Token: 0x02004408 RID: 17416
		[Token(Token = "0x2004408")]
		public class RacerInfo
		{
			// Token: 0x0601A9C2 RID: 108994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A9C2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RacerInfo()
			{
			}

			// Token: 0x04021EBB RID: 138939
			[Token(Token = "0x4021EBB")]
			[FieldOffset(Offset = "0x10")]
			public string inst;

			// Token: 0x04021EBC RID: 138940
			[Token(Token = "0x4021EBC")]
			[FieldOffset(Offset = "0x18")]
			public string id;

			// Token: 0x04021EBD RID: 138941
			[Token(Token = "0x4021EBD")]
			[FieldOffset(Offset = "0x20")]
			public List<int> attrib;

			// Token: 0x04021EBE RID: 138942
			[Token(Token = "0x4021EBE")]
			[FieldOffset(Offset = "0x28")]
			public SandboxV2RacingBattleStartResponse.RacerTalent skill;
		}

		// Token: 0x02004409 RID: 17417
		[Token(Token = "0x2004409")]
		public class RacerTalent
		{
			// Token: 0x0601A9C3 RID: 108995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A9C3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RacerTalent()
			{
			}

			// Token: 0x04021EBF RID: 138943
			[Token(Token = "0x4021EBF")]
			[FieldOffset(Offset = "0x10")]
			public Blackboard born;

			// Token: 0x04021EC0 RID: 138944
			[Token(Token = "0x4021EC0")]
			[FieldOffset(Offset = "0x18")]
			public Blackboard learned;
		}
	}
}
