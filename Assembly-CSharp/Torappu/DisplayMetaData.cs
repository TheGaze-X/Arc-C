using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FE9 RID: 4073
	[Token(Token = "0x2000FE9")]
	public class DisplayMetaData
	{
		// Token: 0x06006D40 RID: 27968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D40")]
		[Address(RVA = "0x21018B0", Offset = "0x21004B0", VA = "0x1821018B0")]
		public DisplayMetaData()
		{
		}

		// Token: 0x04005653 RID: 22099
		[Token(Token = "0x4005653")]
		[FieldOffset(Offset = "0x10")]
		public PlayerAvatarData playerAvatarData;

		// Token: 0x04005654 RID: 22100
		[Token(Token = "0x4005654")]
		[FieldOffset(Offset = "0x18")]
		public HomeBackgroundData homeBackgroundData;

		// Token: 0x04005655 RID: 22101
		[Token(Token = "0x4005655")]
		[FieldOffset(Offset = "0x20")]
		public NameCardV2Data nameCardV2Data;

		// Token: 0x04005656 RID: 22102
		[Token(Token = "0x4005656")]
		[FieldOffset(Offset = "0x28")]
		public MailArchiveData mailArchiveData;

		// Token: 0x04005657 RID: 22103
		[Token(Token = "0x4005657")]
		[FieldOffset(Offset = "0x30")]
		public MailSenderData mailSenderData;

		// Token: 0x04005658 RID: 22104
		[Token(Token = "0x4005658")]
		[FieldOffset(Offset = "0x38")]
		public EmoticonData emoticonData;

		// Token: 0x04005659 RID: 22105
		[Token(Token = "0x4005659")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, StoryVariantData> storyVariantData;

		// Token: 0x0400565A RID: 22106
		[Token(Token = "0x400565A")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, GuidebookGroupData> guidebookGroupDatas;

		// Token: 0x0400565B RID: 22107
		[Token(Token = "0x400565B")]
		[FieldOffset(Offset = "0x50")]
		public PCKeyData pcKeyData;

		// Token: 0x0400565C RID: 22108
		[Token(Token = "0x400565C")]
		[FieldOffset(Offset = "0x58")]
		public List<ResolutionSettingItemData> resolutionSettingList;

		// Token: 0x0400565D RID: 22109
		[Token(Token = "0x400565D")]
		[FieldOffset(Offset = "0x60")]
		public ArtGalleryCollectData artGalleryCollectData;

		// Token: 0x0400565E RID: 22110
		[Token(Token = "0x400565E")]
		[FieldOffset(Offset = "0x68")]
		public MagazineLeafData magazineLeafData;

		// Token: 0x0400565F RID: 22111
		[Token(Token = "0x400565F")]
		[FieldOffset(Offset = "0x70")]
		public StickerData stickerData;

		// Token: 0x04005660 RID: 22112
		[Token(Token = "0x4005660")]
		[FieldOffset(Offset = "0x78")]
		public AVGDialogSettingData avgDialogSettingData;
	}
}
