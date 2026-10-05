using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	[DisallowMultipleComponent]
	public class TMP_SpriteAnimator : MonoBehaviour
	{
		// Token: 0x06000404 RID: 1028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x58CBA60", Offset = "0x58CA660", VA = "0x1858CBA60")]
		private void Awake()
		{
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void OnEnable()
		{
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void OnDisable()
		{
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x58CBCA0", Offset = "0x58CA8A0", VA = "0x1858CBCA0")]
		public void StopAllAnimations()
		{
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x58CBB70", Offset = "0x58CA770", VA = "0x1858CBB70")]
		public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate)
		{
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x58CBAB0", Offset = "0x58CA6B0", VA = "0x1858CBAB0")]
		private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate)
		{
			return null;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x58CBCF0", Offset = "0x58CA8F0", VA = "0x1858CBCF0")]
		public TMP_SpriteAnimator()
		{
		}

		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, bool> m_animations;

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x20")]
		private TMP_Text m_TextComponent;
	}
}
