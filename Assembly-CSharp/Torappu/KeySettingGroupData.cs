using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001017 RID: 4119
	[Token(Token = "0x2001017")]
	public class KeySettingGroupData
	{
		// Token: 0x06006D6A RID: 28010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6A")]
		[Address(RVA = "0x21063D0", Offset = "0x2104FD0", VA = "0x1821063D0")]
		public KeySettingGroupData()
		{
		}

		// Token: 0x0400577C RID: 22396
		[Token(Token = "0x400577C")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0400577D RID: 22397
		[Token(Token = "0x400577D")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400577E RID: 22398
		[Token(Token = "0x400577E")]
		[FieldOffset(Offset = "0x20")]
		public KeySettingGroup funcType;

		// Token: 0x0400577F RID: 22399
		[Token(Token = "0x400577F")]
		[FieldOffset(Offset = "0x24")]
		public KeyEffectGroup keyEffectGroup;

		// Token: 0x04005780 RID: 22400
		[Token(Token = "0x4005780")]
		[FieldOffset(Offset = "0x28")]
		public bool isHidden;

		// Token: 0x04005781 RID: 22401
		[Token(Token = "0x4005781")]
		[FieldOffset(Offset = "0x2C")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ActivityType relatedActType;

		// Token: 0x04005782 RID: 22402
		[Token(Token = "0x4005782")]
		[FieldOffset(Offset = "0x30")]
		public string gameModeTag;

		// Token: 0x04005783 RID: 22403
		[Token(Token = "0x4005783")]
		[FieldOffset(Offset = "0x38")]
		public int sortId;

		// Token: 0x04005784 RID: 22404
		[Token(Token = "0x4005784")]
		[FieldOffset(Offset = "0x40")]
		public long startTs;

		// Token: 0x04005785 RID: 22405
		[Token(Token = "0x4005785")]
		[FieldOffset(Offset = "0x48")]
		public List<KeySettingItemData> itemList;
	}
}
