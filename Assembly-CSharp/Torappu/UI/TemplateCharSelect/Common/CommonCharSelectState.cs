using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C00 RID: 23552
	[Token(Token = "0x2005C00")]
	public class CommonCharSelectState : PopupFadeState, ITemplateCharSelectCtrlHost
	{
		// Token: 0x17004FEA RID: 20458
		// (get) Token: 0x0602222B RID: 139819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FEA")]
		public TemplateCharSelectMainProperty prop
		{
			[Token(Token = "0x602222B")]
			[Address(RVA = "0x1C8A660", Offset = "0x1C89260", VA = "0x181C8A660", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602222C RID: 139820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602222C")]
		[Address(RVA = "0x1C88C70", Offset = "0x1C87870", VA = "0x181C88C70", Slot = "32")]
		public void Ensure()
		{
		}

		// Token: 0x0602222D RID: 139821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602222D")]
		[Address(RVA = "0x1C88BF0", Offset = "0x1C877F0", VA = "0x181C88BF0", Slot = "33")]
		public void Cancel()
		{
		}

		// Token: 0x0602222E RID: 139822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602222E")]
		[Address(RVA = "0x1C897A0", Offset = "0x1C883A0", VA = "0x181C897A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602222F RID: 139823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602222F")]
		[Address(RVA = "0x1C88DB0", Offset = "0x1C879B0", VA = "0x181C88DB0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022230 RID: 139824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022230")]
		[Address(RVA = "0x1C89370", Offset = "0x1C87F70", VA = "0x181C89370", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06022231 RID: 139825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022231")]
		[Address(RVA = "0x1C89300", Offset = "0x1C87F00", VA = "0x181C89300", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06022232 RID: 139826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022232")]
		[Address(RVA = "0x1C88D50", Offset = "0x1C87950", VA = "0x181C88D50")]
		private void OnDestroy()
		{
		}

		// Token: 0x06022233 RID: 139827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022233")]
		[Address(RVA = "0x1C88CF0", Offset = "0x1C878F0", VA = "0x181C88CF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022234 RID: 139828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022234")]
		[Address(RVA = "0x1C894C0", Offset = "0x1C880C0", VA = "0x181C894C0")]
		protected TemplateCharSelectCardViewModel _CreateCardViewModel(int instId, TemplateCharSelectCharInputData inputNullable, [Optional] PlayerCharacter playerData)
		{
			return null;
		}

		// Token: 0x06022235 RID: 139829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022235")]
		[Address(RVA = "0x1C89FB0", Offset = "0x1C88BB0", VA = "0x181C89FB0")]
		protected void _SetUpTopMenuHolderInState(bool hasTopMenuInState)
		{
		}

		// Token: 0x06022236 RID: 139830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022236")]
		[Address(RVA = "0x1C8A240", Offset = "0x1C88E40", VA = "0x181C8A240")]
		private void _TryRaiseAVGSignal()
		{
		}

		// Token: 0x06022237 RID: 139831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022237")]
		[Address(RVA = "0x1C8A160", Offset = "0x1C88D60", VA = "0x181C8A160")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x06022238 RID: 139832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022238")]
		[Address(RVA = "0x1C8A3E0", Offset = "0x1C88FE0", VA = "0x181C8A3E0")]
		private IEnumerator _WaitAndTriggerTutorialAVG()
		{
			return null;
		}

		// Token: 0x06022239 RID: 139833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022239")]
		[Address(RVA = "0x1C8A490", Offset = "0x1C89090", VA = "0x181C8A490")]
		public CommonCharSelectState()
		{
		}

		// Token: 0x0602223C RID: 139836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602223C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602223D RID: 139837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602223D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602223E RID: 139838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602223E")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0402ECDE RID: 191710
		[Token(Token = "0x402ECDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		public TemplateCharSelectController _controller;

		// Token: 0x0402ECDF RID: 191711
		[Token(Token = "0x402ECDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0402ECE0 RID: 191712
		[Token(Token = "0x402ECE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _rectBackPress;

		// Token: 0x0402ECE1 RID: 191713
		[Token(Token = "0x402ECE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CommonCharSelectStateBean m_stateBean;

		// Token: 0x0402ECE2 RID: 191714
		[Token(Token = "0x402ECE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x0402ECE3 RID: 191715
		[Token(Token = "0x402ECE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0402ECE4 RID: 191716
		[Token(Token = "0x402ECE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0402ECE5 RID: 191717
		[Token(Token = "0x402ECE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Ensure;

		// Token: 0x0402ECE6 RID: 191718
		[Token(Token = "0x402ECE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Cancel;

		// Token: 0x0402ECE7 RID: 191719
		[Token(Token = "0x402ECE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402ECE8 RID: 191720
		[Token(Token = "0x402ECE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402ECE9 RID: 191721
		[Token(Token = "0x402ECE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402ECEA RID: 191722
		[Token(Token = "0x402ECEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0402ECEB RID: 191723
		[Token(Token = "0x402ECEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402ECEC RID: 191724
		[Token(Token = "0x402ECEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402ECED RID: 191725
		[Token(Token = "0x402ECED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CreateCardViewModel;

		// Token: 0x0402ECEE RID: 191726
		[Token(Token = "0x402ECEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetUpTopMenuHolderInState;

		// Token: 0x0402ECEF RID: 191727
		[Token(Token = "0x402ECEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryRaiseAVGSignal;

		// Token: 0x0402ECF0 RID: 191728
		[Token(Token = "0x402ECF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0402ECF1 RID: 191729
		[Token(Token = "0x402ECF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__WaitAndTriggerTutorialAVG;

		// Token: 0x0402ECF2 RID: 191730
		[Token(Token = "0x402ECF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
