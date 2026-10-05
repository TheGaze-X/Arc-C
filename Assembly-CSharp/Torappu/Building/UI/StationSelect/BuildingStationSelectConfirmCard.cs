using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C89 RID: 7305
	[Token(Token = "0x2001C89")]
	public class BuildingStationSelectConfirmCard : MonoBehaviour, ITimeWatcher
	{
		// Token: 0x0600B56E RID: 46446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B56E")]
		[Address(RVA = "0xF98BF0", Offset = "0xF977F0", VA = "0x180F98BF0")]
		private void Start()
		{
		}

		// Token: 0x0600B56F RID: 46447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B56F")]
		[Address(RVA = "0x330E2A0", Offset = "0x330CEA0", VA = "0x18330E2A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600B570 RID: 46448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B570")]
		[Address(RVA = "0x330E2B0", Offset = "0x330CEB0", VA = "0x18330E2B0")]
		public void Render(ChangedCharCardViewModel statusModel)
		{
		}

		// Token: 0x0600B571 RID: 46449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B571")]
		[Address(RVA = "0x330E310", Offset = "0x330CF10", VA = "0x18330E310", Slot = "4")]
		public void UpdateTime(float delta)
		{
		}

		// Token: 0x0600B572 RID: 46450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B572")]
		[Address(RVA = "0x330E570", Offset = "0x330D170", VA = "0x18330E570")]
		private void _OnManpowerChanged()
		{
		}

		// Token: 0x0600B573 RID: 46451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B573")]
		[Address(RVA = "0x330E6B0", Offset = "0x330D2B0", VA = "0x18330E6B0")]
		private void _RenderCharInfo(ChangedCharCardViewModel statusModel)
		{
		}

		// Token: 0x0600B574 RID: 46452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B574")]
		[Address(RVA = "0x330E360", Offset = "0x330CF60", VA = "0x18330E360")]
		private void _Init(StationCharViewModel viewModel)
		{
		}

		// Token: 0x0600B575 RID: 46453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B575")]
		[Address(RVA = "0x330E580", Offset = "0x330D180", VA = "0x18330E580")]
		private void _RenderAssistPanel(ChangedCharCardViewModel statusModel)
		{
		}

		// Token: 0x0600B576 RID: 46454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B576")]
		[Address(RVA = "0x330EDD0", Offset = "0x330D9D0", VA = "0x18330EDD0")]
		private void _RenderMP()
		{
		}

		// Token: 0x0600B577 RID: 46455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B577")]
		[Address(RVA = "0x330EF50", Offset = "0x330DB50", VA = "0x18330EF50")]
		public BuildingStationSelectConfirmCard()
		{
		}

		// Token: 0x0400B1B9 RID: 45497
		[Token(Token = "0x400B1B9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelInfo;

		// Token: 0x0400B1BA RID: 45498
		[Token(Token = "0x400B1BA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0400B1BB RID: 45499
		[Token(Token = "0x400B1BB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400B1BC RID: 45500
		[Token(Token = "0x400B1BC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _portrait;

		// Token: 0x0400B1BD RID: 45501
		[Token(Token = "0x400B1BD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _buffIconLayout;

		// Token: 0x0400B1BE RID: 45502
		[Token(Token = "0x400B1BE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _manpowerBarContainer;

		// Token: 0x0400B1BF RID: 45503
		[Token(Token = "0x400B1BF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _maskOnWork;

		// Token: 0x0400B1C0 RID: 45504
		[Token(Token = "0x400B1C0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _maskOffWork;

		// Token: 0x0400B1C1 RID: 45505
		[Token(Token = "0x400B1C1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _maskAssist;

		// Token: 0x0400B1C2 RID: 45506
		[Token(Token = "0x400B1C2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _buffPanel;

		// Token: 0x0400B1C3 RID: 45507
		[Token(Token = "0x400B1C3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _hotzone;

		// Token: 0x0400B1C4 RID: 45508
		[Token(Token = "0x400B1C4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _assitIcon;

		// Token: 0x0400B1C5 RID: 45509
		[Token(Token = "0x400B1C5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _assistRoomCode;

		// Token: 0x0400B1C6 RID: 45510
		[Token(Token = "0x400B1C6")]
		[FieldOffset(Offset = "0x80")]
		private StationCharViewModel m_viewModel;

		// Token: 0x0400B1C7 RID: 45511
		[Token(Token = "0x400B1C7")]
		[FieldOffset(Offset = "0x88")]
		private BuildingStationSelectConfirmCard.ViewCache m_viewCache;

		// Token: 0x0400B1C8 RID: 45512
		[Token(Token = "0x400B1C8")]
		[FieldOffset(Offset = "0x108")]
		private bool m_isInited;

		// Token: 0x0400B1C9 RID: 45513
		[Token(Token = "0x400B1C9")]
		[FieldOffset(Offset = "0x110")]
		private BuildingCharMPStateBar m_mpBar;

		// Token: 0x0400B1CA RID: 45514
		[Token(Token = "0x400B1CA")]
		[FieldOffset(Offset = "0x118")]
		private BuildingCharMPHelper m_mpHelper;

		// Token: 0x0400B1CB RID: 45515
		[Token(Token = "0x400B1CB")]
		[FieldOffset(Offset = "0x120")]
		private BuildingStationSelectConfirmCard.BuffIconAdapter m_buffAdapter;

		// Token: 0x02001C8A RID: 7306
		[Token(Token = "0x2001C8A")]
		[Serializable]
		private class BuffIconAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600B578 RID: 46456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B578")]
			[Address(RVA = "0x3303CF0", Offset = "0x33028F0", VA = "0x183303CF0")]
			public BuffIconAdapter(BuildingStationSelectConfirmCard closure)
			{
			}

			// Token: 0x170015D4 RID: 5588
			// (get) Token: 0x0600B579 RID: 46457 RVA: 0x00044C88 File Offset: 0x00042E88
			[Token(Token = "0x170015D4")]
			public override int count
			{
				[Token(Token = "0x600B579")]
				[Address(RVA = "0x3303D70", Offset = "0x3302970", VA = "0x183303D70", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B57A RID: 46458 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B57A")]
			[Address(RVA = "0x3303B30", Offset = "0x3302730", VA = "0x183303B30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400B1CC RID: 45516
			[Token(Token = "0x400B1CC")]
			[FieldOffset(Offset = "0x20")]
			private BuildingStationSelectConfirmCard m_closure;

			// Token: 0x0400B1CD RID: 45517
			[Token(Token = "0x400B1CD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B1CE RID: 45518
			[Token(Token = "0x400B1CE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400B1CF RID: 45519
			[Token(Token = "0x400B1CF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02001C8B RID: 7307
		[Token(Token = "0x2001C8B")]
		private struct ViewCache
		{
			// Token: 0x0600B57B RID: 46459 RVA: 0x00044CA0 File Offset: 0x00042EA0
			[Token(Token = "0x600B57B")]
			[Address(RVA = "0x331B9C0", Offset = "0x331A5C0", VA = "0x18331B9C0")]
			public static BuildingStationSelectConfirmCard.ViewCache Create(StationCharViewModel viewModel)
			{
				return default(BuildingStationSelectConfirmCard.ViewCache);
			}

			// Token: 0x0400B1D0 RID: 45520
			[Token(Token = "0x400B1D0")]
			[FieldOffset(Offset = "0x0")]
			public static BuildingStationSelectConfirmCard.ViewCache EMPTY;

			// Token: 0x0400B1D1 RID: 45521
			[Token(Token = "0x400B1D1")]
			[FieldOffset(Offset = "0x0")]
			public BuildingCharModel buildingChar;

			// Token: 0x0400B1D2 RID: 45522
			[Token(Token = "0x400B1D2")]
			[FieldOffset(Offset = "0x78")]
			public string buffStatusHash;
		}
	}
}
