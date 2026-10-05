using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI
{
	// Token: 0x02001B71 RID: 7025
	[Token(Token = "0x2001B71")]
	public class UIRoomTypeColorMap : MonoBehaviour
	{
		// Token: 0x0600B00C RID: 45068 RVA: 0x00043608 File Offset: 0x00041808
		[Token(Token = "0x600B00C")]
		[Address(RVA = "0x32BA7C0", Offset = "0x32B93C0", VA = "0x1832BA7C0")]
		public Color GetColorByRoomType(BuildingData.RoomType type)
		{
			return default(Color);
		}

		// Token: 0x0600B00D RID: 45069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B00D")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIRoomTypeColorMap()
		{
		}

		// Token: 0x0400AA5A RID: 43610
		[Token(Token = "0x400AA5A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIRoomTypeColorMap.Entry[] _enties;

		// Token: 0x0400AA5B RID: 43611
		[Token(Token = "0x400AA5B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x02001B72 RID: 7026
		[Token(Token = "0x2001B72")]
		[Serializable]
		public class Entry
		{
			// Token: 0x0600B00E RID: 45070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B00E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Entry()
			{
			}

			// Token: 0x0400AA5C RID: 43612
			[Token(Token = "0x400AA5C")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.RoomType type;

			// Token: 0x0400AA5D RID: 43613
			[Token(Token = "0x400AA5D")]
			[FieldOffset(Offset = "0x14")]
			public Color color;
		}
	}
}
