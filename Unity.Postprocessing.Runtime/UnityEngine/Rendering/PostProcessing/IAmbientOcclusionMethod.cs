using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	internal interface IAmbientOcclusionMethod
	{
		// Token: 0x06000012 RID: 18
		[Token(Token = "0x6000012")]
		DepthTextureMode GetCameraFlags();

		// Token: 0x06000013 RID: 19
		[Token(Token = "0x6000013")]
		void RenderAfterOpaque(PostProcessRenderContext context);

		// Token: 0x06000014 RID: 20
		[Token(Token = "0x6000014")]
		void RenderAmbientOnly(PostProcessRenderContext context);

		// Token: 0x06000015 RID: 21
		[Token(Token = "0x6000015")]
		void CompositeAmbientOnly(PostProcessRenderContext context);

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		void Release();
	}
}
