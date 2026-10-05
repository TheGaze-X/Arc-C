using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002759 RID: 10073
	[Token(Token = "0x2002759")]
	public class AutoChessTaskManager : IHotfixable
	{
		// Token: 0x060106AA RID: 67242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106AA")]
		[Address(RVA = "0x821D30", Offset = "0x820930", VA = "0x180821D30")]
		public void Start()
		{
		}

		// Token: 0x060106AB RID: 67243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106AB")]
		[Address(RVA = "0x821480", Offset = "0x820080", VA = "0x180821480")]
		public void RegisterTask(AutoChessTaskManager.IPendingTask task, AutoChessGameStateType state, AutoChessGameStatus.SubState subState)
		{
		}

		// Token: 0x060106AC RID: 67244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60106AC")]
		[Address(RVA = "0x821EE0", Offset = "0x820AE0", VA = "0x180821EE0")]
		private List<AutoChessTaskManager.IPendingTask> _TryGetPendingTasks(AutoChessGameStateType state, AutoChessGameStatus.SubState subState)
		{
			return null;
		}

		// Token: 0x060106AD RID: 67245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106AD")]
		[Address(RVA = "0x821DF0", Offset = "0x8209F0", VA = "0x180821DF0")]
		private void _HandleDataChanged(object arg)
		{
		}

		// Token: 0x060106AE RID: 67246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106AE")]
		[Address(RVA = "0x8216F0", Offset = "0x8202F0", VA = "0x1808216F0")]
		public void RestartTasks()
		{
		}

		// Token: 0x060106AF RID: 67247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106AF")]
		[Address(RVA = "0x8210C0", Offset = "0x81FCC0", VA = "0x1808210C0")]
		public void OnTick()
		{
		}

		// Token: 0x060106B0 RID: 67248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106B0")]
		[Address(RVA = "0x821FF0", Offset = "0x820BF0", VA = "0x180821FF0")]
		public AutoChessTaskManager()
		{
		}

		// Token: 0x04012600 RID: 75264
		[Token(Token = "0x4012600")]
		[FieldOffset(Offset = "0x10")]
		private bool m_taskDirty;

		// Token: 0x04012601 RID: 75265
		[Token(Token = "0x4012601")]
		[FieldOffset(Offset = "0x18")]
		private FP m_taskTime;

		// Token: 0x04012602 RID: 75266
		[Token(Token = "0x4012602")]
		[FieldOffset(Offset = "0x20")]
		private AutoChessGameStatus.GameStateChecker m_stateChecker;

		// Token: 0x04012603 RID: 75267
		[Token(Token = "0x4012603")]
		[FieldOffset(Offset = "0x28")]
		private List<AutoChessTaskManager.IPendingTask> m_pendingTasks;

		// Token: 0x04012604 RID: 75268
		[Token(Token = "0x4012604")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<AutoChessGameStateType, Dictionary<AutoChessGameStatus.SubState, List<AutoChessTaskManager.IPendingTask>>> m_allPendingTasks;

		// Token: 0x04012605 RID: 75269
		[Token(Token = "0x4012605")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04012606 RID: 75270
		[Token(Token = "0x4012606")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterTask;

		// Token: 0x04012607 RID: 75271
		[Token(Token = "0x4012607")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryGetPendingTasks;

		// Token: 0x04012608 RID: 75272
		[Token(Token = "0x4012608")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HandleDataChanged;

		// Token: 0x04012609 RID: 75273
		[Token(Token = "0x4012609")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RestartTasks;

		// Token: 0x0401260A RID: 75274
		[Token(Token = "0x401260A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401260B RID: 75275
		[Token(Token = "0x401260B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200275A RID: 10074
		[Token(Token = "0x200275A")]
		public interface IPendingTask
		{
			// Token: 0x060106B1 RID: 67249
			[Token(Token = "0x60106B1")]
			void OnTaskStart();

			// Token: 0x060106B2 RID: 67250
			[Token(Token = "0x60106B2")]
			void OnTaskFinish(bool isInterrupt);

			// Token: 0x170023DF RID: 9183
			// (get) Token: 0x060106B3 RID: 67251
			[Token(Token = "0x170023DF")]
			bool taskFinished { [Token(Token = "0x60106B3")] get; }

			// Token: 0x170023E0 RID: 9184
			// (get) Token: 0x060106B4 RID: 67252
			[Token(Token = "0x170023E0")]
			float maxTaskTime { [Token(Token = "0x60106B4")] get; }
		}
	}
}
