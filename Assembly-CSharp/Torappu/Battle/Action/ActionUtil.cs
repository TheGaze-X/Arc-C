using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Action
{
	// Token: 0x020031E6 RID: 12774
	[Token(Token = "0x20031E6")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ActionUtil
	{
		// Token: 0x06014465 RID: 83045 RVA: 0x00086460 File Offset: 0x00084660
		[Token(Token = "0x6014465")]
		[Address(RVA = "0xC82CB0", Offset = "0xC818B0", VA = "0x180C82CB0")]
		public static bool CheckExecute(ActionNode nextAction, bool lastOneIsSucceed)
		{
			return default(bool);
		}

		// Token: 0x06014466 RID: 83046 RVA: 0x00086478 File Offset: 0x00084678
		[Token(Token = "0x6014466")]
		[Address(RVA = "0xC837C0", Offset = "0xC823C0", VA = "0x180C837C0")]
		public static bool RunActions(IList<ActionNode> actions, ActionNode.SourceType sourceType, Blackboard blackboard, ref Context.Snapshot snapshot)
		{
			return default(bool);
		}

		// Token: 0x06014467 RID: 83047 RVA: 0x00086490 File Offset: 0x00084690
		[Token(Token = "0x6014467")]
		[Address(RVA = "0xC83530", Offset = "0xC82130", VA = "0x180C83530")]
		public static Context.Snapshot RunActions(IList<ActionNode> actions, ActionNode.SourceType sourceType, Blackboard blackboard)
		{
			return default(Context.Snapshot);
		}

		// Token: 0x06014468 RID: 83048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014468")]
		[Address(RVA = "0xC82EA0", Offset = "0xC81AA0", VA = "0x180C82EA0")]
		public static void Dump(List<ActionNode> dumpTo, IList<ActionNode> dumpFrom, bool recursive)
		{
		}

		// Token: 0x06014469 RID: 83049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014469")]
		[Address(RVA = "0xC82D80", Offset = "0xC81980", VA = "0x180C82D80")]
		public static void Dump(List<ActionNode> dumpTo, ActionNode dumpFrom, bool recursive)
		{
		}

		// Token: 0x0601446A RID: 83050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601446A")]
		[Address(RVA = "0xC83310", Offset = "0xC81F10", VA = "0x180C83310")]
		public static void ReplaceFirst(this IList<ActionNode> list, ActionNode item, ActionNode replace)
		{
		}

		// Token: 0x0601446B RID: 83051 RVA: 0x000864A8 File Offset: 0x000846A8
		[Token(Token = "0x601446B")]
		public static bool TryFindFirst<T>(this IList<ActionNode> list, out T result) where T : ActionNode
		{
			return default(bool);
		}

		// Token: 0x0601446C RID: 83052 RVA: 0x000864C0 File Offset: 0x000846C0
		[Token(Token = "0x601446C")]
		[Address(RVA = "0xC83150", Offset = "0xC81D50", VA = "0x180C83150")]
		public static ActionPurposeMask GeneratePurposeMask(this IList<ActionNode> list)
		{
			return ActionPurposeMask.NONE;
		}

		// Token: 0x04017EBD RID: 97981
		[Token(Token = "0x4017EBD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckExecute;

		// Token: 0x04017EBE RID: 97982
		[Token(Token = "0x4017EBE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RunActions;

		// Token: 0x04017EBF RID: 97983
		[Token(Token = "0x4017EBF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_RunActions;

		// Token: 0x04017EC0 RID: 97984
		[Token(Token = "0x4017EC0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Dump;

		// Token: 0x04017EC1 RID: 97985
		[Token(Token = "0x4017EC1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_Dump;

		// Token: 0x04017EC2 RID: 97986
		[Token(Token = "0x4017EC2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ReplaceFirst;

		// Token: 0x04017EC3 RID: 97987
		[Token(Token = "0x4017EC3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryFindFirst;

		// Token: 0x04017EC4 RID: 97988
		[Token(Token = "0x4017EC4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GeneratePurposeMask;
	}
}
