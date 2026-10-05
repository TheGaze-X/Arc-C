using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001B5F RID: 7007
	[Token(Token = "0x2001B5F")]
	public class UIComplexRoomLevelView : MonoBehaviour
	{
		// Token: 0x0600AFEB RID: 45035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFEB")]
		[Address(RVA = "0x32B9BA0", Offset = "0x32B87A0", VA = "0x1832B9BA0")]
		public void Setup(int level, BuildingData.RoomType roomType)
		{
		}

		// Token: 0x0600AFEC RID: 45036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFEC")]
		[Address(RVA = "0x32B9D80", Offset = "0x32B8980", VA = "0x1832B9D80")]
		public UIComplexRoomLevelView()
		{
		}

		// Token: 0x0400AA2E RID: 43566
		[Token(Token = "0x400AA2E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _levelLayoutContent;

		// Token: 0x0400AA2F RID: 43567
		[Token(Token = "0x400AA2F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _levelLabel;

		// Token: 0x0400AA30 RID: 43568
		[Token(Token = "0x400AA30")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _emptyColor;

		// Token: 0x0400AA31 RID: 43569
		[Token(Token = "0x400AA31")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIRoomTypeColorMap _colorMap;

		// Token: 0x0400AA32 RID: 43570
		[Token(Token = "0x400AA32")]
		[FieldOffset(Offset = "0x40")]
		private UIBuildingLevelPanelAdapter m_adapter;
	}
}
