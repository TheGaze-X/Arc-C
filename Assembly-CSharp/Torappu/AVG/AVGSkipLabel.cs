using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EB1 RID: 7857
	[Token(Token = "0x2001EB1")]
	public class AVGSkipLabel : ExecutorComponent
	{
		// Token: 0x0600C290 RID: 49808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C290")]
		[Address(RVA = "0x33FCAC0", Offset = "0x33FB6C0", VA = "0x1833FCAC0", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C291 RID: 49809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C291")]
		[Address(RVA = "0x33FC9A0", Offset = "0x33FB5A0", VA = "0x1833FC9A0", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C292 RID: 49810 RVA: 0x00047628 File Offset: 0x00045828
		[Token(Token = "0x600C292")]
		[Address(RVA = "0x33FCB40", Offset = "0x33FB740", VA = "0x1833FCB40")]
		private bool _ExecuteSkipNode(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C293 RID: 49811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C293")]
		[Address(RVA = "0x33FC940", Offset = "0x33FB540", VA = "0x1833FC940", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C294 RID: 49812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C294")]
		[Address(RVA = "0x33FCC40", Offset = "0x33FB840", VA = "0x1833FCC40")]
		public AVGSkipLabel()
		{
		}

		// Token: 0x0600C295 RID: 49813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C295")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0400C46E RID: 50286
		[Token(Token = "0x400C46E")]
		public const string PARAM_NAME_SKIP_MODE = "mode";

		// Token: 0x0400C46F RID: 50287
		[Token(Token = "0x400C46F")]
		public const string COMMAND_NAME_SKIP_NODE = "skipnode";

		// Token: 0x0400C470 RID: 50288
		[Token(Token = "0x400C470")]
		public const string MODE_NAME_FIRST_CANNOT_SKIP = "nofirstskip";

		// Token: 0x0400C471 RID: 50289
		[Token(Token = "0x400C471")]
		public const string MODE_NAME_CAN_SKIP = "skip";

		// Token: 0x0400C472 RID: 50290
		[Token(Token = "0x400C472")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AVGController _avgController;

		// Token: 0x0400C473 RID: 50291
		[Token(Token = "0x400C473")]
		[FieldOffset(Offset = "0x58")]
		private AVGSkipLabel.SkipLabelController m_skipLabelController;

		// Token: 0x0400C474 RID: 50292
		[Token(Token = "0x400C474")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C475 RID: 50293
		[Token(Token = "0x400C475")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C476 RID: 50294
		[Token(Token = "0x400C476")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ExecuteSkipNode;

		// Token: 0x0400C477 RID: 50295
		[Token(Token = "0x400C477")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C478 RID: 50296
		[Token(Token = "0x400C478")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001EB2 RID: 7858
		[Token(Token = "0x2001EB2")]
		private class SkipLabelController : AVGController.ICommandSkipController
		{
			// Token: 0x0600C296 RID: 49814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C296")]
			[Address(RVA = "0x3404DF0", Offset = "0x34039F0", VA = "0x183404DF0", Slot = "5")]
			public void PreprocessCommands(List<Command> commands)
			{
			}

			// Token: 0x0600C297 RID: 49815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C297")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
			public void Reset()
			{
			}

			// Token: 0x0600C298 RID: 49816 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C298")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SkipLabelController()
			{
			}
		}
	}
}
