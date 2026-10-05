using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200671B RID: 26395
	[Token(Token = "0x200671B")]
	public class HandBookV2MissionListItemModel : IComparable<HandBookV2MissionListItemModel>
	{
		// Token: 0x06025DEF RID: 155119 RVA: 0x000C9408 File Offset: 0x000C7608
		[Token(Token = "0x6025DEF")]
		[Address(RVA = "0x20E5CF0", Offset = "0x20E48F0", VA = "0x1820E5CF0", Slot = "4")]
		public int CompareTo(HandBookV2MissionListItemModel other)
		{
			return 0;
		}

		// Token: 0x06025DF0 RID: 155120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DF0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookV2MissionListItemModel()
		{
		}

		// Token: 0x0403543E RID: 218174
		[Token(Token = "0x403543E")]
		[FieldOffset(Offset = "0x10")]
		public string missionId;

		// Token: 0x0403543F RID: 218175
		[Token(Token = "0x403543F")]
		[FieldOffset(Offset = "0x18")]
		public int missionSort;

		// Token: 0x04035440 RID: 218176
		[Token(Token = "0x4035440")]
		[FieldOffset(Offset = "0x20")]
		public string forceId;

		// Token: 0x04035441 RID: 218177
		[Token(Token = "0x4035441")]
		[FieldOffset(Offset = "0x28")]
		public string forceName;

		// Token: 0x04035442 RID: 218178
		[Token(Token = "0x4035442")]
		[FieldOffset(Offset = "0x30")]
		public List<HandBookV2MissionListItemModel.CharacterFavorData> charDataList;

		// Token: 0x04035443 RID: 218179
		[Token(Token = "0x4035443")]
		[FieldOffset(Offset = "0x38")]
		public HandBookV2ForceFavorViewModel favorModel;

		// Token: 0x04035444 RID: 218180
		[Token(Token = "0x4035444")]
		[FieldOffset(Offset = "0x40")]
		public ItemBundle item;

		// Token: 0x04035445 RID: 218181
		[Token(Token = "0x4035445")]
		[FieldOffset(Offset = "0x48")]
		public int needFavorPoint;

		// Token: 0x04035446 RID: 218182
		[Token(Token = "0x4035446")]
		[FieldOffset(Offset = "0x4C")]
		public bool isRewardAvail;

		// Token: 0x0200671C RID: 26396
		[Token(Token = "0x200671C")]
		public class CharacterFavorData
		{
			// Token: 0x06025DF1 RID: 155121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025DF1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CharacterFavorData()
			{
			}

			// Token: 0x04035447 RID: 218183
			[Token(Token = "0x4035447")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04035448 RID: 218184
			[Token(Token = "0x4035448")]
			[FieldOffset(Offset = "0x18")]
			public string charName;

			// Token: 0x04035449 RID: 218185
			[Token(Token = "0x4035449")]
			[FieldOffset(Offset = "0x20")]
			public string displayNumber;

			// Token: 0x0403544A RID: 218186
			[Token(Token = "0x403544A")]
			[FieldOffset(Offset = "0x28")]
			public int favorPoint;

			// Token: 0x0403544B RID: 218187
			[Token(Token = "0x403544B")]
			[FieldOffset(Offset = "0x2C")]
			public bool isAvail;

			// Token: 0x0403544C RID: 218188
			[Token(Token = "0x403544C")]
			[FieldOffset(Offset = "0x2D")]
			public bool isNPC;
		}
	}
}
