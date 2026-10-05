using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002437 RID: 9271
	[Token(Token = "0x2002437")]
	public class DataDrivenRandomSchedulerPreprocessor : Scheduler.DefaultSchedulerPreprocessor
	{
		// Token: 0x0600ED0E RID: 60686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED0E")]
		[Address(RVA = "0x6215C0", Offset = "0x6201C0", VA = "0x1806215C0")]
		public DataDrivenRandomSchedulerPreprocessor([Optional] List<List<int>> validActionResults)
		{
		}

		// Token: 0x0600ED0F RID: 60687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED0F")]
		[Address(RVA = "0x6203A0", Offset = "0x61EFA0", VA = "0x1806203A0")]
		private void _ConstructorImpl(List<List<int>> validActionResults)
		{
		}

		// Token: 0x0600ED10 RID: 60688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED10")]
		[Address(RVA = "0x620080", Offset = "0x61EC80", VA = "0x180620080")]
		public void SetSingleActionKilledCount(List<List<int>> singleActionRemainCount)
		{
		}

		// Token: 0x0600ED11 RID: 60689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED11")]
		[Address(RVA = "0x61FFE0", Offset = "0x61EBE0", VA = "0x18061FFE0")]
		public void SetActionRemainCount(Dictionary<string, int> actionRemainCount)
		{
		}

		// Token: 0x0600ED12 RID: 60690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED12")]
		[Address(RVA = "0x61FCB0", Offset = "0x61E8B0", VA = "0x18061FCB0", Slot = "5")]
		public override void DoPreprocess(LevelData levelData)
		{
		}

		// Token: 0x0600ED13 RID: 60691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED13")]
		[Address(RVA = "0x6208A0", Offset = "0x61F4A0", VA = "0x1806208A0")]
		private void _InitValidation(LevelData levelData)
		{
		}

		// Token: 0x0600ED14 RID: 60692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED14")]
		[Address(RVA = "0x620640", Offset = "0x61F240", VA = "0x180620640")]
		private void _DeleteInvalidActions(LevelData levelData)
		{
		}

		// Token: 0x0600ED15 RID: 60693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED15")]
		[Address(RVA = "0x621220", Offset = "0x61FE20", VA = "0x180621220")]
		private void _ProcessValidActionsViaInputResults(LevelData levelData)
		{
		}

		// Token: 0x0600ED16 RID: 60694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED16")]
		[Address(RVA = "0x620A90", Offset = "0x61F690", VA = "0x180620A90")]
		private void _ProcessActionCountViaInputResults(LevelData levelData)
		{
		}

		// Token: 0x0600ED17 RID: 60695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED17")]
		[Address(RVA = "0x620DA0", Offset = "0x61F9A0", VA = "0x180620DA0")]
		private void _ProcessActionSingleCountViaInputResults(LevelData levelData)
		{
		}

		// Token: 0x0600ED18 RID: 60696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED18")]
		[Address(RVA = "0x621030", Offset = "0x61FC30", VA = "0x180621030")]
		private void _ProcessEmptyActionKeys(LevelData levelData)
		{
		}

		// Token: 0x0600ED19 RID: 60697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED19")]
		[Address(RVA = "0x61FBB0", Offset = "0x61E7B0", VA = "0x18061FBB0", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x0600ED1A RID: 60698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED1A")]
		[Address(RVA = "0x620340", Offset = "0x61EF40", VA = "0x180620340")]
		private void <>xLuaBaseProxy_DoPreprocess(LevelData P0)
		{
		}

		// Token: 0x0600ED1B RID: 60699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED1B")]
		[Address(RVA = "0x6202E0", Offset = "0x61EEE0", VA = "0x1806202E0")]
		private void <>xLuaBaseProxy_Dispose()
		{
		}

		// Token: 0x0401062B RID: 67115
		[Token(Token = "0x401062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<LevelData.ActionID> m_validActionResults;

		// Token: 0x0401062C RID: 67116
		[Token(Token = "0x401062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ListDict<LevelData.ActionID, int> m_singleActionKilledCount;

		// Token: 0x0401062D RID: 67117
		[Token(Token = "0x401062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<string> m_validActionPackKeys;

		// Token: 0x0401062E RID: 67118
		[Token(Token = "0x401062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<string, int> m_actionRemainCount;

		// Token: 0x0401062F RID: 67119
		[Token(Token = "0x401062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04010630 RID: 67120
		[Token(Token = "0x4010630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ConstructorImpl;

		// Token: 0x04010631 RID: 67121
		[Token(Token = "0x4010631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSingleActionKilledCount;

		// Token: 0x04010632 RID: 67122
		[Token(Token = "0x4010632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetActionRemainCount;

		// Token: 0x04010633 RID: 67123
		[Token(Token = "0x4010633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoPreprocess;

		// Token: 0x04010634 RID: 67124
		[Token(Token = "0x4010634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitValidation;

		// Token: 0x04010635 RID: 67125
		[Token(Token = "0x4010635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DeleteInvalidActions;

		// Token: 0x04010636 RID: 67126
		[Token(Token = "0x4010636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ProcessValidActionsViaInputResults;

		// Token: 0x04010637 RID: 67127
		[Token(Token = "0x4010637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ProcessActionCountViaInputResults;

		// Token: 0x04010638 RID: 67128
		[Token(Token = "0x4010638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ProcessActionSingleCountViaInputResults;

		// Token: 0x04010639 RID: 67129
		[Token(Token = "0x4010639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ProcessEmptyActionKeys;

		// Token: 0x0401063A RID: 67130
		[Token(Token = "0x401063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Dispose;
	}
}
