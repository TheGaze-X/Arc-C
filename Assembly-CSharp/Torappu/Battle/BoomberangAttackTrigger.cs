using System;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200255B RID: 9563
	[Token(Token = "0x200255B")]
	public class BoomberangAttackTrigger : SelectorTrigger
	{
		// Token: 0x0600F6D7 RID: 63191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6D7")]
		[Address(RVA = "0x6F1C10", Offset = "0x6F0810", VA = "0x1806F1C10", Slot = "12")]
		public override void Reset(Entity owner, Ability ability)
		{
		}

		// Token: 0x0600F6D8 RID: 63192 RVA: 0x0005C058 File Offset: 0x0005A258
		[Token(Token = "0x600F6D8")]
		[Address(RVA = "0x6F1DD0", Offset = "0x6F09D0", VA = "0x1806F1DD0", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F6D9 RID: 63193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6D9")]
		[Address(RVA = "0x6F1ED0", Offset = "0x6F0AD0", VA = "0x1806F1ED0")]
		public BoomberangAttackTrigger()
		{
		}

		// Token: 0x0600F6DA RID: 63194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6DA")]
		[Address(RVA = "0x6F1EB0", Offset = "0x6F0AB0", VA = "0x1806F1EB0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1)
		{
		}

		// Token: 0x0600F6DB RID: 63195 RVA: 0x0005C070 File Offset: 0x0005A270
		[Token(Token = "0x600F6DB")]
		[Address(RVA = "0x6F1EC0", Offset = "0x6F0AC0", VA = "0x1806F1EC0")]
		private bool <>xLuaBaseProxy_Search(bool P0)
		{
			return default(bool);
		}

		// Token: 0x0401122D RID: 70189
		[Token(Token = "0x401122D")]
		[FieldOffset(Offset = "0x50")]
		private BoomberangTrait m_trait;

		// Token: 0x0401122E RID: 70190
		[Token(Token = "0x401122E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401122F RID: 70191
		[Token(Token = "0x401122F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x04011230 RID: 70192
		[Token(Token = "0x4011230")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
