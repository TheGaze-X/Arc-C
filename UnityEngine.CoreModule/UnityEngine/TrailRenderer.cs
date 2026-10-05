using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	[NativeHeader("Runtime/Graphics/TrailRenderer.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	public sealed class TrailRenderer : Renderer
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000353 RID: 851
		// (set) Token: 0x06000354 RID: 852
		[Token(Token = "0x170000CA")]
		public extern float time { [Token(Token = "0x6000353")] [Address(RVA = "0x59468D0", Offset = "0x59454D0", VA = "0x1859468D0")] [MethodImpl(4096)] get; [Token(Token = "0x6000354")] [Address(RVA = "0x5946A00", Offset = "0x5945600", VA = "0x185946A00")] [MethodImpl(4096)] set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000355 RID: 853
		// (set) Token: 0x06000356 RID: 854
		[Token(Token = "0x170000CB")]
		public extern float startWidth { [Token(Token = "0x6000355")] [Address(RVA = "0x5946890", Offset = "0x5945490", VA = "0x185946890")] [MethodImpl(4096)] get; [Token(Token = "0x6000356")] [Address(RVA = "0x59469B0", Offset = "0x59455B0", VA = "0x1859469B0")] [MethodImpl(4096)] set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000357 RID: 855
		// (set) Token: 0x06000358 RID: 856
		[Token(Token = "0x170000CC")]
		public extern float endWidth { [Token(Token = "0x6000357")] [Address(RVA = "0x5946810", Offset = "0x5945410", VA = "0x185946810")] [MethodImpl(4096)] get; [Token(Token = "0x6000358")] [Address(RVA = "0x5946910", Offset = "0x5945510", VA = "0x185946910")] [MethodImpl(4096)] set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000359 RID: 857
		// (set) Token: 0x0600035A RID: 858
		[Token(Token = "0x170000CD")]
		public extern float minVertexDistance { [Token(Token = "0x6000359")] [Address(RVA = "0x5946850", Offset = "0x5945450", VA = "0x185946850")] [MethodImpl(4096)] get; [Token(Token = "0x600035A")] [Address(RVA = "0x5946960", Offset = "0x5945560", VA = "0x185946960")] [MethodImpl(4096)] set; }

		// Token: 0x0600035B RID: 859
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x59467D0", Offset = "0x59453D0", VA = "0x1859467D0")]
		[MethodImpl(4096)]
		public extern void Clear();
	}
}
