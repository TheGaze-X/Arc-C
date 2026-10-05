using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005836 RID: 22582
	[Token(Token = "0x2005836")]
	public class RL03StatusBarChaosEffect : RoguelikeMenuEffect
	{
		// Token: 0x06021020 RID: 135200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021020")]
		[Address(RVA = "0x1B52520", Offset = "0x1B51120", VA = "0x181B52520")]
		public void RenderChaosEffect(RL03StatusBarChaosEffect.RenderParam renderParam)
		{
		}

		// Token: 0x06021021 RID: 135201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021021")]
		[Address(RVA = "0x1B52620", Offset = "0x1B51220", VA = "0x181B52620")]
		public RL03StatusBarChaosEffect()
		{
		}

		// Token: 0x0402CE33 RID: 183859
		[Token(Token = "0x402CE33")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _effectRectTransform;

		// Token: 0x0402CE34 RID: 183860
		[Token(Token = "0x402CE34")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _startRotationZ;

		// Token: 0x0402CE35 RID: 183861
		[Token(Token = "0x402CE35")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _endRotationZ;

		// Token: 0x0402CE36 RID: 183862
		[Token(Token = "0x402CE36")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderChaosEffect;

		// Token: 0x0402CE37 RID: 183863
		[Token(Token = "0x402CE37")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005837 RID: 22583
		[Token(Token = "0x2005837")]
		public struct RenderParam
		{
			// Token: 0x0402CE38 RID: 183864
			[Token(Token = "0x402CE38")]
			[FieldOffset(Offset = "0x0")]
			public int chaosLevel;

			// Token: 0x0402CE39 RID: 183865
			[Token(Token = "0x402CE39")]
			[FieldOffset(Offset = "0x4")]
			public int chaosMaxLevel;
		}
	}
}
