using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E3E RID: 7742
	[Token(Token = "0x2001E3E")]
	public class AVGAnimatedKV : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600BFB2 RID: 49074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BFB2")]
		[Address(RVA = "0x33CFF50", Offset = "0x33CEB50", VA = "0x1833CFF50")]
		public Tween PlayEntry(float from, float to, float duration)
		{
			return null;
		}

		// Token: 0x0600BFB3 RID: 49075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BFB3")]
		[Address(RVA = "0x33D01D0", Offset = "0x33CEDD0", VA = "0x1833D01D0")]
		private AnimationWrapper _EnsureWrapper()
		{
			return null;
		}

		// Token: 0x0600BFB4 RID: 49076 RVA: 0x00046B00 File Offset: 0x00044D00
		[Token(Token = "0x600BFB4")]
		[Address(RVA = "0x33D02A0", Offset = "0x33CEEA0", VA = "0x1833D02A0")]
		private float _GetPosition()
		{
			return 0f;
		}

		// Token: 0x0600BFB5 RID: 49077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFB5")]
		[Address(RVA = "0x33D0300", Offset = "0x33CEF00", VA = "0x1833D0300")]
		private void _SetPosition(float value)
		{
		}

		// Token: 0x0600BFB6 RID: 49078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFB6")]
		[Address(RVA = "0x33D03A0", Offset = "0x33CEFA0", VA = "0x1833D03A0")]
		public AVGAnimatedKV()
		{
		}

		// Token: 0x0400C0E3 RID: 49379
		[Token(Token = "0x400C0E3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _entryAnimation;

		// Token: 0x0400C0E4 RID: 49380
		[Token(Token = "0x400C0E4")]
		[FieldOffset(Offset = "0x28")]
		private AnimationWrapper m_wrapper;

		// Token: 0x0400C0E5 RID: 49381
		[Token(Token = "0x400C0E5")]
		[FieldOffset(Offset = "0x30")]
		private string m_animationName;

		// Token: 0x0400C0E6 RID: 49382
		[Token(Token = "0x400C0E6")]
		[FieldOffset(Offset = "0x38")]
		private float m_animationLength;

		// Token: 0x0400C0E7 RID: 49383
		[Token(Token = "0x400C0E7")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_tween;

		// Token: 0x0400C0E8 RID: 49384
		[Token(Token = "0x400C0E8")]
		[FieldOffset(Offset = "0x48")]
		private float m_playPosition;

		// Token: 0x0400C0E9 RID: 49385
		[Token(Token = "0x400C0E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlayEntry;

		// Token: 0x0400C0EA RID: 49386
		[Token(Token = "0x400C0EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureWrapper;

		// Token: 0x0400C0EB RID: 49387
		[Token(Token = "0x400C0EB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetPosition;

		// Token: 0x0400C0EC RID: 49388
		[Token(Token = "0x400C0EC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetPosition;

		// Token: 0x0400C0ED RID: 49389
		[Token(Token = "0x400C0ED")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
