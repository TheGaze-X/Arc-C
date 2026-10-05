using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001092 RID: 4242
	[Token(Token = "0x2001092")]
	[Serializable]
	public class HandBookInfoTextViewData
	{
		// Token: 0x06006E1D RID: 28189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E1D")]
		[Address(RVA = "0x21056A0", Offset = "0x21042A0", VA = "0x1821056A0")]
		public HandBookInfoTextViewData()
		{
		}

		// Token: 0x04005A7E RID: 23166
		[Token(Token = "0x4005A7E")]
		[FieldOffset(Offset = "0x10")]
		public List<HandBookInfoTextViewData.InfoTextAudio> infoList;

		// Token: 0x04005A7F RID: 23167
		[Token(Token = "0x4005A7F")]
		[FieldOffset(Offset = "0x18")]
		public bool unLockorNot;

		// Token: 0x04005A80 RID: 23168
		[Token(Token = "0x4005A80")]
		[FieldOffset(Offset = "0x1C")]
		public DataUnlockType unLockType;

		// Token: 0x04005A81 RID: 23169
		[Token(Token = "0x4005A81")]
		[FieldOffset(Offset = "0x20")]
		public string unLockParam;

		// Token: 0x04005A82 RID: 23170
		[Token(Token = "0x4005A82")]
		[FieldOffset(Offset = "0x28")]
		public int unLockLevel;

		// Token: 0x04005A83 RID: 23171
		[Token(Token = "0x4005A83")]
		[FieldOffset(Offset = "0x2C")]
		public int unLockLevelAdditive;

		// Token: 0x04005A84 RID: 23172
		[Token(Token = "0x4005A84")]
		[FieldOffset(Offset = "0x30")]
		public string unLockString;

		// Token: 0x02001093 RID: 4243
		[Token(Token = "0x2001093")]
		[Serializable]
		public struct InfoTextAudio
		{
			// Token: 0x06006E1E RID: 28190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E1E")]
			[Address(RVA = "0xD6AD60", Offset = "0xD69960", VA = "0x180D6AD60")]
			public InfoTextAudio(string text, string audio)
			{
			}

			// Token: 0x04005A85 RID: 23173
			[Token(Token = "0x4005A85")]
			[FieldOffset(Offset = "0x0")]
			public string infoText;

			// Token: 0x04005A86 RID: 23174
			[Token(Token = "0x4005A86")]
			[FieldOffset(Offset = "0x8")]
			public string audioName;
		}
	}
}
