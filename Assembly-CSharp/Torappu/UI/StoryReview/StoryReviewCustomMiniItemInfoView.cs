using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x0200490E RID: 18702
	[Token(Token = "0x200490E")]
	public class StoryReviewCustomMiniItemInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C33D RID: 115517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C33D")]
		[Address(RVA = "0x15B3650", Offset = "0x15B2250", VA = "0x1815B3650")]
		public void Render(Sprite charSprite, bool locked, bool read)
		{
		}

		// Token: 0x0601C33E RID: 115518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C33E")]
		[Address(RVA = "0x15B3750", Offset = "0x15B2350", VA = "0x1815B3750")]
		public StoryReviewCustomMiniItemInfoView()
		{
		}

		// Token: 0x04024DF3 RID: 151027
		[Token(Token = "0x4024DF3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _readBg;

		// Token: 0x04024DF4 RID: 151028
		[Token(Token = "0x4024DF4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _unreadBg;

		// Token: 0x04024DF5 RID: 151029
		[Token(Token = "0x4024DF5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _newTag;

		// Token: 0x04024DF6 RID: 151030
		[Token(Token = "0x4024DF6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _readMask;

		// Token: 0x04024DF7 RID: 151031
		[Token(Token = "0x4024DF7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _charImg;

		// Token: 0x04024DF8 RID: 151032
		[Token(Token = "0x4024DF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024DF9 RID: 151033
		[Token(Token = "0x4024DF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
