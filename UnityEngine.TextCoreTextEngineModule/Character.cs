using System;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[Serializable]
	public class Character : TextElement
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x59E84F0", Offset = "0x59E70F0", VA = "0x1859E84F0")]
		public Character()
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x59E8520", Offset = "0x59E7120", VA = "0x1859E8520")]
		public Character(uint unicode, FontAsset fontAsset, Glyph glyph)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x59E8490", Offset = "0x59E7090", VA = "0x1859E8490")]
		internal Character(uint unicode, uint glyphIndex)
		{
		}
	}
}
