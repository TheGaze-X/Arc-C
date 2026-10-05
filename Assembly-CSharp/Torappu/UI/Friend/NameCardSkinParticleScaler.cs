using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DF1 RID: 19953
	[Token(Token = "0x2004DF1")]
	[RequireComponent(typeof(UIParticle))]
	public class NameCardSkinParticleScaler : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DD2A RID: 122154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD2A")]
		[Address(RVA = "0x1757540", Offset = "0x1756140", VA = "0x181757540")]
		private void Start()
		{
		}

		// Token: 0x0601DD2B RID: 122155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD2B")]
		[Address(RVA = "0x1757740", Offset = "0x1756340", VA = "0x181757740")]
		private void _ApplyParticleScale(UIParticle uip, Transform scaler)
		{
		}

		// Token: 0x0601DD2C RID: 122156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD2C")]
		[Address(RVA = "0x1757870", Offset = "0x1756470", VA = "0x181757870")]
		public NameCardSkinParticleScaler()
		{
		}

		// Token: 0x0402781B RID: 161819
		[Token(Token = "0x402781B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0402781C RID: 161820
		[Token(Token = "0x402781C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ApplyParticleScale;

		// Token: 0x0402781D RID: 161821
		[Token(Token = "0x402781D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
