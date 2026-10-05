using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B4B RID: 27467
	[Token(Token = "0x2006B4B")]
	public class ArchiveChatRecordCircleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027417 RID: 160791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027417")]
		[Address(RVA = "0x226DE30", Offset = "0x226CA30", VA = "0x18226DE30")]
		public void Render(bool isFullCollected, bool isSelected)
		{
		}

		// Token: 0x06027418 RID: 160792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027418")]
		[Address(RVA = "0x226DF40", Offset = "0x226CB40", VA = "0x18226DF40")]
		public ArchiveChatRecordCircleView()
		{
		}

		// Token: 0x040378E9 RID: 227561
		[Token(Token = "0x40378E9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _collectedImage;

		// Token: 0x040378EA RID: 227562
		[Token(Token = "0x40378EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _uncollectedImage;

		// Token: 0x040378EB RID: 227563
		[Token(Token = "0x40378EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIColorToggle _colorToggle;

		// Token: 0x040378EC RID: 227564
		[Token(Token = "0x40378EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040378ED RID: 227565
		[Token(Token = "0x40378ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
