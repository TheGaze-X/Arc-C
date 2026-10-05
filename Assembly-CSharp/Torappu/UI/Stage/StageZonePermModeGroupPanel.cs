using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069B3 RID: 27059
	[Token(Token = "0x20069B3")]
	public class StageZonePermModeGroupPanel : StageZoneGroupPanel, IHotfixable
	{
		// Token: 0x06026B95 RID: 158613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B95")]
		[Address(RVA = "0x21CC020", Offset = "0x21CAC20", VA = "0x1821CC020", Slot = "8")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026B96 RID: 158614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B96")]
		[Address(RVA = "0x21CBA50", Offset = "0x21CA650", VA = "0x1821CBA50", Slot = "9")]
		protected override void OnDataUpdated(ZoneGroupViewProperty prop)
		{
		}

		// Token: 0x06026B97 RID: 158615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B97")]
		[Address(RVA = "0x21CB8A0", Offset = "0x21CA4A0", VA = "0x1821CB8A0")]
		public void EventOnRoguelikeClicked()
		{
		}

		// Token: 0x06026B98 RID: 158616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B98")]
		[Address(RVA = "0x21CB930", Offset = "0x21CA530", VA = "0x1821CB930")]
		public void EventOnRoguelikeEntryClicked()
		{
		}

		// Token: 0x06026B99 RID: 158617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B99")]
		[Address(RVA = "0x21CB9C0", Offset = "0x21CA5C0", VA = "0x1821CB9C0")]
		public void EventOnSandboxHomeClicked()
		{
		}

		// Token: 0x06026B9A RID: 158618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B9A")]
		[Address(RVA = "0x21CC0C0", Offset = "0x21CACC0", VA = "0x1821CC0C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026B9B RID: 158619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B9B")]
		[Address(RVA = "0x21CC130", Offset = "0x21CAD30", VA = "0x1821CC130")]
		private void _RenderRoguelike(PermModeZoneGroupViewModel model, ILoadAsset loader)
		{
		}

		// Token: 0x06026B9C RID: 158620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B9C")]
		[Address(RVA = "0x21CC440", Offset = "0x21CB040", VA = "0x1821CC440")]
		private void _RenderSandbox(PermModeZoneGroupViewModel model, ILoadAsset loader)
		{
		}

		// Token: 0x06026B9D RID: 158621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B9D")]
		[Address(RVA = "0x21CC5D0", Offset = "0x21CB1D0", VA = "0x1821CC5D0")]
		public StageZonePermModeGroupPanel()
		{
		}

		// Token: 0x06026B9E RID: 158622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B9E")]
		[Address(RVA = "0x21BDE90", Offset = "0x21BCA90", VA = "0x1821BDE90")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06026B9F RID: 158623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B9F")]
		[Address(RVA = "0x21BDE30", Offset = "0x21BCA30", VA = "0x1821BDE30")]
		private void <>xLuaBaseProxy_OnDataUpdated(ZoneGroupViewProperty P0)
		{
		}

		// Token: 0x04036AC9 RID: 223945
		[Token(Token = "0x4036AC9")]
		[FieldOffset(Offset = "0x60")]
		[Header("Roguelike")]
		[SerializeField]
		private GameObject _panelRoguelike;

		// Token: 0x04036ACA RID: 223946
		[Token(Token = "0x4036ACA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgRoguelike;

		// Token: 0x04036ACB RID: 223947
		[Token(Token = "0x4036ACB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelOnBattle;

		// Token: 0x04036ACC RID: 223948
		[Token(Token = "0x4036ACC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textOnBattleName;

		// Token: 0x04036ACD RID: 223949
		[Token(Token = "0x4036ACD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private MaskableGraphic[] _imgOnBattle;

		// Token: 0x04036ACE RID: 223950
		[Token(Token = "0x4036ACE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelRoguelikeDLCUpdate;

		// Token: 0x04036ACF RID: 223951
		[Token(Token = "0x4036ACF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelRoguelikeReviewUpdate;

		// Token: 0x04036AD0 RID: 223952
		[Token(Token = "0x4036AD0")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Space(12f)]
		[Header("Sandbox")]
		private GameObject _panelSandboxClosed;

		// Token: 0x04036AD1 RID: 223953
		[Token(Token = "0x4036AD1")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _panelSandbox;

		// Token: 0x04036AD2 RID: 223954
		[Token(Token = "0x4036AD2")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _panelSandboxUpdate;

		// Token: 0x04036AD3 RID: 223955
		[Token(Token = "0x4036AD3")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image _imgSandbox;

		// Token: 0x04036AD4 RID: 223956
		[Token(Token = "0x4036AD4")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_hasInited;

		// Token: 0x04036AD5 RID: 223957
		[Token(Token = "0x4036AD5")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04036AD6 RID: 223958
		[Token(Token = "0x4036AD6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04036AD7 RID: 223959
		[Token(Token = "0x4036AD7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04036AD8 RID: 223960
		[Token(Token = "0x4036AD8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnRoguelikeClicked;

		// Token: 0x04036AD9 RID: 223961
		[Token(Token = "0x4036AD9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnRoguelikeEntryClicked;

		// Token: 0x04036ADA RID: 223962
		[Token(Token = "0x4036ADA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnSandboxHomeClicked;

		// Token: 0x04036ADB RID: 223963
		[Token(Token = "0x4036ADB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036ADC RID: 223964
		[Token(Token = "0x4036ADC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderRoguelike;

		// Token: 0x04036ADD RID: 223965
		[Token(Token = "0x4036ADD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderSandbox;

		// Token: 0x04036ADE RID: 223966
		[Token(Token = "0x4036ADE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
