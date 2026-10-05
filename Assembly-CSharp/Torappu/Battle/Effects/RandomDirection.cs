using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200324C RID: 12876
	[Token(Token = "0x200324C")]
	public class RandomDirection : Effect.Behaviour
	{
		// Token: 0x060146C1 RID: 83649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146C1")]
		[Address(RVA = "0xCAB6D0", Offset = "0xCAA2D0", VA = "0x180CAB6D0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060146C2 RID: 83650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146C2")]
		[Address(RVA = "0xCAB8D0", Offset = "0xCAA4D0", VA = "0x180CAB8D0")]
		private void UpdateDirection()
		{
		}

		// Token: 0x060146C3 RID: 83651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146C3")]
		[Address(RVA = "0xCABA80", Offset = "0xCAA680", VA = "0x180CABA80")]
		private void _RandomDirection(Entity entity)
		{
		}

		// Token: 0x060146C4 RID: 83652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146C4")]
		[Address(RVA = "0xCABB80", Offset = "0xCAA780", VA = "0x180CABB80")]
		public RandomDirection()
		{
		}

		// Token: 0x060146C5 RID: 83653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146C5")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x040181EB RID: 98795
		[Token(Token = "0x40181EB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _randomRotationFrom;

		// Token: 0x040181EC RID: 98796
		[Token(Token = "0x40181EC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 _randomRotationTo;

		// Token: 0x040181ED RID: 98797
		[Token(Token = "0x40181ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040181EE RID: 98798
		[Token(Token = "0x40181EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateDirection;

		// Token: 0x040181EF RID: 98799
		[Token(Token = "0x40181EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RandomDirection;

		// Token: 0x040181F0 RID: 98800
		[Token(Token = "0x40181F0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
