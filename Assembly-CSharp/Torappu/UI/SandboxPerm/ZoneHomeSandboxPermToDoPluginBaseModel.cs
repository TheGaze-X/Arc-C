using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm
{
	// Token: 0x02004014 RID: 16404
	[Token(Token = "0x2004014")]
	public abstract class ZoneHomeSandboxPermToDoPluginBaseModel : IHotfixable, IComparable
	{
		// Token: 0x0601967D RID: 104061 RVA: 0x0009DF38 File Offset: 0x0009C138
		[Token(Token = "0x601967D")]
		[Address(RVA = "0x1229BB0", Offset = "0x12287B0", VA = "0x181229BB0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0601967E RID: 104062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601967E")]
		[Address(RVA = "0x1229D30", Offset = "0x1228930", VA = "0x181229D30")]
		protected ZoneHomeSandboxPermToDoPluginBaseModel()
		{
		}

		// Token: 0x0401F9A5 RID: 129445
		[Token(Token = "0x401F9A5")]
		[FieldOffset(Offset = "0x10")]
		public string topicName;

		// Token: 0x0401F9A6 RID: 129446
		[Token(Token = "0x401F9A6")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0401F9A7 RID: 129447
		[Token(Token = "0x401F9A7")]
		[FieldOffset(Offset = "0x20")]
		public string displayId;

		// Token: 0x0401F9A8 RID: 129448
		[Token(Token = "0x401F9A8")]
		[FieldOffset(Offset = "0x28")]
		protected ZoneHomeSandboxPermToDoPluginBaseModel.ShowPriority priority;

		// Token: 0x0401F9A9 RID: 129449
		[Token(Token = "0x401F9A9")]
		[FieldOffset(Offset = "0x30")]
		protected long startTs;

		// Token: 0x0401F9AA RID: 129450
		[Token(Token = "0x401F9AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0401F9AB RID: 129451
		[Token(Token = "0x401F9AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004015 RID: 16405
		[Token(Token = "0x2004015")]
		protected enum ShowPriority
		{
			// Token: 0x0401F9AD RID: 129453
			[Token(Token = "0x401F9AD")]
			NONE,
			// Token: 0x0401F9AE RID: 129454
			[Token(Token = "0x401F9AE")]
			PINNED = 10,
			// Token: 0x0401F9AF RID: 129455
			[Token(Token = "0x401F9AF")]
			CHALLENGE = 20
		}
	}
}
