using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067A7 RID: 26535
	[Token(Token = "0x20067A7")]
	public class StageZoneHomeEntryItem : StageZoneHomeEntryItemBase
	{
		// Token: 0x17005A05 RID: 23045
		// (get) Token: 0x060260E8 RID: 155880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A05")]
		public override CanvasGroup alphaHandler
		{
			[Token(Token = "0x60260E8")]
			[Address(RVA = "0x21217F0", Offset = "0x21203F0", VA = "0x1821217F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005A06 RID: 23046
		// (get) Token: 0x060260E9 RID: 155881 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060260EA RID: 155882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A06")]
		public Action<ZoneHomeEntryItemModel> onClick
		{
			[Token(Token = "0x60260E9")]
			[Address(RVA = "0x2121850", Offset = "0x2120450", VA = "0x182121850")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60260EA")]
			[Address(RVA = "0x21218B0", Offset = "0x21204B0", VA = "0x1821218B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060260EB RID: 155883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260EB")]
		[Address(RVA = "0x2120560", Offset = "0x211F160", VA = "0x182120560", Slot = "5")]
		protected override void OnRender(ZoneHomeEntryItemModel viewModel, HomeEntryLayoutLevel layoutLevel)
		{
		}

		// Token: 0x060260EC RID: 155884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260EC")]
		[Address(RVA = "0x21212A0", Offset = "0x211FEA0", VA = "0x1821212A0")]
		private void _UpdatePlugin(ZoneHomeEntryItemModel viewModel)
		{
		}

		// Token: 0x060260ED RID: 155885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260ED")]
		[Address(RVA = "0x21210F0", Offset = "0x211FCF0", VA = "0x1821210F0")]
		private void _UpdateMedalInfo(ZoneHomeEntryMedalStatus medalConfig)
		{
		}

		// Token: 0x060260EE RID: 155886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260EE")]
		[Address(RVA = "0x2120EE0", Offset = "0x211FAE0", VA = "0x182120EE0")]
		private void _UpdateLockInfo(ZoneHomeEntryLockInfo lockInfo)
		{
		}

		// Token: 0x060260EF RID: 155887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260EF")]
		[Address(RVA = "0x2120A70", Offset = "0x211F670", VA = "0x182120A70")]
		public static void UpdateEndTimeStatus(long endTs, GameObject panelEndTime, ref CountDownTask refCountDown, Action<CountDownTask.TickValue> onTimeTick)
		{
		}

		// Token: 0x060260F0 RID: 155888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260F0")]
		[Address(RVA = "0x2120DF0", Offset = "0x211F9F0", VA = "0x182120DF0")]
		private void _UpdateEndTime(long endTs)
		{
		}

		// Token: 0x060260F1 RID: 155889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260F1")]
		[Address(RVA = "0x2120CE0", Offset = "0x211F8E0", VA = "0x182120CE0")]
		private void _TickEndTimeDisplay(CountDownTask.TickValue value)
		{
		}

		// Token: 0x060260F2 RID: 155890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260F2")]
		[Address(RVA = "0x2120440", Offset = "0x211F040", VA = "0x182120440")]
		public void EventOnClicked()
		{
		}

		// Token: 0x060260F3 RID: 155891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260F3")]
		[Address(RVA = "0x2120C70", Offset = "0x211F870", VA = "0x182120C70", Slot = "6")]
		protected virtual void Update()
		{
		}

		// Token: 0x060260F4 RID: 155892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260F4")]
		[Address(RVA = "0x21216F0", Offset = "0x21202F0", VA = "0x1821216F0")]
		public StageZoneHomeEntryItem()
		{
		}

		// Token: 0x040358EC RID: 219372
		[Token(Token = "0x40358EC")]
		private const string COLOR_GROUP_PLUGIN = "plugin";

		// Token: 0x040358ED RID: 219373
		[Token(Token = "0x40358ED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x040358EE RID: 219374
		[Token(Token = "0x40358EE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _mainImage;

		// Token: 0x040358EF RID: 219375
		[Token(Token = "0x40358EF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _funcIcon;

		// Token: 0x040358F0 RID: 219376
		[Token(Token = "0x40358F0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<StageZoneHomeEntryItem.PluginConfig> _plugins;

		// Token: 0x040358F1 RID: 219377
		[Token(Token = "0x40358F1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _pluginHolder;

		// Token: 0x040358F2 RID: 219378
		[Token(Token = "0x40358F2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIColorGraphic _clickHotspot;

		// Token: 0x040358F3 RID: 219379
		[Token(Token = "0x40358F3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _clickButton;

		// Token: 0x040358F4 RID: 219380
		[Token(Token = "0x40358F4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("EndTime")]
		private GameObject _panelEndTime;

		// Token: 0x040358F5 RID: 219381
		[Token(Token = "0x40358F5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("EndTime")]
		private Text _textEndTime;

		// Token: 0x040358F6 RID: 219382
		[Token(Token = "0x40358F6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("MedalInfo")]
		private StageZoneHomeEntryMedalView _medalPrefab;

		// Token: 0x040358F7 RID: 219383
		[Token(Token = "0x40358F7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("MedalInfo")]
		private RectTransform _medalContainer;

		// Token: 0x040358F8 RID: 219384
		[Token(Token = "0x40358F8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("LockInfo")]
		private GameObject _panelLockInfo;

		// Token: 0x040358F9 RID: 219385
		[Token(Token = "0x40358F9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("LockInfo")]
		private Text _textLock;

		// Token: 0x040358FA RID: 219386
		[Token(Token = "0x40358FA")]
		[FieldOffset(Offset = "0x88")]
		private ZoneHomeEntryItemModel m_cachedModel;

		// Token: 0x040358FB RID: 219387
		[Token(Token = "0x40358FB")]
		[FieldOffset(Offset = "0x90")]
		private StageZoneHomeEntryItemPlugin m_cachedPlugin;

		// Token: 0x040358FC RID: 219388
		[Token(Token = "0x40358FC")]
		[FieldOffset(Offset = "0x98")]
		private StageZoneHomeEntryMedalView m_medalView;

		// Token: 0x040358FD RID: 219389
		[Token(Token = "0x40358FD")]
		[FieldOffset(Offset = "0xA0")]
		private HomeEntryLayoutLevel m_layoutLevel;

		// Token: 0x040358FE RID: 219390
		[Token(Token = "0x40358FE")]
		[FieldOffset(Offset = "0xA8")]
		private ZoneHomeEntryLockInfo m_cachedLockInfo;

		// Token: 0x040358FF RID: 219391
		[Token(Token = "0x40358FF")]
		[FieldOffset(Offset = "0xC0")]
		private CountDownTask m_endTimeCountDown;

		// Token: 0x04035901 RID: 219393
		[Token(Token = "0x4035901")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x04035902 RID: 219394
		[Token(Token = "0x4035902")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x04035903 RID: 219395
		[Token(Token = "0x4035903")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x04035904 RID: 219396
		[Token(Token = "0x4035904")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04035905 RID: 219397
		[Token(Token = "0x4035905")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdatePlugin;

		// Token: 0x04035906 RID: 219398
		[Token(Token = "0x4035906")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateMedalInfo;

		// Token: 0x04035907 RID: 219399
		[Token(Token = "0x4035907")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateLockInfo;

		// Token: 0x04035908 RID: 219400
		[Token(Token = "0x4035908")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateEndTimeStatus;

		// Token: 0x04035909 RID: 219401
		[Token(Token = "0x4035909")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateEndTime;

		// Token: 0x0403590A RID: 219402
		[Token(Token = "0x403590A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TickEndTimeDisplay;

		// Token: 0x0403590B RID: 219403
		[Token(Token = "0x403590B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403590C RID: 219404
		[Token(Token = "0x403590C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403590D RID: 219405
		[Token(Token = "0x403590D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020067A8 RID: 26536
		[Token(Token = "0x20067A8")]
		[Serializable]
		private struct PluginConfig
		{
			// Token: 0x0403590E RID: 219406
			[Token(Token = "0x403590E")]
			[FieldOffset(Offset = "0x0")]
			public HomeEntryFuncType type;

			// Token: 0x0403590F RID: 219407
			[Token(Token = "0x403590F")]
			[FieldOffset(Offset = "0x8")]
			public StageZoneHomeEntryItemPlugin pluginPrefab;
		}

		// Token: 0x020067A9 RID: 26537
		[Token(Token = "0x20067A9")]
		public class PluginHandler : IHotfixable
		{
			// Token: 0x060260F5 RID: 155893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60260F5")]
			[Address(RVA = "0x211BB50", Offset = "0x211A750", VA = "0x18211BB50")]
			public PluginHandler(StageZoneHomeEntryItem closure)
			{
			}

			// Token: 0x060260F6 RID: 155894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60260F6")]
			[Address(RVA = "0x211BA90", Offset = "0x211A690", VA = "0x18211BA90")]
			public void SetMainSprite(Sprite sprite)
			{
			}

			// Token: 0x060260F7 RID: 155895 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60260F7")]
			[Address(RVA = "0x211B760", Offset = "0x211A360", VA = "0x18211B760")]
			public ZoneHomeEntryItemModel GetViewModel()
			{
				return null;
			}

			// Token: 0x060260F8 RID: 155896 RVA: 0x000C9D50 File Offset: 0x000C7F50
			[Token(Token = "0x60260F8")]
			[Address(RVA = "0x211B6F0", Offset = "0x211A2F0", VA = "0x18211B6F0")]
			public HomeEntryLayoutLevel GetLayoutLevel()
			{
				return HomeEntryLayoutLevel.NONE;
			}

			// Token: 0x060260F9 RID: 155897 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60260F9")]
			[Address(RVA = "0x211B8C0", Offset = "0x211A4C0", VA = "0x18211B8C0")]
			public void SetEndTime(long endTs)
			{
			}

			// Token: 0x060260FA RID: 155898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60260FA")]
			[Address(RVA = "0x211B940", Offset = "0x211A540", VA = "0x18211B940")]
			public void SetFuncIcon(Sprite sprite)
			{
			}

			// Token: 0x060260FB RID: 155899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60260FB")]
			[Address(RVA = "0x211B600", Offset = "0x211A200", VA = "0x18211B600")]
			public void AttachGraphicsToButton(List<Graphic> graphics)
			{
			}

			// Token: 0x04035910 RID: 219408
			[Token(Token = "0x4035910")]
			[FieldOffset(Offset = "0x10")]
			private StageZoneHomeEntryItem m_closure;

			// Token: 0x04035911 RID: 219409
			[Token(Token = "0x4035911")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04035912 RID: 219410
			[Token(Token = "0x4035912")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetMainSprite;

			// Token: 0x04035913 RID: 219411
			[Token(Token = "0x4035913")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetViewModel;

			// Token: 0x04035914 RID: 219412
			[Token(Token = "0x4035914")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetLayoutLevel;

			// Token: 0x04035915 RID: 219413
			[Token(Token = "0x4035915")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_SetEndTime;

			// Token: 0x04035916 RID: 219414
			[Token(Token = "0x4035916")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_SetFuncIcon;

			// Token: 0x04035917 RID: 219415
			[Token(Token = "0x4035917")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_AttachGraphicsToButton;
		}
	}
}
