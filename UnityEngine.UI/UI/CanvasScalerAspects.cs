using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	public interface CanvasScalerAspects
	{
		// Token: 0x06000583 RID: 1411
		[Token(Token = "0x6000583")]
		Vector2 ReferenceResolutionAfterScalerGetter(CanvasScaler scaler);

		// Token: 0x06000584 RID: 1412
		[Token(Token = "0x6000584")]
		void HandleOnEnable(CanvasScaler scaler);

		// Token: 0x06000585 RID: 1413
		[Token(Token = "0x6000585")]
		bool isViewportSizeMatch(CanvasScaler scaler);

		// Token: 0x06000586 RID: 1414
		[Token(Token = "0x6000586")]
		void HandleScaleWithScreenSize(CanvasScaler scaler);
	}
}
