using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	public abstract class Monitor
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000004")]
		public RenderTexture output
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x58318E0", Offset = "0x58304E0", VA = "0x1858318E0")]
		public bool IsRequestedAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x060000BF RID: 191
		[Token(Token = "0x60000BF")]
		internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

		// Token: 0x060000C0 RID: 192 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		internal virtual bool NeedsHalfRes()
		{
			return default(bool);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x5831740", Offset = "0x5830340", VA = "0x185831740")]
		protected void CheckOutput(int width, int height)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		internal virtual void OnEnable()
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x5831980", Offset = "0x5830580", VA = "0x185831980", Slot = "7")]
		internal virtual void OnDisable()
		{
		}

		// Token: 0x060000C4 RID: 196
		[Token(Token = "0x60000C4")]
		internal abstract void Render(PostProcessRenderContext context);

		// Token: 0x060000C5 RID: 197 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Monitor()
		{
		}

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x18")]
		internal bool requested;
	}
}
