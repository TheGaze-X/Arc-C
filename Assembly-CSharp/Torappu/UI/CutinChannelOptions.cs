using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200369C RID: 13980
	[Token(Token = "0x200369C")]
	public struct CutinChannelOptions
	{
		// Token: 0x0401AB9B RID: 109467
		[Token(Token = "0x401AB9B")]
		[FieldOffset(Offset = "0x0")]
		public ILoadAsset assetLoader;

		// Token: 0x0401AB9C RID: 109468
		[Token(Token = "0x401AB9C")]
		[FieldOffset(Offset = "0x8")]
		public Func<string, string> getMaskPathFromId;
	}
}
