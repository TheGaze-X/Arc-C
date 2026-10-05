using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public class DropdownMenuAction : DropdownMenuItem
	{
		// Token: 0x17000020 RID: 32
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		private DropdownMenuAction.Status status
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		private DropdownMenuEventInfo eventInfo
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		private object userData
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x5A2BB90", Offset = "0x5A2A790", VA = "0x185A2BB90")]
		public DropdownMenuAction(string actionName, Action<DropdownMenuAction> actionCallback, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, [Optional] object userData)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x5A2BB40", Offset = "0x5A2A740", VA = "0x185A2BB40")]
		public void UpdateActionStatus(DropdownMenuEventInfo eventInfo)
		{
		}

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Action<DropdownMenuAction> actionCallback;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback;

		// Token: 0x02000021 RID: 33
		[Token(Token = "0x2000021")]
		[Flags]
		public enum Status
		{
			// Token: 0x0400005F RID: 95
			[Token(Token = "0x400005F")]
			None = 0,
			// Token: 0x04000060 RID: 96
			[Token(Token = "0x4000060")]
			Normal = 1,
			// Token: 0x04000061 RID: 97
			[Token(Token = "0x4000061")]
			Disabled = 2,
			// Token: 0x04000062 RID: 98
			[Token(Token = "0x4000062")]
			Checked = 4,
			// Token: 0x04000063 RID: 99
			[Token(Token = "0x4000063")]
			Hidden = 8
		}
	}
}
