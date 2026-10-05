using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B39 RID: 6969
	[Token(Token = "0x2001B39")]
	public class BuildingUIRoomTab : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600AF68 RID: 44904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF68")]
		[Address(RVA = "0x32AA710", Offset = "0x32A9310", VA = "0x1832AA710")]
		public void Render(BasicRoomInfoModel basicModel, bool isSelected)
		{
		}

		// Token: 0x0600AF69 RID: 44905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF69")]
		[Address(RVA = "0x32AA690", Offset = "0x32A9290", VA = "0x1832AA690")]
		public void OnTabClicked()
		{
		}

		// Token: 0x0600AF6A RID: 44906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF6A")]
		[Address(RVA = "0x32AA980", Offset = "0x32A9580", VA = "0x1832AA980")]
		private void _RenderActive()
		{
		}

		// Token: 0x0600AF6B RID: 44907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF6B")]
		[Address(RVA = "0x32AABE0", Offset = "0x32A97E0", VA = "0x1832AABE0")]
		public BuildingUIRoomTab()
		{
		}

		// Token: 0x0400A8F3 RID: 43251
		[Token(Token = "0x400A8F3")]
		private const string LEVEL_ICON_NAME = "level_icon";

		// Token: 0x0400A8F4 RID: 43252
		[Token(Token = "0x400A8F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _levelLayout;

		// Token: 0x0400A8F5 RID: 43253
		[Token(Token = "0x400A8F5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0400A8F6 RID: 43254
		[Token(Token = "0x400A8F6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0400A8F7 RID: 43255
		[Token(Token = "0x400A8F7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelTrackPoint;

		// Token: 0x0400A8F8 RID: 43256
		[Token(Token = "0x400A8F8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelUpgrading;

		// Token: 0x0400A8F9 RID: 43257
		[Token(Token = "0x400A8F9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelHotspot;

		// Token: 0x0400A8FA RID: 43258
		[Token(Token = "0x400A8FA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textIndex;

		// Token: 0x0400A8FB RID: 43259
		[Token(Token = "0x400A8FB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _tglSelected;

		// Token: 0x0400A8FC RID: 43260
		[Token(Token = "0x400A8FC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BuildingRoomLevelView _levelView;

		// Token: 0x0400A8FD RID: 43261
		[Token(Token = "0x400A8FD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Styles")]
		private Color _colorTextSelected;

		// Token: 0x0400A8FE RID: 43262
		[Token(Token = "0x400A8FE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Styles")]
		private Color _colorTextUnselected;

		// Token: 0x0400A8FF RID: 43263
		[Token(Token = "0x400A8FF")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0400A900 RID: 43264
		[Token(Token = "0x400A900")]
		[FieldOffset(Offset = "0x88")]
		private BuildingUIRoomTab.CacheStatus m_status;

		// Token: 0x0400A901 RID: 43265
		[Token(Token = "0x400A901")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public Action<string> onRoomSelected;

		// Token: 0x0400A902 RID: 43266
		[Token(Token = "0x400A902")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400A903 RID: 43267
		[Token(Token = "0x400A903")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTabClicked;

		// Token: 0x0400A904 RID: 43268
		[Token(Token = "0x400A904")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderActive;

		// Token: 0x0400A905 RID: 43269
		[Token(Token = "0x400A905")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B3A RID: 6970
		[Token(Token = "0x2001B3A")]
		private struct CacheStatus
		{
			// Token: 0x0600AF6C RID: 44908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF6C")]
			[Address(RVA = "0x32AB190", Offset = "0x32A9D90", VA = "0x1832AB190")]
			public CacheStatus(BasicRoomInfoModel infoModel, bool isSelected)
			{
			}

			// Token: 0x0400A906 RID: 43270
			[Token(Token = "0x400A906")]
			[FieldOffset(Offset = "0x0")]
			public string slotId;

			// Token: 0x0400A907 RID: 43271
			[Token(Token = "0x400A907")]
			[FieldOffset(Offset = "0x8")]
			public int index;

			// Token: 0x0400A908 RID: 43272
			[Token(Token = "0x400A908")]
			[FieldOffset(Offset = "0xC")]
			public int level;

			// Token: 0x0400A909 RID: 43273
			[Token(Token = "0x400A909")]
			[FieldOffset(Offset = "0x10")]
			public bool isSelected;

			// Token: 0x0400A90A RID: 43274
			[Token(Token = "0x400A90A")]
			[FieldOffset(Offset = "0x14")]
			public int maxLevel;

			// Token: 0x0400A90B RID: 43275
			[Token(Token = "0x400A90B")]
			[FieldOffset(Offset = "0x18")]
			public bool hasTrackPoint;
		}
	}
}
