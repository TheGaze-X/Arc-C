using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C93 RID: 7315
	[Token(Token = "0x2001C93")]
	public class BuildingStationSelectMaskPlugin : BuildingStationSelectCardMaskPlugin
	{
		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x0600B591 RID: 46481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D7")]
		public BuildingCharSelectRoomConfig roomConfig
		{
			[Token(Token = "0x600B591")]
			[Address(RVA = "0x33119A0", Offset = "0x33105A0", VA = "0x1833119A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B592 RID: 46482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B592")]
		[Address(RVA = "0x3310D00", Offset = "0x330F900", VA = "0x183310D00", Slot = "4")]
		public override void Init(BuildingStationSelectCharItemView cardView, StationSelectStateBean stateBean, object context)
		{
		}

		// Token: 0x0600B593 RID: 46483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B593")]
		[Address(RVA = "0x3310DD0", Offset = "0x330F9D0", VA = "0x183310DD0", Slot = "5")]
		public override void Render(StationCharViewModel cardModel)
		{
		}

		// Token: 0x0600B594 RID: 46484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B594")]
		[Address(RVA = "0x3311560", Offset = "0x3310160", VA = "0x183311560")]
		private void _RenderStationed(StationCharViewModel exclusiveCharModel)
		{
		}

		// Token: 0x0600B595 RID: 46485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B595")]
		[Address(RVA = "0x3311940", Offset = "0x3310540", VA = "0x183311940")]
		public BuildingStationSelectMaskPlugin()
		{
		}

		// Token: 0x0400B203 RID: 45571
		[Token(Token = "0x400B203")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400B204 RID: 45572
		[Token(Token = "0x400B204")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _isAssistantOnWork;

		// Token: 0x0400B205 RID: 45573
		[Token(Token = "0x400B205")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _isAssistantNotWork;

		// Token: 0x0400B206 RID: 45574
		[Token(Token = "0x400B206")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _isSelected;

		// Token: 0x0400B207 RID: 45575
		[Token(Token = "0x400B207")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelStationed;

		// Token: 0x0400B208 RID: 45576
		[Token(Token = "0x400B208")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imageStationIcon;

		// Token: 0x0400B209 RID: 45577
		[Token(Token = "0x400B209")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imageStationBg;

		// Token: 0x0400B20A RID: 45578
		[Token(Token = "0x400B20A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textRoomName;

		// Token: 0x0400B20B RID: 45579
		[Token(Token = "0x400B20B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _panelInvalid;

		// Token: 0x0400B20C RID: 45580
		[Token(Token = "0x400B20C")]
		[FieldOffset(Offset = "0x60")]
		private StationSelectStateBean m_stationSelectBean;

		// Token: 0x0400B20D RID: 45581
		[Token(Token = "0x400B20D")]
		[FieldOffset(Offset = "0x68")]
		private IBuildingSelectController m_buildingSelectController;

		// Token: 0x0400B20E RID: 45582
		[Token(Token = "0x400B20E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_roomConfig;

		// Token: 0x0400B20F RID: 45583
		[Token(Token = "0x400B20F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400B210 RID: 45584
		[Token(Token = "0x400B210")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B211 RID: 45585
		[Token(Token = "0x400B211")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderStationed;

		// Token: 0x0400B212 RID: 45586
		[Token(Token = "0x400B212")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
