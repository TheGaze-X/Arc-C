using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	[Serializable]
	public class TMP_Style
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E9")]
		public static TMP_Style NormalStyle
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x58CEAF0", Offset = "0x58CD6F0", VA = "0x1858CEAF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EA")]
		public string name
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x58CEBE0", Offset = "0x58CD7E0", VA = "0x1858CEBE0")]
			set
			{
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00003810 File Offset: 0x00001A10
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EB")]
		public int hashCode
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x58CEBD0", Offset = "0x58CD7D0", VA = "0x1858CEBD0")]
			set
			{
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000EC")]
		public string styleOpeningDefinition
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000ED")]
		public string styleClosingDefinition
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000EE")]
		public int[] styleOpeningTagArray
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000EF")]
		public int[] styleClosingTagArray
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x58CEA30", Offset = "0x58CD630", VA = "0x1858CEA30")]
		internal TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition)
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x58CE7E0", Offset = "0x58CD3E0", VA = "0x1858CE7E0")]
		public void RefreshStyle()
		{
		}

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x0")]
		internal static TMP_Style k_NormalStyle;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_Name;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_HashCode;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_OpeningDefinition;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_ClosingDefinition;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int[] m_OpeningTagArray;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int[] m_ClosingTagArray;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		internal uint[] m_OpeningTagUnicodeArray;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		internal uint[] m_ClosingTagUnicodeArray;
	}
}
