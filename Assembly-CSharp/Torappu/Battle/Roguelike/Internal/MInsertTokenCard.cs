using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x0200296F RID: 10607
	[Token(Token = "0x200296F")]
	public class MInsertTokenCard : BasicMiscRelic
	{
		// Token: 0x060118E9 RID: 71913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118E9")]
		[Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "5")]
		public override void OnInit()
		{
		}

		// Token: 0x060118EA RID: 71914 RVA: 0x0006BE20 File Offset: 0x0006A020
		[Token(Token = "0x60118EA")]
		[Address(RVA = "0x9576D0", Offset = "0x9562D0", VA = "0x1809576D0")]
		private bool _TryAddCntIfAlreadyExist(Blackboard blackboard)
		{
			return default(bool);
		}

		// Token: 0x060118EB RID: 71915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118EB")]
		[Address(RVA = "0x957370", Offset = "0x955F70", VA = "0x180957370")]
		protected void InsertToken(Blackboard blackboard)
		{
		}

		// Token: 0x060118EC RID: 71916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118EC")]
		[Address(RVA = "0x957840", Offset = "0x956440", VA = "0x180957840")]
		public MInsertTokenCard()
		{
		}

		// Token: 0x060118ED RID: 71917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118ED")]
		[Address(RVA = "0x950440", Offset = "0x94F040", VA = "0x180950440")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x040139E9 RID: 80361
		[Token(Token = "0x40139E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040139EA RID: 80362
		[Token(Token = "0x40139EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryAddCntIfAlreadyExist;

		// Token: 0x040139EB RID: 80363
		[Token(Token = "0x40139EB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InsertToken;

		// Token: 0x040139EC RID: 80364
		[Token(Token = "0x40139EC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
