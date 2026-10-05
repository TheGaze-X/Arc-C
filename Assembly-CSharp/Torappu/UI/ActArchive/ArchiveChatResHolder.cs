using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B50 RID: 27472
	[Token(Token = "0x2006B50")]
	public class ArchiveChatResHolder : MonoBehaviour, IActArchiveSubResHolder, IHotfixable
	{
		// Token: 0x17005CC4 RID: 23748
		// (get) Token: 0x0602742D RID: 160813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005CC4")]
		public Sprite chatTitle
		{
			[Token(Token = "0x602742D")]
			[Address(RVA = "0x226F8A0", Offset = "0x226E4A0", VA = "0x18226F8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602742E RID: 160814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602742E")]
		[Address(RVA = "0x226F840", Offset = "0x226E440", VA = "0x18226F840")]
		public ArchiveChatResHolder()
		{
		}

		// Token: 0x04037927 RID: 227623
		[Token(Token = "0x4037927")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Chat Image")]
		private Sprite _chatTitle;

		// Token: 0x04037928 RID: 227624
		[Token(Token = "0x4037928")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_chatTitle;

		// Token: 0x04037929 RID: 227625
		[Token(Token = "0x4037929")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
