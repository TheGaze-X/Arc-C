using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200351E RID: 13598
	[Token(Token = "0x200351E")]
	public class UICharacterProfessionFilterView : DataBinder<UICharacterProfessionFilterProperty>
	{
		// Token: 0x06015AD5 RID: 88789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AD5")]
		[Address(RVA = "0xE42A20", Offset = "0xE41620", VA = "0x180E42A20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015AD6 RID: 88790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AD6")]
		[Address(RVA = "0xE427F0", Offset = "0xE413F0", VA = "0x180E427F0", Slot = "7")]
		public override void OnValueChanged(UICharacterProfessionFilterProperty property)
		{
		}

		// Token: 0x06015AD7 RID: 88791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AD7")]
		[Address(RVA = "0xE42C40", Offset = "0xE41840", VA = "0x180E42C40")]
		private void _RenderImpl(UICharacterProfessionFilterViewModel model)
		{
		}

		// Token: 0x06015AD8 RID: 88792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AD8")]
		[Address(RVA = "0xE42ED0", Offset = "0xE41AD0", VA = "0x180E42ED0")]
		private void _SetPanelShow(bool isProfShow, bool isSubProfShow, bool isFastMode)
		{
		}

		// Token: 0x06015AD9 RID: 88793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AD9")]
		[Address(RVA = "0xE42710", Offset = "0xE41310", VA = "0x180E42710")]
		public void OnBarTopClick()
		{
		}

		// Token: 0x06015ADA RID: 88794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ADA")]
		[Address(RVA = "0xE42780", Offset = "0xE41380", VA = "0x180E42780")]
		public void OnCloseSubProfClick()
		{
		}

		// Token: 0x06015ADB RID: 88795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ADB")]
		[Address(RVA = "0xE42FE0", Offset = "0xE41BE0", VA = "0x180E42FE0")]
		public UICharacterProfessionFilterView()
		{
		}

		// Token: 0x0401A051 RID: 106577
		[Token(Token = "0x401A051")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _selectedName;

		// Token: 0x0401A052 RID: 106578
		[Token(Token = "0x401A052")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x0401A053 RID: 106579
		[Token(Token = "0x401A053")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelUnSelected;

		// Token: 0x0401A054 RID: 106580
		[Token(Token = "0x401A054")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelSubProfBlocker;

		// Token: 0x0401A055 RID: 106581
		[Token(Token = "0x401A055")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICharacterProfessionFilterProfView _profView;

		// Token: 0x0401A056 RID: 106582
		[Token(Token = "0x401A056")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UICharacterProfessionFilterSubProfView _subProfView;

		// Token: 0x0401A057 RID: 106583
		[Token(Token = "0x401A057")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _profBarAnim;

		// Token: 0x0401A058 RID: 106584
		[Token(Token = "0x401A058")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _subProfBarAnim;

		// Token: 0x0401A059 RID: 106585
		[Token(Token = "0x401A059")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public ILoadAsset assetLoader;

		// Token: 0x0401A05A RID: 106586
		[Token(Token = "0x401A05A")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Action<ProfessionCategory, bool> onProfessionClick;

		// Token: 0x0401A05B RID: 106587
		[Token(Token = "0x401A05B")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action<string, bool> onSubProfessionClick;

		// Token: 0x0401A05C RID: 106588
		[Token(Token = "0x401A05C")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public Action onBarTopClick;

		// Token: 0x0401A05D RID: 106589
		[Token(Token = "0x401A05D")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action onCloseSubClick;

		// Token: 0x0401A05E RID: 106590
		[Token(Token = "0x401A05E")]
		[FieldOffset(Offset = "0x98")]
		private int m_fastSeq;

		// Token: 0x0401A05F RID: 106591
		[Token(Token = "0x401A05F")]
		[FieldOffset(Offset = "0x9C")]
		private int m_profChangeSeq;

		// Token: 0x0401A060 RID: 106592
		[Token(Token = "0x401A060")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0401A061 RID: 106593
		[Token(Token = "0x401A061")]
		[FieldOffset(Offset = "0xA8")]
		private AnimationSwitchTween m_profShow;

		// Token: 0x0401A062 RID: 106594
		[Token(Token = "0x401A062")]
		[FieldOffset(Offset = "0xB0")]
		private AnimationSwitchTween m_subProfShow;

		// Token: 0x0401A063 RID: 106595
		[Token(Token = "0x401A063")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A064 RID: 106596
		[Token(Token = "0x401A064")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401A065 RID: 106597
		[Token(Token = "0x401A065")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderImpl;

		// Token: 0x0401A066 RID: 106598
		[Token(Token = "0x401A066")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetPanelShow;

		// Token: 0x0401A067 RID: 106599
		[Token(Token = "0x401A067")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBarTopClick;

		// Token: 0x0401A068 RID: 106600
		[Token(Token = "0x401A068")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCloseSubProfClick;

		// Token: 0x0401A069 RID: 106601
		[Token(Token = "0x401A069")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
