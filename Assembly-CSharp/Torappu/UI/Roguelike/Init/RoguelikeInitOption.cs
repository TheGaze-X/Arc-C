using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057E2 RID: 22498
	[Token(Token = "0x20057E2")]
	public class RoguelikeInitOption : RoguelikeInitCardBase
	{
		// Token: 0x06020E6F RID: 134767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E6F")]
		[Address(RVA = "0x1B3E750", Offset = "0x1B3D350", VA = "0x181B3E750")]
		public void Setup(int optionIdx, RoguelikeInitOption.Model data)
		{
		}

		// Token: 0x06020E70 RID: 134768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E70")]
		[Address(RVA = "0x1B3E670", Offset = "0x1B3D270", VA = "0x181B3E670")]
		public void SetupDescriptionAlignment()
		{
		}

		// Token: 0x06020E71 RID: 134769 RVA: 0x000B7B70 File Offset: 0x000B5D70
		[Token(Token = "0x6020E71")]
		[Address(RVA = "0x1B3E450", Offset = "0x1B3D050", VA = "0x181B3E450")]
		public Vector3 GetSubViewPosition()
		{
			return default(Vector3);
		}

		// Token: 0x17004D35 RID: 19765
		// (get) Token: 0x06020E72 RID: 134770 RVA: 0x000B7B88 File Offset: 0x000B5D88
		[Token(Token = "0x17004D35")]
		public int optionIndex
		{
			[Token(Token = "0x6020E72")]
			[Address(RVA = "0x1B3F3B0", Offset = "0x1B3DFB0", VA = "0x181B3F3B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06020E73 RID: 134771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E73")]
		[Address(RVA = "0x1B3E4F0", Offset = "0x1B3D0F0", VA = "0x181B3E4F0")]
		public void SetOptionActive(bool active)
		{
		}

		// Token: 0x06020E74 RID: 134772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E74")]
		[Address(RVA = "0x1B3E350", Offset = "0x1B3CF50", VA = "0x181B3E350")]
		public void EventActiveButtonPressed()
		{
		}

		// Token: 0x06020E75 RID: 134773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E75")]
		[Address(RVA = "0x1B3E3D0", Offset = "0x1B3CFD0", VA = "0x181B3E3D0")]
		public void EventSelectButtonPressed()
		{
		}

		// Token: 0x06020E76 RID: 134774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020E76")]
		[Address(RVA = "0x1B3F240", Offset = "0x1B3DE40", VA = "0x181B3F240")]
		private UIAtlasImage _CreateIcon()
		{
			return null;
		}

		// Token: 0x06020E77 RID: 134775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E77")]
		[Address(RVA = "0x1B3F300", Offset = "0x1B3DF00", VA = "0x181B3F300")]
		public RoguelikeInitOption()
		{
		}

		// Token: 0x0402CB5B RID: 183131
		[Token(Token = "0x402CB5B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0402CB5C RID: 183132
		[Token(Token = "0x402CB5C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _descriptionText;

		// Token: 0x0402CB5D RID: 183133
		[Token(Token = "0x402CB5D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x0402CB5E RID: 183134
		[Token(Token = "0x402CB5E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _levels;

		// Token: 0x0402CB5F RID: 183135
		[Token(Token = "0x402CB5F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _underTex;

		// Token: 0x0402CB60 RID: 183136
		[Token(Token = "0x402CB60")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _endingPanel;

		// Token: 0x0402CB61 RID: 183137
		[Token(Token = "0x402CB61")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _endingIconPrefab;

		// Token: 0x0402CB62 RID: 183138
		[Token(Token = "0x402CB62")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _endingFrameUp;

		// Token: 0x0402CB63 RID: 183139
		[Token(Token = "0x402CB63")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _endingFrameDown;

		// Token: 0x0402CB64 RID: 183140
		[Token(Token = "0x402CB64")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _newPanel;

		// Token: 0x0402CB65 RID: 183141
		[Token(Token = "0x402CB65")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _lockPanel;

		// Token: 0x0402CB66 RID: 183142
		[Token(Token = "0x402CB66")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _lockMessageLabel;

		// Token: 0x0402CB67 RID: 183143
		[Token(Token = "0x402CB67")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button _activeButton;

		// Token: 0x0402CB68 RID: 183144
		[Token(Token = "0x402CB68")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _selectButton;

		// Token: 0x0402CB69 RID: 183145
		[Token(Token = "0x402CB69")]
		private const string ANIM_ACTIVE = "init_option_active";

		// Token: 0x0402CB6A RID: 183146
		[Token(Token = "0x402CB6A")]
		private const string ANIM_DISACTIVE = "init_option_disactive";

		// Token: 0x0402CB6B RID: 183147
		[Token(Token = "0x402CB6B")]
		[FieldOffset(Offset = "0x98")]
		private int m_optionIndex;

		// Token: 0x0402CB6C RID: 183148
		[Token(Token = "0x402CB6C")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeInitOption.Model m_data;

		// Token: 0x0402CB6D RID: 183149
		[Token(Token = "0x402CB6D")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_active;

		// Token: 0x0402CB6E RID: 183150
		[Token(Token = "0x402CB6E")]
		[FieldOffset(Offset = "0xE8")]
		private ItemPool<UIAtlasImage> m_endingIcons;

		// Token: 0x0402CB6F RID: 183151
		[Token(Token = "0x402CB6F")]
		[FieldOffset(Offset = "0xF0")]
		private ItemPool<UIAtlasImage> m_endingFrameUps;

		// Token: 0x0402CB70 RID: 183152
		[Token(Token = "0x402CB70")]
		[FieldOffset(Offset = "0xF8")]
		private ItemPool<UIAtlasImage> m_endingFrameDowns;

		// Token: 0x0402CB71 RID: 183153
		[Token(Token = "0x402CB71")]
		[FieldOffset(Offset = "0x100")]
		[HideInInspector]
		public Action<int> selectCallback;

		// Token: 0x0402CB72 RID: 183154
		[Token(Token = "0x402CB72")]
		[FieldOffset(Offset = "0x108")]
		[HideInInspector]
		public Action<int> activeCallback;

		// Token: 0x0402CB73 RID: 183155
		[Token(Token = "0x402CB73")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0402CB74 RID: 183156
		[Token(Token = "0x402CB74")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetupDescriptionAlignment;

		// Token: 0x0402CB75 RID: 183157
		[Token(Token = "0x402CB75")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSubViewPosition;

		// Token: 0x0402CB76 RID: 183158
		[Token(Token = "0x402CB76")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_optionIndex;

		// Token: 0x0402CB77 RID: 183159
		[Token(Token = "0x402CB77")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetOptionActive;

		// Token: 0x0402CB78 RID: 183160
		[Token(Token = "0x402CB78")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventActiveButtonPressed;

		// Token: 0x0402CB79 RID: 183161
		[Token(Token = "0x402CB79")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventSelectButtonPressed;

		// Token: 0x0402CB7A RID: 183162
		[Token(Token = "0x402CB7A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateIcon;

		// Token: 0x0402CB7B RID: 183163
		[Token(Token = "0x402CB7B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020057E3 RID: 22499
		[Token(Token = "0x20057E3")]
		public struct Model
		{
			// Token: 0x0402CB7C RID: 183164
			[Token(Token = "0x402CB7C")]
			[FieldOffset(Offset = "0x0")]
			public string title;

			// Token: 0x0402CB7D RID: 183165
			[Token(Token = "0x402CB7D")]
			[FieldOffset(Offset = "0x8")]
			public string description;

			// Token: 0x0402CB7E RID: 183166
			[Token(Token = "0x402CB7E")]
			[FieldOffset(Offset = "0x10")]
			public Sprite icon;

			// Token: 0x0402CB7F RID: 183167
			[Token(Token = "0x402CB7F")]
			[FieldOffset(Offset = "0x18")]
			public List<RoguelikeInitOption.Model.EndingFamily> endings;

			// Token: 0x0402CB80 RID: 183168
			[Token(Token = "0x402CB80")]
			[FieldOffset(Offset = "0x20")]
			public bool isNew;

			// Token: 0x0402CB81 RID: 183169
			[Token(Token = "0x402CB81")]
			[FieldOffset(Offset = "0x21")]
			public bool isLocked;

			// Token: 0x0402CB82 RID: 183170
			[Token(Token = "0x402CB82")]
			[FieldOffset(Offset = "0x28")]
			public string lockMsg;

			// Token: 0x0402CB83 RID: 183171
			[Token(Token = "0x402CB83")]
			[FieldOffset(Offset = "0x30")]
			public Sprite underTex;

			// Token: 0x0402CB84 RID: 183172
			[Token(Token = "0x402CB84")]
			[FieldOffset(Offset = "0x38")]
			public int level;

			// Token: 0x020057E4 RID: 22500
			[Token(Token = "0x20057E4")]
			public struct EndingFamily
			{
				// Token: 0x17004D36 RID: 19766
				// (get) Token: 0x06020E7A RID: 134778 RVA: 0x000B7BA0 File Offset: 0x000B5DA0
				[Token(Token = "0x17004D36")]
				public bool showFrame
				{
					[Token(Token = "0x6020E7A")]
					[Address(RVA = "0x1B2E700", Offset = "0x1B2D300", VA = "0x181B2E700")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x0402CB85 RID: 183173
				[Token(Token = "0x402CB85")]
				[FieldOffset(Offset = "0x0")]
				public int canShowFrameEndingCount;

				// Token: 0x0402CB86 RID: 183174
				[Token(Token = "0x402CB86")]
				[FieldOffset(Offset = "0x4")]
				public int showFrameRequirement;

				// Token: 0x0402CB87 RID: 183175
				[Token(Token = "0x402CB87")]
				[FieldOffset(Offset = "0x8")]
				public List<SpriteRenderData> endings;
			}
		}
	}
}
