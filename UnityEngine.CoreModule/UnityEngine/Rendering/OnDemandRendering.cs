using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x0200026B RID: 619
	[Token(Token = "0x200026B")]
	[RequiredByNativeCode]
	public class OnDemandRendering
	{
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00006EB8 File Offset: 0x000050B8
		[Token(Token = "0x170002B4")]
		public static int renderFrameInterval
		{
			[Token(Token = "0x6000D99")]
			[Address(RVA = "0x5963C10", Offset = "0x5962810", VA = "0x185963C10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x5963B40", Offset = "0x5962740", VA = "0x185963B40")]
		[RequiredByNativeCode]
		internal static void GetRenderFrameInterval(out int frameInterval)
		{
		}

		// Token: 0x0400074F RID: 1871
		[Token(Token = "0x400074F")]
		[FieldOffset(Offset = "0x0")]
		private static int m_RenderFrameInterval;
	}
}
