using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200324D RID: 12877
	[Token(Token = "0x200324D")]
	public class RandomEmitter : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x060146C6 RID: 83654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146C6")]
		[Address(RVA = "0xCABCE0", Offset = "0xCAA8E0", VA = "0x180CABCE0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060146C7 RID: 83655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146C7")]
		[Address(RVA = "0xCABC40", Offset = "0xCAA840", VA = "0x180CABC40", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060146C8 RID: 83656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60146C8")]
		[Address(RVA = "0xCABDE0", Offset = "0xCAA9E0", VA = "0x180CABDE0")]
		private IEnumerator _DoEmit()
		{
			return null;
		}

		// Token: 0x060146C9 RID: 83657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146C9")]
		[Address(RVA = "0xCABBE0", Offset = "0xCAA7E0", VA = "0x180CABBE0", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x060146CA RID: 83658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146CA")]
		[Address(RVA = "0xCABE90", Offset = "0xCAAA90", VA = "0x180CABE90")]
		public RandomEmitter()
		{
		}

		// Token: 0x060146CB RID: 83659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146CB")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x040181F1 RID: 98801
		[Token(Token = "0x40181F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _count;

		// Token: 0x040181F2 RID: 98802
		[Token(Token = "0x40181F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _effect;

		// Token: 0x040181F3 RID: 98803
		[Token(Token = "0x40181F3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _preDelay;

		// Token: 0x040181F4 RID: 98804
		[Token(Token = "0x40181F4")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _delayPerEffect;

		// Token: 0x040181F5 RID: 98805
		[Token(Token = "0x40181F5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 _randomRangeFrom;

		// Token: 0x040181F6 RID: 98806
		[Token(Token = "0x40181F6")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Vector3 _randomRangeTo;

		// Token: 0x040181F7 RID: 98807
		[Token(Token = "0x40181F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040181F8 RID: 98808
		[Token(Token = "0x40181F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040181F9 RID: 98809
		[Token(Token = "0x40181F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DoEmit;

		// Token: 0x040181FA RID: 98810
		[Token(Token = "0x40181FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x040181FB RID: 98811
		[Token(Token = "0x40181FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
