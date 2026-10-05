using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070B9 RID: 28857
	[Token(Token = "0x20070B9")]
	public class Act1BossRushEntryRelicButtonViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x06029045 RID: 168005 RVA: 0x000D4190 File Offset: 0x000D2390
		[Token(Token = "0x6029045")]
		[Address(RVA = "0x2467310", Offset = "0x2465F10", VA = "0x182467310")]
		public bool HasRelicUnlock()
		{
			return default(bool);
		}

		// Token: 0x06029046 RID: 168006 RVA: 0x000D41A8 File Offset: 0x000D23A8
		[Token(Token = "0x6029046")]
		[Address(RVA = "0x2467290", Offset = "0x2465E90", VA = "0x182467290")]
		public bool HasRelicCanUpgrade()
		{
			return default(bool);
		}

		// Token: 0x06029047 RID: 168007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029047")]
		[Address(RVA = "0x2467380", Offset = "0x2465F80", VA = "0x182467380")]
		public Act1BossRushEntryRelicButtonViewModel(object param)
		{
		}

		// Token: 0x0403A8C3 RID: 239811
		[Token(Token = "0x403A8C3")]
		[FieldOffset(Offset = "0x20")]
		private Func<bool> m_checkIfRelicUnlockFunc;

		// Token: 0x0403A8C4 RID: 239812
		[Token(Token = "0x403A8C4")]
		[FieldOffset(Offset = "0x28")]
		private Func<bool> m_checkIfRelicCanUpgradeFunc;

		// Token: 0x0403A8C5 RID: 239813
		[Token(Token = "0x403A8C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HasRelicUnlock;

		// Token: 0x0403A8C6 RID: 239814
		[Token(Token = "0x403A8C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HasRelicCanUpgrade;

		// Token: 0x0403A8C7 RID: 239815
		[Token(Token = "0x403A8C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020070BA RID: 28858
		[Token(Token = "0x20070BA")]
		public class Input
		{
			// Token: 0x06029048 RID: 168008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029048")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403A8C8 RID: 239816
			[Token(Token = "0x403A8C8")]
			[FieldOffset(Offset = "0x10")]
			public Func<bool> checkIfRelicUnlockFunc;

			// Token: 0x0403A8C9 RID: 239817
			[Token(Token = "0x403A8C9")]
			[FieldOffset(Offset = "0x18")]
			public Func<bool> checkIfRelicCanUpgradeFunc;
		}
	}
}
