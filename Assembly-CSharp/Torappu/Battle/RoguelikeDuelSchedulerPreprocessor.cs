using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.Roguelike;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200240A RID: 9226
	[Token(Token = "0x200240A")]
	public class RoguelikeDuelSchedulerPreprocessor : Roguelike2SchedulerPreprocessor
	{
		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x0600EBD6 RID: 60374 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EBD7 RID: 60375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001E26")]
		protected Dictionary<RoguelikeSchedulerPreprocessor.RandomGroupKey, List<RoguelikeSchedulerPreprocessor.RandomActionPtr>> randomActionGroups_2
		{
			[Token(Token = "0x600EBD6")]
			[Address(RVA = "0x622ED0", Offset = "0x621AD0", VA = "0x180622ED0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600EBD7")]
			[Address(RVA = "0x623000", Offset = "0x621C00", VA = "0x180623000")]
			set
			{
			}
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x0600EBD8 RID: 60376 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EBD9 RID: 60377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001E27")]
		protected PriorityQueue<RoguelikeSchedulerPreprocessor.RandomActionPtr> actionsToDelete_2
		{
			[Token(Token = "0x600EBD8")]
			[Address(RVA = "0x622E20", Offset = "0x621A20", VA = "0x180622E20")]
			get
			{
				return null;
			}
			[Token(Token = "0x600EBD9")]
			[Address(RVA = "0x622F80", Offset = "0x621B80", VA = "0x180622F80")]
			set
			{
			}
		}

		// Token: 0x0600EBDA RID: 60378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBDA")]
		[Address(RVA = "0x622CA0", Offset = "0x6218A0", VA = "0x180622CA0")]
		public RoguelikeDuelSchedulerPreprocessor(RoguelikeInput input, GameModeFactory.RoguelikeGameMode gameMode)
		{
		}

		// Token: 0x0600EBDB RID: 60379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBDB")]
		[Address(RVA = "0x621F30", Offset = "0x620B30", VA = "0x180621F30", Slot = "5")]
		public override void DoPreprocess(LevelData levelData)
		{
		}

		// Token: 0x0600EBDC RID: 60380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBDC")]
		[Address(RVA = "0x621E50", Offset = "0x620A50", VA = "0x180621E50", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x0600EBDD RID: 60381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBDD")]
		[Address(RVA = "0x622C90", Offset = "0x621890", VA = "0x180622C90")]
		private void <>xLuaBaseProxy_DoPreprocess(LevelData P0)
		{
		}

		// Token: 0x0600EBDE RID: 60382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBDE")]
		[Address(RVA = "0x622C80", Offset = "0x621880", VA = "0x180622C80")]
		private void <>xLuaBaseProxy_Dispose()
		{
		}

		// Token: 0x0401049F RID: 66719
		[Token(Token = "0x401049F")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<RoguelikeSchedulerPreprocessor.RandomGroupKey, List<RoguelikeSchedulerPreprocessor.RandomActionPtr>> m_randomActionGroups;

		// Token: 0x040104A0 RID: 66720
		[Token(Token = "0x40104A0")]
		[FieldOffset(Offset = "0x78")]
		private PriorityQueue<RoguelikeSchedulerPreprocessor.RandomActionPtr> m_actionsToDelete;

		// Token: 0x040104A1 RID: 66721
		[Token(Token = "0x40104A1")]
		[FieldOffset(Offset = "0x80")]
		private List<List<int>> m_fragmentEnemiesAppeared;

		// Token: 0x040104A2 RID: 66722
		[Token(Token = "0x40104A2")]
		private const int MAX_RANDOM_COUNT = 100;

		// Token: 0x040104A3 RID: 66723
		[Token(Token = "0x40104A3")]
		private const int MAX_GROUP_NUM = 6;

		// Token: 0x040104A4 RID: 66724
		[Token(Token = "0x40104A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_randomActionGroups_2;

		// Token: 0x040104A5 RID: 66725
		[Token(Token = "0x40104A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_randomActionGroups_2;

		// Token: 0x040104A6 RID: 66726
		[Token(Token = "0x40104A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_actionsToDelete_2;

		// Token: 0x040104A7 RID: 66727
		[Token(Token = "0x40104A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_actionsToDelete_2;

		// Token: 0x040104A8 RID: 66728
		[Token(Token = "0x40104A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040104A9 RID: 66729
		[Token(Token = "0x40104A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoPreprocess;

		// Token: 0x040104AA RID: 66730
		[Token(Token = "0x40104AA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Dispose;
	}
}
