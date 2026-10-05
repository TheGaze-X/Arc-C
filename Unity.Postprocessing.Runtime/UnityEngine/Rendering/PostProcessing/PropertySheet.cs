using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	public sealed class PropertySheet
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600020A RID: 522 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000036")]
		public MaterialPropertyBlock properties
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600020D RID: 525 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000037")]
		internal Material material
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x58456D0", Offset = "0x58442D0", VA = "0x1858456D0")]
		internal PropertySheet(Material material)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x58455F0", Offset = "0x58441F0", VA = "0x1858455F0")]
		public void ClearKeywords()
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x5845640", Offset = "0x5844240", VA = "0x185845640")]
		public void EnableKeyword(string keyword)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x5845620", Offset = "0x5844220", VA = "0x185845620")]
		public void DisableKeyword(string keyword)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x5845660", Offset = "0x5844260", VA = "0x185845660")]
		internal void Release()
		{
		}
	}
}
