using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B68 RID: 15208
	[Token(Token = "0x2003B68")]
	public class RuneSquadPageV1 : StateEnginePage
	{
		// Token: 0x06017DBA RID: 97722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DBA")]
		[Address(RVA = "0x1017310", Offset = "0x1015F10", VA = "0x181017310")]
		public RuneSquadPageV1()
		{
		}

		// Token: 0x0401CD29 RID: 118057
		[Token(Token = "0x401CD29")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003B69 RID: 15209
		[Token(Token = "0x2003B69")]
		public struct Params
		{
			// Token: 0x0401CD2A RID: 118058
			[Token(Token = "0x401CD2A")]
			[FieldOffset(Offset = "0x0")]
			public string runeStageId;

			// Token: 0x0401CD2B RID: 118059
			[Token(Token = "0x401CD2B")]
			[FieldOffset(Offset = "0x8")]
			public string levelId;

			// Token: 0x0401CD2C RID: 118060
			[Token(Token = "0x401CD2C")]
			[FieldOffset(Offset = "0x10")]
			public List<RuneTable.PackedRuneData> selectedRunes;

			// Token: 0x0401CD2D RID: 118061
			[Token(Token = "0x401CD2D")]
			[FieldOffset(Offset = "0x18")]
			public BattleStageInfo overrideStageInfo;

			// Token: 0x0401CD2E RID: 118062
			[Token(Token = "0x401CD2E")]
			[FieldOffset(Offset = "0x88")]
			public BattleActivityMeta actMeta;

			// Token: 0x0401CD2F RID: 118063
			[Token(Token = "0x401CD2F")]
			[FieldOffset(Offset = "0xA8")]
			public DataBundle bundleToJumpBack;
		}
	}
}
