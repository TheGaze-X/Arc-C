using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
	public sealed class GraphicsBuffer
	{
		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		// Token: 0x0200008D RID: 141
		[Token(Token = "0x200008D")]
		[Flags]
		public enum Target
		{
			// Token: 0x04000192 RID: 402
			[Token(Token = "0x4000192")]
			Vertex = 1,
			// Token: 0x04000193 RID: 403
			[Token(Token = "0x4000193")]
			Index = 2,
			// Token: 0x04000194 RID: 404
			[Token(Token = "0x4000194")]
			CopySource = 4,
			// Token: 0x04000195 RID: 405
			[Token(Token = "0x4000195")]
			CopyDestination = 8,
			// Token: 0x04000196 RID: 406
			[Token(Token = "0x4000196")]
			Structured = 16,
			// Token: 0x04000197 RID: 407
			[Token(Token = "0x4000197")]
			Raw = 32,
			// Token: 0x04000198 RID: 408
			[Token(Token = "0x4000198")]
			Append = 64,
			// Token: 0x04000199 RID: 409
			[Token(Token = "0x4000199")]
			Counter = 128,
			// Token: 0x0400019A RID: 410
			[Token(Token = "0x400019A")]
			IndirectArguments = 256,
			// Token: 0x0400019B RID: 411
			[Token(Token = "0x400019B")]
			Constant = 512
		}
	}
}
