using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002447 RID: 9287
	[Token(Token = "0x2002447")]
	public class AutoCastablePassiveSkill : CastSkill
	{
		// Token: 0x0600ED90 RID: 60816 RVA: 0x00056DC0 File Offset: 0x00054FC0
		[Token(Token = "0x600ED90")]
		[Address(RVA = "0x636590", Offset = "0x635190", VA = "0x180636590", Slot = "19")]
		public override bool IsAvailable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600ED91 RID: 60817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED91")]
		[Address(RVA = "0x636690", Offset = "0x635290", VA = "0x180636690", Slot = "74")]
		protected override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600ED92 RID: 60818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED92")]
		[Address(RVA = "0x636860", Offset = "0x635460", VA = "0x180636860")]
		public AutoCastablePassiveSkill()
		{
		}

		// Token: 0x0600ED93 RID: 60819 RVA: 0x00056DD8 File Offset: 0x00054FD8
		[Token(Token = "0x600ED93")]
		[Address(RVA = "0x636840", Offset = "0x635440", VA = "0x180636840")]
		private bool <>xLuaBaseProxy_IsAvailable(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600ED94 RID: 60820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED94")]
		[Address(RVA = "0x636850", Offset = "0x635450", VA = "0x180636850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040106AB RID: 67243
		[Token(Token = "0x40106AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsAvailable;

		// Token: 0x040106AC RID: 67244
		[Token(Token = "0x40106AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040106AD RID: 67245
		[Token(Token = "0x40106AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
