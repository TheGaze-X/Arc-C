using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002D7 RID: 727
	[Token(Token = "0x20002D7")]
	internal class DrawParams
	{
		// Token: 0x0600139D RID: 5021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139D")]
		[Address(RVA = "0x5A582D0", Offset = "0x5A56ED0", VA = "0x185A582D0")]
		public void Reset()
		{
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139E")]
		[Address(RVA = "0x5A58560", Offset = "0x5A57160", VA = "0x185A58560")]
		public DrawParams()
		{
		}

		// Token: 0x04000B5F RID: 2911
		[Token(Token = "0x4000B5F")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Rect k_UnlimitedRect;

		// Token: 0x04000B60 RID: 2912
		[Token(Token = "0x4000B60")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly Rect k_FullNormalizedRect;

		// Token: 0x04000B61 RID: 2913
		[Token(Token = "0x4000B61")]
		[FieldOffset(Offset = "0x10")]
		internal readonly Stack<Matrix4x4> view;

		// Token: 0x04000B62 RID: 2914
		[Token(Token = "0x4000B62")]
		[FieldOffset(Offset = "0x18")]
		internal readonly Stack<Rect> scissor;

		// Token: 0x04000B63 RID: 2915
		[Token(Token = "0x4000B63")]
		[FieldOffset(Offset = "0x20")]
		internal readonly List<RenderTexture> renderTexture;

		// Token: 0x04000B64 RID: 2916
		[Token(Token = "0x4000B64")]
		[FieldOffset(Offset = "0x28")]
		internal readonly List<Material> defaultMaterial;
	}
}
