using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	public sealed class PropertySheetFactory
	{
		// Token: 0x06000213 RID: 531 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x5845560", Offset = "0x5844160", VA = "0x185845560")]
		public PropertySheetFactory()
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x5845250", Offset = "0x5843E50", VA = "0x185845250")]
		[Obsolete("Use PropertySheet.Get(Shader) with a direct reference to the Shader instead.")]
		public PropertySheet Get(string shaderName)
		{
			return null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x5845020", Offset = "0x5843C20", VA = "0x185845020")]
		public PropertySheet Get(Shader shader)
		{
			return null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x5845340", Offset = "0x5843F40", VA = "0x185845340")]
		public void Release()
		{
		}

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<Shader, PropertySheet> m_Sheets;
	}
}
