using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020036E0 RID: 14048
	[Token(Token = "0x20036E0")]
	public class UIAnimationClipHolder : MonoBehaviour, IAnimationClipSource
	{
		// Token: 0x06016511 RID: 91409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016511")]
		[Address(RVA = "0xECC600", Offset = "0xECB200", VA = "0x180ECC600", Slot = "4")]
		public void GetAnimationClips(List<AnimationClip> results)
		{
		}

		// Token: 0x06016512 RID: 91410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016512")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIAnimationClipHolder()
		{
		}

		// Token: 0x0401AD70 RID: 109936
		[Token(Token = "0x401AD70")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationClip[] _clips;
	}
}
