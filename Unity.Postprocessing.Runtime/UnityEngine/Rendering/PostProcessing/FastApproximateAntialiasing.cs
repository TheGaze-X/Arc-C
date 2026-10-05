using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[Preserve]
	[Serializable]
	public sealed class FastApproximateAntialiasing
	{
		// Token: 0x06000049 RID: 73 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FastApproximateAntialiasing()
		{
		}

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("mobileOptimized")]
		[Tooltip("Boost performances by lowering the effect quality. This setting is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
		public bool fastMode;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x11")]
		[Tooltip("Keep alpha channel. This will slightly lower the effect quality but allows rendering against a transparent background.")]
		public bool keepAlpha;
	}
}
