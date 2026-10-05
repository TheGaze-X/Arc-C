using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C29 RID: 27689
	[Token(Token = "0x2006C29")]
	public class ArchiveStoryResHolder : MonoBehaviour, IActArchiveSubResHolder, IHotfixable
	{
		// Token: 0x17005D4D RID: 23885
		// (get) Token: 0x0602787E RID: 161918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D4D")]
		public Sprite storyTitle
		{
			[Token(Token = "0x602787E")]
			[Address(RVA = "0x22B6360", Offset = "0x22B4F60", VA = "0x1822B6360")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602787F RID: 161919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602787F")]
		[Address(RVA = "0x22B6300", Offset = "0x22B4F00", VA = "0x1822B6300")]
		public ArchiveStoryResHolder()
		{
		}

		// Token: 0x040380C1 RID: 229569
		[Token(Token = "0x40380C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Story Image")]
		private Sprite _storyTitle;

		// Token: 0x040380C2 RID: 229570
		[Token(Token = "0x40380C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_storyTitle;

		// Token: 0x040380C3 RID: 229571
		[Token(Token = "0x40380C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
