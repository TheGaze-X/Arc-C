using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058E0 RID: 22752
	[Token(Token = "0x20058E0")]
	public class CrossAppSharePage : UIPage
	{
		// Token: 0x060212D6 RID: 135894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212D6")]
		[Address(RVA = "0x1B74790", Offset = "0x1B73390", VA = "0x181B74790", Slot = "8")]
		protected override void OnCreate(DataBundle savedInstance)
		{
		}

		// Token: 0x060212D7 RID: 135895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60212D7")]
		[Address(RVA = "0x1B74C30", Offset = "0x1B73830", VA = "0x181B74C30", Slot = "12")]
		public override IEnumerator ShowCoroutine(bool isFromStack)
		{
			return null;
		}

		// Token: 0x060212D8 RID: 135896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60212D8")]
		[Address(RVA = "0x1B746B0", Offset = "0x1B732B0", VA = "0x181B746B0", Slot = "13")]
		protected override IEnumerator HideCoroutine(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x060212D9 RID: 135897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212D9")]
		[Address(RVA = "0x1B75580", Offset = "0x1B74180", VA = "0x181B75580")]
		private void _StartShare(CrossAppSharePage.InputParam inputParam)
		{
		}

		// Token: 0x060212DA RID: 135898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60212DA")]
		[Address(RVA = "0x1B75420", Offset = "0x1B74020", VA = "0x181B75420")]
		private IEnumerator _ShareCorot(CrossAppShareController.InputOption option)
		{
			return null;
		}

		// Token: 0x060212DB RID: 135899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212DB")]
		[Address(RVA = "0x1B74A50", Offset = "0x1B73650", VA = "0x181B74A50", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060212DC RID: 135900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212DC")]
		[Address(RVA = "0x1B75260", Offset = "0x1B73E60", VA = "0x181B75260")]
		private void _OnClosePanel(Action onFinish)
		{
		}

		// Token: 0x060212DD RID: 135901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212DD")]
		[Address(RVA = "0x1B74EC0", Offset = "0x1B73AC0", VA = "0x181B74EC0")]
		private void _ConfirmCrossAppShareMission(string missionId, Action onFinish)
		{
		}

		// Token: 0x060212DE RID: 135902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212DE")]
		[Address(RVA = "0x1B745F0", Offset = "0x1B731F0", VA = "0x181B745F0")]
		public void ExitShareWithoutUnRegister()
		{
		}

		// Token: 0x060212DF RID: 135903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60212DF")]
		[Address(RVA = "0x1B74AD0", Offset = "0x1B736D0", VA = "0x181B74AD0")]
		public IEnumerator PlayFlashInAnim()
		{
			return null;
		}

		// Token: 0x060212E0 RID: 135904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60212E0")]
		[Address(RVA = "0x1B74B80", Offset = "0x1B73780", VA = "0x181B74B80")]
		public IEnumerator PlayFlashOutAnim()
		{
			return null;
		}

		// Token: 0x060212E1 RID: 135905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212E1")]
		[Address(RVA = "0x1B752F0", Offset = "0x1B73EF0", VA = "0x181B752F0")]
		private void _ReceiveRewards(List<RewardItemModel> items)
		{
		}

		// Token: 0x060212E2 RID: 135906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212E2")]
		[Address(RVA = "0x1B74D00", Offset = "0x1B73900", VA = "0x181B74D00")]
		private void _BindBackPressWhenSDKDisabled()
		{
		}

		// Token: 0x060212E3 RID: 135907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212E3")]
		[Address(RVA = "0x1B75AE0", Offset = "0x1B746E0", VA = "0x181B75AE0")]
		public CrossAppSharePage()
		{
		}

		// Token: 0x060212E8 RID: 135912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212E8")]
		[Address(RVA = "0xE98770", Offset = "0xE97370", VA = "0x180E98770")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x060212E9 RID: 135913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60212E9")]
		[Address(RVA = "0xE987B0", Offset = "0xE973B0", VA = "0x180E987B0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(bool P0)
		{
			return null;
		}

		// Token: 0x060212EA RID: 135914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60212EA")]
		[Address(RVA = "0xE98760", Offset = "0xE97360", VA = "0x180E98760")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x060212EB RID: 135915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212EB")]
		[Address(RVA = "0x12172F0", Offset = "0x1215EF0", VA = "0x1812172F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0402D327 RID: 185127
		[Token(Token = "0x402D327")]
		private const float DEFAULT_FADE_DURATION = 0.23f;

		// Token: 0x0402D328 RID: 185128
		[Token(Token = "0x402D328")]
		private const float DEFAULT_HIDE_ALPHA = 0f;

		// Token: 0x0402D329 RID: 185129
		[Token(Token = "0x402D329")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private RectTransform _remakeContent;

		// Token: 0x0402D32A RID: 185130
		[Token(Token = "0x402D32A")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIRenderTextureImage _background;

		// Token: 0x0402D32B RID: 185131
		[Token(Token = "0x402D32B")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Camera _remakeCamera;

		// Token: 0x0402D32C RID: 185132
		[Token(Token = "0x402D32C")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Canvas _remakeCanvas;

		// Token: 0x0402D32D RID: 185133
		[Token(Token = "0x402D32D")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIAnimationLocation _flashInAnim;

		// Token: 0x0402D32E RID: 185134
		[Token(Token = "0x402D32E")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIAnimationLocation _flashOutAnim;

		// Token: 0x0402D32F RID: 185135
		[Token(Token = "0x402D32F")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private CanvasGroup _pageCanvasGroup;

		// Token: 0x0402D330 RID: 185136
		[Token(Token = "0x402D330")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0402D331 RID: 185137
		[Token(Token = "0x402D331")]
		[FieldOffset(Offset = "0x128")]
		private CrossAppShareController m_controller;

		// Token: 0x0402D332 RID: 185138
		[Token(Token = "0x402D332")]
		[FieldOffset(Offset = "0x130")]
		private Tween m_flashInTween;

		// Token: 0x0402D333 RID: 185139
		[Token(Token = "0x402D333")]
		[FieldOffset(Offset = "0x138")]
		private Tween m_flashOutTween;

		// Token: 0x0402D334 RID: 185140
		[Token(Token = "0x402D334")]
		[FieldOffset(Offset = "0x140")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0402D335 RID: 185141
		[Token(Token = "0x402D335")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402D336 RID: 185142
		[Token(Token = "0x402D336")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0402D337 RID: 185143
		[Token(Token = "0x402D337")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0402D338 RID: 185144
		[Token(Token = "0x402D338")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__StartShare;

		// Token: 0x0402D339 RID: 185145
		[Token(Token = "0x402D339")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShareCorot;

		// Token: 0x0402D33A RID: 185146
		[Token(Token = "0x402D33A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402D33B RID: 185147
		[Token(Token = "0x402D33B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnClosePanel;

		// Token: 0x0402D33C RID: 185148
		[Token(Token = "0x402D33C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ConfirmCrossAppShareMission;

		// Token: 0x0402D33D RID: 185149
		[Token(Token = "0x402D33D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ExitShareWithoutUnRegister;

		// Token: 0x0402D33E RID: 185150
		[Token(Token = "0x402D33E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_PlayFlashInAnim;

		// Token: 0x0402D33F RID: 185151
		[Token(Token = "0x402D33F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_PlayFlashOutAnim;

		// Token: 0x0402D340 RID: 185152
		[Token(Token = "0x402D340")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ReceiveRewards;

		// Token: 0x0402D341 RID: 185153
		[Token(Token = "0x402D341")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__BindBackPressWhenSDKDisabled;

		// Token: 0x0402D342 RID: 185154
		[Token(Token = "0x402D342")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020058E1 RID: 22753
		[Token(Token = "0x20058E1")]
		public struct InputParam : ILuaCallCSharp
		{
			// Token: 0x0402D343 RID: 185155
			[Token(Token = "0x402D343")]
			[FieldOffset(Offset = "0x0")]
			public CrossAppShareRemakeController remakePrefab;

			// Token: 0x0402D344 RID: 185156
			[Token(Token = "0x402D344")]
			[FieldOffset(Offset = "0x8")]
			public string remakePrefabPath;

			// Token: 0x0402D345 RID: 185157
			[Token(Token = "0x402D345")]
			[FieldOffset(Offset = "0x10")]
			public ICrossAppShareModelCollector modelCollector;

			// Token: 0x0402D346 RID: 185158
			[Token(Token = "0x402D346")]
			[FieldOffset(Offset = "0x18")]
			public ICrossAppShareRemakeAdditionBaseModel additionModel;

			// Token: 0x0402D347 RID: 185159
			[Token(Token = "0x402D347")]
			[FieldOffset(Offset = "0x20")]
			public string shareMissionId;

			// Token: 0x0402D348 RID: 185160
			[Token(Token = "0x402D348")]
			[FieldOffset(Offset = "0x28")]
			public CrossAppShareDisplayEffects.EffectType effectType;
		}
	}
}
