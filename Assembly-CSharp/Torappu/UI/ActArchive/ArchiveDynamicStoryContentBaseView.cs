using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C2B RID: 27691
	[Token(Token = "0x2006C2B")]
	public abstract class ArchiveDynamicStoryContentBaseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027882 RID: 161922
		[Token(Token = "0x6027882")]
		public abstract void ApplyContentView(StoryItemModel model, Sprite header, Sprite content);

		// Token: 0x06027883 RID: 161923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027883")]
		[Address(RVA = "0x22A7B70", Offset = "0x22A6770", VA = "0x1822A7B70")]
		protected ArchiveDynamicStoryContentBaseView()
		{
		}

		// Token: 0x040380CA RID: 229578
		[Token(Token = "0x40380CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
