using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	internal class TextureLerper
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700004F")]
		internal static TextureLerper instance
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x5851250", Offset = "0x584FE50", VA = "0x185851250")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x5851190", Offset = "0x584FD90", VA = "0x185851190")]
		private TextureLerper()
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x584F8A0", Offset = "0x584E4A0", VA = "0x18584F8A0")]
		internal void BeginFrame(PostProcessRenderContext context)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x584FB90", Offset = "0x584E790", VA = "0x18584FB90")]
		internal void EndFrame()
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x584FEA0", Offset = "0x584EAA0", VA = "0x18584FEA0")]
		private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = false, bool force3D = false)
		{
			return null;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x5850170", Offset = "0x584ED70", VA = "0x185850170")]
		internal Texture Lerp(Texture from, Texture to, float t)
		{
			return null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x5850920", Offset = "0x584F520", VA = "0x185850920")]
		internal Texture Lerp(Texture from, Color to, float t)
		{
			return null;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x584F910", Offset = "0x584E510", VA = "0x18584F910")]
		internal void Clear()
		{
		}

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x0")]
		private static TextureLerper m_Instance;

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x10")]
		private CommandBuffer m_Command;

		// Token: 0x04000375 RID: 885
		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x18")]
		private PropertySheetFactory m_PropertySheets;

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x20")]
		private PostProcessResources m_Resources;

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x28")]
		private List<RenderTexture> m_Recycled;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x30")]
		private List<RenderTexture> m_Actives;
	}
}
