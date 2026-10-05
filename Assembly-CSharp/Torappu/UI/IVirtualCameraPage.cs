using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200363E RID: 13886
	[Token(Token = "0x200363E")]
	public interface IVirtualCameraPage
	{
		// Token: 0x060161B0 RID: 90544
		[Token(Token = "0x60161B0")]
		void LoadAllVirtualCamTypes(ICollection<int> cameraTypes);

		// Token: 0x060161B1 RID: 90545
		[Token(Token = "0x60161B1")]
		void InitVirtualCamera(UIPageCameraProvider provider);

		// Token: 0x060161B2 RID: 90546
		[Token(Token = "0x60161B2")]
		void DisposeVirtualCamera();
	}
}
