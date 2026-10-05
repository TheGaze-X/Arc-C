using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.U2D
{
	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	[NativeType(Header = "Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
	[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
	public class SpriteAtlas : Object
	{
		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000C13 RID: 3091
		[Token(Token = "0x17000287")]
		public extern int spriteCount { [Token(Token = "0x6000C13")] [Address(RVA = "0x596D070", Offset = "0x596BC70", VA = "0x18596D070")] [MethodImpl(4096)] get; }

		// Token: 0x06000C14 RID: 3092
		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x596CFD0", Offset = "0x596BBD0", VA = "0x18596CFD0")]
		[MethodImpl(4096)]
		public extern bool CanBindTo([NotNull("ArgumentNullException")] Sprite sprite);

		// Token: 0x06000C15 RID: 3093 RVA: 0x00006900 File Offset: 0x00004B00
		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x596D020", Offset = "0x596BC20", VA = "0x18596D020")]
		public int GetSprites(Sprite[] sprites)
		{
			return 0;
		}

		// Token: 0x06000C16 RID: 3094
		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x596D020", Offset = "0x596BC20", VA = "0x18596D020")]
		[MethodImpl(4096)]
		private extern int GetSpritesScripting([Unmarshalled] Sprite[] sprites);
	}
}
