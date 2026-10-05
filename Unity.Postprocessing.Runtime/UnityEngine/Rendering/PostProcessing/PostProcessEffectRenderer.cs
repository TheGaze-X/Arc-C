using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	public abstract class PostProcessEffectRenderer
	{
		// Token: 0x06000120 RID: 288 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public virtual void Init()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
		public virtual DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000122")]
		[Address(RVA = "0xF3CBA0", Offset = "0xF3B7A0", VA = "0x180F3CBA0", Slot = "6")]
		public virtual void ResetHistory()
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x3E806B0", Offset = "0x3E7F2B0", VA = "0x183E806B0", Slot = "7")]
		public virtual void Release()
		{
		}

		// Token: 0x06000124 RID: 292
		[Token(Token = "0x6000124")]
		public abstract void Render(PostProcessRenderContext context);

		// Token: 0x06000125 RID: 293
		[Token(Token = "0x6000125")]
		internal abstract void SetSettings(PostProcessEffectSettings settings);

		// Token: 0x06000126 RID: 294 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1E9AB00", Offset = "0x1E99700", VA = "0x181E9AB00")]
		protected PostProcessEffectRenderer()
		{
		}

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x10")]
		protected bool m_ResetHistory;
	}
}
