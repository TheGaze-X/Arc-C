using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Mode
{
	// Token: 0x0200466E RID: 18030
	[Token(Token = "0x200466E")]
	public class RoguelikeTopicKeyVisualTemplate : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B600 RID: 112128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B600")]
		[Address(RVA = "0x14BAC20", Offset = "0x14B9820", VA = "0x1814BAC20")]
		public void AttachBackground(Transform root)
		{
		}

		// Token: 0x0601B601 RID: 112129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B601")]
		[Address(RVA = "0x14BACD0", Offset = "0x14B98D0", VA = "0x1814BACD0")]
		public GameObject AttachEffect(Transform root)
		{
			return null;
		}

		// Token: 0x0601B602 RID: 112130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B602")]
		[Address(RVA = "0x14BAD80", Offset = "0x14B9980", VA = "0x1814BAD80")]
		public void AttachForeground(Transform root)
		{
		}

		// Token: 0x0601B603 RID: 112131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B603")]
		[Address(RVA = "0x14BAE60", Offset = "0x14B9A60", VA = "0x1814BAE60")]
		public RoguelikeTopicKeyVisualTemplate()
		{
		}

		// Token: 0x04023606 RID: 144902
		[Token(Token = "0x4023606")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _bg;

		// Token: 0x04023607 RID: 144903
		[Token(Token = "0x4023607")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _effect;

		// Token: 0x04023608 RID: 144904
		[Token(Token = "0x4023608")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _fg;

		// Token: 0x04023609 RID: 144905
		[Token(Token = "0x4023609")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AttachBackground;

		// Token: 0x0402360A RID: 144906
		[Token(Token = "0x402360A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AttachEffect;

		// Token: 0x0402360B RID: 144907
		[Token(Token = "0x402360B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AttachForeground;

		// Token: 0x0402360C RID: 144908
		[Token(Token = "0x402360C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
