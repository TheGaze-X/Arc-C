using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DD6 RID: 7638
	[Token(Token = "0x2001DD6")]
	public class BuildingFloatNonVisitState : BuildingFloatState
	{
		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x0600BC6A RID: 48234 RVA: 0x00046230 File Offset: 0x00044430
		[Token(Token = "0x170016C9")]
		protected override FloatState state
		{
			[Token(Token = "0x600BC6A")]
			[Address(RVA = "0x338A830", Offset = "0x3389430", VA = "0x18338A830", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BC6B RID: 48235 RVA: 0x00046248 File Offset: 0x00044448
		[Token(Token = "0x600BC6B")]
		[Address(RVA = "0x338A750", Offset = "0x3389350", VA = "0x18338A750", Slot = "11")]
		protected override bool CheckIfToActive(FloatState targetState)
		{
			return default(bool);
		}

		// Token: 0x0600BC6C RID: 48236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC6C")]
		[Address(RVA = "0x338A7D0", Offset = "0x33893D0", VA = "0x18338A7D0")]
		public BuildingFloatNonVisitState()
		{
		}

		// Token: 0x0600BC6D RID: 48237 RVA: 0x00046260 File Offset: 0x00044460
		[Token(Token = "0x600BC6D")]
		[Address(RVA = "0x338A7C0", Offset = "0x33893C0", VA = "0x18338A7C0")]
		private bool <>xLuaBaseProxy_CheckIfToActive(FloatState P0)
		{
			return default(bool);
		}

		// Token: 0x0400BC77 RID: 48247
		[Token(Token = "0x400BC77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BC78 RID: 48248
		[Token(Token = "0x400BC78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfToActive;

		// Token: 0x0400BC79 RID: 48249
		[Token(Token = "0x400BC79")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
