using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Fragment
{
	// Token: 0x020057F9 RID: 22521
	[Token(Token = "0x20057F9")]
	public abstract class RoguelikeFragmentDialog : UICompDialog<RoguelikeFragmentDialog.Options>, IHotfixable
	{
		// Token: 0x06020EC5 RID: 134853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EC5")]
		[Address(RVA = "0x1B34EB0", Offset = "0x1B33AB0", VA = "0x181B34EB0")]
		protected RoguelikeFragmentDialog()
		{
		}

		// Token: 0x0402CC10 RID: 183312
		[Token(Token = "0x402CC10")]
		public const RoguelikeFragmentDialogListType DEFAULT_LIST_TYPE = RoguelikeFragmentDialogListType.DETAIL;

		// Token: 0x0402CC11 RID: 183313
		[Token(Token = "0x402CC11")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020057FA RID: 22522
		[Token(Token = "0x20057FA")]
		public class Options
		{
			// Token: 0x06020EC6 RID: 134854 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020EC6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0402CC12 RID: 183314
			[Token(Token = "0x402CC12")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0402CC13 RID: 183315
			[Token(Token = "0x402CC13")]
			[FieldOffset(Offset = "0x18")]
			public UICompDialogMgr dialogMgr;

			// Token: 0x0402CC14 RID: 183316
			[Token(Token = "0x402CC14")]
			[FieldOffset(Offset = "0x20")]
			public RoguelikeFragmentDialogMode mode;

			// Token: 0x0402CC15 RID: 183317
			[Token(Token = "0x402CC15")]
			[FieldOffset(Offset = "0x24")]
			public RoguelikeFragmentDialogListType listType;
		}
	}
}
