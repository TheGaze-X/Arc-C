using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FDE RID: 24542
	[Token(Token = "0x2005FDE")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CGGalleryServiceCode
	{
		// Token: 0x04031138 RID: 201016
		[Token(Token = "0x4031138")]
		public const string ADD_FAVOURITE = "/cg/addCgCollection";

		// Token: 0x04031139 RID: 201017
		[Token(Token = "0x4031139")]
		public const string REMOVE_FAVOURITE = "/cg/removeCgCollection";

		// Token: 0x0403113A RID: 201018
		[Token(Token = "0x403113A")]
		public const string GET_FAVOURITE = "/cg/getCgCollection";
	}
}
