using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071BF RID: 29119
	[Token(Token = "0x20071BF")]
	public class Act6FunZoneStageButtonPlugin : ActivityCustomZoneBaseStageButtonPlugin
	{
		// Token: 0x06029530 RID: 169264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029530")]
		[Address(RVA = "0x24B7570", Offset = "0x24B6170", VA = "0x1824B7570", Slot = "5")]
		public override void Render(ActivityCustomZoneMapViewModel zoneModel, StageViewModel stageViewModel, bool isSelected, bool isFastMode)
		{
		}

		// Token: 0x06029531 RID: 169265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029531")]
		[Address(RVA = "0x24B74E0", Offset = "0x24B60E0", VA = "0x1824B74E0")]
		public void EventOnLockItemClick()
		{
		}

		// Token: 0x06029532 RID: 169266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029532")]
		[Address(RVA = "0x24B7990", Offset = "0x24B6590", VA = "0x1824B7990")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029533 RID: 169267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029533")]
		[Address(RVA = "0x24B7AB0", Offset = "0x24B66B0", VA = "0x1824B7AB0")]
		private Act6FunZoneMapStageButtonPluginViewModel _TryGetButtonPluginViewModel(ActivityCustomZoneMapViewModel zoneModel, StageViewModel stageViewModel)
		{
			return null;
		}

		// Token: 0x06029534 RID: 169268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029534")]
		[Address(RVA = "0x24B7C30", Offset = "0x24B6830", VA = "0x1824B7C30")]
		public Act6FunZoneStageButtonPlugin()
		{
		}

		// Token: 0x06029535 RID: 169269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029535")]
		[Address(RVA = "0x24B7970", Offset = "0x24B6570", VA = "0x1824B7970")]
		private void <>xLuaBaseProxy_Render(ActivityCustomZoneMapViewModel P0, StageViewModel P1, bool P2, bool P3)
		{
		}

		// Token: 0x0403B034 RID: 241716
		[Token(Token = "0x403B034")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objUnlockPart;

		// Token: 0x0403B035 RID: 241717
		[Token(Token = "0x403B035")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objCompletePart;

		// Token: 0x0403B036 RID: 241718
		[Token(Token = "0x403B036")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtStageName;

		// Token: 0x0403B037 RID: 241719
		[Token(Token = "0x403B037")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objLockPart;

		// Token: 0x0403B038 RID: 241720
		[Token(Token = "0x403B038")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x0403B039 RID: 241721
		[Token(Token = "0x403B039")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasSelectPart;

		// Token: 0x0403B03A RID: 241722
		[Token(Token = "0x403B03A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Act6FunZoneMapStageButtonAchieveItemView _achieveItemView;

		// Token: 0x0403B03B RID: 241723
		[Token(Token = "0x403B03B")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0403B03C RID: 241724
		[Token(Token = "0x403B03C")]
		[FieldOffset(Offset = "0x60")]
		private Act6FunZoneStageButtonPlugin.SelectSwitchTween m_selectSwitchTween;

		// Token: 0x0403B03D RID: 241725
		[Token(Token = "0x403B03D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B03E RID: 241726
		[Token(Token = "0x403B03E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnLockItemClick;

		// Token: 0x0403B03F RID: 241727
		[Token(Token = "0x403B03F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B040 RID: 241728
		[Token(Token = "0x403B040")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryGetButtonPluginViewModel;

		// Token: 0x0403B041 RID: 241729
		[Token(Token = "0x403B041")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020071C0 RID: 29120
		[Token(Token = "0x20071C0")]
		private class SelectSwitchTween : UISwitchTween
		{
			// Token: 0x06029536 RID: 169270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029536")]
			[Address(RVA = "0x24BF680", Offset = "0x24BE280", VA = "0x1824BF680")]
			public SelectSwitchTween(Act6FunZoneStageButtonPlugin closure)
			{
			}

			// Token: 0x06029537 RID: 169271 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029537")]
			[Address(RVA = "0x24BF470", Offset = "0x24BE070", VA = "0x1824BF470", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06029538 RID: 169272 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029538")]
			[Address(RVA = "0x24BF350", Offset = "0x24BDF50", VA = "0x1824BF350", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06029539 RID: 169273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029539")]
			[Address(RVA = "0x24BF5D0", Offset = "0x24BE1D0", VA = "0x1824BF5D0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602953A RID: 169274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602953A")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403B042 RID: 241730
			[Token(Token = "0x403B042")]
			[FieldOffset(Offset = "0x48")]
			private Act6FunZoneStageButtonPlugin m_closure;

			// Token: 0x0403B043 RID: 241731
			[Token(Token = "0x403B043")]
			private const float FADE_OUT_DUR = 0.18f;

			// Token: 0x0403B044 RID: 241732
			[Token(Token = "0x403B044")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403B045 RID: 241733
			[Token(Token = "0x403B045")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403B046 RID: 241734
			[Token(Token = "0x403B046")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403B047 RID: 241735
			[Token(Token = "0x403B047")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
