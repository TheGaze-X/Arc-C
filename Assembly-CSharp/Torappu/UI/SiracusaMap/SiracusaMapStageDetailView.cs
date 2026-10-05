using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003EFE RID: 16126
	[Token(Token = "0x2003EFE")]
	public class SiracusaMapStageDetailView : DataBinder<SiracusaMapPanelMapProperty>
	{
		// Token: 0x17003BCA RID: 15306
		// (get) Token: 0x06019092 RID: 102546 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019093 RID: 102547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BCA")]
		public SiracusaMapController closure
		{
			[Token(Token = "0x6019092")]
			[Address(RVA = "0x11C0030", Offset = "0x11BEC30", VA = "0x1811C0030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019093")]
			[Address(RVA = "0x11C0150", Offset = "0x11BED50", VA = "0x1811C0150")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003BCB RID: 15307
		// (get) Token: 0x06019094 RID: 102548 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019095 RID: 102549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BCB")]
		public Action<string> eventOnDetailItemSelect
		{
			[Token(Token = "0x6019094")]
			[Address(RVA = "0x11C0090", Offset = "0x11BEC90", VA = "0x1811C0090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019095")]
			[Address(RVA = "0x11C01D0", Offset = "0x11BEDD0", VA = "0x1811C01D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003BCC RID: 15308
		// (get) Token: 0x06019096 RID: 102550 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019097 RID: 102551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BCC")]
		public Action eventOnDetailItemUnselect
		{
			[Token(Token = "0x6019096")]
			[Address(RVA = "0x11C00F0", Offset = "0x11BECF0", VA = "0x1811C00F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019097")]
			[Address(RVA = "0x11C0250", Offset = "0x11BEE50", VA = "0x1811C0250")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019098 RID: 102552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019098")]
		[Address(RVA = "0x11BF770", Offset = "0x11BE370", VA = "0x1811BF770")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019099 RID: 102553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019099")]
		[Address(RVA = "0x11BF930", Offset = "0x11BE530", VA = "0x1811BF930")]
		private void _OnDetailItemSelect(string key)
		{
		}

		// Token: 0x0601909A RID: 102554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601909A")]
		[Address(RVA = "0x11BFA50", Offset = "0x11BE650", VA = "0x1811BFA50")]
		private void _Render(SiracusaMapNavigationDetailViewModel viewModel)
		{
		}

		// Token: 0x0601909B RID: 102555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601909B")]
		[Address(RVA = "0x11BF6C0", Offset = "0x11BE2C0", VA = "0x1811BF6C0", Slot = "7")]
		public override void OnValueChanged(SiracusaMapPanelMapProperty property)
		{
		}

		// Token: 0x0601909C RID: 102556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601909C")]
		[Address(RVA = "0x11BF5F0", Offset = "0x11BE1F0", VA = "0x1811BF5F0")]
		public void OnDetailItemUnselect()
		{
		}

		// Token: 0x0601909D RID: 102557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601909D")]
		[Address(RVA = "0x11BFFC0", Offset = "0x11BEBC0", VA = "0x1811BFFC0")]
		public SiracusaMapStageDetailView()
		{
		}

		// Token: 0x0401EF43 RID: 126787
		[Token(Token = "0x401EF43")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objContentPart;

		// Token: 0x0401EF44 RID: 126788
		[Token(Token = "0x401EF44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objEmptyPart;

		// Token: 0x0401EF45 RID: 126789
		[Token(Token = "0x401EF45")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgEntryIcon;

		// Token: 0x0401EF46 RID: 126790
		[Token(Token = "0x401EF46")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x0401EF47 RID: 126791
		[Token(Token = "0x401EF47")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtEntryName1;

		// Token: 0x0401EF48 RID: 126792
		[Token(Token = "0x401EF48")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtEntryName2;

		// Token: 0x0401EF49 RID: 126793
		[Token(Token = "0x401EF49")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SiracusaMapStageDetailListAdapter _listAdapter;

		// Token: 0x0401EF4A RID: 126794
		[Token(Token = "0x401EF4A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvas;

		// Token: 0x0401EF4B RID: 126795
		[Token(Token = "0x401EF4B")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0401EF4C RID: 126796
		[Token(Token = "0x401EF4C")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedEntryId;

		// Token: 0x0401EF4D RID: 126797
		[Token(Token = "0x401EF4D")]
		[FieldOffset(Offset = "0x70")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x0401EF4E RID: 126798
		[Token(Token = "0x401EF4E")]
		[FieldOffset(Offset = "0x78")]
		private bool m_rendered;

		// Token: 0x0401EF52 RID: 126802
		[Token(Token = "0x401EF52")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_closure;

		// Token: 0x0401EF53 RID: 126803
		[Token(Token = "0x401EF53")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_closure;

		// Token: 0x0401EF54 RID: 126804
		[Token(Token = "0x401EF54")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_eventOnDetailItemSelect;

		// Token: 0x0401EF55 RID: 126805
		[Token(Token = "0x401EF55")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_eventOnDetailItemSelect;

		// Token: 0x0401EF56 RID: 126806
		[Token(Token = "0x401EF56")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_eventOnDetailItemUnselect;

		// Token: 0x0401EF57 RID: 126807
		[Token(Token = "0x401EF57")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_eventOnDetailItemUnselect;

		// Token: 0x0401EF58 RID: 126808
		[Token(Token = "0x401EF58")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EF59 RID: 126809
		[Token(Token = "0x401EF59")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnDetailItemSelect;

		// Token: 0x0401EF5A RID: 126810
		[Token(Token = "0x401EF5A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0401EF5B RID: 126811
		[Token(Token = "0x401EF5B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401EF5C RID: 126812
		[Token(Token = "0x401EF5C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDetailItemUnselect;

		// Token: 0x0401EF5D RID: 126813
		[Token(Token = "0x401EF5D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
