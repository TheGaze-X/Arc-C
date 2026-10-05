using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A77 RID: 6775
	[Token(Token = "0x2001A77")]
	public class VCharacterEmojiAnimItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600AAC9 RID: 43721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AAC9")]
		[Address(RVA = "0x325CE20", Offset = "0x325BA20", VA = "0x18325CE20")]
		public Tween PlayAnim()
		{
			return null;
		}

		// Token: 0x0600AACA RID: 43722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AACA")]
		[Address(RVA = "0x325CED0", Offset = "0x325BAD0", VA = "0x18325CED0")]
		public VCharacterEmojiAnimItem()
		{
		}

		// Token: 0x0400A329 RID: 41769
		[Token(Token = "0x400A329")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x0400A32A RID: 41770
		[Token(Token = "0x400A32A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x0400A32B RID: 41771
		[Token(Token = "0x400A32B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
