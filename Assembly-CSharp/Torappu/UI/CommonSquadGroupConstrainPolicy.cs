using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035D7 RID: 13783
	[Token(Token = "0x20035D7")]
	public abstract class CommonSquadGroupConstrainPolicy : IHotfixable
	{
		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x06015EE0 RID: 89824 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015EE1 RID: 89825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170034B3")]
		private protected CommonSquadStateBean closure
		{
			[Token(Token = "0x6015EE0")]
			[Address(RVA = "0xE76040", Offset = "0xE74C40", VA = "0x180E76040")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6015EE1")]
			[Address(RVA = "0xE760A0", Offset = "0xE74CA0", VA = "0x180E760A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015EE2 RID: 89826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EE2")]
		[Address(RVA = "0xE75F30", Offset = "0xE74B30", VA = "0x180E75F30")]
		public void SetClosure(CommonSquadStateBean closure)
		{
		}

		// Token: 0x06015EE3 RID: 89827 RVA: 0x0008EB00 File Offset: 0x0008CD00
		[Token(Token = "0x6015EE3")]
		[Address(RVA = "0xE75A30", Offset = "0xE74630", VA = "0x180E75A30", Slot = "4")]
		public virtual bool CheckIfAssistLocked(out string errorCode)
		{
			return default(bool);
		}

		// Token: 0x06015EE4 RID: 89828 RVA: 0x0008EB18 File Offset: 0x0008CD18
		[Token(Token = "0x6015EE4")]
		[Address(RVA = "0xE75CA0", Offset = "0xE748A0", VA = "0x180E75CA0", Slot = "5")]
		public virtual bool CheckIfSquadSlotLocked(int index, out string errorCode)
		{
			return default(bool);
		}

		// Token: 0x06015EE5 RID: 89829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EE5")]
		[Address(RVA = "0xE75FE0", Offset = "0xE74BE0", VA = "0x180E75FE0")]
		protected CommonSquadGroupConstrainPolicy()
		{
		}

		// Token: 0x0401A5C7 RID: 107975
		[Token(Token = "0x401A5C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_closure;

		// Token: 0x0401A5C8 RID: 107976
		[Token(Token = "0x401A5C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_closure;

		// Token: 0x0401A5C9 RID: 107977
		[Token(Token = "0x401A5C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetClosure;

		// Token: 0x0401A5CA RID: 107978
		[Token(Token = "0x401A5CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfAssistLocked;

		// Token: 0x0401A5CB RID: 107979
		[Token(Token = "0x401A5CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfSquadSlotLocked;

		// Token: 0x0401A5CC RID: 107980
		[Token(Token = "0x401A5CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
