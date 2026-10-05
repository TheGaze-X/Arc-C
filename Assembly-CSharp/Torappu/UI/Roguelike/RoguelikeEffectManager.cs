using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005449 RID: 21577
	[Token(Token = "0x2005449")]
	public class RoguelikeEffectManager : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FBE9 RID: 130025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FBE9")]
		public TEffect AttachRoguelikeEffect<TEffect>(TEffect effectPrefab) where TEffect : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0601FBEA RID: 130026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FBEA")]
		[Address(RVA = "0x196AFF0", Offset = "0x1969BF0", VA = "0x18196AFF0")]
		public void SetAllParticleEffectVisible(bool isVisible)
		{
		}

		// Token: 0x0601FBEB RID: 130027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FBEB")]
		[Address(RVA = "0x196B070", Offset = "0x1969C70", VA = "0x18196B070")]
		public RoguelikeEffectManager()
		{
		}

		// Token: 0x0402AC60 RID: 175200
		[Token(Token = "0x402AC60")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AttachRoguelikeEffect;

		// Token: 0x0402AC61 RID: 175201
		[Token(Token = "0x402AC61")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetAllParticleEffectVisible;

		// Token: 0x0402AC62 RID: 175202
		[Token(Token = "0x402AC62")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
