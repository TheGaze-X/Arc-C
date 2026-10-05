using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000201 RID: 513
	[Token(Token = "0x2000201")]
	internal class UIDocumentList
	{
		// Token: 0x06000D83 RID: 3459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x5B154A0", Offset = "0x5B140A0", VA = "0x185B154A0")]
		internal void RemoveFromListAndFromVisualTree(UIDocument uiDocument)
		{
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x5B15190", Offset = "0x5B13D90", VA = "0x185B15190")]
		internal void AddToListAndToVisualTree(UIDocument uiDocument, VisualElement visualTree, int firstInsertIndex = 0)
		{
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x5B15510", Offset = "0x5B14110", VA = "0x185B15510")]
		public UIDocumentList()
		{
		}

		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x40006FA")]
		[FieldOffset(Offset = "0x10")]
		internal List<UIDocument> m_AttachedUIDocuments;
	}
}
