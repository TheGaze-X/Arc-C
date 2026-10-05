using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F17 RID: 20247
	[Token(Token = "0x2004F17")]
	public class FifthAnnivExploreTargetInfoView : DataBinder<FifthAnnivExploreTargetInfoProperty>, IHotfixable
	{
		// Token: 0x170046BB RID: 18107
		// (get) Token: 0x0601E2BA RID: 123578 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E2B9 RID: 123577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046BB")]
		public Action onBlankClick
		{
			[Token(Token = "0x601E2BA")]
			[Address(RVA = "0x17DA110", Offset = "0x17D8D10", VA = "0x1817DA110")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601E2B9")]
			[Address(RVA = "0x17DA170", Offset = "0x17D8D70", VA = "0x1817DA170")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601E2BB RID: 123579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2BB")]
		[Address(RVA = "0x17D9E50", Offset = "0x17D8A50", VA = "0x1817D9E50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E2BC RID: 123580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2BC")]
		[Address(RVA = "0x17D9B70", Offset = "0x17D8770", VA = "0x1817D9B70")]
		public void OnBlankClick()
		{
		}

		// Token: 0x0601E2BD RID: 123581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2BD")]
		[Address(RVA = "0x17D9C80", Offset = "0x17D8880", VA = "0x1817D9C80", Slot = "7")]
		public override void OnValueChanged(FifthAnnivExploreTargetInfoProperty property)
		{
		}

		// Token: 0x0601E2BE RID: 123582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2BE")]
		[Address(RVA = "0x17DA0A0", Offset = "0x17D8CA0", VA = "0x1817DA0A0")]
		public FifthAnnivExploreTargetInfoView()
		{
		}

		// Token: 0x040282D1 RID: 164561
		[Token(Token = "0x40282D1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageNumText;

		// Token: 0x040282D2 RID: 164562
		[Token(Token = "0x40282D2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _stageNameText;

		// Token: 0x040282D3 RID: 164563
		[Token(Token = "0x40282D3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _apNumText;

		// Token: 0x040282D4 RID: 164564
		[Token(Token = "0x40282D4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FifthAnnivExploreTargetInfoItemView.Config _config;

		// Token: 0x040282D5 RID: 164565
		[Token(Token = "0x40282D5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _layoutContent;

		// Token: 0x040282D6 RID: 164566
		[Token(Token = "0x40282D6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _blankHotspotObj;

		// Token: 0x040282D7 RID: 164567
		[Token(Token = "0x40282D7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x040282D8 RID: 164568
		[Token(Token = "0x40282D8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040282D9 RID: 164569
		[Token(Token = "0x40282D9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Vector2 _hidePos;

		// Token: 0x040282DA RID: 164570
		[Token(Token = "0x40282DA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Vector2 _showPos;

		// Token: 0x040282DB RID: 164571
		[Token(Token = "0x40282DB")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x040282DC RID: 164572
		[Token(Token = "0x40282DC")]
		[FieldOffset(Offset = "0xB0")]
		private FifthAnnivExploreTargetInfoView.Adapter m_adapter;

		// Token: 0x040282DD RID: 164573
		[Token(Token = "0x40282DD")]
		[FieldOffset(Offset = "0xB8")]
		private List<FifthAnnivExploreTargetInfoItemViewModel> m_cachedItemViewModels;

		// Token: 0x040282DE RID: 164574
		[Token(Token = "0x40282DE")]
		[FieldOffset(Offset = "0xC0")]
		private FadeTranslationSwitchTween m_fadeTween;

		// Token: 0x040282E0 RID: 164576
		[Token(Token = "0x40282E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onBlankClick;

		// Token: 0x040282E1 RID: 164577
		[Token(Token = "0x40282E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onBlankClick;

		// Token: 0x040282E2 RID: 164578
		[Token(Token = "0x40282E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040282E3 RID: 164579
		[Token(Token = "0x40282E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBlankClick;

		// Token: 0x040282E4 RID: 164580
		[Token(Token = "0x40282E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040282E5 RID: 164581
		[Token(Token = "0x40282E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F18 RID: 20248
		[Token(Token = "0x2004F18")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170046BC RID: 18108
			// (get) Token: 0x0601E2BF RID: 123583 RVA: 0x000ADB98 File Offset: 0x000ABD98
			[Token(Token = "0x170046BC")]
			public override int count
			{
				[Token(Token = "0x601E2BF")]
				[Address(RVA = "0x17C9820", Offset = "0x17C8420", VA = "0x1817C9820", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E2C0 RID: 123584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E2C0")]
			[Address(RVA = "0x17C97A0", Offset = "0x17C83A0", VA = "0x1817C97A0")]
			public Adapter(FifthAnnivExploreTargetInfoView closure)
			{
			}

			// Token: 0x0601E2C1 RID: 123585 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E2C1")]
			[Address(RVA = "0x17C9550", Offset = "0x17C8150", VA = "0x1817C9550", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040282E6 RID: 164582
			[Token(Token = "0x40282E6")]
			[FieldOffset(Offset = "0x20")]
			private FifthAnnivExploreTargetInfoView m_closure;

			// Token: 0x040282E7 RID: 164583
			[Token(Token = "0x40282E7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040282E8 RID: 164584
			[Token(Token = "0x40282E8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040282E9 RID: 164585
			[Token(Token = "0x40282E9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
