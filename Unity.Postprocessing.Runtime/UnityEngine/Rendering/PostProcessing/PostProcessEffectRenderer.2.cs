using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public abstract class PostProcessEffectRenderer<T> : PostProcessEffectRenderer where T : PostProcessEffectSettings
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000127 RID: 295 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700000B")]
		public T settings
		{
			[Token(Token = "0x6000127")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000128")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000129")]
		internal override void SetSettings(PostProcessEffectSettings settings)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600012A")]
		protected PostProcessEffectRenderer()
		{
		}
	}
}
