using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EA1 RID: 7841
	[Token(Token = "0x2001EA1")]
	public class AVGGotoStagePanel : ExecutorComponent
	{
		// Token: 0x0600C234 RID: 49716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C234")]
		[Address(RVA = "0x33F60B0", Offset = "0x33F4CB0", VA = "0x1833F60B0", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C235 RID: 49717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C235")]
		[Address(RVA = "0x33F6050", Offset = "0x33F4C50", VA = "0x1833F6050", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C236 RID: 49718 RVA: 0x00047430 File Offset: 0x00045630
		[Token(Token = "0x600C236")]
		[Address(RVA = "0x33F61D0", Offset = "0x33F4DD0", VA = "0x1833F61D0")]
		private bool _ExecuteGotoStage(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C237 RID: 49719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C237")]
		[Address(RVA = "0x33F6300", Offset = "0x33F4F00", VA = "0x1833F6300")]
		public AVGGotoStagePanel()
		{
		}

		// Token: 0x0400C3F4 RID: 50164
		[Token(Token = "0x400C3F4")]
		private const string COMMAND_NAME_GOTO_STAGE = "gotostage";

		// Token: 0x0400C3F5 RID: 50165
		[Token(Token = "0x400C3F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C3F6 RID: 50166
		[Token(Token = "0x400C3F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C3F7 RID: 50167
		[Token(Token = "0x400C3F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ExecuteGotoStage;

		// Token: 0x0400C3F8 RID: 50168
		[Token(Token = "0x400C3F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
