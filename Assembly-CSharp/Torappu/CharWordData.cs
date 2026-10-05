using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000F7D RID: 3965
	[Token(Token = "0x2000F7D")]
	public class CharWordData : ICharWordData
	{
		// Token: 0x06006CB4 RID: 27828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB4")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
		public string GetWordKey()
		{
			return null;
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB5")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "5")]
		public string GetCharId()
		{
			return null;
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB6")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "6")]
		public string GetVoiceId()
		{
			return null;
		}

		// Token: 0x06006CB7 RID: 27831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB7")]
		[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10", Slot = "7")]
		public string GetVoiceAsset()
		{
			return null;
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB8")]
		[Address(RVA = "0x20FF8A0", Offset = "0x20FE4A0", VA = "0x1820FF8A0")]
		public CharWordData()
		{
		}

		// Token: 0x04005422 RID: 21538
		[Token(Token = "0x4005422")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HashSet<CharWordShowType> ILLUST_SHOW_TYPES;

		// Token: 0x04005423 RID: 21539
		[Token(Token = "0x4005423")]
		[FieldOffset(Offset = "0x10")]
		public string charWordId;

		// Token: 0x04005424 RID: 21540
		[Token(Token = "0x4005424")]
		[FieldOffset(Offset = "0x18")]
		public string wordKey;

		// Token: 0x04005425 RID: 21541
		[Token(Token = "0x4005425")]
		[FieldOffset(Offset = "0x20")]
		public string charId;

		// Token: 0x04005426 RID: 21542
		[Token(Token = "0x4005426")]
		[FieldOffset(Offset = "0x28")]
		public string voiceId;

		// Token: 0x04005427 RID: 21543
		[Token(Token = "0x4005427")]
		[FieldOffset(Offset = "0x30")]
		public string voiceText;

		// Token: 0x04005428 RID: 21544
		[Token(Token = "0x4005428")]
		[FieldOffset(Offset = "0x38")]
		public string voiceTitle;

		// Token: 0x04005429 RID: 21545
		[Token(Token = "0x4005429")]
		[FieldOffset(Offset = "0x40")]
		public int voiceIndex;

		// Token: 0x0400542A RID: 21546
		[Token(Token = "0x400542A")]
		[FieldOffset(Offset = "0x44")]
		[JsonConverter(typeof(StringEnumConverter))]
		public CharWordVoiceType voiceType;

		// Token: 0x0400542B RID: 21547
		[Token(Token = "0x400542B")]
		[FieldOffset(Offset = "0x48")]
		[JsonConverter(typeof(StringEnumConverter))]
		public DataUnlockType unlockType;

		// Token: 0x0400542C RID: 21548
		[Token(Token = "0x400542C")]
		[FieldOffset(Offset = "0x50")]
		public List<CharWordUnlockParam> unlockParam;

		// Token: 0x0400542D RID: 21549
		[Token(Token = "0x400542D")]
		[FieldOffset(Offset = "0x58")]
		public string lockDescription;

		// Token: 0x0400542E RID: 21550
		[Token(Token = "0x400542E")]
		[FieldOffset(Offset = "0x60")]
		[JsonConverter(typeof(StringEnumConverter))]
		public CharWordShowType placeType;

		// Token: 0x0400542F RID: 21551
		[Token(Token = "0x400542F")]
		[FieldOffset(Offset = "0x68")]
		public string voiceAsset;
	}
}
