using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000029 RID: 41
[Token(Token = "0x2000029")]
public class DitherTrigger : MonoBehaviour
{
	// Token: 0x060000A1 RID: 161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x4F81F0", Offset = "0x4F6DF0", VA = "0x1804F81F0")]
	private void Start()
	{
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x4F7FF0", Offset = "0x4F6BF0", VA = "0x1804F7FF0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x4F80F0", Offset = "0x4F6CF0", VA = "0x1804F80F0")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x4F7F30", Offset = "0x4F6B30", VA = "0x1804F7F30")]
	private IEnumerator Fade(float from, float to, Renderer renderer)
	{
		return null;
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x4F8260", Offset = "0x4F6E60", VA = "0x1804F8260")]
	public DitherTrigger()
	{
	}

	// Token: 0x04000094 RID: 148
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x18")]
	private MaterialPropertyBlock block;

	// Token: 0x04000095 RID: 149
	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x20")]
	[Range(0f, 1f)]
	public float fadeDuration;

	// Token: 0x04000096 RID: 150
	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x24")]
	public float minAlpha;
}
