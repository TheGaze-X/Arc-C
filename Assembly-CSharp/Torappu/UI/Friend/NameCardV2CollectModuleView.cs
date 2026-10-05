using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E05 RID: 19973
	[Token(Token = "0x2004E05")]
	public class NameCardV2CollectModuleView : NameCardV2BaseFixedModuleView<NameCardV2CollectModuleModel>
	{
		// Token: 0x0601DD92 RID: 122258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD92")]
		[Address(RVA = "0x1773DF0", Offset = "0x17729F0", VA = "0x181773DF0", Slot = "20")]
		public override void OnModuleViewRendered(NameCardV2CollectModuleModel model)
		{
		}

		// Token: 0x0601DD93 RID: 122259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD93")]
		[Address(RVA = "0x1773A30", Offset = "0x1772630", VA = "0x181773A30", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0601DD94 RID: 122260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD94")]
		[Address(RVA = "0x1774760", Offset = "0x1773360", VA = "0x181774760")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DD95 RID: 122261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD95")]
		[Address(RVA = "0x1774500", Offset = "0x1773100", VA = "0x181774500")]
		public void SwitchOperatorCountStyle()
		{
		}

		// Token: 0x0601DD96 RID: 122262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD96")]
		[Address(RVA = "0x1774470", Offset = "0x1773070", VA = "0x181774470")]
		public void SwitchDateDisplay()
		{
		}

		// Token: 0x0601DD97 RID: 122263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD97")]
		[Address(RVA = "0x17739A0", Offset = "0x17725A0", VA = "0x1817739A0")]
		public void CloseButtonFadeIn()
		{
		}

		// Token: 0x0601DD98 RID: 122264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD98")]
		[Address(RVA = "0x17748A0", Offset = "0x17734A0", VA = "0x1817748A0")]
		public NameCardV2CollectModuleView()
		{
		}

		// Token: 0x0601DD99 RID: 122265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD99")]
		[Address(RVA = "0x1772BA0", Offset = "0x17717A0", VA = "0x181772BA0")]
		private void <>xLuaBaseProxy_OnApplyStyle(NameCardV2SkinStyle P0)
		{
		}

		// Token: 0x040278DB RID: 162011
		[Token(Token = "0x40278DB")]
		private const string HIRED_TIME_FORMAT = "{0}-{1}-{2}";

		// Token: 0x040278DC RID: 162012
		[Token(Token = "0x40278DC")]
		private const string BIRTH_TIME_FORMAT = "{0}-{1}";

		// Token: 0x040278DD RID: 162013
		[Token(Token = "0x40278DD")]
		private const string CHAR_COLLECT_PERCENT_FORMAT = "{0}.{1}%";

		// Token: 0x040278DE RID: 162014
		[Token(Token = "0x40278DE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Panel Left")]
		private GameObject _hotspot;

		// Token: 0x040278DF RID: 162015
		[Token(Token = "0x40278DF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Panel Left")]
		private TwoStateToggle _dateToggle;

		// Token: 0x040278E0 RID: 162016
		[Token(Token = "0x40278E0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Panel Left")]
		private GameObject _dateSwitchGo;

		// Token: 0x040278E1 RID: 162017
		[Token(Token = "0x40278E1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Panel Left")]
		private Text _hiredTime;

		// Token: 0x040278E2 RID: 162018
		[Token(Token = "0x40278E2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Panel Left")]
		private Text _birthTime;

		// Token: 0x040278E3 RID: 162019
		[Token(Token = "0x40278E3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Panel Left")]
		private TwoStateToggle _assistThemeStateToggle;

		// Token: 0x040278E4 RID: 162020
		[Token(Token = "0x40278E4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Panel Left")]
		private Text _assistThemeName;

		// Token: 0x040278E5 RID: 162021
		[Token(Token = "0x40278E5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Panel Left")]
		private Text _assistThemeEnName;

		// Token: 0x040278E6 RID: 162022
		[Token(Token = "0x40278E6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Panel Left")]
		private Text _skinCount;

		// Token: 0x040278E7 RID: 162023
		[Token(Token = "0x40278E7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Panel Left")]
		private Text _characterCount;

		// Token: 0x040278E8 RID: 162024
		[Token(Token = "0x40278E8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Panel Left")]
		private SimpleLayoutContent _teamIconContent;

		// Token: 0x040278E9 RID: 162025
		[Token(Token = "0x40278E9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Panel Left")]
		private Image _operatorCollectPercent;

		// Token: 0x040278EA RID: 162026
		[Token(Token = "0x40278EA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Panel Left")]
		private TwoStateToggle _operatorCollectToggle;

		// Token: 0x040278EB RID: 162027
		[Token(Token = "0x40278EB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Panel Left")]
		private UIAnimationLocation _switchIconAnim;

		// Token: 0x040278EC RID: 162028
		[Token(Token = "0x40278EC")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Panel Left")]
		private GameObject[] _switchOperatorObjects;

		// Token: 0x040278ED RID: 162029
		[Token(Token = "0x40278ED")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Theme Colored")]
		private Image[] _themeColoredIcons;

		// Token: 0x040278EE RID: 162030
		[Token(Token = "0x40278EE")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Theme Colored")]
		private Text[] _themeColoredTexts;

		// Token: 0x040278EF RID: 162031
		[Token(Token = "0x40278EF")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_hasInited;

		// Token: 0x040278F0 RID: 162032
		[Token(Token = "0x40278F0")]
		[FieldOffset(Offset = "0xE8")]
		private List<NameCardV2CollectModuleModel.NameCardTeamViewModel> m_cachedTeamViewModelList;

		// Token: 0x040278F1 RID: 162033
		[Token(Token = "0x40278F1")]
		[FieldOffset(Offset = "0xF0")]
		private NameCardV2CollectModuleView.TeamIconAdapter m_teamIconAdpter;

		// Token: 0x040278F2 RID: 162034
		[Token(Token = "0x40278F2")]
		[FieldOffset(Offset = "0xF8")]
		private Tween m_switchIconTween;

		// Token: 0x040278F3 RID: 162035
		[Token(Token = "0x40278F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnModuleViewRendered;

		// Token: 0x040278F4 RID: 162036
		[Token(Token = "0x40278F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x040278F5 RID: 162037
		[Token(Token = "0x40278F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040278F6 RID: 162038
		[Token(Token = "0x40278F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SwitchOperatorCountStyle;

		// Token: 0x040278F7 RID: 162039
		[Token(Token = "0x40278F7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SwitchDateDisplay;

		// Token: 0x040278F8 RID: 162040
		[Token(Token = "0x40278F8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CloseButtonFadeIn;

		// Token: 0x040278F9 RID: 162041
		[Token(Token = "0x40278F9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E06 RID: 19974
		[Token(Token = "0x2004E06")]
		private class TeamIconAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004609 RID: 17929
			// (get) Token: 0x0601DD9B RID: 122267 RVA: 0x000AC830 File Offset: 0x000AAA30
			// (set) Token: 0x0601DD9A RID: 122266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004609")]
			public Color collectedIconColor
			{
				[Token(Token = "0x601DD9B")]
				[Address(RVA = "0x177E7F0", Offset = "0x177D3F0", VA = "0x18177E7F0")]
				[CompilerGenerated]
				private get
				{
					return default(Color);
				}
				[Token(Token = "0x601DD9A")]
				[Address(RVA = "0x177E8F0", Offset = "0x177D4F0", VA = "0x18177E8F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601DD9C RID: 122268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DD9C")]
			[Address(RVA = "0x177E770", Offset = "0x177D370", VA = "0x18177E770")]
			public TeamIconAdapter(NameCardV2CollectModuleView closure)
			{
			}

			// Token: 0x1700460A RID: 17930
			// (get) Token: 0x0601DD9D RID: 122269 RVA: 0x000AC848 File Offset: 0x000AAA48
			[Token(Token = "0x1700460A")]
			public override int count
			{
				[Token(Token = "0x601DD9D")]
				[Address(RVA = "0x177E870", Offset = "0x177D470", VA = "0x18177E870", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601DD9E RID: 122270 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DD9E")]
			[Address(RVA = "0x177E560", Offset = "0x177D160", VA = "0x18177E560", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040278FA RID: 162042
			[Token(Token = "0x40278FA")]
			[FieldOffset(Offset = "0x20")]
			private NameCardV2CollectModuleView m_closure;

			// Token: 0x040278FC RID: 162044
			[Token(Token = "0x40278FC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_collectedIconColor;

			// Token: 0x040278FD RID: 162045
			[Token(Token = "0x40278FD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_collectedIconColor;

			// Token: 0x040278FE RID: 162046
			[Token(Token = "0x40278FE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040278FF RID: 162047
			[Token(Token = "0x40278FF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04027900 RID: 162048
			[Token(Token = "0x4027900")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
