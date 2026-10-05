using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200015F RID: 351
	[Token(Token = "0x200015F")]
	internal readonly struct TreeItem
	{
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00005940 File Offset: 0x00003B40
		[Token(Token = "0x1700021F")]
		public int id
		{
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x17000220")]
		public int parentId
		{
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000221")]
		public IEnumerable<int> childrenIds
		{
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00005970 File Offset: 0x00003B70
		[Token(Token = "0x17000222")]
		public bool hasChildren
		{
			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x5ACD090", Offset = "0x5ACBC90", VA = "0x185ACD090")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x9C8E50", Offset = "0x9C7A50", VA = "0x1809C8E50")]
		public TreeItem(int id, int parentId = -1, [Optional] IEnumerable<int> childrenIds)
		{
		}
	}
}
