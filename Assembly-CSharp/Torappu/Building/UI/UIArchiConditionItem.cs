using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001B44 RID: 6980
	[Token(Token = "0x2001B44")]
	public class UIArchiConditionItem : MonoBehaviour
	{
		// Token: 0x0600AF83 RID: 44931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF83")]
		[Address(RVA = "0x32B2070", Offset = "0x32B0C70", VA = "0x1832B2070")]
		public void Setup(UIArchiConditionItem.ConditionContentItem item)
		{
		}

		// Token: 0x0600AF84 RID: 44932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF84")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIArchiConditionItem()
		{
		}

		// Token: 0x0400A934 RID: 43316
		[Token(Token = "0x400A934")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _nameView;

		// Token: 0x0400A935 RID: 43317
		[Token(Token = "0x400A935")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIComplexRoomLevelView _levelView;

		// Token: 0x0400A936 RID: 43318
		[Token(Token = "0x400A936")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _countView;

		// Token: 0x02001B45 RID: 6981
		[Token(Token = "0x2001B45")]
		public struct ConditionContentItem
		{
			// Token: 0x0600AF85 RID: 44933 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF85")]
			[Address(RVA = "0x317D1A0", Offset = "0x317BDA0", VA = "0x18317D1A0")]
			public ConditionContentItem(string name, BuildingData.RoomType roomType, int level, int count)
			{
			}

			// Token: 0x0400A937 RID: 43319
			[Token(Token = "0x400A937")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x0400A938 RID: 43320
			[Token(Token = "0x400A938")]
			[FieldOffset(Offset = "0x8")]
			public BuildingData.RoomType roomType;

			// Token: 0x0400A939 RID: 43321
			[Token(Token = "0x400A939")]
			[FieldOffset(Offset = "0xC")]
			public int level;

			// Token: 0x0400A93A RID: 43322
			[Token(Token = "0x400A93A")]
			[FieldOffset(Offset = "0x10")]
			public int count;
		}
	}
}
