using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.Battle.Dialog
{
	// Token: 0x02002807 RID: 10247
	[Token(Token = "0x2002807")]
	public class BattleStoryTree : IHotfixable
	{
		// Token: 0x1700258F RID: 9615
		// (get) Token: 0x0601109F RID: 69791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700258F")]
		private Dictionary<string, BattleStoryTree.JumpToCond> jumpToDic
		{
			[Token(Token = "0x601109F")]
			[Address(RVA = "0x8EAA10", Offset = "0x8E9610", VA = "0x1808EAA10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060110A0 RID: 69792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110A0")]
		[Address(RVA = "0x8E9B50", Offset = "0x8E8750", VA = "0x1808E9B50")]
		public void Init()
		{
		}

		// Token: 0x060110A1 RID: 69793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110A1")]
		[Address(RVA = "0x8E8F60", Offset = "0x8E7B60", VA = "0x1808E8F60")]
		public void Attach(Dictionary<string, BattleStoryTree.Executor> executors)
		{
		}

		// Token: 0x060110A2 RID: 69794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110A2")]
		[Address(RVA = "0x8E9700", Offset = "0x8E8300", VA = "0x1808E9700")]
		public void Detach(Dictionary<string, BattleStoryTree.Executor> executors)
		{
		}

		// Token: 0x060110A3 RID: 69795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110A3")]
		[Address(RVA = "0x8E9680", Offset = "0x8E8280", VA = "0x1808E9680")]
		public void DetachExcutors()
		{
		}

		// Token: 0x060110A4 RID: 69796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110A4")]
		[Address(RVA = "0x8E9C60", Offset = "0x8E8860", VA = "0x1808E9C60")]
		public void RunStory(Story story)
		{
		}

		// Token: 0x060110A5 RID: 69797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110A5")]
		[Address(RVA = "0x8E9BB0", Offset = "0x8E87B0", VA = "0x1808E9BB0")]
		public void Reset()
		{
		}

		// Token: 0x060110A6 RID: 69798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110A6")]
		[Address(RVA = "0x8EA070", Offset = "0x8E8C70", VA = "0x1808EA070")]
		private void _ConstructJumpToDic()
		{
		}

		// Token: 0x060110A7 RID: 69799 RVA: 0x00068E80 File Offset: 0x00067080
		[Token(Token = "0x60110A7")]
		[Address(RVA = "0x8E9CF0", Offset = "0x8E88F0", VA = "0x1808E9CF0")]
		public bool TryGetNext(int currentCommandIndex, out int commandIndex, out Command command, int decision = -1)
		{
			return default(bool);
		}

		// Token: 0x060110A8 RID: 69800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60110A8")]
		[Address(RVA = "0x8E9340", Offset = "0x8E7F40", VA = "0x1808E9340")]
		public List<BattleDialogOption> ConstructOptionsFromCommand(Command command)
		{
			return null;
		}

		// Token: 0x060110A9 RID: 69801 RVA: 0x00068E98 File Offset: 0x00067098
		[Token(Token = "0x60110A9")]
		[Address(RVA = "0x8E98C0", Offset = "0x8E84C0", VA = "0x1808E98C0")]
		public bool ExcuteCommand(Command command)
		{
			return default(bool);
		}

		// Token: 0x060110AA RID: 69802 RVA: 0x00068EB0 File Offset: 0x000670B0
		[Token(Token = "0x60110AA")]
		[Address(RVA = "0x8E9250", Offset = "0x8E7E50", VA = "0x1808E9250")]
		public bool CheckCondnByPred(string commandConditionSource)
		{
			return default(bool);
		}

		// Token: 0x060110AB RID: 69803 RVA: 0x00068EC8 File Offset: 0x000670C8
		[Token(Token = "0x60110AB")]
		[Address(RVA = "0x8EA580", Offset = "0x8E9180", VA = "0x1808EA580")]
		public bool _DoCheckCond(string lamda, Func<string, bool> validate)
		{
			return default(bool);
		}

		// Token: 0x060110AC RID: 69804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60110AC")]
		[Address(RVA = "0x8EA800", Offset = "0x8E9400", VA = "0x1808EA800")]
		public BattleStoryTree()
		{
		}

		// Token: 0x04013160 RID: 78176
		[Token(Token = "0x4013160")]
		[FieldOffset(Offset = "0x10")]
		public Story story;

		// Token: 0x04013161 RID: 78177
		[Token(Token = "0x4013161")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, BattleStoryTree.JumpToCond> m_optionJumpCommandDic;

		// Token: 0x04013162 RID: 78178
		[Token(Token = "0x4013162")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, int> m_optionCond;

		// Token: 0x04013163 RID: 78179
		[Token(Token = "0x4013163")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, List<BattleStoryTree.Executor>> m_executors;

		// Token: 0x04013164 RID: 78180
		[Token(Token = "0x4013164")]
		[FieldOffset(Offset = "0x30")]
		private List<BattleStoryTree.Executor> m_executerCache;

		// Token: 0x04013165 RID: 78181
		[Token(Token = "0x4013165")]
		private const string LOGIC_EXPRESION_PATTERN = "(!|\\|\\||&&)";

		// Token: 0x04013166 RID: 78182
		[Token(Token = "0x4013166")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_jumpToDic;

		// Token: 0x04013167 RID: 78183
		[Token(Token = "0x4013167")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013168 RID: 78184
		[Token(Token = "0x4013168")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Attach;

		// Token: 0x04013169 RID: 78185
		[Token(Token = "0x4013169")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Detach;

		// Token: 0x0401316A RID: 78186
		[Token(Token = "0x401316A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DetachExcutors;

		// Token: 0x0401316B RID: 78187
		[Token(Token = "0x401316B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RunStory;

		// Token: 0x0401316C RID: 78188
		[Token(Token = "0x401316C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401316D RID: 78189
		[Token(Token = "0x401316D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ConstructJumpToDic;

		// Token: 0x0401316E RID: 78190
		[Token(Token = "0x401316E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryGetNext;

		// Token: 0x0401316F RID: 78191
		[Token(Token = "0x401316F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ConstructOptionsFromCommand;

		// Token: 0x04013170 RID: 78192
		[Token(Token = "0x4013170")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ExcuteCommand;

		// Token: 0x04013171 RID: 78193
		[Token(Token = "0x4013171")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckCondnByPred;

		// Token: 0x04013172 RID: 78194
		[Token(Token = "0x4013172")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DoCheckCond;

		// Token: 0x04013173 RID: 78195
		[Token(Token = "0x4013173")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002808 RID: 10248
		[Token(Token = "0x2002808")]
		public struct JumpToCond
		{
			// Token: 0x04013174 RID: 78196
			[Token(Token = "0x4013174")]
			[FieldOffset(Offset = "0x0")]
			public int refCommandIndex;

			// Token: 0x04013175 RID: 78197
			[Token(Token = "0x4013175")]
			[FieldOffset(Offset = "0x8")]
			public string visibleCond;

			// Token: 0x04013176 RID: 78198
			[Token(Token = "0x4013176")]
			[FieldOffset(Offset = "0x10")]
			public string selectableCond;
		}

		// Token: 0x02002809 RID: 10249
		// (Invoke) Token: 0x060110AF RID: 69807
		[Token(Token = "0x2002809")]
		public delegate bool Executor(Command command);
	}
}
