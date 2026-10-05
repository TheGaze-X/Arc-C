using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066C4 RID: 26308
	[Token(Token = "0x20066C4")]
	public class HandBookVoiceLangViewModel : IHotfixable
	{
		// Token: 0x17005986 RID: 22918
		// (get) Token: 0x06025C74 RID: 154740 RVA: 0x000C90F0 File Offset: 0x000C72F0
		[Token(Token = "0x17005986")]
		public int itemCount
		{
			[Token(Token = "0x6025C74")]
			[Address(RVA = "0x20CB3E0", Offset = "0x20C9FE0", VA = "0x1820CB3E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06025C75 RID: 154741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025C75")]
		[Address(RVA = "0x20CAD90", Offset = "0x20C9990", VA = "0x1820CAD90")]
		public HandBookVoiceLangViewModel.VoiceLangItem GetVoiceLangItem(int index)
		{
			return null;
		}

		// Token: 0x06025C76 RID: 154742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C76")]
		[Address(RVA = "0x20CAE90", Offset = "0x20C9A90", VA = "0x1820CAE90")]
		public void InitData(VoiceLangType voiceLangType, VoiceLangData voiceLangData)
		{
		}

		// Token: 0x06025C77 RID: 154743 RVA: 0x000C9108 File Offset: 0x000C7308
		[Token(Token = "0x6025C77")]
		[Address(RVA = "0x20CB2D0", Offset = "0x20C9ED0", VA = "0x1820CB2D0")]
		private static VoiceLangType _EnumVoiceLangType(VoiceLangType type)
		{
			return VoiceLangType.NONE;
		}

		// Token: 0x06025C78 RID: 154744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C78")]
		[Address(RVA = "0x20CB330", Offset = "0x20C9F30", VA = "0x1820CB330")]
		public HandBookVoiceLangViewModel()
		{
		}

		// Token: 0x040351B6 RID: 217526
		[Token(Token = "0x40351B6")]
		[FieldOffset(Offset = "0x10")]
		public VoiceLangType selectedLangType;

		// Token: 0x040351B7 RID: 217527
		[Token(Token = "0x40351B7")]
		[FieldOffset(Offset = "0x18")]
		private List<HandBookVoiceLangViewModel.VoiceLangItem> m_langItems;

		// Token: 0x040351B8 RID: 217528
		[Token(Token = "0x40351B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemCount;

		// Token: 0x040351B9 RID: 217529
		[Token(Token = "0x40351B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetVoiceLangItem;

		// Token: 0x040351BA RID: 217530
		[Token(Token = "0x40351BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040351BB RID: 217531
		[Token(Token = "0x40351BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnumVoiceLangType;

		// Token: 0x040351BC RID: 217532
		[Token(Token = "0x40351BC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020066C5 RID: 26309
		[Token(Token = "0x20066C5")]
		public class VoiceLangItem
		{
			// Token: 0x06025C79 RID: 154745 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025C79")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VoiceLangItem()
			{
			}

			// Token: 0x040351BD RID: 217533
			[Token(Token = "0x40351BD")]
			[FieldOffset(Offset = "0x10")]
			public string langName;

			// Token: 0x040351BE RID: 217534
			[Token(Token = "0x40351BE")]
			[FieldOffset(Offset = "0x18")]
			public VoiceLangType voiceLangType;

			// Token: 0x040351BF RID: 217535
			[Token(Token = "0x40351BF")]
			[FieldOffset(Offset = "0x20")]
			public string cvName;

			// Token: 0x040351C0 RID: 217536
			[Token(Token = "0x40351C0")]
			[FieldOffset(Offset = "0x28")]
			public bool hasNoResource;
		}
	}
}
