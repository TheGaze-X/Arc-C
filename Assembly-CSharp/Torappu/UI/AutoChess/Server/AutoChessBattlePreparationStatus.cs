using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006423 RID: 25635
	[Token(Token = "0x2006423")]
	public class AutoChessBattlePreparationStatus : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EA3 RID: 151203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EA3")]
		[Address(RVA = "0x1FB0670", Offset = "0x1FAF270", VA = "0x181FB0670", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EA4 RID: 151204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EA4")]
		[Address(RVA = "0x1FB0910", Offset = "0x1FAF510", VA = "0x181FB0910")]
		public AutoChessBattlePreparationStatus()
		{
		}

		// Token: 0x040339F3 RID: 211443
		[Token(Token = "0x40339F3")]
		[FieldOffset(Offset = "0x10")]
		public int uidIndex;

		// Token: 0x040339F4 RID: 211444
		[Token(Token = "0x40339F4")]
		[FieldOffset(Offset = "0x14")]
		public int hp;

		// Token: 0x040339F5 RID: 211445
		[Token(Token = "0x40339F5")]
		[FieldOffset(Offset = "0x18")]
		public int round;

		// Token: 0x040339F6 RID: 211446
		[Token(Token = "0x40339F6")]
		[FieldOffset(Offset = "0x20")]
		public AutoChessBattleStoreInfo store;

		// Token: 0x040339F7 RID: 211447
		[Token(Token = "0x40339F7")]
		[FieldOffset(Offset = "0x28")]
		public List<AutoChessBattleCharChess> charChess;

		// Token: 0x040339F8 RID: 211448
		[Token(Token = "0x40339F8")]
		[FieldOffset(Offset = "0x30")]
		public List<AutoChessBattleEquipOrTrapChess> equipChess;

		// Token: 0x040339F9 RID: 211449
		[Token(Token = "0x40339F9")]
		[FieldOffset(Offset = "0x38")]
		public List<AutoChessBattleEquipOrTrapChess> trapChess;

		// Token: 0x040339FA RID: 211450
		[Token(Token = "0x40339FA")]
		[FieldOffset(Offset = "0x40")]
		public List<AutoChessBattleChessPosUnitInfo> positions;

		// Token: 0x040339FB RID: 211451
		[Token(Token = "0x40339FB")]
		[FieldOffset(Offset = "0x48")]
		public List<AutoChessBattleChessBondInfo> bonds;

		// Token: 0x040339FC RID: 211452
		[Token(Token = "0x40339FC")]
		[FieldOffset(Offset = "0x50")]
		public AutoChessBattleSelfChoiceInfo selfChoice;

		// Token: 0x040339FD RID: 211453
		[Token(Token = "0x40339FD")]
		[FieldOffset(Offset = "0x58")]
		public int maxDeploymentCnt;

		// Token: 0x040339FE RID: 211454
		[Token(Token = "0x40339FE")]
		[FieldOffset(Offset = "0x60")]
		public List<AutoChessBattleEffectEnemyInfo> effectEnemies;

		// Token: 0x040339FF RID: 211455
		[Token(Token = "0x40339FF")]
		[FieldOffset(Offset = "0x68")]
		public AutoChessBattlePreparationRoundAnalytics roundAnalytics;

		// Token: 0x04033A00 RID: 211456
		[Token(Token = "0x4033A00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A01 RID: 211457
		[Token(Token = "0x4033A01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
