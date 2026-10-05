using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EBC RID: 16060
	[Token(Token = "0x2003EBC")]
	public abstract class SocialCardAlbumSideSubBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003B79 RID: 15225
		// (get) Token: 0x06018EDB RID: 102107
		[Token(Token = "0x17003B79")]
		public abstract CardType cardType { [Token(Token = "0x6018EDB")] get; }

		// Token: 0x06018EDC RID: 102108
		[Token(Token = "0x6018EDC")]
		public abstract void Render(CardViewModel card);

		// Token: 0x06018EDD RID: 102109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EDD")]
		[Address(RVA = "0x11A8430", Offset = "0x11A7030", VA = "0x1811A8430")]
		protected SocialCardAlbumSideSubBase()
		{
		}

		// Token: 0x0401EC30 RID: 126000
		[Token(Token = "0x401EC30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
