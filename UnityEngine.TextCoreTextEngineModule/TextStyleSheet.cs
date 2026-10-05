using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	[ExcludeFromPreset]
	[ExcludeFromObjectFactory]
	[Serializable]
	public class TextStyleSheet : ScriptableObject
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000047")]
		internal List<TextStyle> styles
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x4893C50", Offset = "0x4892850", VA = "0x184893C50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x5A01CC0", Offset = "0x5A008C0", VA = "0x185A01CC0")]
		public TextStyle GetStyle(int hashCode)
		{
			return null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x5A01D50", Offset = "0x5A00950", VA = "0x185A01D50")]
		public TextStyle GetStyle(string name)
		{
			return null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x5A01FE0", Offset = "0x5A00BE0", VA = "0x185A01FE0")]
		public void RefreshStyles()
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x5A01DF0", Offset = "0x5A009F0", VA = "0x185A01DF0")]
		private void LoadStyleDictionaryInternal()
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x5A01FF0", Offset = "0x5A00BF0", VA = "0x185A01FF0")]
		public TextStyleSheet()
		{
		}

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<TextStyle> m_StyleList;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, TextStyle> m_StyleLookupDictionary;
	}
}
