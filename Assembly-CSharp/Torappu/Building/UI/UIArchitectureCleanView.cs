using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B4E RID: 6990
	[Token(Token = "0x2001B4E")]
	public class UIArchitectureCleanView : UIArchitectureBaseView<UIArchitectureCleanView.Argument>
	{
		// Token: 0x0600AFA1 RID: 44961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFA1")]
		[Address(RVA = "0x32B52B0", Offset = "0x32B3EB0", VA = "0x1832B52B0", Slot = "14")]
		protected override void DoSetup(UIArchitectureCleanView.Argument arg)
		{
		}

		// Token: 0x0600AFA2 RID: 44962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFA2")]
		[Address(RVA = "0x32B59B0", Offset = "0x32B45B0", VA = "0x1832B59B0", Slot = "15")]
		protected override void OnPlayerDataChanged(object _)
		{
		}

		// Token: 0x0600AFA3 RID: 44963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFA3")]
		[Address(RVA = "0x32B5BC0", Offset = "0x32B47C0", VA = "0x1832B5BC0", Slot = "16")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600AFA4 RID: 44964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFA4")]
		[Address(RVA = "0x32B5C30", Offset = "0x32B4830", VA = "0x1832B5C30")]
		private void _UpdateLabor()
		{
		}

		// Token: 0x0600AFA5 RID: 44965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFA5")]
		[Address(RVA = "0x32B5EC0", Offset = "0x32B4AC0", VA = "0x1832B5EC0")]
		public UIArchitectureCleanView()
		{
		}

		// Token: 0x0400A976 RID: 43382
		[Token(Token = "0x400A976")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _listRoom;

		// Token: 0x0400A977 RID: 43383
		[Token(Token = "0x400A977")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _itemCardProto;

		// Token: 0x0400A978 RID: 43384
		[Token(Token = "0x400A978")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _conditionPanelConnect;

		// Token: 0x0400A979 RID: 43385
		[Token(Token = "0x400A979")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _conditionPanelControlLevel;

		// Token: 0x0400A97A RID: 43386
		[Token(Token = "0x400A97A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIComplexRoomLevelView _conditionlevelView;

		// Token: 0x0400A97B RID: 43387
		[Token(Token = "0x400A97B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject[] _mainViewGameObjects;

		// Token: 0x0400A97C RID: 43388
		[Token(Token = "0x400A97C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject[] _lockedViewGameObjects;

		// Token: 0x0400A97D RID: 43389
		[Token(Token = "0x400A97D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textLaborFrom;

		// Token: 0x0400A97E RID: 43390
		[Token(Token = "0x400A97E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textLaborTo;

		// Token: 0x0400A97F RID: 43391
		[Token(Token = "0x400A97F")]
		[FieldOffset(Offset = "0x90")]
		private List<UIArchiCostItemCard> m_costCards;

		// Token: 0x0400A980 RID: 43392
		[Token(Token = "0x400A980")]
		[FieldOffset(Offset = "0x98")]
		private List<ArchiCostItemModel> m_costModels;

		// Token: 0x0400A981 RID: 43393
		[Token(Token = "0x400A981")]
		[FieldOffset(Offset = "0xA0")]
		private int m_costLabor;

		// Token: 0x0400A982 RID: 43394
		[Token(Token = "0x400A982")]
		[FieldOffset(Offset = "0xA4")]
		private int m_provideLabor;

		// Token: 0x0400A983 RID: 43395
		[Token(Token = "0x400A983")]
		[FieldOffset(Offset = "0xA8")]
		private BuildingLaborViewModel m_laborModel;

		// Token: 0x0400A984 RID: 43396
		[Token(Token = "0x400A984")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetup;

		// Token: 0x0400A985 RID: 43397
		[Token(Token = "0x400A985")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0400A986 RID: 43398
		[Token(Token = "0x400A986")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400A987 RID: 43399
		[Token(Token = "0x400A987")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateLabor;

		// Token: 0x0400A988 RID: 43400
		[Token(Token = "0x400A988")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B4F RID: 6991
		[Token(Token = "0x2001B4F")]
		public class Argument
		{
			// Token: 0x0600AFA7 RID: 44967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AFA7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Argument()
			{
			}

			// Token: 0x0400A989 RID: 43401
			[Token(Token = "0x400A989")]
			[FieldOffset(Offset = "0x10")]
			public RoomSlotModel roomSlotModel;

			// Token: 0x0400A98A RID: 43402
			[Token(Token = "0x400A98A")]
			[FieldOffset(Offset = "0x18")]
			public List<ArchiCostItemModel> costList;

			// Token: 0x0400A98B RID: 43403
			[Token(Token = "0x400A98B")]
			[FieldOffset(Offset = "0x20")]
			public UIArchitectureCleanView.Argument.ConditionPanelShown conditionPanelShown;

			// Token: 0x0400A98C RID: 43404
			[Token(Token = "0x400A98C")]
			[FieldOffset(Offset = "0x24")]
			public int targetControlLevel;

			// Token: 0x02001B50 RID: 6992
			[Token(Token = "0x2001B50")]
			public enum ConditionPanelShown
			{
				// Token: 0x0400A98E RID: 43406
				[Token(Token = "0x400A98E")]
				NONE,
				// Token: 0x0400A98F RID: 43407
				[Token(Token = "0x400A98F")]
				CONTROL_LEVEL,
				// Token: 0x0400A990 RID: 43408
				[Token(Token = "0x400A990")]
				CONNECT
			}
		}
	}
}
