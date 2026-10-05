using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002658 RID: 9816
	[Token(Token = "0x2002658")]
	public class GameObjectSetActiveWrapper : IHotfixable
	{
		// Token: 0x060100C6 RID: 65734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60100C6")]
		[Address(RVA = "0x7C6360", Offset = "0x7C4F60", VA = "0x1807C6360")]
		public GameObjectSetActiveWrapper(GameObject gameObjectNullable)
		{
		}

		// Token: 0x060100C7 RID: 65735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60100C7")]
		[Address(RVA = "0x7C62F0", Offset = "0x7C4EF0", VA = "0x1807C62F0")]
		public void SetActiveVal(bool value)
		{
		}

		// Token: 0x060100C8 RID: 65736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60100C8")]
		[Address(RVA = "0x7C6240", Offset = "0x7C4E40", VA = "0x1807C6240")]
		public void ApplyActiveVal()
		{
		}

		// Token: 0x04011DA1 RID: 73121
		[Token(Token = "0x4011DA1")]
		[FieldOffset(Offset = "0x10")]
		private GameObject m_gameObjectNullable;

		// Token: 0x04011DA2 RID: 73122
		[Token(Token = "0x4011DA2")]
		[FieldOffset(Offset = "0x18")]
		private bool m_lastValue;

		// Token: 0x04011DA3 RID: 73123
		[Token(Token = "0x4011DA3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04011DA4 RID: 73124
		[Token(Token = "0x4011DA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetActiveVal;

		// Token: 0x04011DA5 RID: 73125
		[Token(Token = "0x4011DA5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyActiveVal;
	}
}
