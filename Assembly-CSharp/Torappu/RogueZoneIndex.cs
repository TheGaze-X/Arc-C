using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200116A RID: 4458
	[Token(Token = "0x200116A")]
	public class RogueZoneIndex : IHotfixable
	{
		// Token: 0x06006F59 RID: 28505 RVA: 0x00032688 File Offset: 0x00030888
		[Token(Token = "0x6006F59")]
		[Address(RVA = "0x2110220", Offset = "0x210EE20", VA = "0x182110220")]
		public bool IsEqual(RogueZoneIndex index)
		{
			return default(bool);
		}

		// Token: 0x06006F5A RID: 28506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F5A")]
		[Address(RVA = "0x21102B0", Offset = "0x210EEB0", VA = "0x1821102B0")]
		public RogueZoneIndex()
		{
		}

		// Token: 0x04005F80 RID: 24448
		[Token(Token = "0x4005F80")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04005F81 RID: 24449
		[Token(Token = "0x4005F81")]
		[FieldOffset(Offset = "0x18")]
		public PlayerRoguelikeZoneType zoneType;

		// Token: 0x04005F82 RID: 24450
		[Token(Token = "0x4005F82")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEqual;

		// Token: 0x04005F83 RID: 24451
		[Token(Token = "0x4005F83")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
