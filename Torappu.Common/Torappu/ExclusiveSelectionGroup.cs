using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	public class ExclusiveSelectionGroup : IHotfixable
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x00005384 File Offset: 0x00003584
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x54FCD20", Offset = "0x54FB920", VA = "0x1854FCD20")]
		public bool RequestSetState(ExclusiveSelectionGroup.ITarget target, bool isSelected)
		{
			return default(bool);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x54FCF80", Offset = "0x54FBB80", VA = "0x1854FCF80")]
		public void ResetUnselect()
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x54FD120", Offset = "0x54FBD20", VA = "0x1854FD120")]
		public ExclusiveSelectionGroup()
		{
		}

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isProcessing;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x18")]
		private List<ExclusiveSelectionGroup.ITarget> m_targets;

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate54 __Hotfix0_RequestSetState;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ResetUnselect;

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x020000B4 RID: 180
		[Token(Token = "0x20000B4")]
		public interface ITarget
		{
			// Token: 0x06000462 RID: 1122
			[Token(Token = "0x6000462")]
			void SetGroup(ExclusiveSelectionGroup group);

			// Token: 0x06000463 RID: 1123
			[Token(Token = "0x6000463")]
			void OnConfirmState(bool isSelected);
		}
	}
}
