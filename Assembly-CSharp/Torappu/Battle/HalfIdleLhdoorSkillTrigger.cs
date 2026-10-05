using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002566 RID: 9574
	[Token(Token = "0x2002566")]
	[RequireComponent(typeof(TargetSelector))]
	public class HalfIdleLhdoorSkillTrigger : SelectorTrigger
	{
		// Token: 0x0600F71C RID: 63260 RVA: 0x0005C370 File Offset: 0x0005A570
		[Token(Token = "0x600F71C")]
		[Address(RVA = "0x70DCF0", Offset = "0x70C8F0", VA = "0x18070DCF0", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F71D RID: 63261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F71D")]
		[Address(RVA = "0x70E470", Offset = "0x70D070", VA = "0x18070E470")]
		public HalfIdleLhdoorSkillTrigger()
		{
		}

		// Token: 0x0600F71E RID: 63262 RVA: 0x0005C388 File Offset: 0x0005A588
		[Token(Token = "0x600F71E")]
		[Address(RVA = "0x6F1EC0", Offset = "0x6F0AC0", VA = "0x1806F1EC0")]
		private bool <>xLuaBaseProxy_Search(bool P0)
		{
			return default(bool);
		}

		// Token: 0x04011281 RID: 70273
		[Token(Token = "0x4011281")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MotionMode _motionMode;

		// Token: 0x04011282 RID: 70274
		[Token(Token = "0x4011282")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x04011283 RID: 70275
		[Token(Token = "0x4011283")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
