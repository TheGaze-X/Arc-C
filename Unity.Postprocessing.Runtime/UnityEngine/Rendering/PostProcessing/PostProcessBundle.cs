using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	public sealed class PostProcessBundle
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000005")]
		public PostProcessAttribute attribute
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000006")]
		public PostProcessEffectSettings settings
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000007")]
		internal PostProcessEffectRenderer renderer
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x5831B70", Offset = "0x5830770", VA = "0x185831B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x5831AC0", Offset = "0x58306C0", VA = "0x185831AC0")]
		internal PostProcessBundle(PostProcessEffectSettings settings)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x58319F0", Offset = "0x58305F0", VA = "0x1858319F0")]
		internal void Release()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x5831A80", Offset = "0x5830680", VA = "0x185831A80")]
		internal void ResetHistory()
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000102")]
		internal T CastSettings<T>() where T : PostProcessEffectSettings
		{
			return null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000103")]
		internal T CastRenderer<T>() where T : PostProcessEffectRenderer
		{
			return null;
		}

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x20")]
		private PostProcessEffectRenderer m_Renderer;
	}
}
