using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004356 RID: 17238
	[Token(Token = "0x2004356")]
	public class SandboxV2RacerInventoryInfoView : DataBinder<SandboxV2RacerInventoryProperty>, IHotfixable
	{
		// Token: 0x0601A763 RID: 108387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A763")]
		[Address(RVA = "0x138EAB0", Offset = "0x138D6B0", VA = "0x18138EAB0", Slot = "7")]
		public override void OnValueChanged(SandboxV2RacerInventoryProperty property)
		{
		}

		// Token: 0x0601A764 RID: 108388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A764")]
		[Address(RVA = "0x138E900", Offset = "0x138D500", VA = "0x18138E900")]
		public void EventOnReleaseClicked()
		{
		}

		// Token: 0x0601A765 RID: 108389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A765")]
		[Address(RVA = "0x138E990", Offset = "0x138D590", VA = "0x18138E990")]
		public void EventOnStartBattleClicked()
		{
		}

		// Token: 0x0601A766 RID: 108390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A766")]
		[Address(RVA = "0x138EA20", Offset = "0x138D620", VA = "0x18138EA20")]
		public void EventOnTempBagClicked()
		{
		}

		// Token: 0x0601A767 RID: 108391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A767")]
		[Address(RVA = "0x138EDF0", Offset = "0x138D9F0", VA = "0x18138EDF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A768 RID: 108392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A768")]
		[Address(RVA = "0x138EEC0", Offset = "0x138DAC0", VA = "0x18138EEC0")]
		public SandboxV2RacerInventoryInfoView()
		{
		}

		// Token: 0x04021A8F RID: 137871
		[Token(Token = "0x4021A8F")]
		private const string AP_COST_FORMAT = "-{0}";

		// Token: 0x04021A90 RID: 137872
		[Token(Token = "0x4021A90")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2RacerInventoryDetailView _prefabDetail;

		// Token: 0x04021A91 RID: 137873
		[Token(Token = "0x4021A91")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _containerDetail;

		// Token: 0x04021A92 RID: 137874
		[Token(Token = "0x4021A92")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelStartBattle;

		// Token: 0x04021A93 RID: 137875
		[Token(Token = "0x4021A93")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _hotSpotStartBattle;

		// Token: 0x04021A94 RID: 137876
		[Token(Token = "0x4021A94")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelStartBattleDisable;

		// Token: 0x04021A95 RID: 137877
		[Token(Token = "0x4021A95")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textApCost;

		// Token: 0x04021A96 RID: 137878
		[Token(Token = "0x4021A96")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelRelease;

		// Token: 0x04021A97 RID: 137879
		[Token(Token = "0x4021A97")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelBtnTempBag;

		// Token: 0x04021A98 RID: 137880
		[Token(Token = "0x4021A98")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textTempBagName;

		// Token: 0x04021A99 RID: 137881
		[Token(Token = "0x4021A99")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Slider _progressTempBag;

		// Token: 0x04021A9A RID: 137882
		[Token(Token = "0x4021A9A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelTempBagFullTip;

		// Token: 0x04021A9B RID: 137883
		[Token(Token = "0x4021A9B")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x04021A9C RID: 137884
		[Token(Token = "0x4021A9C")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2RacerInventoryDetailView m_detailView;

		// Token: 0x04021A9D RID: 137885
		[Token(Token = "0x4021A9D")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04021A9E RID: 137886
		[Token(Token = "0x4021A9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04021A9F RID: 137887
		[Token(Token = "0x4021A9F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnReleaseClicked;

		// Token: 0x04021AA0 RID: 137888
		[Token(Token = "0x4021AA0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnStartBattleClicked;

		// Token: 0x04021AA1 RID: 137889
		[Token(Token = "0x4021AA1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnTempBagClicked;

		// Token: 0x04021AA2 RID: 137890
		[Token(Token = "0x4021AA2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021AA3 RID: 137891
		[Token(Token = "0x4021AA3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
