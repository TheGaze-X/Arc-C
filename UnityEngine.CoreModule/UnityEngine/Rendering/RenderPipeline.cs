using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Rendering
{
	// Token: 0x02000274 RID: 628
	[Token(Token = "0x2000274")]
	public abstract class RenderPipeline
	{
		// Token: 0x06000E08 RID: 3592
		[Token(Token = "0x6000E08")]
		protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

		// Token: 0x06000E09 RID: 3593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		protected virtual void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, List<Camera.RenderRequest> renderRequests)
		{
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0x59863C0", Offset = "0x5984FC0", VA = "0x1859863C0", Slot = "6")]
		protected virtual void Render(ScriptableRenderContext context, List<Camera> cameras)
		{
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0x5986300", Offset = "0x5984F00", VA = "0x185986300")]
		internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras)
		{
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x59861E0", Offset = "0x5984DE0", VA = "0x1859861E0")]
		internal void InternalRenderWithRequests(ScriptableRenderContext context, List<Camera> cameras, List<Camera.RenderRequest> renderRequests)
		{
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00006F78 File Offset: 0x00005178
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B7")]
		public bool disposed
		{
			[Token(Token = "0x6000E0D")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E0E")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x5986160", Offset = "0x5984D60", VA = "0x185986160")]
		internal void Dispose()
		{
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E10")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
