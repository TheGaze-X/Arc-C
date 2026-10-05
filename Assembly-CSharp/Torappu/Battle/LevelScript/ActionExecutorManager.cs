using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002829 RID: 10281
	[Token(Token = "0x2002829")]
	public class ActionExecutorManager : IHotfixable
	{
		// Token: 0x060111DA RID: 70106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111DA")]
		[Address(RVA = "0x902CB0", Offset = "0x9018B0", VA = "0x180902CB0")]
		public ActionExecutor Run(LevelScriptActionBase action, EventParams eventParams, [Optional] Action onFinishCallback, bool needRecycle = true)
		{
			return null;
		}

		// Token: 0x060111DB RID: 70107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60111DB")]
		[Address(RVA = "0x902960", Offset = "0x901560", VA = "0x180902960")]
		public ActionExecutor Run(ActionContext context, int startNodeID, EventParams eventParams, [Optional] Action onFinishCallback, bool needRecycle = false, [Optional] ActionExecutor parent)
		{
			return null;
		}

		// Token: 0x060111DC RID: 70108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111DC")]
		[Address(RVA = "0x903020", Offset = "0x901C20", VA = "0x180903020")]
		public void Tick(FP deltaTime)
		{
		}

		// Token: 0x060111DD RID: 70109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111DD")]
		[Address(RVA = "0x902580", Offset = "0x901180", VA = "0x180902580")]
		public void OnInit()
		{
		}

		// Token: 0x060111DE RID: 70110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111DE")]
		[Address(RVA = "0x9025E0", Offset = "0x9011E0", VA = "0x1809025E0")]
		public void OnRelease()
		{
		}

		// Token: 0x060111DF RID: 70111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111DF")]
		[Address(RVA = "0x9027C0", Offset = "0x9013C0", VA = "0x1809027C0")]
		public void ReleaseAllExecutor()
		{
		}

		// Token: 0x060111E0 RID: 70112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60111E0")]
		[Address(RVA = "0x903220", Offset = "0x901E20", VA = "0x180903220")]
		public ActionExecutorManager()
		{
		}

		// Token: 0x040132EB RID: 78571
		[Token(Token = "0x40132EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<ObjectPtr<ActionExecutor>> m_subExecutorList;

		// Token: 0x040132EC RID: 78572
		[Token(Token = "0x40132EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Run;

		// Token: 0x040132ED RID: 78573
		[Token(Token = "0x40132ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Run;

		// Token: 0x040132EE RID: 78574
		[Token(Token = "0x40132EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x040132EF RID: 78575
		[Token(Token = "0x40132EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040132F0 RID: 78576
		[Token(Token = "0x40132F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRelease;

		// Token: 0x040132F1 RID: 78577
		[Token(Token = "0x40132F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ReleaseAllExecutor;

		// Token: 0x040132F2 RID: 78578
		[Token(Token = "0x40132F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
