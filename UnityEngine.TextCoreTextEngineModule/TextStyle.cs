using System;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	[Serializable]
	public class TextStyle
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x17000044")]
		public int hashCode
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x428FB90", Offset = "0x428E790", VA = "0x18428FB90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000045")]
		public int[] styleOpeningTagArray
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x5964990", Offset = "0x5963590", VA = "0x185964990")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000046")]
		public int[] styleClosingTagArray
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x59976A0", Offset = "0x59962A0", VA = "0x1859976A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x5A02080", Offset = "0x5A00C80", VA = "0x185A02080")]
		public void RefreshStyle()
		{
		}

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x0")]
		internal static TextStyle k_NormalStyle;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_Name;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_HashCode;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_OpeningDefinition;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_ClosingDefinition;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int[] m_OpeningTagArray;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int[] m_ClosingTagArray;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		internal uint[] m_OpeningTagUnicodeArray;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		internal uint[] m_ClosingTagUnicodeArray;
	}
}
