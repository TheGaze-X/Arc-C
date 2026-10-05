using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[Preserve]
	[Serializable]
	public sealed class Fog
	{
		// Token: 0x0600004A RID: 74 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40")]
		internal DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x5820E90", Offset = "0x581FA90", VA = "0x185820E90")]
		internal bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x5820FD0", Offset = "0x581FBD0", VA = "0x185820FD0")]
		internal void Render(PostProcessRenderContext context)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x5821370", Offset = "0x581FF70", VA = "0x185821370")]
		public Fog()
		{
		}

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Enables the internal deferred fog pass. Actual fog settings should be set in the Lighting panel.")]
		public bool enabled;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x11")]
		[Tooltip("Mark true for the fog to ignore the skybox")]
		public bool excludeSkybox;
	}
}
