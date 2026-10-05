using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001B48 RID: 6984
	[Token(Token = "0x2001B48")]
	public class UIArchitectureBuildRoomPanel : MonoBehaviour
	{
		// Token: 0x0600AF8A RID: 44938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF8A")]
		[Address(RVA = "0x32B27A0", Offset = "0x32B13A0", VA = "0x1832B27A0")]
		public void Setup(UIArchitectureBuildRoomPanel.Argument arg)
		{
		}

		// Token: 0x0600AF8B RID: 44939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF8B")]
		[Address(RVA = "0x32B26D0", Offset = "0x32B12D0", VA = "0x1832B26D0")]
		public void Select()
		{
		}

		// Token: 0x0600AF8C RID: 44940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF8C")]
		[Address(RVA = "0x32B3370", Offset = "0x32B1F70", VA = "0x1832B3370")]
		public void Unselect()
		{
		}

		// Token: 0x0600AF8D RID: 44941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF8D")]
		[Address(RVA = "0x32B26B0", Offset = "0x32B12B0", VA = "0x1832B26B0")]
		public void OnDescButtonPressed()
		{
		}

		// Token: 0x0600AF8E RID: 44942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF8E")]
		[Address(RVA = "0x32B26A0", Offset = "0x32B12A0", VA = "0x1832B26A0")]
		public void OnDescBGPressed()
		{
		}

		// Token: 0x0600AF8F RID: 44943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF8F")]
		[Address(RVA = "0x32B2560", Offset = "0x32B1160", VA = "0x1832B2560")]
		public void NotifyPlayerDataChanged()
		{
		}

		// Token: 0x0600AF90 RID: 44944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF90")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIArchitectureBuildRoomPanel()
		{
		}

		// Token: 0x0400A943 RID: 43331
		[Token(Token = "0x400A943")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _infoRoot;

		// Token: 0x0400A944 RID: 43332
		[Token(Token = "0x400A944")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _infoProto;

		// Token: 0x0400A945 RID: 43333
		[Token(Token = "0x400A945")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _nameLabel;

		// Token: 0x0400A946 RID: 43334
		[Token(Token = "0x400A946")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _countLabel;

		// Token: 0x0400A947 RID: 43335
		[Token(Token = "0x400A947")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _descPanel;

		// Token: 0x0400A948 RID: 43336
		[Token(Token = "0x400A948")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _descPanelNameLabel;

		// Token: 0x0400A949 RID: 43337
		[Token(Token = "0x400A949")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _descPanelDescLabel;

		// Token: 0x0400A94A RID: 43338
		[Token(Token = "0x400A94A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _nameIcon;

		// Token: 0x0400A94B RID: 43339
		[Token(Token = "0x400A94B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _panelBG;

		// Token: 0x0400A94C RID: 43340
		[Token(Token = "0x400A94C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _selectedFrame;

		// Token: 0x0400A94D RID: 43341
		[Token(Token = "0x400A94D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _unselectedFrame;

		// Token: 0x0400A94E RID: 43342
		[Token(Token = "0x400A94E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIBuildCostScrollAdapter _costAdapter;

		// Token: 0x0400A94F RID: 43343
		[Token(Token = "0x400A94F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _conditionPanel;

		// Token: 0x0400A950 RID: 43344
		[Token(Token = "0x400A950")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _conditionItemRoot;

		// Token: 0x0400A951 RID: 43345
		[Token(Token = "0x400A951")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _conditionItemProto;

		// Token: 0x0400A952 RID: 43346
		[Token(Token = "0x400A952")]
		[FieldOffset(Offset = "0x90")]
		private int m_infoFrameDelay;

		// Token: 0x0400A953 RID: 43347
		[Token(Token = "0x400A953")]
		[FieldOffset(Offset = "0x94")]
		private bool m_selected;

		// Token: 0x02001B49 RID: 6985
		[Token(Token = "0x2001B49")]
		public class Argument
		{
			// Token: 0x0600AF91 RID: 44945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF91")]
			[Address(RVA = "0x32A0DF0", Offset = "0x329F9F0", VA = "0x1832A0DF0")]
			public Argument()
			{
			}

			// Token: 0x0400A954 RID: 43348
			[Token(Token = "0x400A954")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.RoomType roomType;

			// Token: 0x0400A955 RID: 43349
			[Token(Token = "0x400A955")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;

			// Token: 0x0400A956 RID: 43350
			[Token(Token = "0x400A956")]
			[FieldOffset(Offset = "0x20")]
			public Sprite bgSprite;

			// Token: 0x0400A957 RID: 43351
			[Token(Token = "0x400A957")]
			[FieldOffset(Offset = "0x28")]
			public string name;

			// Token: 0x0400A958 RID: 43352
			[Token(Token = "0x400A958")]
			[FieldOffset(Offset = "0x30")]
			public string desc;

			// Token: 0x0400A959 RID: 43353
			[Token(Token = "0x400A959")]
			[FieldOffset(Offset = "0x38")]
			public int count0;

			// Token: 0x0400A95A RID: 43354
			[Token(Token = "0x400A95A")]
			[FieldOffset(Offset = "0x3C")]
			public int count1;

			// Token: 0x0400A95B RID: 43355
			[Token(Token = "0x400A95B")]
			[FieldOffset(Offset = "0x40")]
			public List<LevelInfoItem> infoItemList;

			// Token: 0x0400A95C RID: 43356
			[Token(Token = "0x400A95C")]
			[FieldOffset(Offset = "0x48")]
			public List<ArchiCostItemModel> costList;

			// Token: 0x0400A95D RID: 43357
			[Token(Token = "0x400A95D")]
			[FieldOffset(Offset = "0x50")]
			public bool showConditionPanel;

			// Token: 0x0400A95E RID: 43358
			[Token(Token = "0x400A95E")]
			[FieldOffset(Offset = "0x58")]
			public UIArchiConditionItem.ConditionContentItem[] conditionContent;
		}
	}
}
