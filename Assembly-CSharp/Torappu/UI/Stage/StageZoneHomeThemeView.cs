using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067BD RID: 26557
	[Token(Token = "0x20067BD")]
	public class StageZoneHomeThemeView : DataBinder<ZoneHomeThemeViewProp>
	{
		// Token: 0x17005A12 RID: 23058
		// (get) Token: 0x06026158 RID: 155992 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026159 RID: 155993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A12")]
		public Action<ZoneHomeEntryItemModel> onThemeClicked
		{
			[Token(Token = "0x6026158")]
			[Address(RVA = "0x2124E40", Offset = "0x2123A40", VA = "0x182124E40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6026159")]
			[Address(RVA = "0x2124EA0", Offset = "0x2123AA0", VA = "0x182124EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602615A RID: 155994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602615A")]
		[Address(RVA = "0x2123960", Offset = "0x2122560", VA = "0x182123960", Slot = "7")]
		public override void OnValueChanged(ZoneHomeThemeViewProp viewProp)
		{
		}

		// Token: 0x0602615B RID: 155995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602615B")]
		[Address(RVA = "0x21238B0", Offset = "0x21224B0", VA = "0x1821238B0")]
		public void EventOnThemeClicked()
		{
		}

		// Token: 0x0602615C RID: 155996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602615C")]
		[Address(RVA = "0x21237D0", Offset = "0x21223D0", VA = "0x1821237D0")]
		public void EventOnThemeClickedPluginOnly()
		{
		}

		// Token: 0x0602615D RID: 155997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602615D")]
		[Address(RVA = "0x2124960", Offset = "0x2123560", VA = "0x182124960")]
		private void _UpdatePlugin(ZoneHomeThemeViewModel viewModel)
		{
		}

		// Token: 0x0602615E RID: 155998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602615E")]
		[Address(RVA = "0x2123CF0", Offset = "0x21228F0", VA = "0x182123CF0")]
		private StageZoneHomeThemeView.Plugin _GetPluginPrefabFromType(HomeEntryFuncType funcType)
		{
			return null;
		}

		// Token: 0x0602615F RID: 155999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602615F")]
		[Address(RVA = "0x21246C0", Offset = "0x21232C0", VA = "0x1821246C0")]
		private void _UpdateMedalInfo(ZoneHomeEntryItemModel entryModel)
		{
		}

		// Token: 0x06026160 RID: 156000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026160")]
		[Address(RVA = "0x2124200", Offset = "0x2122E00", VA = "0x182124200")]
		private void _UpdateEndTime(ZoneHomeEntryItemModel entryModel)
		{
		}

		// Token: 0x06026161 RID: 156001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026161")]
		[Address(RVA = "0x2123DF0", Offset = "0x21229F0", VA = "0x182123DF0")]
		private void _TickEndTimeDisplay(CountDownTask.TickValue value)
		{
		}

		// Token: 0x06026162 RID: 156002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026162")]
		[Address(RVA = "0x2123F00", Offset = "0x2122B00", VA = "0x182123F00")]
		private void _UpdateCalender(ZoneHomeThemeViewModel themeModel)
		{
		}

		// Token: 0x06026163 RID: 156003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026163")]
		[Address(RVA = "0x2124300", Offset = "0x2122F00", VA = "0x182124300")]
		private void _UpdateLockStatus(ZoneHomeEntryItemModel entryModel)
		{
		}

		// Token: 0x06026164 RID: 156004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026164")]
		[Address(RVA = "0x2124550", Offset = "0x2123150", VA = "0x182124550")]
		private void _UpdateLogo(ZoneHomeEntryItemModel entryModel)
		{
		}

		// Token: 0x06026165 RID: 156005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026165")]
		[Address(RVA = "0x2123C80", Offset = "0x2122880", VA = "0x182123C80", Slot = "8")]
		protected virtual void Update()
		{
		}

		// Token: 0x06026166 RID: 156006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026166")]
		[Address(RVA = "0x2124D70", Offset = "0x2123970", VA = "0x182124D70")]
		public StageZoneHomeThemeView()
		{
		}

		// Token: 0x040359A3 RID: 219555
		[Token(Token = "0x40359A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _btnEnter;

		// Token: 0x040359A4 RID: 219556
		[Token(Token = "0x40359A4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x040359A5 RID: 219557
		[Token(Token = "0x40359A5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textLock;

		// Token: 0x040359A6 RID: 219558
		[Token(Token = "0x40359A6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelContent;

		// Token: 0x040359A7 RID: 219559
		[Token(Token = "0x40359A7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x040359A8 RID: 219560
		[Token(Token = "0x40359A8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _themeInfo;

		// Token: 0x040359A9 RID: 219561
		[Token(Token = "0x40359A9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Plugins")]
		private List<StageZoneHomeThemeView.PluginConfig> _plugins;

		// Token: 0x040359AA RID: 219562
		[Token(Token = "0x40359AA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Plugins")]
		private RectTransform _pluginContainer;

		// Token: 0x040359AB RID: 219563
		[Token(Token = "0x40359AB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("EndTime")]
		private GameObject _panelEndTime;

		// Token: 0x040359AC RID: 219564
		[Token(Token = "0x40359AC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("EndTime")]
		private Text _textEndTime;

		// Token: 0x040359AD RID: 219565
		[Token(Token = "0x40359AD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("MedalInfo")]
		private StageZoneHomeEntryMedalView _medalPrefab;

		// Token: 0x040359AE RID: 219566
		[Token(Token = "0x40359AE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("MedalInfo")]
		private RectTransform _medalContainer;

		// Token: 0x040359AF RID: 219567
		[Token(Token = "0x40359AF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Calender")]
		private UIProgressCalender _calender;

		// Token: 0x040359B0 RID: 219568
		[Token(Token = "0x40359B0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Calender")]
		private UIProgressCalender _bkgCalender;

		// Token: 0x040359B1 RID: 219569
		[Token(Token = "0x40359B1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Calender")]
		private Text _titleCalender;

		// Token: 0x040359B2 RID: 219570
		[Token(Token = "0x40359B2")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Logo")]
		private GameObject _logoContainer;

		// Token: 0x040359B3 RID: 219571
		[Token(Token = "0x40359B3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Logo")]
		private Image _logoImg;

		// Token: 0x040359B4 RID: 219572
		[Token(Token = "0x40359B4")]
		[FieldOffset(Offset = "0xA8")]
		private ZoneHomeThemeViewModel m_cachedModel;

		// Token: 0x040359B5 RID: 219573
		[Token(Token = "0x40359B5")]
		[FieldOffset(Offset = "0xB0")]
		private CountDownTask m_endTimeCountDown;

		// Token: 0x040359B6 RID: 219574
		[Token(Token = "0x40359B6")]
		[FieldOffset(Offset = "0xB8")]
		private StageZoneHomeEntryMedalView m_medalView;

		// Token: 0x040359B7 RID: 219575
		[Token(Token = "0x40359B7")]
		[FieldOffset(Offset = "0xC0")]
		private List<UIProgressCalender.Node> m_calenderNodes;

		// Token: 0x040359B9 RID: 219577
		[Token(Token = "0x40359B9")]
		[FieldOffset(Offset = "0xD0")]
		private StageZoneHomeThemeView.Plugin m_plugin;

		// Token: 0x040359BA RID: 219578
		[Token(Token = "0x40359BA")]
		[FieldOffset(Offset = "0xD8")]
		private HomeEntryFuncType m_pluginType;

		// Token: 0x040359BB RID: 219579
		[Token(Token = "0x40359BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onThemeClicked;

		// Token: 0x040359BC RID: 219580
		[Token(Token = "0x40359BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onThemeClicked;

		// Token: 0x040359BD RID: 219581
		[Token(Token = "0x40359BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040359BE RID: 219582
		[Token(Token = "0x40359BE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnThemeClicked;

		// Token: 0x040359BF RID: 219583
		[Token(Token = "0x40359BF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnThemeClickedPluginOnly;

		// Token: 0x040359C0 RID: 219584
		[Token(Token = "0x40359C0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdatePlugin;

		// Token: 0x040359C1 RID: 219585
		[Token(Token = "0x40359C1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetPluginPrefabFromType;

		// Token: 0x040359C2 RID: 219586
		[Token(Token = "0x40359C2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateMedalInfo;

		// Token: 0x040359C3 RID: 219587
		[Token(Token = "0x40359C3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateEndTime;

		// Token: 0x040359C4 RID: 219588
		[Token(Token = "0x40359C4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TickEndTimeDisplay;

		// Token: 0x040359C5 RID: 219589
		[Token(Token = "0x40359C5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateCalender;

		// Token: 0x040359C6 RID: 219590
		[Token(Token = "0x40359C6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateLockStatus;

		// Token: 0x040359C7 RID: 219591
		[Token(Token = "0x40359C7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateLogo;

		// Token: 0x040359C8 RID: 219592
		[Token(Token = "0x40359C8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040359C9 RID: 219593
		[Token(Token = "0x40359C9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020067BE RID: 26558
		[Token(Token = "0x20067BE")]
		[Serializable]
		private struct PluginConfig
		{
			// Token: 0x040359CA RID: 219594
			[Token(Token = "0x40359CA")]
			[FieldOffset(Offset = "0x0")]
			public HomeEntryFuncType type;

			// Token: 0x040359CB RID: 219595
			[Token(Token = "0x40359CB")]
			[FieldOffset(Offset = "0x8")]
			public StageZoneHomeThemeView.Plugin pluginPrefab;
		}

		// Token: 0x020067BF RID: 26559
		[Token(Token = "0x20067BF")]
		public abstract class Plugin : MonoBehaviour, IHotfixable
		{
			// Token: 0x17005A13 RID: 23059
			// (get) Token: 0x06026167 RID: 156007 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06026168 RID: 156008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005A13")]
			public StageZoneHomeThemeView holder
			{
				[Token(Token = "0x6026167")]
				[Address(RVA = "0x211C390", Offset = "0x211AF90", VA = "0x18211C390")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6026168")]
				[Address(RVA = "0x211C400", Offset = "0x211B000", VA = "0x18211C400")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06026169 RID: 156009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026169")]
			[Address(RVA = "0x211BEF0", Offset = "0x211AAF0", VA = "0x18211BEF0", Slot = "4")]
			protected virtual void OnInit(StageZoneHomeThemeView holder)
			{
			}

			// Token: 0x0602616A RID: 156010
			[Token(Token = "0x602616A")]
			public abstract Sprite GetThemeLogo();

			// Token: 0x0602616B RID: 156011
			[Token(Token = "0x602616B")]
			protected abstract void OnDataUpdated(StageZoneHomeThemeView.Plugin.Param param);

			// Token: 0x0602616C RID: 156012 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602616C")]
			[Address(RVA = "0x211C080", Offset = "0x211AC80", VA = "0x18211C080")]
			public void TriggerInit(StageZoneHomeThemeView holder)
			{
			}

			// Token: 0x0602616D RID: 156013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602616D")]
			[Address(RVA = "0x211BFD0", Offset = "0x211ABD0", VA = "0x18211BFD0")]
			public void TriggerDataUpdated(StageZoneHomeThemeView.Plugin.Param param)
			{
			}

			// Token: 0x0602616E RID: 156014 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602616E")]
			[Address(RVA = "0x211C130", Offset = "0x211AD30", VA = "0x18211C130")]
			protected void TriggerThemeClicked()
			{
			}

			// Token: 0x0602616F RID: 156015 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602616F")]
			protected T LoadAsset<T>(string assetPath) where T : UnityEngine.Object
			{
				return null;
			}

			// Token: 0x06026170 RID: 156016 RVA: 0x000C9F30 File Offset: 0x000C8130
			[Token(Token = "0x6026170")]
			[Address(RVA = "0x211BC50", Offset = "0x211A850", VA = "0x18211BC50")]
			protected bool CheckIsEnlargeMode(Sprite sprite)
			{
				return default(bool);
			}

			// Token: 0x06026171 RID: 156017 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026171")]
			[Address(RVA = "0x211BE60", Offset = "0x211AA60", VA = "0x18211BE60")]
			protected Sprite LoadCommonThemeSprite(string funcId)
			{
				return null;
			}

			// Token: 0x06026172 RID: 156018 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026172")]
			[Address(RVA = "0x211C310", Offset = "0x211AF10", VA = "0x18211C310")]
			protected Plugin()
			{
			}

			// Token: 0x040359CC RID: 219596
			[Token(Token = "0x40359CC")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Vector2 ENLARGE_SIZE;

			// Token: 0x040359CE RID: 219598
			[Token(Token = "0x40359CE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_holder;

			// Token: 0x040359CF RID: 219599
			[Token(Token = "0x40359CF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_holder;

			// Token: 0x040359D0 RID: 219600
			[Token(Token = "0x40359D0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x040359D1 RID: 219601
			[Token(Token = "0x40359D1")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_TriggerInit;

			// Token: 0x040359D2 RID: 219602
			[Token(Token = "0x40359D2")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_TriggerDataUpdated;

			// Token: 0x040359D3 RID: 219603
			[Token(Token = "0x40359D3")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_TriggerThemeClicked;

			// Token: 0x040359D4 RID: 219604
			[Token(Token = "0x40359D4")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_LoadAsset;

			// Token: 0x040359D5 RID: 219605
			[Token(Token = "0x40359D5")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_CheckIsEnlargeMode;

			// Token: 0x040359D6 RID: 219606
			[Token(Token = "0x40359D6")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_LoadCommonThemeSprite;

			// Token: 0x040359D7 RID: 219607
			[Token(Token = "0x40359D7")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020067C0 RID: 26560
			[Token(Token = "0x20067C0")]
			public struct Param
			{
				// Token: 0x040359D8 RID: 219608
				[Token(Token = "0x40359D8")]
				[FieldOffset(Offset = "0x0")]
				public ZoneHomeThemeViewModel viewModel;
			}
		}
	}
}
