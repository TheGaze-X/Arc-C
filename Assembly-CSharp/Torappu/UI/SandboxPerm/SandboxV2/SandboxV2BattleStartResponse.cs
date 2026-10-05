using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004404 RID: 17412
	[Token(Token = "0x2004404")]
	public class SandboxV2BattleStartResponse : CommonStartBattleResponse
	{
		// Token: 0x0601A9B4 RID: 108980 RVA: 0x000A2780 File Offset: 0x000A0980
		[Token(Token = "0x601A9B4")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override int GetApFailReturn()
		{
			return 0;
		}

		// Token: 0x0601A9B5 RID: 108981 RVA: 0x000A2798 File Offset: 0x000A0998
		[Token(Token = "0x601A9B5")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public override bool GetInApProtectPeriod()
		{
			return default(bool);
		}

		// Token: 0x0601A9B6 RID: 108982 RVA: 0x000A27B0 File Offset: 0x000A09B0
		[Token(Token = "0x601A9B6")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x0601A9B7 RID: 108983 RVA: 0x000A27C8 File Offset: 0x000A09C8
		[Token(Token = "0x601A9B7")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x0601A9B8 RID: 108984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9B8")]
		[Address(RVA = "0x13A8EF0", Offset = "0x13A7AF0", VA = "0x1813A8EF0")]
		public SandboxV2BattleStartResponse()
		{
		}

		// Token: 0x04021EAA RID: 138922
		[Token(Token = "0x4021EAA")]
		[FieldOffset(Offset = "0x38")]
		public bool isEnemyRush;

		// Token: 0x04021EAB RID: 138923
		[Token(Token = "0x4021EAB")]
		[FieldOffset(Offset = "0x40")]
		public List<string> extraRunes;

		// Token: 0x04021EAC RID: 138924
		[Token(Token = "0x4021EAC")]
		[FieldOffset(Offset = "0x48")]
		public List<string> lureInsect;

		// Token: 0x04021EAD RID: 138925
		[Token(Token = "0x4021EAD")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, int> shinyAnimals;

		// Token: 0x04021EAE RID: 138926
		[Token(Token = "0x4021EAE")]
		[FieldOffset(Offset = "0x58")]
		public List<string> shinyUniEnemy;
	}
}
