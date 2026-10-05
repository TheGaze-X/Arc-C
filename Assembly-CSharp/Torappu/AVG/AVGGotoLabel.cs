using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E9F RID: 7839
	[Token(Token = "0x2001E9F")]
	public class AVGGotoLabel : ExecutorComponent
	{
		// Token: 0x0600C225 RID: 49701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C225")]
		[Address(RVA = "0x33F5AF0", Offset = "0x33F46F0", VA = "0x1833F5AF0", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C226 RID: 49702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C226")]
		[Address(RVA = "0x33F5CE0", Offset = "0x33F48E0", VA = "0x1833F5CE0", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C227 RID: 49703 RVA: 0x000473E8 File Offset: 0x000455E8
		[Token(Token = "0x600C227")]
		[Address(RVA = "0x33F5ED0", Offset = "0x33F4AD0", VA = "0x1833F5ED0")]
		private bool _ExecuteLabel(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C228 RID: 49704 RVA: 0x00047400 File Offset: 0x00045600
		[Token(Token = "0x600C228")]
		[Address(RVA = "0x33F5DB0", Offset = "0x33F49B0", VA = "0x1833F5DB0")]
		private bool _ExecuteGoto(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C229 RID: 49705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C229")]
		[Address(RVA = "0x33F5C80", Offset = "0x33F4880", VA = "0x1833F5C80", Slot = "11")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600C22A RID: 49706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C22A")]
		[Address(RVA = "0x33F5A90", Offset = "0x33F4690", VA = "0x1833F5A90", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C22B RID: 49707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C22B")]
		[Address(RVA = "0x33F5F40", Offset = "0x33F4B40", VA = "0x1833F5F40")]
		public AVGGotoLabel()
		{
		}

		// Token: 0x0600C22C RID: 49708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C22C")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600C22D RID: 49709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C22D")]
		[Address(RVA = "0x33F4E00", Offset = "0x33F3A00", VA = "0x1833F4E00")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400C3E7 RID: 50151
		[Token(Token = "0x400C3E7")]
		private const string PARAM_NAME_NAME = "name";

		// Token: 0x0400C3E8 RID: 50152
		[Token(Token = "0x400C3E8")]
		private const string COMMAND_NAME_LABEL = "label";

		// Token: 0x0400C3E9 RID: 50153
		[Token(Token = "0x400C3E9")]
		private const string COMMAND_NAME_GOTO = "warp";

		// Token: 0x0400C3EA RID: 50154
		[Token(Token = "0x400C3EA")]
		[FieldOffset(Offset = "0x50")]
		private AVGGotoLabel.GotoLabelController m_gotoLabelController;

		// Token: 0x0400C3EB RID: 50155
		[Token(Token = "0x400C3EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C3EC RID: 50156
		[Token(Token = "0x400C3EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C3ED RID: 50157
		[Token(Token = "0x400C3ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ExecuteLabel;

		// Token: 0x0400C3EE RID: 50158
		[Token(Token = "0x400C3EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ExecuteGoto;

		// Token: 0x0400C3EF RID: 50159
		[Token(Token = "0x400C3EF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400C3F0 RID: 50160
		[Token(Token = "0x400C3F0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C3F1 RID: 50161
		[Token(Token = "0x400C3F1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001EA0 RID: 7840
		[Token(Token = "0x2001EA0")]
		private class GotoLabelController : AVGController.ICommandFlowController
		{
			// Token: 0x0600C22E RID: 49710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C22E")]
			[Address(RVA = "0x34041E0", Offset = "0x3402DE0", VA = "0x1834041E0")]
			public void RegisterLabel(string label, int index)
			{
			}

			// Token: 0x0600C22F RID: 49711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C22F")]
			[Address(RVA = "0x34042C0", Offset = "0x3402EC0", VA = "0x1834042C0")]
			public void TryGotoLabel(string label)
			{
			}

			// Token: 0x0600C230 RID: 49712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C230")]
			[Address(RVA = "0x3404270", Offset = "0x3402E70", VA = "0x183404270", Slot = "4")]
			public void Reset()
			{
			}

			// Token: 0x0600C231 RID: 49713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C231")]
			[Address(RVA = "0x34040D0", Offset = "0x3402CD0", VA = "0x1834040D0", Slot = "5")]
			public void PreprocessCommands(List<Command> commands)
			{
			}

			// Token: 0x0600C232 RID: 49714 RVA: 0x00047418 File Offset: 0x00045618
			[Token(Token = "0x600C232")]
			[Address(RVA = "0x34040C0", Offset = "0x3402CC0", VA = "0x1834040C0", Slot = "6")]
			public int GotoCommandIndex()
			{
				return 0;
			}

			// Token: 0x0600C233 RID: 49715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C233")]
			[Address(RVA = "0x3404350", Offset = "0x3402F50", VA = "0x183404350")]
			public GotoLabelController()
			{
			}

			// Token: 0x0400C3F2 RID: 50162
			[Token(Token = "0x400C3F2")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<string, int> m_labelMap;

			// Token: 0x0400C3F3 RID: 50163
			[Token(Token = "0x400C3F3")]
			[FieldOffset(Offset = "0x18")]
			private int m_gotoIndex;
		}
	}
}
