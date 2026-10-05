using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200363F RID: 13887
	[Token(Token = "0x200363F")]
	public interface IPageVirtualCamBinder
	{
		// Token: 0x060161B3 RID: 90547
		[Token(Token = "0x60161B3")]
		void BindCamera(CameraWrapper camera);

		// Token: 0x060161B4 RID: 90548
		[Token(Token = "0x60161B4")]
		void UnBindCamera();
	}
}
