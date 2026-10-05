using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI.AutoChess.CharSelect;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200634B RID: 25419
	[Token(Token = "0x200634B")]
	public class AutoChessShopDetailView : MonoBehaviour, IHotfixable, AutoChessCharSelectDetailPanel.ICtrl, ICommandExecutor
	{
		// Token: 0x06024ACC RID: 150220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ACC")]
		[Address(RVA = "0x1F85120", Offset = "0x1F83D20", VA = "0x181F85120")]
		public void RenderViewModel(AutoChessShopViewModel model)
		{
		}

		// Token: 0x06024ACD RID: 150221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ACD")]
		[Address(RVA = "0x1F85E20", Offset = "0x1F84A20", VA = "0x181F85E20")]
		private void _SetCharName(string name)
		{
		}

		// Token: 0x06024ACE RID: 150222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ACE")]
		[Address(RVA = "0x1F85CF0", Offset = "0x1F848F0", VA = "0x181F85CF0")]
		private void _SetCharHead(Sprite head)
		{
		}

		// Token: 0x06024ACF RID: 150223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ACF")]
		[Address(RVA = "0x1F85AB0", Offset = "0x1F846B0", VA = "0x181F85AB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024AD0 RID: 150224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AD0")]
		[Address(RVA = "0x1F85010", Offset = "0x1F83C10", VA = "0x181F85010")]
		private void OnDestroy()
		{
		}

		// Token: 0x06024AD1 RID: 150225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AD1")]
		[Address(RVA = "0x1F84BE0", Offset = "0x1F837E0", VA = "0x181F84BE0")]
		public void EventOnBack()
		{
		}

		// Token: 0x06024AD2 RID: 150226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AD2")]
		[Address(RVA = "0x1F84C70", Offset = "0x1F83870", VA = "0x181F84C70")]
		public void EventOnConfirmCharDetailClick()
		{
		}

		// Token: 0x06024AD3 RID: 150227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AD3")]
		[Address(RVA = "0x1F84D00", Offset = "0x1F83900", VA = "0x181F84D00")]
		public void EventOnFriendAssist()
		{
		}

		// Token: 0x06024AD4 RID: 150228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AD4")]
		[Address(RVA = "0x1F857E0", Offset = "0x1F843E0", VA = "0x181F857E0", Slot = "6")]
		public void SelectEquip(string equipId)
		{
		}

		// Token: 0x06024AD5 RID: 150229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AD5")]
		[Address(RVA = "0x1F858D0", Offset = "0x1F844D0", VA = "0x181F858D0", Slot = "5")]
		public void SelectSkill(string skillId)
		{
		}

		// Token: 0x06024AD6 RID: 150230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AD6")]
		[Address(RVA = "0x1F859C0", Offset = "0x1F845C0", VA = "0x181F859C0", Slot = "4")]
		public void SwitchGold(bool isGold)
		{
		}

		// Token: 0x06024AD7 RID: 150231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AD7")]
		[Address(RVA = "0x1F85F50", Offset = "0x1F84B50", VA = "0x181F85F50")]
		private void _TryRegisterTutorialGO()
		{
		}

		// Token: 0x1700569B RID: 22171
		// (get) Token: 0x06024AD8 RID: 150232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700569B")]
		public string command
		{
			[Token(Token = "0x6024AD8")]
			[Address(RVA = "0x1F86160", Offset = "0x1F84D60", VA = "0x181F86160", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024AD9 RID: 150233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AD9")]
		[Address(RVA = "0x1F84D90", Offset = "0x1F83990", VA = "0x181F84D90", Slot = "8")]
		public void Execute(Command command, Action<ICommandExecutor> finishCb)
		{
		}

		// Token: 0x06024ADA RID: 150234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ADA")]
		[Address(RVA = "0x1F850C0", Offset = "0x1F83CC0", VA = "0x181F850C0", Slot = "9")]
		public void RaiseSignal(Command _)
		{
		}

		// Token: 0x06024ADB RID: 150235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ADB")]
		[Address(RVA = "0x1F84FB0", Offset = "0x1F83BB0", VA = "0x181F84FB0", Slot = "10")]
		public void ForceEnd()
		{
		}

		// Token: 0x06024ADC RID: 150236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ADC")]
		[Address(RVA = "0x1F86100", Offset = "0x1F84D00", VA = "0x181F86100")]
		public AutoChessShopDetailView()
		{
		}

		// Token: 0x040332F1 RID: 209649
		[Token(Token = "0x40332F1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _detailPanelContainer;

		// Token: 0x040332F2 RID: 209650
		[Token(Token = "0x40332F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessCharSelectDetailPanel _detailPanelPrefab;

		// Token: 0x040332F3 RID: 209651
		[Token(Token = "0x40332F3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _backBtn;

		// Token: 0x040332F4 RID: 209652
		[Token(Token = "0x40332F4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _confirmBtn;

		// Token: 0x040332F5 RID: 209653
		[Token(Token = "0x40332F5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Assist")]
		private ThreeStateToggle _assistToggle;

		// Token: 0x040332F6 RID: 209654
		[Token(Token = "0x40332F6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Assist")]
		private Text[] _assistName;

		// Token: 0x040332F7 RID: 209655
		[Token(Token = "0x40332F7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Assist")]
		private Image[] _assistHead;

		// Token: 0x040332F8 RID: 209656
		[Token(Token = "0x40332F8")]
		[FieldOffset(Offset = "0x50")]
		private AutoChessCharSelectDetailPanel m_detailPanel;

		// Token: 0x040332F9 RID: 209657
		[Token(Token = "0x40332F9")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040332FA RID: 209658
		[Token(Token = "0x40332FA")]
		private const string TUTORIAL_FOCUS_TYPE_GARRISON = "garrison";

		// Token: 0x040332FB RID: 209659
		[Token(Token = "0x40332FB")]
		private const string TUTORIAL_FOCUS_TYPE_BOND = "bond";

		// Token: 0x040332FC RID: 209660
		[Token(Token = "0x40332FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderViewModel;

		// Token: 0x040332FD RID: 209661
		[Token(Token = "0x40332FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetCharName;

		// Token: 0x040332FE RID: 209662
		[Token(Token = "0x40332FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetCharHead;

		// Token: 0x040332FF RID: 209663
		[Token(Token = "0x40332FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033300 RID: 209664
		[Token(Token = "0x4033300")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04033301 RID: 209665
		[Token(Token = "0x4033301")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBack;

		// Token: 0x04033302 RID: 209666
		[Token(Token = "0x4033302")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnConfirmCharDetailClick;

		// Token: 0x04033303 RID: 209667
		[Token(Token = "0x4033303")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnFriendAssist;

		// Token: 0x04033304 RID: 209668
		[Token(Token = "0x4033304")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SelectEquip;

		// Token: 0x04033305 RID: 209669
		[Token(Token = "0x4033305")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SelectSkill;

		// Token: 0x04033306 RID: 209670
		[Token(Token = "0x4033306")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SwitchGold;

		// Token: 0x04033307 RID: 209671
		[Token(Token = "0x4033307")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryRegisterTutorialGO;

		// Token: 0x04033308 RID: 209672
		[Token(Token = "0x4033308")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_command;

		// Token: 0x04033309 RID: 209673
		[Token(Token = "0x4033309")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Execute;

		// Token: 0x0403330A RID: 209674
		[Token(Token = "0x403330A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RaiseSignal;

		// Token: 0x0403330B RID: 209675
		[Token(Token = "0x403330B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ForceEnd;

		// Token: 0x0403330C RID: 209676
		[Token(Token = "0x403330C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
