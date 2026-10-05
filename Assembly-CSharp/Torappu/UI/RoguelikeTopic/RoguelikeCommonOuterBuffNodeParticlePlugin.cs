using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004504 RID: 17668
	[Token(Token = "0x2004504")]
	public class RoguelikeCommonOuterBuffNodeParticlePlugin : MonoBehaviour, IRoguelikeCommonOuterBuffNodePlugin, IHotfixable
	{
		// Token: 0x0601AF5E RID: 110430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF5E")]
		[Address(RVA = "0x141E730", Offset = "0x141D330", VA = "0x18141E730", Slot = "4")]
		public void Init(RoguelikeCommonOuterBuffNodeBaseViewModel model)
		{
		}

		// Token: 0x0601AF5F RID: 110431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF5F")]
		[Address(RVA = "0x141E7D0", Offset = "0x141D3D0", VA = "0x18141E7D0", Slot = "5")]
		public void Render(string selectedBuffId, RoguelikeCommonOuterBuffNodeBaseViewModel model)
		{
		}

		// Token: 0x0601AF60 RID: 110432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF60")]
		[Address(RVA = "0x141E9F0", Offset = "0x141D5F0", VA = "0x18141E9F0")]
		private void _Play()
		{
		}

		// Token: 0x0601AF61 RID: 110433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AF61")]
		[Address(RVA = "0x141E8F0", Offset = "0x141D4F0", VA = "0x18141E8F0")]
		private Tween _PlayTween()
		{
			return null;
		}

		// Token: 0x0601AF62 RID: 110434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF62")]
		[Address(RVA = "0x141EC30", Offset = "0x141D830", VA = "0x18141EC30")]
		public RoguelikeCommonOuterBuffNodeParticlePlugin()
		{
		}

		// Token: 0x0402298E RID: 141710
		[Token(Token = "0x402298E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIParticle _particleEffectPrefab;

		// Token: 0x0402298F RID: 141711
		[Token(Token = "0x402298F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _particleEffectHolder;

		// Token: 0x04022990 RID: 141712
		[Token(Token = "0x4022990")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _playDelay;

		// Token: 0x04022991 RID: 141713
		[Token(Token = "0x4022991")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_cachedActive;

		// Token: 0x04022992 RID: 141714
		[Token(Token = "0x4022992")]
		[FieldOffset(Offset = "0x2D")]
		private bool m_instantiated;

		// Token: 0x04022993 RID: 141715
		[Token(Token = "0x4022993")]
		[FieldOffset(Offset = "0x30")]
		private UIParticle m_particleEffect;

		// Token: 0x04022994 RID: 141716
		[Token(Token = "0x4022994")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_playTween;

		// Token: 0x04022995 RID: 141717
		[Token(Token = "0x4022995")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022996 RID: 141718
		[Token(Token = "0x4022996")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022997 RID: 141719
		[Token(Token = "0x4022997")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Play;

		// Token: 0x04022998 RID: 141720
		[Token(Token = "0x4022998")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayTween;

		// Token: 0x04022999 RID: 141721
		[Token(Token = "0x4022999")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
