using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F46 RID: 24390
	[Token(Token = "0x2005F46")]
	public class CharacterEvolveDetailCommon : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023527 RID: 144679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023527")]
		[Address(RVA = "0x1DD4250", Offset = "0x1DD2E50", VA = "0x181DD4250")]
		public void AnimRender()
		{
		}

		// Token: 0x06023528 RID: 144680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023528")]
		[Address(RVA = "0x1DD41D0", Offset = "0x1DD2DD0", VA = "0x181DD41D0")]
		public void AnimBack()
		{
		}

		// Token: 0x06023529 RID: 144681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023529")]
		[Address(RVA = "0x1DD42D0", Offset = "0x1DD2ED0", VA = "0x181DD42D0")]
		public CharacterEvolveDetailCommon()
		{
		}

		// Token: 0x04030BCC RID: 199628
		[Token(Token = "0x4030BCC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator _animatorController;

		// Token: 0x04030BCD RID: 199629
		[Token(Token = "0x4030BCD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AnimRender;

		// Token: 0x04030BCE RID: 199630
		[Token(Token = "0x4030BCE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AnimBack;

		// Token: 0x04030BCF RID: 199631
		[Token(Token = "0x4030BCF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
