using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043C8 RID: 17352
	[Token(Token = "0x20043C8")]
	public class SandboxV2CookFoodResponse : PlayerDeltaResponse
	{
		// Token: 0x0601A973 RID: 108915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A973")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public SandboxV2CookFoodResponse()
		{
		}

		// Token: 0x04021E4A RID: 138826
		[Token(Token = "0x4021E4A")]
		[FieldOffset(Offset = "0x28")]
		public string instId;

		// Token: 0x04021E4B RID: 138827
		[Token(Token = "0x4021E4B")]
		[FieldOffset(Offset = "0x30")]
		public PlayerSandboxV2.Cook.Food food;

		// Token: 0x04021E4C RID: 138828
		[Token(Token = "0x4021E4C")]
		[FieldOffset(Offset = "0x38")]
		public bool newBook;
	}
}
