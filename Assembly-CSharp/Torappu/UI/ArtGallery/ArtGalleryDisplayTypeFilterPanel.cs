using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065FC RID: 26108
	[Token(Token = "0x20065FC")]
	public class ArtGalleryDisplayTypeFilterPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025841 RID: 153665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025841")]
		[Address(RVA = "0x2081520", Offset = "0x2080120", VA = "0x182081520")]
		public void Render(ArtGalleryCollectDisplayFilterViewModel filterViewModel)
		{
		}

		// Token: 0x06025842 RID: 153666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025842")]
		[Address(RVA = "0x20817F0", Offset = "0x20803F0", VA = "0x1820817F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025843 RID: 153667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025843")]
		[Address(RVA = "0x2081490", Offset = "0x2080090", VA = "0x182081490")]
		public void EventOnClose()
		{
		}

		// Token: 0x06025844 RID: 153668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025844")]
		[Address(RVA = "0x2081910", Offset = "0x2080510", VA = "0x182081910")]
		public ArtGalleryDisplayTypeFilterPanel()
		{
		}

		// Token: 0x04034AF5 RID: 215797
		[Token(Token = "0x4034AF5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _setTypeItemList;

		// Token: 0x04034AF6 RID: 215798
		[Token(Token = "0x4034AF6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateBiAnimationSwitcher _animPanelSwitch;

		// Token: 0x04034AF7 RID: 215799
		[Token(Token = "0x4034AF7")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x04034AF8 RID: 215800
		[Token(Token = "0x4034AF8")]
		[FieldOffset(Offset = "0x30")]
		private ArtGalleryCollectDisplayFilterViewModel m_filterViewModel;

		// Token: 0x04034AF9 RID: 215801
		[Token(Token = "0x4034AF9")]
		[FieldOffset(Offset = "0x38")]
		private ArtGalleryDisplayTypeFilterPanel.Adapter m_setTypeListAdapter;

		// Token: 0x04034AFA RID: 215802
		[Token(Token = "0x4034AFA")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04034AFB RID: 215803
		[Token(Token = "0x4034AFB")]
		[FieldOffset(Offset = "0x50")]
		private bool m_cachedOpenState;

		// Token: 0x04034AFC RID: 215804
		[Token(Token = "0x4034AFC")]
		[FieldOffset(Offset = "0x51")]
		private bool m_isItemShowFastMode;

		// Token: 0x04034AFD RID: 215805
		[Token(Token = "0x4034AFD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034AFE RID: 215806
		[Token(Token = "0x4034AFE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034AFF RID: 215807
		[Token(Token = "0x4034AFF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClose;

		// Token: 0x04034B00 RID: 215808
		[Token(Token = "0x4034B00")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020065FD RID: 26109
		[Token(Token = "0x20065FD")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06025845 RID: 153669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025845")]
			[Address(RVA = "0x206F340", Offset = "0x206DF40", VA = "0x18206F340")]
			public Adapter(ArtGalleryDisplayTypeFilterPanel closure)
			{
			}

			// Token: 0x170058A0 RID: 22688
			// (get) Token: 0x06025846 RID: 153670 RVA: 0x000C81A8 File Offset: 0x000C63A8
			[Token(Token = "0x170058A0")]
			public override int count
			{
				[Token(Token = "0x6025846")]
				[Address(RVA = "0x206F3C0", Offset = "0x206DFC0", VA = "0x18206F3C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06025847 RID: 153671 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025847")]
			[Address(RVA = "0x206EF30", Offset = "0x206DB30", VA = "0x18206EF30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04034B01 RID: 215809
			[Token(Token = "0x4034B01")]
			[FieldOffset(Offset = "0x20")]
			private ArtGalleryDisplayTypeFilterPanel m_closure;

			// Token: 0x04034B02 RID: 215810
			[Token(Token = "0x4034B02")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04034B03 RID: 215811
			[Token(Token = "0x4034B03")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04034B04 RID: 215812
			[Token(Token = "0x4034B04")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
