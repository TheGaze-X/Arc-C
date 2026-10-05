using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B56 RID: 6998
	[Token(Token = "0x2001B56")]
	public class UIArchitectureTeardownView : UIArchitectureBaseView<UIArchitectureTeardownView.Argument>
	{
		// Token: 0x0600AFC5 RID: 44997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFC5")]
		[Address(RVA = "0x32B9190", Offset = "0x32B7D90", VA = "0x1832B9190", Slot = "4")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600AFC6 RID: 44998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFC6")]
		[Address(RVA = "0x32B92C0", Offset = "0x32B7EC0", VA = "0x1832B92C0")]
		private void _UpdateRoomLevelPanel(BuildingData.RoomType roomType, int level0, int level1)
		{
		}

		// Token: 0x0600AFC7 RID: 44999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFC7")]
		[Address(RVA = "0x32B8B50", Offset = "0x32B7750", VA = "0x1832B8B50", Slot = "14")]
		protected override void DoSetup(UIArchitectureTeardownView.Argument arg)
		{
		}

		// Token: 0x0600AFC8 RID: 45000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFC8")]
		[Address(RVA = "0x32B9590", Offset = "0x32B8190", VA = "0x1832B9590")]
		public UIArchitectureTeardownView()
		{
		}

		// Token: 0x0400A9D0 RID: 43472
		[Token(Token = "0x400A9D0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _infoRoot;

		// Token: 0x0400A9D1 RID: 43473
		[Token(Token = "0x400A9D1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _infoProto;

		// Token: 0x0400A9D2 RID: 43474
		[Token(Token = "0x400A9D2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _nameLabel;

		// Token: 0x0400A9D3 RID: 43475
		[Token(Token = "0x400A9D3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _nameIcon;

		// Token: 0x0400A9D4 RID: 43476
		[Token(Token = "0x400A9D4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _levelImage0;

		// Token: 0x0400A9D5 RID: 43477
		[Token(Token = "0x400A9D5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _levelImage1;

		// Token: 0x0400A9D6 RID: 43478
		[Token(Token = "0x400A9D6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _level0Panel;

		// Token: 0x0400A9D7 RID: 43479
		[Token(Token = "0x400A9D7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SimpleLayoutContent _level1Panel;

		// Token: 0x0400A9D8 RID: 43480
		[Token(Token = "0x400A9D8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _zeroLevelIcon;

		// Token: 0x0400A9D9 RID: 43481
		[Token(Token = "0x400A9D9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIRoomTypeColorMap _roomTypeLevelMap;

		// Token: 0x0400A9DA RID: 43482
		[Token(Token = "0x400A9DA")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIBuildCostScrollAdapter _returnAdapter;

		// Token: 0x0400A9DB RID: 43483
		[Token(Token = "0x400A9DB")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _returnItemLayout;

		// Token: 0x0400A9DC RID: 43484
		[Token(Token = "0x400A9DC")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _panelTip;

		// Token: 0x0400A9DD RID: 43485
		[Token(Token = "0x400A9DD")]
		[FieldOffset(Offset = "0xB0")]
		private UIBuildingLevelPanelAdapter _adapter0;

		// Token: 0x0400A9DE RID: 43486
		[Token(Token = "0x400A9DE")]
		[FieldOffset(Offset = "0xB8")]
		private UIBuildingLevelPanelAdapter _adapter1;

		// Token: 0x0400A9DF RID: 43487
		[Token(Token = "0x400A9DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnAwake;

		// Token: 0x0400A9E0 RID: 43488
		[Token(Token = "0x400A9E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateRoomLevelPanel;

		// Token: 0x0400A9E1 RID: 43489
		[Token(Token = "0x400A9E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoSetup;

		// Token: 0x0400A9E2 RID: 43490
		[Token(Token = "0x400A9E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B57 RID: 6999
		[Token(Token = "0x2001B57")]
		public class Argument
		{
			// Token: 0x0600AFCA RID: 45002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AFCA")]
			[Address(RVA = "0x32A0EC0", Offset = "0x329FAC0", VA = "0x1832A0EC0")]
			public Argument()
			{
			}

			// Token: 0x0400A9E3 RID: 43491
			[Token(Token = "0x400A9E3")]
			[FieldOffset(Offset = "0x10")]
			public RoomSlotModel roomSlotModel;

			// Token: 0x0400A9E4 RID: 43492
			[Token(Token = "0x400A9E4")]
			[FieldOffset(Offset = "0x18")]
			public BuildingData.RoomType roomType;

			// Token: 0x0400A9E5 RID: 43493
			[Token(Token = "0x400A9E5")]
			[FieldOffset(Offset = "0x20")]
			public Sprite icon;

			// Token: 0x0400A9E6 RID: 43494
			[Token(Token = "0x400A9E6")]
			[FieldOffset(Offset = "0x28")]
			public int level0;

			// Token: 0x0400A9E7 RID: 43495
			[Token(Token = "0x400A9E7")]
			[FieldOffset(Offset = "0x2C")]
			public int level1;

			// Token: 0x0400A9E8 RID: 43496
			[Token(Token = "0x400A9E8")]
			[FieldOffset(Offset = "0x30")]
			public List<LevelInfoItem> infoItemList;

			// Token: 0x0400A9E9 RID: 43497
			[Token(Token = "0x400A9E9")]
			[FieldOffset(Offset = "0x38")]
			public List<ArchiCostItemModel> returnList;
		}
	}
}
