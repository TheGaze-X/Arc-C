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
	// Token: 0x020067C2 RID: 26562
	[Token(Token = "0x20067C2")]
	public class StageZoneHomeToDoItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005A15 RID: 23061
		// (get) Token: 0x06026179 RID: 156025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A15")]
		public CanvasGroup alphaHandler
		{
			[Token(Token = "0x6026179")]
			[Address(RVA = "0x2125D60", Offset = "0x2124960", VA = "0x182125D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005A16 RID: 23062
		// (get) Token: 0x0602617A RID: 156026 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602617B RID: 156027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A16")]
		public Action<ZoneHomeToDoItemModel> onClick
		{
			[Token(Token = "0x602617A")]
			[Address(RVA = "0x2125DC0", Offset = "0x21249C0", VA = "0x182125DC0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x602617B")]
			[Address(RVA = "0x2125E20", Offset = "0x2124A20", VA = "0x182125E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602617C RID: 156028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602617C")]
		[Address(RVA = "0x2125450", Offset = "0x2124050", VA = "0x182125450")]
		public void Render(ZoneHomeToDoItemModel viewModel)
		{
		}

		// Token: 0x0602617D RID: 156029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602617D")]
		[Address(RVA = "0x2125990", Offset = "0x2124590", VA = "0x182125990")]
		private void _UpdatePlugin(ZoneHomeToDoItemModel viewModel)
		{
		}

		// Token: 0x0602617E RID: 156030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602617E")]
		[Address(RVA = "0x2125790", Offset = "0x2124390", VA = "0x182125790")]
		private void _UpdateEndTime(long endTs)
		{
		}

		// Token: 0x0602617F RID: 156031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602617F")]
		[Address(RVA = "0x2125550", Offset = "0x2124150", VA = "0x182125550")]
		private void _TickEndTimeDisplay(CountDownTask.TickValue value)
		{
		}

		// Token: 0x06026180 RID: 156032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026180")]
		[Address(RVA = "0x2125340", Offset = "0x2123F40", VA = "0x182125340")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06026181 RID: 156033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026181")]
		[Address(RVA = "0x21254E0", Offset = "0x21240E0", VA = "0x1821254E0", Slot = "4")]
		protected virtual void Update()
		{
		}

		// Token: 0x06026182 RID: 156034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026182")]
		[Address(RVA = "0x2125D00", Offset = "0x2124900", VA = "0x182125D00")]
		public StageZoneHomeToDoItem()
		{
		}

		// Token: 0x040359E0 RID: 219616
		[Token(Token = "0x40359E0")]
		private const string COLOR_GROUP_PLUGIN = "plugin";

		// Token: 0x040359E1 RID: 219617
		[Token(Token = "0x40359E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x040359E2 RID: 219618
		[Token(Token = "0x40359E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _mainImage;

		// Token: 0x040359E3 RID: 219619
		[Token(Token = "0x40359E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<StageZoneHomeToDoItem.PluginConfig> _plugins;

		// Token: 0x040359E4 RID: 219620
		[Token(Token = "0x40359E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _pluginHolder;

		// Token: 0x040359E5 RID: 219621
		[Token(Token = "0x40359E5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIColorGraphic _clickHotspot;

		// Token: 0x040359E6 RID: 219622
		[Token(Token = "0x40359E6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("EndTime")]
		private GameObject _panelEndTime;

		// Token: 0x040359E7 RID: 219623
		[Token(Token = "0x40359E7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("EndTime")]
		private Text _textEndTime;

		// Token: 0x040359E8 RID: 219624
		[Token(Token = "0x40359E8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("EndTime")]
		private StageZoneHomeToDoItem.EndTimeCountDownBgStyle[] _endTimeStyles;

		// Token: 0x040359E9 RID: 219625
		[Token(Token = "0x40359E9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("EndTime")]
		private Image _imgEndTimeBkg;

		// Token: 0x040359EB RID: 219627
		[Token(Token = "0x40359EB")]
		[FieldOffset(Offset = "0x68")]
		private ZoneHomeToDoItemModel m_viewModel;

		// Token: 0x040359EC RID: 219628
		[Token(Token = "0x40359EC")]
		[FieldOffset(Offset = "0x70")]
		private StageZoneHomeToDoItemPlugin m_cachedPlugin;

		// Token: 0x040359ED RID: 219629
		[Token(Token = "0x40359ED")]
		[FieldOffset(Offset = "0x78")]
		private CountDownTask m_endTimeCountDown;

		// Token: 0x040359EE RID: 219630
		[Token(Token = "0x40359EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x040359EF RID: 219631
		[Token(Token = "0x40359EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x040359F0 RID: 219632
		[Token(Token = "0x40359F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x040359F1 RID: 219633
		[Token(Token = "0x40359F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040359F2 RID: 219634
		[Token(Token = "0x40359F2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdatePlugin;

		// Token: 0x040359F3 RID: 219635
		[Token(Token = "0x40359F3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateEndTime;

		// Token: 0x040359F4 RID: 219636
		[Token(Token = "0x40359F4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TickEndTimeDisplay;

		// Token: 0x040359F5 RID: 219637
		[Token(Token = "0x40359F5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x040359F6 RID: 219638
		[Token(Token = "0x40359F6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040359F7 RID: 219639
		[Token(Token = "0x40359F7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020067C3 RID: 26563
		[Token(Token = "0x20067C3")]
		[Serializable]
		public struct EndTimeCountDownBgStyle
		{
			// Token: 0x040359F8 RID: 219640
			[Token(Token = "0x40359F8")]
			[FieldOffset(Offset = "0x0")]
			public Sprite imgBkg;

			// Token: 0x040359F9 RID: 219641
			[Token(Token = "0x40359F9")]
			[FieldOffset(Offset = "0x8")]
			public int secondRemain;

			// Token: 0x040359FA RID: 219642
			[Token(Token = "0x40359FA")]
			[FieldOffset(Offset = "0xC")]
			public Color textColor;
		}

		// Token: 0x020067C4 RID: 26564
		[Token(Token = "0x20067C4")]
		[Serializable]
		private struct PluginConfig
		{
			// Token: 0x040359FB RID: 219643
			[Token(Token = "0x40359FB")]
			[FieldOffset(Offset = "0x0")]
			public HomeToDoFuncType type;

			// Token: 0x040359FC RID: 219644
			[Token(Token = "0x40359FC")]
			[FieldOffset(Offset = "0x8")]
			public StageZoneHomeToDoItemPlugin pluginPrefab;
		}

		// Token: 0x020067C5 RID: 26565
		[Token(Token = "0x20067C5")]
		public class PluginHandler : IHotfixable
		{
			// Token: 0x06026183 RID: 156035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026183")]
			[Address(RVA = "0x211BBD0", Offset = "0x211A7D0", VA = "0x18211BBD0")]
			public PluginHandler(StageZoneHomeToDoItem closure)
			{
			}

			// Token: 0x06026184 RID: 156036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026184")]
			[Address(RVA = "0x211BA00", Offset = "0x211A600", VA = "0x18211BA00")]
			public void SetMainSprite(Sprite sprite)
			{
			}

			// Token: 0x06026185 RID: 156037 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026185")]
			[Address(RVA = "0x211B7D0", Offset = "0x211A3D0", VA = "0x18211B7D0")]
			public ZoneHomeToDoItemModel GetViewModel()
			{
				return null;
			}

			// Token: 0x06026186 RID: 156038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026186")]
			[Address(RVA = "0x211B840", Offset = "0x211A440", VA = "0x18211B840")]
			public void SetEndTime(long endTs)
			{
			}

			// Token: 0x06026187 RID: 156039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026187")]
			[Address(RVA = "0x211B510", Offset = "0x211A110", VA = "0x18211B510")]
			public void AttachGraphicsToButton(List<Graphic> graphics)
			{
			}

			// Token: 0x040359FD RID: 219645
			[Token(Token = "0x40359FD")]
			[FieldOffset(Offset = "0x10")]
			private StageZoneHomeToDoItem m_closure;

			// Token: 0x040359FE RID: 219646
			[Token(Token = "0x40359FE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040359FF RID: 219647
			[Token(Token = "0x40359FF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetMainSprite;

			// Token: 0x04035A00 RID: 219648
			[Token(Token = "0x4035A00")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetViewModel;

			// Token: 0x04035A01 RID: 219649
			[Token(Token = "0x4035A01")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_SetEndTime;

			// Token: 0x04035A02 RID: 219650
			[Token(Token = "0x4035A02")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AttachGraphicsToButton;
		}
	}
}
