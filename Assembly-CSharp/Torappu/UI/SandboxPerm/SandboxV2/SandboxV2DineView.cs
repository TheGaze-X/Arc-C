using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004143 RID: 16707
	[Token(Token = "0x2004143")]
	public class SandboxV2DineView : DataBinder<SandboxV2DineProperty>, IHotfixable
	{
		// Token: 0x17003D7E RID: 15742
		// (get) Token: 0x06019CCD RID: 105677 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019CCE RID: 105678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D7E")]
		public Action backEvent
		{
			[Token(Token = "0x6019CCD")]
			[Address(RVA = "0x12B1BE0", Offset = "0x12B07E0", VA = "0x1812B1BE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019CCE")]
			[Address(RVA = "0x12B1D60", Offset = "0x12B0960", VA = "0x1812B1D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D7F RID: 15743
		// (get) Token: 0x06019CCF RID: 105679 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019CD0 RID: 105680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D7F")]
		public Action cookEvent
		{
			[Token(Token = "0x6019CCF")]
			[Address(RVA = "0x12B1CA0", Offset = "0x12B08A0", VA = "0x1812B1CA0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019CD0")]
			[Address(RVA = "0x12B1E60", Offset = "0x12B0A60", VA = "0x1812B1E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D80 RID: 15744
		// (get) Token: 0x06019CD1 RID: 105681 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019CD2 RID: 105682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D80")]
		public Action<int> itemSelectEvent
		{
			[Token(Token = "0x6019CD1")]
			[Address(RVA = "0x12B1D00", Offset = "0x12B0900", VA = "0x1812B1D00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019CD2")]
			[Address(RVA = "0x12B1EE0", Offset = "0x12B0AE0", VA = "0x1812B1EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D81 RID: 15745
		// (get) Token: 0x06019CD3 RID: 105683 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019CD4 RID: 105684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D81")]
		public Action confirmEvent
		{
			[Token(Token = "0x6019CD3")]
			[Address(RVA = "0x12B1C40", Offset = "0x12B0840", VA = "0x1812B1C40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019CD4")]
			[Address(RVA = "0x12B1DE0", Offset = "0x12B09E0", VA = "0x1812B1DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019CD5 RID: 105685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CD5")]
		[Address(RVA = "0x12B0ED0", Offset = "0x12AFAD0", VA = "0x1812B0ED0")]
		public void OnBackEvent()
		{
		}

		// Token: 0x06019CD6 RID: 105686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CD6")]
		[Address(RVA = "0x12B10F0", Offset = "0x12AFCF0", VA = "0x1812B10F0")]
		public void OnCookEvent()
		{
		}

		// Token: 0x06019CD7 RID: 105687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CD7")]
		[Address(RVA = "0x12B0FE0", Offset = "0x12AFBE0", VA = "0x1812B0FE0")]
		public void OnConfirmEvent()
		{
		}

		// Token: 0x06019CD8 RID: 105688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CD8")]
		[Address(RVA = "0x12B18D0", Offset = "0x12B04D0", VA = "0x1812B18D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019CD9 RID: 105689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CD9")]
		[Address(RVA = "0x12B1200", Offset = "0x12AFE00", VA = "0x1812B1200", Slot = "7")]
		public override void OnValueChanged(SandboxV2DineProperty property)
		{
		}

		// Token: 0x06019CDA RID: 105690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CDA")]
		[Address(RVA = "0x12B1B70", Offset = "0x12B0770", VA = "0x1812B1B70")]
		public SandboxV2DineView()
		{
		}

		// Token: 0x04020603 RID: 132611
		[Token(Token = "0x4020603")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2ItemCard _itemCardPrefab;

		// Token: 0x04020604 RID: 132612
		[Token(Token = "0x4020604")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x04020605 RID: 132613
		[Token(Token = "0x4020605")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _validStatusInfoPanel;

		// Token: 0x04020606 RID: 132614
		[Token(Token = "0x4020606")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _invalidStatusInfoPanel;

		// Token: 0x04020607 RID: 132615
		[Token(Token = "0x4020607")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _validStatusDurationPanel;

		// Token: 0x04020608 RID: 132616
		[Token(Token = "0x4020608")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _invalidStatusDurationPanel;

		// Token: 0x04020609 RID: 132617
		[Token(Token = "0x4020609")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _validDineInfoPanel;

		// Token: 0x0402060A RID: 132618
		[Token(Token = "0x402060A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _invalidDineInfoPanel;

		// Token: 0x0402060B RID: 132619
		[Token(Token = "0x402060B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _validDinePanel;

		// Token: 0x0402060C RID: 132620
		[Token(Token = "0x402060C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _invalidDinePanel;

		// Token: 0x0402060D RID: 132621
		[Token(Token = "0x402060D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _statusInfoItemHolder;

		// Token: 0x0402060E RID: 132622
		[Token(Token = "0x402060E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _dineInfoItemHolder;

		// Token: 0x0402060F RID: 132623
		[Token(Token = "0x402060F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _avatarImage;

		// Token: 0x04020610 RID: 132624
		[Token(Token = "0x4020610")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x04020611 RID: 132625
		[Token(Token = "0x4020611")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _statusFoodNameText;

		// Token: 0x04020612 RID: 132626
		[Token(Token = "0x4020612")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _statusFoodDurationText;

		// Token: 0x04020613 RID: 132627
		[Token(Token = "0x4020613")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _statusFoodUsageText;

		// Token: 0x04020614 RID: 132628
		[Token(Token = "0x4020614")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _dineFoodNameText;

		// Token: 0x04020615 RID: 132629
		[Token(Token = "0x4020615")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _dineFoodDurationText;

		// Token: 0x04020616 RID: 132630
		[Token(Token = "0x4020616")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _dineFoodUsageText;

		// Token: 0x04020617 RID: 132631
		[Token(Token = "0x4020617")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private SandboxV2DineItemLoopAdapter _itemLoopAdapter;

		// Token: 0x04020618 RID: 132632
		[Token(Token = "0x4020618")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private LoopVerticalScrollRect _itemLoopRect;

		// Token: 0x04020619 RID: 132633
		[Token(Token = "0x4020619")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _emptyPanel;

		// Token: 0x0402061A RID: 132634
		[Token(Token = "0x402061A")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_hasInit;

		// Token: 0x0402061B RID: 132635
		[Token(Token = "0x402061B")]
		[FieldOffset(Offset = "0xE0")]
		private SandboxV2ItemCard m_statusFoodItem;

		// Token: 0x0402061C RID: 132636
		[Token(Token = "0x402061C")]
		[FieldOffset(Offset = "0xE8")]
		private SandboxV2ItemCard m_dineFoodItem;

		// Token: 0x0402061D RID: 132637
		[Token(Token = "0x402061D")]
		[FieldOffset(Offset = "0xF0")]
		private string m_cachedStatusFoodId;

		// Token: 0x0402061E RID: 132638
		[Token(Token = "0x402061E")]
		[FieldOffset(Offset = "0xF8")]
		private string m_cachedDineFoodId;

		// Token: 0x04020623 RID: 132643
		[Token(Token = "0x4020623")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_backEvent;

		// Token: 0x04020624 RID: 132644
		[Token(Token = "0x4020624")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_backEvent;

		// Token: 0x04020625 RID: 132645
		[Token(Token = "0x4020625")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cookEvent;

		// Token: 0x04020626 RID: 132646
		[Token(Token = "0x4020626")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_cookEvent;

		// Token: 0x04020627 RID: 132647
		[Token(Token = "0x4020627")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_itemSelectEvent;

		// Token: 0x04020628 RID: 132648
		[Token(Token = "0x4020628")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_itemSelectEvent;

		// Token: 0x04020629 RID: 132649
		[Token(Token = "0x4020629")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_confirmEvent;

		// Token: 0x0402062A RID: 132650
		[Token(Token = "0x402062A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_confirmEvent;

		// Token: 0x0402062B RID: 132651
		[Token(Token = "0x402062B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBackEvent;

		// Token: 0x0402062C RID: 132652
		[Token(Token = "0x402062C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnCookEvent;

		// Token: 0x0402062D RID: 132653
		[Token(Token = "0x402062D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnConfirmEvent;

		// Token: 0x0402062E RID: 132654
		[Token(Token = "0x402062E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402062F RID: 132655
		[Token(Token = "0x402062F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04020630 RID: 132656
		[Token(Token = "0x4020630")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
