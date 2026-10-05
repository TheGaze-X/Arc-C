using System;
using Il2CppDummyDll;

namespace Torappu.Gacha
{
	// Token: 0x0200165B RID: 5723
	[Token(Token = "0x200165B")]
	public class GachaSceneParam : ISceneParam
	{
		// Token: 0x060081E5 RID: 33253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081E5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GachaSceneParam()
		{
		}

		// Token: 0x040083F1 RID: 33777
		[Token(Token = "0x40083F1")]
		[FieldOffset(Offset = "0x10")]
		public GachaController.PlayMode playMode;

		// Token: 0x040083F2 RID: 33778
		[Token(Token = "0x40083F2")]
		[FieldOffset(Offset = "0x18")]
		public GachaController.Input input;

		// Token: 0x040083F3 RID: 33779
		[Token(Token = "0x40083F3")]
		[FieldOffset(Offset = "0x78")]
		public string nextScene;

		// Token: 0x040083F4 RID: 33780
		[Token(Token = "0x40083F4")]
		[FieldOffset(Offset = "0x80")]
		public GameFlowController.Options nextOptions;

		// Token: 0x040083F5 RID: 33781
		[Token(Token = "0x40083F5")]
		[FieldOffset(Offset = "0xA8")]
		public Action<GachaController.Output> endCb;
	}
}
