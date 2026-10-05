using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	public abstract class PostProcessingComponentRenderTexture<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		// Token: 0x060003D2 RID: 978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D2")]
		public virtual void Prepare(Material material)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D3")]
		protected PostProcessingComponentRenderTexture()
		{
		}
	}
}
