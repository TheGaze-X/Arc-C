using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003256 RID: 12886
	[Token(Token = "0x2003256")]
	public class AutoChessFlyToPosition : Effect.Behaviour
	{
		// Token: 0x060146FA RID: 83706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146FA")]
		[Address(RVA = "0xCAF4D0", Offset = "0xCAE0D0", VA = "0x180CAF4D0")]
		public void FlyTo(Vector3 pos)
		{
		}

		// Token: 0x060146FB RID: 83707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146FB")]
		[Address(RVA = "0xCAF660", Offset = "0xCAE260", VA = "0x180CAF660", Slot = "7")]
		public override void OnRecycle()
		{
		}

		// Token: 0x060146FC RID: 83708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146FC")]
		[Address(RVA = "0xCAF6F0", Offset = "0xCAE2F0", VA = "0x180CAF6F0")]
		public AutoChessFlyToPosition()
		{
		}

		// Token: 0x060146FE RID: 83710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146FE")]
		[Address(RVA = "0xC9CBA0", Offset = "0xC9B7A0", VA = "0x180C9CBA0")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x04018241 RID: 98881
		[Token(Token = "0x4018241")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _duration;

		// Token: 0x04018242 RID: 98882
		[Token(Token = "0x4018242")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Ease _easeType;

		// Token: 0x04018243 RID: 98883
		[Token(Token = "0x4018243")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isIndependentUpdate;

		// Token: 0x04018244 RID: 98884
		[Token(Token = "0x4018244")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_tween;

		// Token: 0x04018245 RID: 98885
		[Token(Token = "0x4018245")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FlyTo;

		// Token: 0x04018246 RID: 98886
		[Token(Token = "0x4018246")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04018247 RID: 98887
		[Token(Token = "0x4018247")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
