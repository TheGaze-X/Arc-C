using System;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x020017E7 RID: 6119
	[Token(Token = "0x20017E7")]
	public interface IBuildingBindTools : IHotfixable
	{
		// Token: 0x06009AA5 RID: 39589
		[Token(Token = "0x6009AA5")]
		bool IsActive();

		// Token: 0x06009AA6 RID: 39590
		[Token(Token = "0x6009AA6")]
		void BindController(BuildingController controller);

		// Token: 0x06009AA7 RID: 39591
		[Token(Token = "0x6009AA7")]
		void Tick(float ts);

		// Token: 0x06009AA8 RID: 39592
		[Token(Token = "0x6009AA8")]
		bool CheckNeedActiveWithoutController();

		// Token: 0x06009AA9 RID: 39593
		[Token(Token = "0x6009AA9")]
		void Clear();
	}
}
