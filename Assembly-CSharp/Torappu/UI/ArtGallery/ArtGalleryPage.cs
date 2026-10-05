using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065CD RID: 26061
	[Token(Token = "0x20065CD")]
	public class ArtGalleryPage : StateEnginePage, IValueMsgReceiver
	{
		// Token: 0x06025734 RID: 153396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025734")]
		[Address(RVA = "0x205E260", Offset = "0x205CE60", VA = "0x18205E260", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06025735 RID: 153397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025735")]
		[Address(RVA = "0x205EA40", Offset = "0x205D640", VA = "0x18205EA40")]
		private void _EventOnOpenWardrobePage()
		{
		}

		// Token: 0x06025736 RID: 153398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025736")]
		[Address(RVA = "0x205E8A0", Offset = "0x205D4A0", VA = "0x18205E8A0")]
		private void _EventOnOpenGalleryDisplayState()
		{
		}

		// Token: 0x06025737 RID: 153399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025737")]
		[Address(RVA = "0x205E7C0", Offset = "0x205D3C0", VA = "0x18205E7C0")]
		private void _EventOnOpenCollectionDisplayState()
		{
		}

		// Token: 0x06025738 RID: 153400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025738")]
		[Address(RVA = "0x205E6D0", Offset = "0x205D2D0", VA = "0x18205E6D0")]
		private void _EventOnExitClick()
		{
		}

		// Token: 0x06025739 RID: 153401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025739")]
		[Address(RVA = "0x205E980", Offset = "0x205D580", VA = "0x18205E980")]
		private void _EventOnOpenMagazineCoverPage()
		{
		}

		// Token: 0x0602573A RID: 153402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602573A")]
		[Address(RVA = "0x205E110", Offset = "0x205CD10", VA = "0x18205E110")]
		public void EventOnOpenDiyPage()
		{
		}

		// Token: 0x0602573B RID: 153403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602573B")]
		[Address(RVA = "0x205DF90", Offset = "0x205CB90", VA = "0x18205DF90")]
		public static CommonTopMenu CreateCommonTopMenu(Transform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x0602573C RID: 153404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602573C")]
		[Address(RVA = "0x205EB00", Offset = "0x205D700", VA = "0x18205EB00")]
		public ArtGalleryPage()
		{
		}

		// Token: 0x040348FB RID: 215291
		[Token(Token = "0x40348FB")]
		[NonSerialized]
		public const int OPEN_WARDROBE_PAGE = 0;

		// Token: 0x040348FC RID: 215292
		[Token(Token = "0x40348FC")]
		[NonSerialized]
		public const int OPEN_GALLERY_DISPLAY_STATE = 1;

		// Token: 0x040348FD RID: 215293
		[Token(Token = "0x40348FD")]
		[NonSerialized]
		public const int OPEN_COLLECTION_DISPLAY_STATE = 2;

		// Token: 0x040348FE RID: 215294
		[Token(Token = "0x40348FE")]
		[NonSerialized]
		public const int EXIT_CLICKED = 3;

		// Token: 0x040348FF RID: 215295
		[Token(Token = "0x40348FF")]
		[NonSerialized]
		public const int OPEN_MAGAZINE_COVER_PAGE = 4;

		// Token: 0x04034900 RID: 215296
		[Token(Token = "0x4034900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04034901 RID: 215297
		[Token(Token = "0x4034901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EventOnOpenWardrobePage;

		// Token: 0x04034902 RID: 215298
		[Token(Token = "0x4034902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnOpenGalleryDisplayState;

		// Token: 0x04034903 RID: 215299
		[Token(Token = "0x4034903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnOpenCollectionDisplayState;

		// Token: 0x04034904 RID: 215300
		[Token(Token = "0x4034904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnExitClick;

		// Token: 0x04034905 RID: 215301
		[Token(Token = "0x4034905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnOpenMagazineCoverPage;

		// Token: 0x04034906 RID: 215302
		[Token(Token = "0x4034906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnOpenDiyPage;

		// Token: 0x04034907 RID: 215303
		[Token(Token = "0x4034907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x04034908 RID: 215304
		[Token(Token = "0x4034908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
