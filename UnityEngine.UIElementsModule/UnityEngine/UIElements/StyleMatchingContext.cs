using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	internal class StyleMatchingContext
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x17000144")]
		public int styleSheetCount
		{
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x5A8F990", Offset = "0x5A8E590", VA = "0x185A8F990")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x5A8F890", Offset = "0x5A8E490", VA = "0x185A8F890")]
		public StyleMatchingContext(Action<VisualElement, MatchResultInfo> processResult)
		{
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x5A8F730", Offset = "0x5A8E330", VA = "0x185A8F730")]
		public void AddStyleSheet(StyleSheet sheet)
		{
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x5A8F820", Offset = "0x5A8E420", VA = "0x185A8F820")]
		public void RemoveStyleSheetRange(int index, int count)
		{
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x5A8F7C0", Offset = "0x5A8E3C0", VA = "0x185A8F7C0")]
		public StyleSheet GetStyleSheetAt(int index)
		{
			return null;
		}

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x10")]
		private List<StyleSheet> m_StyleSheetStack;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x18")]
		public StyleVariableContext variableContext;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x20")]
		public VisualElement currentElement;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x28")]
		public Action<VisualElement, MatchResultInfo> processResult;
	}
}
