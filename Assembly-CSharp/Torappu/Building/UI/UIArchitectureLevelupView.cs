using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B52 RID: 6994
	[Token(Token = "0x2001B52")]
	public class UIArchitectureLevelupView : UIArchitectureBaseView<UIArchitectureLevelupView.Argument>
	{
		// Token: 0x0600AFAA RID: 44970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFAA")]
		[Address(RVA = "0x32B6B90", Offset = "0x32B5790", VA = "0x1832B6B90", Slot = "4")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600AFAB RID: 44971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFAB")]
		[Address(RVA = "0x32B6E60", Offset = "0x32B5A60", VA = "0x1832B6E60")]
		private void _UpdateRoomLevelPanel(BuildingData.RoomType roomType, int level0, int level1)
		{
		}

		// Token: 0x0600AFAC RID: 44972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFAC")]
		[Address(RVA = "0x32B6060", Offset = "0x32B4C60", VA = "0x1832B6060", Slot = "14")]
		protected override void DoSetup(UIArchitectureLevelupView.Argument arg)
		{
		}

		// Token: 0x0600AFAD RID: 44973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFAD")]
		[Address(RVA = "0x32B6C70", Offset = "0x32B5870", VA = "0x1832B6C70", Slot = "15")]
		protected override void OnPlayerDataChanged(object _)
		{
		}

		// Token: 0x0600AFAE RID: 44974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFAE")]
		[Address(RVA = "0x32B7090", Offset = "0x32B5C90", VA = "0x1832B7090")]
		public UIArchitectureLevelupView()
		{
		}

		// Token: 0x0400A993 RID: 43411
		[Token(Token = "0x400A993")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _infoRoot;

		// Token: 0x0400A994 RID: 43412
		[Token(Token = "0x400A994")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _infoProto;

		// Token: 0x0400A995 RID: 43413
		[Token(Token = "0x400A995")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _nameLabel;

		// Token: 0x0400A996 RID: 43414
		[Token(Token = "0x400A996")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _nameIcon;

		// Token: 0x0400A997 RID: 43415
		[Token(Token = "0x400A997")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _levelImage0;

		// Token: 0x0400A998 RID: 43416
		[Token(Token = "0x400A998")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _levelImage1;

		// Token: 0x0400A999 RID: 43417
		[Token(Token = "0x400A999")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIBuildCostScrollAdapter _costAdapter;

		// Token: 0x0400A99A RID: 43418
		[Token(Token = "0x400A99A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _conditionPanel;

		// Token: 0x0400A99B RID: 43419
		[Token(Token = "0x400A99B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _conditionItemRoot;

		// Token: 0x0400A99C RID: 43420
		[Token(Token = "0x400A99C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _conditionItemProto;

		// Token: 0x0400A99D RID: 43421
		[Token(Token = "0x400A99D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _panelBG;

		// Token: 0x0400A99E RID: 43422
		[Token(Token = "0x400A99E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SimpleLayoutContent _level0Panel;

		// Token: 0x0400A99F RID: 43423
		[Token(Token = "0x400A99F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private SimpleLayoutContent _level1Panel;

		// Token: 0x0400A9A0 RID: 43424
		[Token(Token = "0x400A9A0")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIRoomTypeColorMap _roomTypeLevelMap;

		// Token: 0x0400A9A1 RID: 43425
		[Token(Token = "0x400A9A1")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private RectTransform _costItemLayout;

		// Token: 0x0400A9A2 RID: 43426
		[Token(Token = "0x400A9A2")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _panelTip;

		// Token: 0x0400A9A3 RID: 43427
		[Token(Token = "0x400A9A3")]
		[FieldOffset(Offset = "0xC8")]
		private UIBuildingLevelPanelAdapter _adapter0;

		// Token: 0x0400A9A4 RID: 43428
		[Token(Token = "0x400A9A4")]
		[FieldOffset(Offset = "0xD0")]
		private UIBuildingLevelPanelAdapter _adapter1;

		// Token: 0x0400A9A5 RID: 43429
		[Token(Token = "0x400A9A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnAwake;

		// Token: 0x0400A9A6 RID: 43430
		[Token(Token = "0x400A9A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateRoomLevelPanel;

		// Token: 0x0400A9A7 RID: 43431
		[Token(Token = "0x400A9A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoSetup;

		// Token: 0x0400A9A8 RID: 43432
		[Token(Token = "0x400A9A8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0400A9A9 RID: 43433
		[Token(Token = "0x400A9A9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B53 RID: 6995
		[Token(Token = "0x2001B53")]
		public class Argument
		{
			// Token: 0x0600AFB0 RID: 44976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AFB0")]
			[Address(RVA = "0x32A0D20", Offset = "0x329F920", VA = "0x1832A0D20")]
			public Argument()
			{
			}

			// Token: 0x0400A9AA RID: 43434
			[Token(Token = "0x400A9AA")]
			[FieldOffset(Offset = "0x10")]
			public RoomSlotModel roomSlotModel;

			// Token: 0x0400A9AB RID: 43435
			[Token(Token = "0x400A9AB")]
			[FieldOffset(Offset = "0x18")]
			public BuildingData.RoomType roomType;

			// Token: 0x0400A9AC RID: 43436
			[Token(Token = "0x400A9AC")]
			[FieldOffset(Offset = "0x20")]
			public Sprite icon;

			// Token: 0x0400A9AD RID: 43437
			[Token(Token = "0x400A9AD")]
			[FieldOffset(Offset = "0x28")]
			public Sprite bg;

			// Token: 0x0400A9AE RID: 43438
			[Token(Token = "0x400A9AE")]
			[FieldOffset(Offset = "0x30")]
			public int level0;

			// Token: 0x0400A9AF RID: 43439
			[Token(Token = "0x400A9AF")]
			[FieldOffset(Offset = "0x34")]
			public int level1;

			// Token: 0x0400A9B0 RID: 43440
			[Token(Token = "0x400A9B0")]
			[FieldOffset(Offset = "0x38")]
			public List<LevelInfoItem> infoItemList;

			// Token: 0x0400A9B1 RID: 43441
			[Token(Token = "0x400A9B1")]
			[FieldOffset(Offset = "0x40")]
			public List<ArchiCostItemModel> costList;

			// Token: 0x0400A9B2 RID: 43442
			[Token(Token = "0x400A9B2")]
			[FieldOffset(Offset = "0x48")]
			public bool levelupInValid;

			// Token: 0x0400A9B3 RID: 43443
			[Token(Token = "0x400A9B3")]
			[FieldOffset(Offset = "0x50")]
			public UIArchiConditionItem.ConditionContentItem[] conditionContent;
		}
	}
}
