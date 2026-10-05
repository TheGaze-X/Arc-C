using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020013AB RID: 5035
	[Token(Token = "0x20013AB")]
	[Serializable]
	public class TipData : IItemWithWeight
	{
		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06007396 RID: 29590 RVA: 0x00033660 File Offset: 0x00031860
		[Token(Token = "0x17000E23")]
		[JsonIgnore]
		public float weightValue
		{
			[Token(Token = "0x6007396")]
			[Address(RVA = "0x5B4650", Offset = "0x5B3250", VA = "0x1805B4650", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007397")]
		[Address(RVA = "0x2215CF0", Offset = "0x22148F0", VA = "0x182215CF0")]
		public TipData()
		{
		}

		// Token: 0x04006FEC RID: 28652
		[Token(Token = "0x4006FEC")]
		[FieldOffset(Offset = "0x10")]
		public string tip;

		// Token: 0x04006FED RID: 28653
		[Token(Token = "0x4006FED")]
		[FieldOffset(Offset = "0x18")]
		public float weight;

		// Token: 0x04006FEE RID: 28654
		[Token(Token = "0x4006FEE")]
		[FieldOffset(Offset = "0x1C")]
		[JsonConverter(typeof(StringEnumConverter))]
		public TipData.Category category;

		// Token: 0x020013AC RID: 5036
		[Token(Token = "0x20013AC")]
		public enum Category
		{
			// Token: 0x04006FF0 RID: 28656
			[Token(Token = "0x4006FF0")]
			NONE,
			// Token: 0x04006FF1 RID: 28657
			[Token(Token = "0x4006FF1")]
			BATTLE,
			// Token: 0x04006FF2 RID: 28658
			[Token(Token = "0x4006FF2")]
			UI,
			// Token: 0x04006FF3 RID: 28659
			[Token(Token = "0x4006FF3")]
			BUILDING = 4,
			// Token: 0x04006FF4 RID: 28660
			[Token(Token = "0x4006FF4")]
			GACHA = 8,
			// Token: 0x04006FF5 RID: 28661
			[Token(Token = "0x4006FF5")]
			MISC = 16,
			// Token: 0x04006FF6 RID: 28662
			[Token(Token = "0x4006FF6")]
			ALL = 31
		}
	}
}
