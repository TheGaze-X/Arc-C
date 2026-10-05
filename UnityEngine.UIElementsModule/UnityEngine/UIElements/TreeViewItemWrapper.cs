using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	internal readonly struct TreeViewItemWrapper
	{
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x17000223")]
		public int id
		{
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000224")]
		public IEnumerable<int> childrenIds
		{
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x17000225")]
		public bool hasChildren
		{
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x5ACD090", Offset = "0x5ACBC90", VA = "0x185ACD090")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x5ACD0E0", Offset = "0x5ACBCE0", VA = "0x185ACD0E0")]
		public TreeViewItemWrapper(TreeItem item, int depth)
		{
		}

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0x0")]
		public readonly TreeItem item;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x10")]
		public readonly int depth;
	}
}
