using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020004FC RID: 1276
	[Token(Token = "0x20004FC")]
	public struct SceneBundle
	{
		// Token: 0x040012DA RID: 4826
		[Token(Token = "0x40012DA")]
		[FieldOffset(Offset = "0x0")]
		public string fromScene;

		// Token: 0x040012DB RID: 4827
		[Token(Token = "0x40012DB")]
		[FieldOffset(Offset = "0x8")]
		public string toScene;

		// Token: 0x040012DC RID: 4828
		[Token(Token = "0x40012DC")]
		[FieldOffset(Offset = "0x10")]
		public ISceneParam param;
	}
}
