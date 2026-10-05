using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003230 RID: 12848
	[Token(Token = "0x2003230")]
	public class FollowOwner : Effect.Behaviour
	{
		// Token: 0x06014602 RID: 83458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014602")]
		[Address(RVA = "0xC9EDD0", Offset = "0xC9D9D0", VA = "0x180C9EDD0")]
		private void Update()
		{
		}

		// Token: 0x06014603 RID: 83459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014603")]
		[Address(RVA = "0xC9EEA0", Offset = "0xC9DAA0", VA = "0x180C9EEA0")]
		private void _FollowEntity(Entity entity)
		{
		}

		// Token: 0x06014604 RID: 83460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014604")]
		[Address(RVA = "0xC9F2F0", Offset = "0xC9DEF0", VA = "0x180C9F2F0")]
		public FollowOwner()
		{
		}

		// Token: 0x040180B7 RID: 98487
		[Token(Token = "0x40180B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040180B8 RID: 98488
		[Token(Token = "0x40180B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FollowEntity;

		// Token: 0x040180B9 RID: 98489
		[Token(Token = "0x40180B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
