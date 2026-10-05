using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F15 RID: 7957
	[Token(Token = "0x2001F15")]
	public class AVGContextStateService : IHotfixable
	{
		// Token: 0x0600C567 RID: 50535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C567")]
		[Address(RVA = "0x3421DA0", Offset = "0x34209A0", VA = "0x183421DA0")]
		public void Register(IAVGCommandStateFilter filter)
		{
		}

		// Token: 0x0600C568 RID: 50536 RVA: 0x000484E0 File Offset: 0x000466E0
		[Token(Token = "0x600C568")]
		[Address(RVA = "0x3421E80", Offset = "0x3420A80", VA = "0x183421E80")]
		public bool TryGet(string cmd, out IAVGCommandStateFilter filter)
		{
			return default(bool);
		}

		// Token: 0x0600C569 RID: 50537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C569")]
		[Address(RVA = "0x341FAB0", Offset = "0x341E6B0", VA = "0x18341FAB0")]
		public List<Command> FilterContextStateCommands(IList<Command> cmds, int endIndex)
		{
			return null;
		}

		// Token: 0x0600C56A RID: 50538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C56A")]
		[Address(RVA = "0x341FD90", Offset = "0x341E990", VA = "0x18341FD90")]
		public void RegisterDefaults()
		{
		}

		// Token: 0x0600C56B RID: 50539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C56B")]
		[Address(RVA = "0x3421F60", Offset = "0x3420B60", VA = "0x183421F60")]
		public AVGContextStateService()
		{
		}

		// Token: 0x0400CA2A RID: 51754
		[Token(Token = "0x400CA2A")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, IAVGCommandStateFilter> m_filters;

		// Token: 0x0400CA2B RID: 51755
		[Token(Token = "0x400CA2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Register;

		// Token: 0x0400CA2C RID: 51756
		[Token(Token = "0x400CA2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryGet;

		// Token: 0x0400CA2D RID: 51757
		[Token(Token = "0x400CA2D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FilterContextStateCommands;

		// Token: 0x0400CA2E RID: 51758
		[Token(Token = "0x400CA2E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterDefaults;

		// Token: 0x0400CA2F RID: 51759
		[Token(Token = "0x400CA2F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F16 RID: 7958
		[Token(Token = "0x2001F16")]
		private sealed class SimpleFilter : IAVGCommandStateFilter, IHotfixable
		{
			// Token: 0x17001783 RID: 6019
			// (get) Token: 0x0600C56C RID: 50540 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001783")]
			public string CommandName
			{
				[Token(Token = "0x600C56C")]
				[Address(RVA = "0x3472FE0", Offset = "0x3471BE0", VA = "0x183472FE0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600C56D RID: 50541 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C56D")]
			[Address(RVA = "0x3472F40", Offset = "0x3471B40", VA = "0x183472F40")]
			public SimpleFilter(string commandName, Action<Command, AVGContextStateBuilder> apply)
			{
			}

			// Token: 0x0600C56E RID: 50542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C56E")]
			[Address(RVA = "0x3472EA0", Offset = "0x3471AA0", VA = "0x183472EA0", Slot = "5")]
			public void Apply(Command cmd, AVGContextStateBuilder builder)
			{
			}

			// Token: 0x0400CA31 RID: 51761
			[Token(Token = "0x400CA31")]
			[FieldOffset(Offset = "0x18")]
			private readonly Action<Command, AVGContextStateBuilder> m_apply;

			// Token: 0x0400CA32 RID: 51762
			[Token(Token = "0x400CA32")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_CommandName;

			// Token: 0x0400CA33 RID: 51763
			[Token(Token = "0x400CA33")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400CA34 RID: 51764
			[Token(Token = "0x400CA34")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Apply;
		}
	}
}
