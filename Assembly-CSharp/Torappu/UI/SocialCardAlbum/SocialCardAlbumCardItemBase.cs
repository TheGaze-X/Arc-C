using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EAE RID: 16046
	[Token(Token = "0x2003EAE")]
	public abstract class SocialCardAlbumCardItemBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003B6D RID: 15213
		// (get) Token: 0x06018E84 RID: 102020
		[Token(Token = "0x17003B6D")]
		public abstract CardType cardType { [Token(Token = "0x6018E84")] get; }

		// Token: 0x17003B6E RID: 15214
		// (get) Token: 0x06018E86 RID: 102022 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018E85 RID: 102021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B6E")]
		public IDragHandler dragHandler
		{
			[Token(Token = "0x6018E86")]
			[Address(RVA = "0x1183950", Offset = "0x1182550", VA = "0x181183950")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6018E85")]
			[Address(RVA = "0x11839B0", Offset = "0x11825B0", VA = "0x1811839B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06018E87 RID: 102023
		[Token(Token = "0x6018E87")]
		public abstract void Render(CardViewModel card);

		// Token: 0x06018E88 RID: 102024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E88")]
		[Address(RVA = "0x11838F0", Offset = "0x11824F0", VA = "0x1811838F0")]
		protected SocialCardAlbumCardItemBase()
		{
		}

		// Token: 0x0401EBBA RID: 125882
		[Token(Token = "0x401EBBA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_dragHandler;

		// Token: 0x0401EBBB RID: 125883
		[Token(Token = "0x401EBBB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dragHandler;

		// Token: 0x0401EBBC RID: 125884
		[Token(Token = "0x401EBBC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
