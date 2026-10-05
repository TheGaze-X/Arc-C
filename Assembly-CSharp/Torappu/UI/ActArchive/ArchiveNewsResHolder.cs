using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BCE RID: 27598
	[Token(Token = "0x2006BCE")]
	public class ArchiveNewsResHolder : MonoBehaviour, IActArchiveSubResHolder, IHotfixable
	{
		// Token: 0x17005D0E RID: 23822
		// (get) Token: 0x060276A1 RID: 161441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D0E")]
		public Sprite newsTitle
		{
			[Token(Token = "0x60276A1")]
			[Address(RVA = "0x2298BB0", Offset = "0x22977B0", VA = "0x182298BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060276A2 RID: 161442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276A2")]
		[Address(RVA = "0x2298B50", Offset = "0x2297750", VA = "0x182298B50")]
		public ArchiveNewsResHolder()
		{
		}

		// Token: 0x04037D7F RID: 228735
		[Token(Token = "0x4037D7F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("News Image")]
		private Sprite _newsTitle;

		// Token: 0x04037D80 RID: 228736
		[Token(Token = "0x4037D80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_newsTitle;

		// Token: 0x04037D81 RID: 228737
		[Token(Token = "0x4037D81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
