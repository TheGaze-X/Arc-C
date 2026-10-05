using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
	public class SepiaTone : ImageEffectBase
	{
		// Token: 0x06000257 RID: 599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x52FF110", Offset = "0x52FDD10", VA = "0x1852FF110")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public SepiaTone()
		{
		}
	}
}
