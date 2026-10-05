using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020039E1 RID: 14817
	[Token(Token = "0x20039E1")]
	public class UICommentedTextData
	{
		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x0601766E RID: 95854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700380D")]
		public List<Vector4> BoundList
		{
			[Token(Token = "0x601766E")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601766F RID: 95855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601766F")]
		[Address(RVA = "0xFBE490", Offset = "0xFBD090", VA = "0x180FBE490")]
		public UICommentedTextData(string content, UICommentedTextData.InfoType infoType, string infoId)
		{
		}

		// Token: 0x06017670 RID: 95856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017670")]
		[Address(RVA = "0xFBE480", Offset = "0xFBD080", VA = "0x180FBE480")]
		public void SetStartIndex(int index, int length = 0)
		{
		}

		// Token: 0x06017671 RID: 95857 RVA: 0x00096528 File Offset: 0x00094728
		[Token(Token = "0x6017671")]
		[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
		public int GetStartIndex()
		{
			return 0;
		}

		// Token: 0x06017672 RID: 95858 RVA: 0x00096540 File Offset: 0x00094740
		[Token(Token = "0x6017672")]
		[Address(RVA = "0xFBE470", Offset = "0xFBD070", VA = "0x180FBE470")]
		public int GetEndIndex()
		{
			return 0;
		}

		// Token: 0x06017673 RID: 95859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017673")]
		[Address(RVA = "0x4EF620", Offset = "0x4EE220", VA = "0x1804EF620")]
		public void SetValid(bool valid)
		{
		}

		// Token: 0x06017674 RID: 95860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017674")]
		[Address(RVA = "0xFBE310", Offset = "0xFBCF10", VA = "0x180FBE310")]
		public void AddBound(Vector4 bound)
		{
		}

		// Token: 0x06017675 RID: 95861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017675")]
		[Address(RVA = "0xFBE430", Offset = "0xFBD030", VA = "0x180FBE430")]
		public void ClearBound()
		{
		}

		// Token: 0x0401C443 RID: 115779
		[Token(Token = "0x401C443")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0401C444 RID: 115780
		[Token(Token = "0x401C444")]
		[FieldOffset(Offset = "0x18")]
		public UICommentedTextData.InfoType type;

		// Token: 0x0401C445 RID: 115781
		[Token(Token = "0x401C445")]
		[FieldOffset(Offset = "0x20")]
		public string populateText;

		// Token: 0x0401C446 RID: 115782
		[Token(Token = "0x401C446")]
		[FieldOffset(Offset = "0x28")]
		public int size;

		// Token: 0x0401C447 RID: 115783
		[Token(Token = "0x401C447")]
		[FieldOffset(Offset = "0x2C")]
		public bool valid;

		// Token: 0x0401C448 RID: 115784
		[Token(Token = "0x401C448")]
		[FieldOffset(Offset = "0x30")]
		private int m_startIndex;

		// Token: 0x0401C449 RID: 115785
		[Token(Token = "0x401C449")]
		[FieldOffset(Offset = "0x34")]
		private int m_length;

		// Token: 0x0401C44A RID: 115786
		[Token(Token = "0x401C44A")]
		[FieldOffset(Offset = "0x38")]
		private List<Vector4> m_boundList;

		// Token: 0x020039E2 RID: 14818
		[Token(Token = "0x20039E2")]
		public enum InfoType
		{
			// Token: 0x0401C44C RID: 115788
			[Token(Token = "0x401C44C")]
			TEXT,
			// Token: 0x0401C44D RID: 115789
			[Token(Token = "0x401C44D")]
			RANGE
		}
	}
}
