using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069B8 RID: 27064
	[Token(Token = "0x20069B8")]
	public class StageZoneTabGroup : DataBinder<ZoneViewProperty>, IHotfixable
	{
		// Token: 0x17005B6F RID: 23407
		// (get) Token: 0x06026BB7 RID: 158647 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026BB8 RID: 158648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B6F")]
		public Action<ZoneViewType> onZoneTabClicked
		{
			[Token(Token = "0x6026BB7")]
			[Address(RVA = "0x21CFF00", Offset = "0x21CEB00", VA = "0x1821CFF00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026BB8")]
			[Address(RVA = "0x21CFF60", Offset = "0x21CEB60", VA = "0x1821CFF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026BB9 RID: 158649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BB9")]
		[Address(RVA = "0x21CF700", Offset = "0x21CE300", VA = "0x1821CF700")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026BBA RID: 158650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BBA")]
		[Address(RVA = "0x21CF0E0", Offset = "0x21CDCE0", VA = "0x1821CF0E0", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x06026BBB RID: 158651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BBB")]
		[Address(RVA = "0x21CFC20", Offset = "0x21CE820", VA = "0x1821CFC20")]
		private void _RenderTabIfAct(StageZoneTabView tabView, StageZoneTabViewModel viewModel, bool isBlack)
		{
		}

		// Token: 0x06026BBC RID: 158652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BBC")]
		[Address(RVA = "0x21CFCF0", Offset = "0x21CE8F0", VA = "0x1821CFCF0")]
		private void _TriggerTabClicked(ZoneViewType viewType)
		{
		}

		// Token: 0x06026BBD RID: 158653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BBD")]
		[Address(RVA = "0x21CFE10", Offset = "0x21CEA10", VA = "0x1821CFE10")]
		public StageZoneTabGroup()
		{
		}

		// Token: 0x04036B03 RID: 224003
		[Token(Token = "0x4036B03")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StageZoneTabView _homeTab;

		// Token: 0x04036B04 RID: 224004
		[Token(Token = "0x4036B04")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StageZoneTabView _mixStoryTab;

		// Token: 0x04036B05 RID: 224005
		[Token(Token = "0x4036B05")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StageZoneTabView _crisisTab;

		// Token: 0x04036B06 RID: 224006
		[Token(Token = "0x4036B06")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private StageZoneTabView _weeklyTab;

		// Token: 0x04036B07 RID: 224007
		[Token(Token = "0x4036B07")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private StageZoneTabView _campaignTab;

		// Token: 0x04036B08 RID: 224008
		[Token(Token = "0x4036B08")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private StageZoneTabView _permModeTab;

		// Token: 0x04036B09 RID: 224009
		[Token(Token = "0x4036B09")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x04036B0A RID: 224010
		[Token(Token = "0x4036B0A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _barLayout;

		// Token: 0x04036B0B RID: 224011
		[Token(Token = "0x4036B0B")]
		[FieldOffset(Offset = "0x60")]
		private StageZoneTabGroup.Adapter m_adapter;

		// Token: 0x04036B0C RID: 224012
		[Token(Token = "0x4036B0C")]
		[FieldOffset(Offset = "0x68")]
		private UIPageListener m_pageListener;

		// Token: 0x04036B0E RID: 224014
		[Token(Token = "0x4036B0E")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x04036B0F RID: 224015
		[Token(Token = "0x4036B0F")]
		[FieldOffset(Offset = "0x80")]
		private StageZoneTabGroupViewModel m_viewModel;

		// Token: 0x04036B10 RID: 224016
		[Token(Token = "0x4036B10")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onZoneTabClicked;

		// Token: 0x04036B11 RID: 224017
		[Token(Token = "0x4036B11")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onZoneTabClicked;

		// Token: 0x04036B12 RID: 224018
		[Token(Token = "0x4036B12")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036B13 RID: 224019
		[Token(Token = "0x4036B13")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036B14 RID: 224020
		[Token(Token = "0x4036B14")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderTabIfAct;

		// Token: 0x04036B15 RID: 224021
		[Token(Token = "0x4036B15")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TriggerTabClicked;

		// Token: 0x04036B16 RID: 224022
		[Token(Token = "0x4036B16")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069B9 RID: 27065
		[Token(Token = "0x20069B9")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005B70 RID: 23408
			// (get) Token: 0x06026BBE RID: 158654 RVA: 0x000CC210 File Offset: 0x000CA410
			[Token(Token = "0x17005B70")]
			public override int count
			{
				[Token(Token = "0x6026BBE")]
				[Address(RVA = "0x21D1F50", Offset = "0x21D0B50", VA = "0x1821D1F50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026BBF RID: 158655 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026BBF")]
			[Address(RVA = "0x21D1AC0", Offset = "0x21D06C0", VA = "0x1821D1AC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06026BC0 RID: 158656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026BC0")]
			[Address(RVA = "0x21D1E60", Offset = "0x21D0A60", VA = "0x1821D1E60")]
			public Adapter()
			{
			}

			// Token: 0x04036B17 RID: 224023
			[Token(Token = "0x4036B17")]
			[FieldOffset(Offset = "0x20")]
			public int availCount;

			// Token: 0x04036B18 RID: 224024
			[Token(Token = "0x4036B18")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04036B19 RID: 224025
			[Token(Token = "0x4036B19")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04036B1A RID: 224026
			[Token(Token = "0x4036B1A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
