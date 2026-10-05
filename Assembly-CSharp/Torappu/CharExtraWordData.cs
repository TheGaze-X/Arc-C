using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F7E RID: 3966
	[Token(Token = "0x2000F7E")]
	public class CharExtraWordData : ICharWordData
	{
		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06006CBA RID: 27834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0F")]
		public string charWordId
		{
			[Token(Token = "0x6006CBA")]
			[Address(RVA = "0x20FF310", Offset = "0x20FDF10", VA = "0x1820FF310")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006CBB RID: 27835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBB")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
		public string GetWordKey()
		{
			return null;
		}

		// Token: 0x06006CBC RID: 27836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBC")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
		public string GetCharId()
		{
			return null;
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBD")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "6")]
		public string GetVoiceId()
		{
			return null;
		}

		// Token: 0x06006CBE RID: 27838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBE")]
		[Address(RVA = "0x20FF2C0", Offset = "0x20FDEC0", VA = "0x1820FF2C0", Slot = "7")]
		public string GetVoiceAsset()
		{
			return null;
		}

		// Token: 0x06006CBF RID: 27839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBF")]
		[Address(RVA = "0x20FF270", Offset = "0x20FDE70", VA = "0x1820FF270")]
		public static string GenerateCharWordId(string wordKey, string voiceId)
		{
			return null;
		}

		// Token: 0x06006CC0 RID: 27840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharExtraWordData()
		{
		}

		// Token: 0x04005430 RID: 21552
		[Token(Token = "0x4005430")]
		private const string CHAR_WORD_ID_FORMAT = "{0}_{1}";

		// Token: 0x04005431 RID: 21553
		[Token(Token = "0x4005431")]
		private const string VOICE_ASSET_FORMAT = "{0}/{1}";

		// Token: 0x04005432 RID: 21554
		[Token(Token = "0x4005432")]
		[FieldOffset(Offset = "0x10")]
		public string wordKey;

		// Token: 0x04005433 RID: 21555
		[Token(Token = "0x4005433")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x04005434 RID: 21556
		[Token(Token = "0x4005434")]
		[FieldOffset(Offset = "0x20")]
		public string voiceId;

		// Token: 0x04005435 RID: 21557
		[Token(Token = "0x4005435")]
		[FieldOffset(Offset = "0x28")]
		public string voiceText;
	}
}
