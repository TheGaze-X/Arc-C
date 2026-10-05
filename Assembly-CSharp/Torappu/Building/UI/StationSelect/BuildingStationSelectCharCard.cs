using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C82 RID: 7298
	[Token(Token = "0x2001C82")]
	public class BuildingStationSelectCharCard : MonoBehaviour, IHotfixable, ITimeWatcher
	{
		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x0600B546 RID: 46406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015CF")]
		public BuildingCharSelectRoomConfig roomConfig
		{
			[Token(Token = "0x600B546")]
			[Address(RVA = "0x32F0360", Offset = "0x32EEF60", VA = "0x1832F0360")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B547 RID: 46407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B547")]
		[Address(RVA = "0x32EFC30", Offset = "0x32EE830", VA = "0x1832EFC30")]
		private void Start()
		{
		}

		// Token: 0x0600B548 RID: 46408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B548")]
		[Address(RVA = "0x32EF070", Offset = "0x32EDC70", VA = "0x1832EF070")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600B549 RID: 46409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B549")]
		[Address(RVA = "0x32EF0D0", Offset = "0x32EDCD0", VA = "0x1832EF0D0")]
		public void Render(StationCharViewModel viewModel, CharSortType sortType)
		{
		}

		// Token: 0x0600B54A RID: 46410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B54A")]
		[Address(RVA = "0x32EEFF0", Offset = "0x32EDBF0", VA = "0x1832EEFF0")]
		public void EventOnCardClicked()
		{
		}

		// Token: 0x0600B54B RID: 46411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B54B")]
		[Address(RVA = "0x32EFC90", Offset = "0x32EE890", VA = "0x1832EFC90", Slot = "4")]
		public void UpdateTime(float delta)
		{
		}

		// Token: 0x0600B54C RID: 46412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B54C")]
		[Address(RVA = "0x32EFFB0", Offset = "0x32EEBB0", VA = "0x1832EFFB0")]
		private void _OnManpowerChanged()
		{
		}

		// Token: 0x0600B54D RID: 46413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B54D")]
		[Address(RVA = "0x32EFD30", Offset = "0x32EE930", VA = "0x1832EFD30")]
		private void _Init(StationCharViewModel viewModel)
		{
		}

		// Token: 0x0600B54E RID: 46414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B54E")]
		[Address(RVA = "0x32F0010", Offset = "0x32EEC10", VA = "0x1832F0010")]
		private void _RenderMP()
		{
		}

		// Token: 0x0600B54F RID: 46415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B54F")]
		[Address(RVA = "0x32F0240", Offset = "0x32EEE40", VA = "0x1832F0240")]
		public BuildingStationSelectCharCard()
		{
		}

		// Token: 0x0400B159 RID: 45401
		[Token(Token = "0x400B159")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400B15A RID: 45402
		[Token(Token = "0x400B15A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICharRarityImage[] _rarityImages;

		// Token: 0x0400B15B RID: 45403
		[Token(Token = "0x400B15B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _portrait;

		// Token: 0x0400B15C RID: 45404
		[Token(Token = "0x400B15C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _buffIconLayout;

		// Token: 0x0400B15D RID: 45405
		[Token(Token = "0x400B15D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _manpowerBarContainer;

		// Token: 0x0400B15E RID: 45406
		[Token(Token = "0x400B15E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _maskRest;

		// Token: 0x0400B15F RID: 45407
		[Token(Token = "0x400B15F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _maskWork;

		// Token: 0x0400B160 RID: 45408
		[Token(Token = "0x400B160")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _maskTired;

		// Token: 0x0400B161 RID: 45409
		[Token(Token = "0x400B161")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _maskTraining;

		// Token: 0x0400B162 RID: 45410
		[Token(Token = "0x400B162")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelStationed;

		// Token: 0x0400B163 RID: 45411
		[Token(Token = "0x400B163")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelInPreQueue;

		// Token: 0x0400B164 RID: 45412
		[Token(Token = "0x400B164")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelInLockStation;

		// Token: 0x0400B165 RID: 45413
		[Token(Token = "0x400B165")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textRoom;

		// Token: 0x0400B166 RID: 45414
		[Token(Token = "0x400B166")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _iconRoom;

		// Token: 0x0400B167 RID: 45415
		[Token(Token = "0x400B167")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Favor")]
		private GameObject _panelCharSortInfo;

		// Token: 0x0400B168 RID: 45416
		[Token(Token = "0x400B168")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Favor")]
		private Text _textFavor;

		// Token: 0x0400B169 RID: 45417
		[Token(Token = "0x400B169")]
		[FieldOffset(Offset = "0x98")]
		private StationCharViewModel m_viewModel;

		// Token: 0x0400B16A RID: 45418
		[Token(Token = "0x400B16A")]
		[FieldOffset(Offset = "0xA0")]
		private BuildingStationSelectCharCard.ViewCache m_viewCache;

		// Token: 0x0400B16B RID: 45419
		[Token(Token = "0x400B16B")]
		[FieldOffset(Offset = "0x128")]
		private bool m_isInited;

		// Token: 0x0400B16C RID: 45420
		[Token(Token = "0x400B16C")]
		[FieldOffset(Offset = "0x130")]
		private BuildingCharMPStateBar m_mpBar;

		// Token: 0x0400B16D RID: 45421
		[Token(Token = "0x400B16D")]
		[FieldOffset(Offset = "0x138")]
		private BuildingCharMPHelper m_mpHelper;

		// Token: 0x0400B16E RID: 45422
		[Token(Token = "0x400B16E")]
		[FieldOffset(Offset = "0x140")]
		private BuildingStationSelectCharCard.BuffIconAdapter m_buffAdapter;

		// Token: 0x0400B16F RID: 45423
		[Token(Token = "0x400B16F")]
		[FieldOffset(Offset = "0x148")]
		private CharSortType m_cachedSortType;

		// Token: 0x0400B170 RID: 45424
		[Token(Token = "0x400B170")]
		[FieldOffset(Offset = "0x150")]
		[NonSerialized]
		public Action<int> onCardClicked;

		// Token: 0x0400B171 RID: 45425
		[Token(Token = "0x400B171")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_roomConfig;

		// Token: 0x0400B172 RID: 45426
		[Token(Token = "0x400B172")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400B173 RID: 45427
		[Token(Token = "0x400B173")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400B174 RID: 45428
		[Token(Token = "0x400B174")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B175 RID: 45429
		[Token(Token = "0x400B175")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnCardClicked;

		// Token: 0x0400B176 RID: 45430
		[Token(Token = "0x400B176")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0400B177 RID: 45431
		[Token(Token = "0x400B177")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnManpowerChanged;

		// Token: 0x0400B178 RID: 45432
		[Token(Token = "0x400B178")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0400B179 RID: 45433
		[Token(Token = "0x400B179")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderMP;

		// Token: 0x0400B17A RID: 45434
		[Token(Token = "0x400B17A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001C83 RID: 7299
		[Token(Token = "0x2001C83")]
		[Serializable]
		private class BuffIconAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600B550 RID: 46416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B550")]
			[Address(RVA = "0x32EC050", Offset = "0x32EAC50", VA = "0x1832EC050")]
			public BuffIconAdapter(BuildingStationSelectCharCard closure)
			{
			}

			// Token: 0x170015D0 RID: 5584
			// (get) Token: 0x0600B551 RID: 46417 RVA: 0x00044C40 File Offset: 0x00042E40
			[Token(Token = "0x170015D0")]
			public override int count
			{
				[Token(Token = "0x600B551")]
				[Address(RVA = "0x32EC0D0", Offset = "0x32EACD0", VA = "0x1832EC0D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B552 RID: 46418 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B552")]
			[Address(RVA = "0x32EBE90", Offset = "0x32EAA90", VA = "0x1832EBE90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400B17B RID: 45435
			[Token(Token = "0x400B17B")]
			[FieldOffset(Offset = "0x20")]
			private BuildingStationSelectCharCard m_closure;

			// Token: 0x0400B17C RID: 45436
			[Token(Token = "0x400B17C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B17D RID: 45437
			[Token(Token = "0x400B17D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400B17E RID: 45438
			[Token(Token = "0x400B17E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02001C84 RID: 7300
		[Token(Token = "0x2001C84")]
		private struct ViewCache
		{
			// Token: 0x0600B553 RID: 46419 RVA: 0x00044C58 File Offset: 0x00042E58
			[Token(Token = "0x600B553")]
			[Address(RVA = "0x3302F70", Offset = "0x3301B70", VA = "0x183302F70")]
			public static BuildingStationSelectCharCard.ViewCache Create(StationCharViewModel viewModel, CharSortType sortType)
			{
				return default(BuildingStationSelectCharCard.ViewCache);
			}

			// Token: 0x0400B17F RID: 45439
			[Token(Token = "0x400B17F")]
			[FieldOffset(Offset = "0x0")]
			public static BuildingStationSelectCharCard.ViewCache EMPTY;

			// Token: 0x0400B180 RID: 45440
			[Token(Token = "0x400B180")]
			[FieldOffset(Offset = "0x0")]
			public BuildingCharModel buildingChar;

			// Token: 0x0400B181 RID: 45441
			[Token(Token = "0x400B181")]
			[FieldOffset(Offset = "0x78")]
			public string buffStatusHash;

			// Token: 0x0400B182 RID: 45442
			[Token(Token = "0x400B182")]
			[FieldOffset(Offset = "0x80")]
			public CharSortType sortType;
		}
	}
}
