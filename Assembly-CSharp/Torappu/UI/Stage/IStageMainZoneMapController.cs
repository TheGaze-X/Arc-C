using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x0200690C RID: 26892
	[Token(Token = "0x200690C")]
	public interface IStageMainZoneMapController
	{
		// Token: 0x17005AEE RID: 23278
		// (get) Token: 0x06026848 RID: 157768
		[Token(Token = "0x17005AEE")]
		float positionValue { [Token(Token = "0x6026848")] get; }

		// Token: 0x17005AEF RID: 23279
		// (get) Token: 0x06026849 RID: 157769
		[Token(Token = "0x17005AEF")]
		float backgroundImageRefValue { [Token(Token = "0x6026849")] get; }

		// Token: 0x0602684A RID: 157770
		[Token(Token = "0x602684A")]
		UIPage GetPage();
	}
}
