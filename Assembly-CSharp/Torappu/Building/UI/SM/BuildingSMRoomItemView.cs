using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CC0 RID: 7360
	[Token(Token = "0x2001CC0")]
	public class BuildingSMRoomItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B660 RID: 46688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B660")]
		[Address(RVA = "0x3306B20", Offset = "0x3305720", VA = "0x183306B20")]
		public void Render(BuildingSMRoomItemView.Params param)
		{
		}

		// Token: 0x0600B661 RID: 46689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B661")]
		[Address(RVA = "0x3306500", Offset = "0x3305100", VA = "0x183306500")]
		public void EventOnRoomClicked()
		{
		}

		// Token: 0x0600B662 RID: 46690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B662")]
		[Address(RVA = "0x3306680", Offset = "0x3305280", VA = "0x183306680")]
		public void EventOnUseQueueClicked()
		{
		}

		// Token: 0x0600B663 RID: 46691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B663")]
		[Address(RVA = "0x3306800", Offset = "0x3305400", VA = "0x183306800")]
		public void EventOnUseQueueNotAvailClicked()
		{
		}

		// Token: 0x0600B664 RID: 46692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B664")]
		[Address(RVA = "0x3306380", Offset = "0x3304F80", VA = "0x183306380")]
		public void EventOnEditQueueClicked()
		{
		}

		// Token: 0x0600B665 RID: 46693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B665")]
		[Address(RVA = "0x3306890", Offset = "0x3305490", VA = "0x183306890")]
		public void OnCharClicked(BuildingCharModel target, object param)
		{
		}

		// Token: 0x0600B666 RID: 46694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B666")]
		[Address(RVA = "0x3307320", Offset = "0x3305F20", VA = "0x183307320")]
		private void _UpdateRoomStyle(BuildingData.RoomType roomId)
		{
		}

		// Token: 0x0600B667 RID: 46695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B667")]
		[Address(RVA = "0x33071B0", Offset = "0x3305DB0", VA = "0x1833071B0")]
		private BuildingSMRoomItemView.RoomStyle _PickRoomStyle(BuildingData.RoomType roomId)
		{
			return null;
		}

		// Token: 0x0600B668 RID: 46696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B668")]
		[Address(RVA = "0x33075A0", Offset = "0x33061A0", VA = "0x1833075A0")]
		public BuildingSMRoomItemView()
		{
		}

		// Token: 0x0400B34F RID: 45903
		[Token(Token = "0x400B34F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x0400B350 RID: 45904
		[Token(Token = "0x400B350")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _charLayout;

		// Token: 0x0400B351 RID: 45905
		[Token(Token = "0x400B351")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0400B352 RID: 45906
		[Token(Token = "0x400B352")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelInactive;

		// Token: 0x0400B353 RID: 45907
		[Token(Token = "0x400B353")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelUpgrading;

		// Token: 0x0400B354 RID: 45908
		[Token(Token = "0x400B354")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelHotspot;

		// Token: 0x0400B355 RID: 45909
		[Token(Token = "0x400B355")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIColorGraphic _mainColorComp;

		// Token: 0x0400B356 RID: 45910
		[Token(Token = "0x400B356")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _selectedFrame;

		// Token: 0x0400B357 RID: 45911
		[Token(Token = "0x400B357")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Room Info")]
		private Text _textName;

		// Token: 0x0400B358 RID: 45912
		[Token(Token = "0x400B358")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Room Info")]
		private GameObject _textIndexHolder;

		// Token: 0x0400B359 RID: 45913
		[Token(Token = "0x400B359")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Room Info")]
		private Text _textRoomIndex;

		// Token: 0x0400B35A RID: 45914
		[Token(Token = "0x400B35A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Room Info")]
		private GameObject _stopWorkIcon;

		// Token: 0x0400B35B RID: 45915
		[Token(Token = "0x400B35B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Room Info")]
		private Text _roomTargetName;

		// Token: 0x0400B35C RID: 45916
		[Token(Token = "0x400B35C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Room Info")]
		private BuildingRoomLevelView _commonLevelView;

		// Token: 0x0400B35D RID: 45917
		[Token(Token = "0x400B35D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Preset Queue")]
		private TwoStateToggle _useQueueBtn;

		// Token: 0x0400B35E RID: 45918
		[Token(Token = "0x400B35E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Preset Queue")]
		private TwoStateToggle _setQueueBtn;

		// Token: 0x0400B35F RID: 45919
		[Token(Token = "0x400B35F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private BuildingSMRoomItemView.RoomStyle[] _roomStyles;

		// Token: 0x0400B360 RID: 45920
		[Token(Token = "0x400B360")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _preferHeight;

		// Token: 0x0400B361 RID: 45921
		[Token(Token = "0x400B361")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _anim;

		// Token: 0x0400B362 RID: 45922
		[Token(Token = "0x400B362")]
		[FieldOffset(Offset = "0xB8")]
		private Sprite m_levelIcon;

		// Token: 0x0400B363 RID: 45923
		[Token(Token = "0x400B363")]
		[FieldOffset(Offset = "0xC0")]
		private BuildingSMRoomItemView.CharAdapter m_charAdapter;

		// Token: 0x0400B364 RID: 45924
		[Token(Token = "0x400B364")]
		[FieldOffset(Offset = "0xC8")]
		private StationRoomStructModel m_roomModel;

		// Token: 0x0400B365 RID: 45925
		[Token(Token = "0x400B365")]
		[FieldOffset(Offset = "0x120")]
		private BuildingData.RoomType m_cachedRoomType;

		// Token: 0x0400B366 RID: 45926
		[Token(Token = "0x400B366")]
		[FieldOffset(Offset = "0x124")]
		private bool m_isSelected;

		// Token: 0x0400B367 RID: 45927
		[Token(Token = "0x400B367")]
		[FieldOffset(Offset = "0x128")]
		private StationCharStructModel[] m_chars;

		// Token: 0x0400B368 RID: 45928
		[Token(Token = "0x400B368")]
		[FieldOffset(Offset = "0x130")]
		private bool m_isEditDormLockMode;

		// Token: 0x0400B369 RID: 45929
		[Token(Token = "0x400B369")]
		[FieldOffset(Offset = "0x131")]
		private bool m_isInited;

		// Token: 0x0400B36A RID: 45930
		[Token(Token = "0x400B36A")]
		[FieldOffset(Offset = "0x138")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0400B36B RID: 45931
		[Token(Token = "0x400B36B")]
		[FieldOffset(Offset = "0x148")]
		private Tween m_charTween;

		// Token: 0x0400B36C RID: 45932
		[Token(Token = "0x400B36C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B36D RID: 45933
		[Token(Token = "0x400B36D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnRoomClicked;

		// Token: 0x0400B36E RID: 45934
		[Token(Token = "0x400B36E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnUseQueueClicked;

		// Token: 0x0400B36F RID: 45935
		[Token(Token = "0x400B36F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnUseQueueNotAvailClicked;

		// Token: 0x0400B370 RID: 45936
		[Token(Token = "0x400B370")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnEditQueueClicked;

		// Token: 0x0400B371 RID: 45937
		[Token(Token = "0x400B371")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCharClicked;

		// Token: 0x0400B372 RID: 45938
		[Token(Token = "0x400B372")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateRoomStyle;

		// Token: 0x0400B373 RID: 45939
		[Token(Token = "0x400B373")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PickRoomStyle;

		// Token: 0x0400B374 RID: 45940
		[Token(Token = "0x400B374")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001CC1 RID: 7361
		[Token(Token = "0x2001CC1")]
		public struct Params
		{
			// Token: 0x0400B375 RID: 45941
			[Token(Token = "0x400B375")]
			[FieldOffset(Offset = "0x0")]
			public StationRoomStructModel roomModel;

			// Token: 0x0400B376 RID: 45942
			[Token(Token = "0x400B376")]
			[FieldOffset(Offset = "0x58")]
			public bool isSelected;

			// Token: 0x0400B377 RID: 45943
			[Token(Token = "0x400B377")]
			[FieldOffset(Offset = "0x59")]
			public bool playCharAnim;

			// Token: 0x0400B378 RID: 45944
			[Token(Token = "0x400B378")]
			[FieldOffset(Offset = "0x5A")]
			public bool isEditDormLockMode;
		}

		// Token: 0x02001CC2 RID: 7362
		[Token(Token = "0x2001CC2")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<BuildingSMRoomItemView>
		{
			// Token: 0x0600B669 RID: 46697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B669")]
			[Address(RVA = "0x331C580", Offset = "0x331B180", VA = "0x18331C580")]
			public VirtualView(BuildingSMRoomItemView prefab)
			{
			}

			// Token: 0x0600B66A RID: 46698 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B66A")]
			[Address(RVA = "0x331BD00", Offset = "0x331A900", VA = "0x18331BD00", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0600B66B RID: 46699 RVA: 0x00044EF8 File Offset: 0x000430F8
			[Token(Token = "0x600B66B")]
			[Address(RVA = "0x331BE50", Offset = "0x331AA50", VA = "0x18331BE50", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0600B66C RID: 46700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B66C")]
			[Address(RVA = "0x331C2B0", Offset = "0x331AEB0", VA = "0x18331C2B0")]
			public void SetParams(BuildingSMRoomItemView.Params param)
			{
			}

			// Token: 0x0600B66D RID: 46701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B66D")]
			[Address(RVA = "0x331BEC0", Offset = "0x331AAC0", VA = "0x18331BEC0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0600B66E RID: 46702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B66E")]
			[Address(RVA = "0x331C0C0", Offset = "0x331ACC0", VA = "0x18331C0C0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0400B379 RID: 45945
			[Token(Token = "0x400B379")]
			[FieldOffset(Offset = "0x20")]
			private BuildingSMRoomItemView m_prefab;

			// Token: 0x0400B37A RID: 45946
			[Token(Token = "0x400B37A")]
			[FieldOffset(Offset = "0x28")]
			private BuildingSMRoomItemView.Params m_params;

			// Token: 0x0400B37B RID: 45947
			[Token(Token = "0x400B37B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B37C RID: 45948
			[Token(Token = "0x400B37C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0400B37D RID: 45949
			[Token(Token = "0x400B37D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0400B37E RID: 45950
			[Token(Token = "0x400B37E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_SetParams;

			// Token: 0x0400B37F RID: 45951
			[Token(Token = "0x400B37F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0400B380 RID: 45952
			[Token(Token = "0x400B380")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnViewDetached;
		}

		// Token: 0x02001CC3 RID: 7363
		[Token(Token = "0x2001CC3")]
		[Serializable]
		private class RoomStyle
		{
			// Token: 0x0600B66F RID: 46703 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B66F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoomStyle()
			{
			}

			// Token: 0x0400B381 RID: 45953
			[Token(Token = "0x400B381")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.RoomType roomId;

			// Token: 0x0400B382 RID: 45954
			[Token(Token = "0x400B382")]
			[FieldOffset(Offset = "0x14")]
			public Color color;

			// Token: 0x0400B383 RID: 45955
			[Token(Token = "0x400B383")]
			[FieldOffset(Offset = "0x28")]
			public Sprite bkgImg;
		}

		// Token: 0x02001CC4 RID: 7364
		[Token(Token = "0x2001CC4")]
		public class CharAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600B670 RID: 46704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B670")]
			[Address(RVA = "0x3313010", Offset = "0x3311C10", VA = "0x183313010")]
			public CharAdapter(BuildingSMRoomItemView closure)
			{
			}

			// Token: 0x170015E3 RID: 5603
			// (get) Token: 0x0600B671 RID: 46705 RVA: 0x00044F10 File Offset: 0x00043110
			[Token(Token = "0x170015E3")]
			public override int count
			{
				[Token(Token = "0x600B671")]
				[Address(RVA = "0x3313090", Offset = "0x3311C90", VA = "0x183313090", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B672 RID: 46706 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B672")]
			[Address(RVA = "0x3312CE0", Offset = "0x33118E0", VA = "0x183312CE0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400B384 RID: 45956
			[Token(Token = "0x400B384")]
			[FieldOffset(Offset = "0x20")]
			private BuildingSMRoomItemView m_closure;

			// Token: 0x0400B385 RID: 45957
			[Token(Token = "0x400B385")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B386 RID: 45958
			[Token(Token = "0x400B386")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400B387 RID: 45959
			[Token(Token = "0x400B387")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
