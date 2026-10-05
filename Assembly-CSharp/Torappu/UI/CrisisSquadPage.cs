using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B66 RID: 15206
	[Token(Token = "0x2003B66")]
	public class CrisisSquadPage : StateEnginePage
	{
		// Token: 0x06017DB9 RID: 97721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DB9")]
		[Address(RVA = "0x1011E30", Offset = "0x1010A30", VA = "0x181011E30")]
		public CrisisSquadPage()
		{
		}

		// Token: 0x0401CD1C RID: 118044
		[Token(Token = "0x401CD1C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003B67 RID: 15207
		[Token(Token = "0x2003B67")]
		public struct Params
		{
			// Token: 0x0401CD1D RID: 118045
			[Token(Token = "0x401CD1D")]
			[FieldOffset(Offset = "0x0")]
			public string runeStageId;

			// Token: 0x0401CD1E RID: 118046
			[Token(Token = "0x401CD1E")]
			[FieldOffset(Offset = "0x8")]
			public string levelId;

			// Token: 0x0401CD1F RID: 118047
			[Token(Token = "0x401CD1F")]
			[FieldOffset(Offset = "0x10")]
			public string overrideSquadSaveKey;

			// Token: 0x0401CD20 RID: 118048
			[Token(Token = "0x401CD20")]
			[FieldOffset(Offset = "0x18")]
			public List<RuneTable.PackedRuneData> selectedRunes;

			// Token: 0x0401CD21 RID: 118049
			[Token(Token = "0x401CD21")]
			[FieldOffset(Offset = "0x20")]
			public BattleStageInfo overrideStageInfo;

			// Token: 0x0401CD22 RID: 118050
			[Token(Token = "0x401CD22")]
			[FieldOffset(Offset = "0x90")]
			public string overrideBgmEvent;

			// Token: 0x0401CD23 RID: 118051
			[Token(Token = "0x401CD23")]
			[FieldOffset(Offset = "0x98")]
			public DataBundle bundleToJumpBack;

			// Token: 0x0401CD24 RID: 118052
			[Token(Token = "0x401CD24")]
			[FieldOffset(Offset = "0xA0")]
			public BattleStageMeta stageMeta;

			// Token: 0x0401CD25 RID: 118053
			[Token(Token = "0x401CD25")]
			[FieldOffset(Offset = "0xA8")]
			public BattleActivityMeta actMeta;

			// Token: 0x0401CD26 RID: 118054
			[Token(Token = "0x401CD26")]
			[FieldOffset(Offset = "0xC8")]
			public ICrisisStartBattleServiceConfig startBattleServiceConfig;

			// Token: 0x0401CD27 RID: 118055
			[Token(Token = "0x401CD27")]
			[FieldOffset(Offset = "0xD0")]
			public IFinishBattleServiceConfig finishBattleServiceConfig;

			// Token: 0x0401CD28 RID: 118056
			[Token(Token = "0x401CD28")]
			[FieldOffset(Offset = "0xD8")]
			public GameModeMeta gameModeMeta;
		}
	}
}
