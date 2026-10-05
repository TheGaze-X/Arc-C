using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C4D RID: 19533
	[Token(Token = "0x2004C4D")]
	public class HomeThemeAnimationWrapper : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D513 RID: 120083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D513")]
		[Address(RVA = "0x16E3610", Offset = "0x16E2210", VA = "0x1816E3610")]
		public void PlayAnim()
		{
		}

		// Token: 0x0601D514 RID: 120084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D514")]
		[Address(RVA = "0x16E3710", Offset = "0x16E2310", VA = "0x1816E3710")]
		public void StopLoop()
		{
		}

		// Token: 0x0601D515 RID: 120085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D515")]
		[Address(RVA = "0x16E3780", Offset = "0x16E2380", VA = "0x1816E3780")]
		public HomeThemeAnimationWrapper()
		{
		}

		// Token: 0x04026928 RID: 157992
		[Token(Token = "0x4026928")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x04026929 RID: 157993
		[Token(Token = "0x4026929")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _clipName;

		// Token: 0x0402692A RID: 157994
		[Token(Token = "0x402692A")]
		[FieldOffset(Offset = "0x28")]
		private Tween m_tween;

		// Token: 0x0402692B RID: 157995
		[Token(Token = "0x402692B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x0402692C RID: 157996
		[Token(Token = "0x402692C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StopLoop;

		// Token: 0x0402692D RID: 157997
		[Token(Token = "0x402692D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
