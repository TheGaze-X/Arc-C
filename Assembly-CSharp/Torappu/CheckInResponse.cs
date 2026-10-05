using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000774 RID: 1908
	[Token(Token = "0x2000774")]
	public class CheckInResponse : PlayerDeltaResponse
	{
		// Token: 0x060063EA RID: 25578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063EA")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public CheckInResponse()
		{
		}

		// Token: 0x04003001 RID: 12289
		[Token(Token = "0x4003001")]
		[FieldOffset(Offset = "0x28")]
		public CheckInResponse.ItemModel[] signInRewards;

		// Token: 0x04003002 RID: 12290
		[Token(Token = "0x4003002")]
		[FieldOffset(Offset = "0x30")]
		public CheckInResponse.ItemModel[] subscriptionRewards;

		// Token: 0x02000775 RID: 1909
		[Token(Token = "0x2000775")]
		public struct ItemModel : ISharedItemModel, IGachaResultHolder
		{
			// Token: 0x060063EB RID: 25579 RVA: 0x000304C8 File Offset: 0x0002E6C8
			[Token(Token = "0x60063EB")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "4")]
			public ItemType GetItemType()
			{
				return ItemType.NONE;
			}

			// Token: 0x060063EC RID: 25580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60063EC")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "5")]
			public string GetItemId()
			{
				return null;
			}

			// Token: 0x060063ED RID: 25581 RVA: 0x000304E0 File Offset: 0x0002E6E0
			[Token(Token = "0x60063ED")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
			public int GetItemCount()
			{
				return 0;
			}

			// Token: 0x060063EE RID: 25582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063EE")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0", Slot = "7")]
			public void SetItemCount(int count_)
			{
			}

			// Token: 0x060063EF RID: 25583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60063EF")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "8")]
			public GachaResult GetGachaResult()
			{
				return null;
			}

			// Token: 0x04003003 RID: 12291
			[Token(Token = "0x4003003")]
			[FieldOffset(Offset = "0x0")]
			[JsonConverter(typeof(StringEnumConverter))]
			public ItemType type;

			// Token: 0x04003004 RID: 12292
			[Token(Token = "0x4003004")]
			[FieldOffset(Offset = "0x8")]
			public string id;

			// Token: 0x04003005 RID: 12293
			[Token(Token = "0x4003005")]
			[FieldOffset(Offset = "0x10")]
			public GachaResult charGet;

			// Token: 0x04003006 RID: 12294
			[Token(Token = "0x4003006")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}
	}
}
