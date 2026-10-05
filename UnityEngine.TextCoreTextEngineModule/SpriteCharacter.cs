using System;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[Serializable]
	public class SpriteCharacter : TextElement
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000026")]
		public string name
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x5964990", Offset = "0x5963590", VA = "0x185964990")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x58CE020", Offset = "0x58CCC20", VA = "0x1858CE020")]
		public SpriteCharacter()
		{
		}

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_Name;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int m_HashCode;
	}
}
