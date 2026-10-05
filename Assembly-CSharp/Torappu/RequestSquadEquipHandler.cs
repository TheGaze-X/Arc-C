using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020008A6 RID: 2214
	[Token(Token = "0x20008A6")]
	public abstract class RequestSquadEquipHandler : IHotfixable
	{
		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06006545 RID: 25925 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006546 RID: 25926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CE0")]
		public string equipId
		{
			[Token(Token = "0x6006545")]
			[Address(RVA = "0x1F00750", Offset = "0x1EFF350", VA = "0x181F00750")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006546")]
			[Address(RVA = "0x1F007B0", Offset = "0x1EFF3B0", VA = "0x181F007B0")]
			set
			{
			}
		}

		// Token: 0x06006547 RID: 25927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006547")]
		[Address(RVA = "0x1F006F0", Offset = "0x1EFF2F0", VA = "0x181F006F0")]
		protected RequestSquadEquipHandler()
		{
		}

		// Token: 0x0400326D RID: 12909
		[Token(Token = "0x400326D")]
		[FieldOffset(Offset = "0x10")]
		private string m_equipId;

		// Token: 0x0400326E RID: 12910
		[Token(Token = "0x400326E")]
		[FieldOffset(Offset = "0x18")]
		public string defaultEquipId;

		// Token: 0x0400326F RID: 12911
		[Token(Token = "0x400326F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_equipId;

		// Token: 0x04003270 RID: 12912
		[Token(Token = "0x4003270")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_equipId;

		// Token: 0x04003271 RID: 12913
		[Token(Token = "0x4003271")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
