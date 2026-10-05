using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B1F RID: 6943
	[Token(Token = "0x2001B1F")]
	public class BuildingUIFloatRoomDetailView : DataBinder<FloatRoomDetailViewProperty>
	{
		// Token: 0x0600AECF RID: 44751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AECF")]
		[Address(RVA = "0x32933B0", Offset = "0x3291FB0", VA = "0x1832933B0", Slot = "7")]
		public override void OnValueChanged(FloatRoomDetailViewProperty property)
		{
		}

		// Token: 0x0600AED0 RID: 44752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AED0")]
		[Address(RVA = "0x3293340", Offset = "0x3291F40", VA = "0x183293340")]
		public void EventOnBlankClicked()
		{
		}

		// Token: 0x0600AED1 RID: 44753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AED1")]
		[Address(RVA = "0x3293790", Offset = "0x3292390", VA = "0x183293790")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600AED2 RID: 44754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AED2")]
		[Address(RVA = "0x3293AB0", Offset = "0x32926B0", VA = "0x183293AB0")]
		private void _UpdateShowEffect()
		{
		}

		// Token: 0x0600AED3 RID: 44755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AED3")]
		[Address(RVA = "0x32938D0", Offset = "0x32924D0", VA = "0x1832938D0")]
		private void _UpdateContent()
		{
		}

		// Token: 0x0600AED4 RID: 44756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AED4")]
		[Address(RVA = "0x3293DC0", Offset = "0x32929C0", VA = "0x183293DC0")]
		public BuildingUIFloatRoomDetailView()
		{
		}

		// Token: 0x0400A7ED RID: 42989
		[Token(Token = "0x400A7ED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400A7EE RID: 42990
		[Token(Token = "0x400A7EE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _levelInfoContent;

		// Token: 0x0400A7EF RID: 42991
		[Token(Token = "0x400A7EF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0400A7F0 RID: 42992
		[Token(Token = "0x400A7F0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x0400A7F1 RID: 42993
		[Token(Token = "0x400A7F1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _panelBlack;

		// Token: 0x0400A7F2 RID: 42994
		[Token(Token = "0x400A7F2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _levelPanel;

		// Token: 0x0400A7F3 RID: 42995
		[Token(Token = "0x400A7F3")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0400A7F4 RID: 42996
		[Token(Token = "0x400A7F4")]
		[FieldOffset(Offset = "0x59")]
		private bool m_isShowing;

		// Token: 0x0400A7F5 RID: 42997
		[Token(Token = "0x400A7F5")]
		[FieldOffset(Offset = "0x60")]
		private FloatRoomDetailModel m_viewModel;

		// Token: 0x0400A7F6 RID: 42998
		[Token(Token = "0x400A7F6")]
		[FieldOffset(Offset = "0x68")]
		private BuildingUIFloatRoomDetailView.DetailInfoAdapter m_infoAdapter;

		// Token: 0x0400A7F7 RID: 42999
		[Token(Token = "0x400A7F7")]
		[FieldOffset(Offset = "0x70")]
		private List<LevelInfoItem> m_detailList;

		// Token: 0x0400A7F8 RID: 43000
		[Token(Token = "0x400A7F8")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_tweenCache;

		// Token: 0x0400A7F9 RID: 43001
		[Token(Token = "0x400A7F9")]
		[FieldOffset(Offset = "0x80")]
		private UIBuildingLevelPanelAdapter m_levelAdapter;

		// Token: 0x0400A7FA RID: 43002
		[Token(Token = "0x400A7FA")]
		[FieldOffset(Offset = "0x88")]
		public Action requestToClose;

		// Token: 0x0400A7FB RID: 43003
		[Token(Token = "0x400A7FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400A7FC RID: 43004
		[Token(Token = "0x400A7FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBlankClicked;

		// Token: 0x0400A7FD RID: 43005
		[Token(Token = "0x400A7FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400A7FE RID: 43006
		[Token(Token = "0x400A7FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateShowEffect;

		// Token: 0x0400A7FF RID: 43007
		[Token(Token = "0x400A7FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateContent;

		// Token: 0x0400A800 RID: 43008
		[Token(Token = "0x400A800")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B20 RID: 6944
		[Token(Token = "0x2001B20")]
		private class DetailInfoAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600AED6 RID: 44758 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AED6")]
			[Address(RVA = "0x329BF50", Offset = "0x329AB50", VA = "0x18329BF50")]
			public DetailInfoAdapter(BuildingUIFloatRoomDetailView closure)
			{
			}

			// Token: 0x170014B6 RID: 5302
			// (get) Token: 0x0600AED7 RID: 44759 RVA: 0x00043350 File Offset: 0x00041550
			[Token(Token = "0x170014B6")]
			public override int count
			{
				[Token(Token = "0x600AED7")]
				[Address(RVA = "0x329BFD0", Offset = "0x329ABD0", VA = "0x18329BFD0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600AED8 RID: 44760 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AED8")]
			[Address(RVA = "0x329BD70", Offset = "0x329A970", VA = "0x18329BD70", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400A801 RID: 43009
			[Token(Token = "0x400A801")]
			[FieldOffset(Offset = "0x20")]
			private BuildingUIFloatRoomDetailView m_closure;

			// Token: 0x0400A802 RID: 43010
			[Token(Token = "0x400A802")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400A803 RID: 43011
			[Token(Token = "0x400A803")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400A804 RID: 43012
			[Token(Token = "0x400A804")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
