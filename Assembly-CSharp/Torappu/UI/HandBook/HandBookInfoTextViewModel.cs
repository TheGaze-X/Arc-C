using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066CA RID: 26314
	[Token(Token = "0x20066CA")]
	[Serializable]
	public class HandBookInfoTextViewModel
	{
		// Token: 0x06025C83 RID: 154755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025C83")]
		[Address(RVA = "0x20BD160", Offset = "0x20BBD60", VA = "0x1820BD160")]
		public static HandBookInfoTextViewModel ConvertFromData(CharWordData data)
		{
			return null;
		}

		// Token: 0x06025C84 RID: 154756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C84")]
		[Address(RVA = "0x20BD390", Offset = "0x20BBF90", VA = "0x1820BD390")]
		public HandBookInfoTextViewModel()
		{
		}

		// Token: 0x040351D4 RID: 217556
		[Token(Token = "0x40351D4")]
		[FieldOffset(Offset = "0x10")]
		public List<HandBookInfoTextViewModel.InfoTextAudio> infoList;

		// Token: 0x040351D5 RID: 217557
		[Token(Token = "0x40351D5")]
		[FieldOffset(Offset = "0x18")]
		public bool unLockorNot;

		// Token: 0x040351D6 RID: 217558
		[Token(Token = "0x40351D6")]
		[FieldOffset(Offset = "0x20")]
		public string unLockString;

		// Token: 0x040351D7 RID: 217559
		[Token(Token = "0x40351D7")]
		[FieldOffset(Offset = "0x28")]
		public DataUnlockType unLockType;

		// Token: 0x040351D8 RID: 217560
		[Token(Token = "0x40351D8")]
		[FieldOffset(Offset = "0x30")]
		public List<CharWordUnlockParam> unLockParam;

		// Token: 0x020066CB RID: 26315
		[Token(Token = "0x20066CB")]
		[Serializable]
		public struct InfoTextAudio
		{
			// Token: 0x06025C85 RID: 154757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025C85")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			public InfoTextAudio(CharWordData data)
			{
			}

			// Token: 0x17005989 RID: 22921
			// (get) Token: 0x06025C86 RID: 154758 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005989")]
			public string infoText
			{
				[Token(Token = "0x6025C86")]
				[Address(RVA = "0x20CBE60", Offset = "0x20CAA60", VA = "0x1820CBE60")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700598A RID: 22922
			// (get) Token: 0x06025C87 RID: 154759 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700598A")]
			public string voiceAsset
			{
				[Token(Token = "0x6025C87")]
				[Address(RVA = "0x20CBEB0", Offset = "0x20CAAB0", VA = "0x1820CBEB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700598B RID: 22923
			// (get) Token: 0x06025C88 RID: 154760 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700598B")]
			public string voiceTitle
			{
				[Token(Token = "0x6025C88")]
				[Address(RVA = "0x20CBF00", Offset = "0x20CAB00", VA = "0x1820CBF00")]
				get
				{
					return null;
				}
			}

			// Token: 0x040351D9 RID: 217561
			[Token(Token = "0x40351D9")]
			[FieldOffset(Offset = "0x0")]
			public CharWordData sourceData;
		}
	}
}
