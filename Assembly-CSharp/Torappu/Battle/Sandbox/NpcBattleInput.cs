using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A7A RID: 10874
	[Token(Token = "0x2002A7A")]
	[Serializable]
	public class NpcBattleInput : IHotfixable
	{
		// Token: 0x06012122 RID: 74018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012122")]
		[Address(RVA = "0xA27900", Offset = "0xA26500", VA = "0x180A27900")]
		public NpcBattleInput()
		{
		}

		// Token: 0x040146D4 RID: 83668
		[Token(Token = "0x40146D4")]
		[FieldOffset(Offset = "0x10")]
		public string npcId;

		// Token: 0x040146D5 RID: 83669
		[Token(Token = "0x40146D5")]
		[FieldOffset(Offset = "0x18")]
		public string trapId;

		// Token: 0x040146D6 RID: 83670
		[Token(Token = "0x40146D6")]
		[FieldOffset(Offset = "0x20")]
		public SharedConsts.Direction dir;

		// Token: 0x040146D7 RID: 83671
		[Token(Token = "0x40146D7")]
		[FieldOffset(Offset = "0x24")]
		public int reactSkillIndex;

		// Token: 0x040146D8 RID: 83672
		[Token(Token = "0x40146D8")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<BattleDialogType, NpcBattleInput.NpcBattleDialogInput> dialogData;

		// Token: 0x040146D9 RID: 83673
		[Token(Token = "0x40146D9")]
		[FieldOffset(Offset = "0x30")]
		public GridPosition pos;

		// Token: 0x040146DA RID: 83674
		[Token(Token = "0x40146DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A7B RID: 10875
		[Token(Token = "0x2002A7B")]
		[Serializable]
		public class NpcBattleDialogInput : IHotfixable
		{
			// Token: 0x06012123 RID: 74019 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012123")]
			[Address(RVA = "0xA278A0", Offset = "0xA264A0", VA = "0x180A278A0")]
			public NpcBattleDialogInput()
			{
			}

			// Token: 0x040146DB RID: 83675
			[Token(Token = "0x40146DB")]
			[FieldOffset(Offset = "0x10")]
			public string signal;

			// Token: 0x040146DC RID: 83676
			[Token(Token = "0x40146DC")]
			[FieldOffset(Offset = "0x18")]
			public List<SandboxItemPair> gacha;

			// Token: 0x040146DD RID: 83677
			[Token(Token = "0x40146DD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
