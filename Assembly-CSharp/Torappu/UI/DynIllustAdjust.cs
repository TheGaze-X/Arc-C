using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020034C9 RID: 13513
	[Token(Token = "0x20034C9")]
	[Serializable]
	public struct DynIllustAdjust
	{
		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x0601588E RID: 88206 RVA: 0x0008C7D8 File Offset: 0x0008A9D8
		[Token(Token = "0x170032E4")]
		public bool enableOffset
		{
			[Token(Token = "0x601588E")]
			[Address(RVA = "0xDFB870", Offset = "0xDFA470", VA = "0x180DFB870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x0601588F RID: 88207 RVA: 0x0008C7F0 File Offset: 0x0008A9F0
		[Token(Token = "0x170032E5")]
		public bool enableSize
		{
			[Token(Token = "0x601588F")]
			[Address(RVA = "0xDFB8A0", Offset = "0xDFA4A0", VA = "0x180DFB8A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015890 RID: 88208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015890")]
		[Address(RVA = "0xDFB7F0", Offset = "0xDFA3F0", VA = "0x180DFB7F0")]
		public void DisableAll()
		{
		}

		// Token: 0x06015891 RID: 88209 RVA: 0x0008C808 File Offset: 0x0008AA08
		[Token(Token = "0x6015891")]
		[Address(RVA = "0xDFB820", Offset = "0xDFA420", VA = "0x180DFB820")]
		public static bool Enable(Vector2 v)
		{
			return default(bool);
		}

		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x06015892 RID: 88210 RVA: 0x0008C820 File Offset: 0x0008AA20
		[Token(Token = "0x170032E6")]
		public static Vector2 DisabledValue
		{
			[Token(Token = "0x6015892")]
			[Address(RVA = "0xDFB850", Offset = "0xDFA450", VA = "0x180DFB850")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x04019D04 RID: 105732
		[Token(Token = "0x4019D04")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 offset;

		// Token: 0x04019D05 RID: 105733
		[Token(Token = "0x4019D05")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 size;
	}
}
