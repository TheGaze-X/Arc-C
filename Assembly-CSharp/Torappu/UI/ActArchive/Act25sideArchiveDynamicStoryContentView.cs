using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C2A RID: 27690
	[Token(Token = "0x2006C2A")]
	public class Act25sideArchiveDynamicStoryContentView : ArchiveDynamicStoryContentBaseView
	{
		// Token: 0x06027880 RID: 161920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027880")]
		[Address(RVA = "0x22A7660", Offset = "0x22A6260", VA = "0x1822A7660", Slot = "4")]
		public override void ApplyContentView(StoryItemModel model, Sprite header, Sprite content)
		{
		}

		// Token: 0x06027881 RID: 161921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027881")]
		[Address(RVA = "0x22A77D0", Offset = "0x22A63D0", VA = "0x1822A77D0")]
		public Act25sideArchiveDynamicStoryContentView()
		{
		}

		// Token: 0x040380C4 RID: 229572
		[Token(Token = "0x40380C4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x040380C5 RID: 229573
		[Token(Token = "0x40380C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x040380C6 RID: 229574
		[Token(Token = "0x40380C6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageContent;

		// Token: 0x040380C7 RID: 229575
		[Token(Token = "0x40380C7")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedStoryId;

		// Token: 0x040380C8 RID: 229576
		[Token(Token = "0x40380C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyContentView;

		// Token: 0x040380C9 RID: 229577
		[Token(Token = "0x40380C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
