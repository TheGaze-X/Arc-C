using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020010B8 RID: 4280
	[Token(Token = "0x20010B8")]
	[Serializable]
	public class ItemBundle : ISharedItemModel
	{
		// Token: 0x06006E46 RID: 28230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E46")]
		[Address(RVA = "0x21061B0", Offset = "0x2104DB0", VA = "0x1821061B0")]
		[JsonConstructor]
		public ItemBundle(string itemId, ItemType itemType, int count)
		{
		}

		// Token: 0x06006E47 RID: 28231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E47")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ItemBundle()
		{
		}

		// Token: 0x06006E48 RID: 28232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E48")]
		[Address(RVA = "0x2106170", Offset = "0x2104D70", VA = "0x182106170")]
		private void _Init(string itemId_, ItemType itemType_, int count_)
		{
		}

		// Token: 0x06006E49 RID: 28233 RVA: 0x00032028 File Offset: 0x00030228
		[Token(Token = "0x6006E49")]
		[Address(RVA = "0x21060B0", Offset = "0x2104CB0", VA = "0x1821060B0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006E4A RID: 28234 RVA: 0x00032040 File Offset: 0x00030240
		[Token(Token = "0x6006E4A")]
		[Address(RVA = "0x2106120", Offset = "0x2104D20", VA = "0x182106120")]
		public bool IsSameItem(ItemBundle other)
		{
			return default(bool);
		}

		// Token: 0x06006E4B RID: 28235 RVA: 0x00032058 File Offset: 0x00030258
		[Token(Token = "0x6006E4B")]
		[Address(RVA = "0x2105F80", Offset = "0x2104B80", VA = "0x182105F80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06006E4C RID: 28236 RVA: 0x00032070 File Offset: 0x00030270
		[Token(Token = "0x17000D20")]
		[JsonIgnore]
		public bool isEmpty
		{
			[Token(Token = "0x6006E4C")]
			[Address(RVA = "0x2106210", Offset = "0x2104E10", VA = "0x182106210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006E4D RID: 28237 RVA: 0x00032088 File Offset: 0x00030288
		[Token(Token = "0x6006E4D")]
		[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "4")]
		public ItemType GetItemType()
		{
			return ItemType.NONE;
		}

		// Token: 0x06006E4E RID: 28238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E4E")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x06006E4F RID: 28239 RVA: 0x000320A0 File Offset: 0x000302A0
		[Token(Token = "0x6006E4F")]
		[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x06006E50 RID: 28240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E50")]
		[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0", Slot = "7")]
		public void SetItemCount(int count_)
		{
		}

		// Token: 0x04005BA0 RID: 23456
		[Token(Token = "0x4005BA0")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005BA1 RID: 23457
		[Token(Token = "0x4005BA1")]
		[FieldOffset(Offset = "0x18")]
		public int count;

		// Token: 0x04005BA2 RID: 23458
		[Token(Token = "0x4005BA2")]
		[FieldOffset(Offset = "0x1C")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType type;
	}
}
