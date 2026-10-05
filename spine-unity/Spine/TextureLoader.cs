using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public interface TextureLoader
	{
		// Token: 0x0600015B RID: 347
		[Token(Token = "0x600015B")]
		void Load(AtlasPage page, string path);

		// Token: 0x0600015C RID: 348
		[Token(Token = "0x600015C")]
		void Unload(object texture);
	}
}
