using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200000A RID: 10
[Token(Token = "0x200000A")]
public class AVGCharacterImage : Image
{
	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000C")]
	private Material DynamicMaterial
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4F7890", Offset = "0x4F6490", VA = "0x1804F7890")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x4F7500", Offset = "0x4F6100", VA = "0x1804F7500")]
	public void Debug_ChangeFace(Sprite sprite)
	{
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x4F76E0", Offset = "0x4F62E0", VA = "0x1804F76E0", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x4F7840", Offset = "0x4F6440", VA = "0x1804F7840")]
	public AVGCharacterImage()
	{
	}

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string HG_DYNAMIC_TEX_PROP;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x190")]
	private Material m_dynamicMaterial;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x198")]
	private Material m_material;
}
