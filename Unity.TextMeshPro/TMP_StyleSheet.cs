using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	[ExcludeFromPreset]
	[Serializable]
	public class TMP_StyleSheet : ScriptableObject
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F0")]
		internal List<TMP_Style> styles
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x58CE740", Offset = "0x58CD340", VA = "0x1858CE740")]
		private void Reset()
		{
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x58CE3B0", Offset = "0x58CCFB0", VA = "0x1858CE3B0")]
		public TMP_Style GetStyle(int hashCode)
		{
			return null;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x58CE2F0", Offset = "0x58CCEF0", VA = "0x1858CE2F0")]
		public TMP_Style GetStyle(string name)
		{
			return null;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x58CE740", Offset = "0x58CD340", VA = "0x1858CE740")]
		public void RefreshStyles()
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x58CE440", Offset = "0x58CD040", VA = "0x1858CE440")]
		private void LoadStyleDictionaryInternal()
		{
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x58CE750", Offset = "0x58CD350", VA = "0x1858CE750")]
		public TMP_StyleSheet()
		{
		}

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<TMP_Style> m_StyleList;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, TMP_Style> m_StyleLookupDictionary;
	}
}
