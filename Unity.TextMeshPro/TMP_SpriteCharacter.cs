using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	[Serializable]
	public class TMP_SpriteCharacter : TMP_TextElement
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E7")]
		public string name
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x58CE0C0", Offset = "0x58CCCC0", VA = "0x1858CE0C0")]
			set
			{
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x170000E8")]
		public int hashCode
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x58CE020", Offset = "0x58CCC20", VA = "0x1858CE020")]
		public TMP_SpriteCharacter()
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x58CDFB0", Offset = "0x58CCBB0", VA = "0x1858CDFB0")]
		public TMP_SpriteCharacter(uint unicode, TMP_SpriteGlyph glyph)
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x58CE040", Offset = "0x58CCC40", VA = "0x1858CE040")]
		public TMP_SpriteCharacter(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph)
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x58CDF50", Offset = "0x58CCB50", VA = "0x1858CDF50")]
		internal TMP_SpriteCharacter(uint unicode, uint glyphIndex)
		{
		}

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_Name;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int m_HashCode;
	}
}
