using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004317 RID: 17175
	[Token(Token = "0x2004317")]
	public class SandboxV2HomeController : SandboxPermHomeControllerBase
	{
		// Token: 0x0601A60F RID: 108047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A60F")]
		[Address(RVA = "0x134CE80", Offset = "0x134BA80", VA = "0x18134CE80", Slot = "4")]
		public override void Init(string topicId)
		{
		}

		// Token: 0x0601A610 RID: 108048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A610")]
		[Address(RVA = "0x134CD20", Offset = "0x134B920", VA = "0x18134CD20", Slot = "5")]
		public override string GetTopicId()
		{
			return null;
		}

		// Token: 0x0601A611 RID: 108049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A611")]
		[Address(RVA = "0x134D050", Offset = "0x134BC50", VA = "0x18134D050", Slot = "6")]
		public override void OnResume(bool isResumedFromStack)
		{
		}

		// Token: 0x0601A612 RID: 108050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A612")]
		[Address(RVA = "0x134CF10", Offset = "0x134BB10", VA = "0x18134CF10")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601A613 RID: 108051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A613")]
		[Address(RVA = "0x134CB40", Offset = "0x134B740", VA = "0x18134CB40", Slot = "7")]
		public override Canvas[] GetNeedBindCanvas()
		{
			return null;
		}

		// Token: 0x0601A614 RID: 108052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A614")]
		[Address(RVA = "0x134CC30", Offset = "0x134B830", VA = "0x18134CC30", Slot = "8")]
		public override UICommonPageEffectHolder[] GetNeedBindEffectHolders()
		{
			return null;
		}

		// Token: 0x0601A615 RID: 108053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A615")]
		[Address(RVA = "0x134CA60", Offset = "0x134B660", VA = "0x18134CA60", Slot = "9")]
		public override string GetMedalGroupId()
		{
			return null;
		}

		// Token: 0x0601A616 RID: 108054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A616")]
		[Address(RVA = "0x134D2B0", Offset = "0x134BEB0", VA = "0x18134D2B0", Slot = "10")]
		public override Coroutine PageOnlyStartShowEffects(bool fastMode, bool backFromBattle)
		{
			return null;
		}

		// Token: 0x0601A617 RID: 108055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A617")]
		[Address(RVA = "0x134D0F0", Offset = "0x134BCF0", VA = "0x18134D0F0", Slot = "11")]
		public override void PageOnlyDisposeEffects()
		{
		}

		// Token: 0x0601A618 RID: 108056 RVA: 0x000A19E8 File Offset: 0x0009FBE8
		[Token(Token = "0x601A618")]
		[Address(RVA = "0x134C7E0", Offset = "0x134B3E0", VA = "0x18134C7E0", Slot = "12")]
		public override bool CheckIfUseFastEnter()
		{
			return default(bool);
		}

		// Token: 0x0601A619 RID: 108057 RVA: 0x000A1A00 File Offset: 0x0009FC00
		[Token(Token = "0x601A619")]
		[Address(RVA = "0x134C880", Offset = "0x134B480", VA = "0x18134C880", Slot = "13")]
		public override SandboxPermHomePage.DisplayTweenConfig GetDisplayTweenConfig(bool fastMode)
		{
			return default(SandboxPermHomePage.DisplayTweenConfig);
		}

		// Token: 0x0601A61A RID: 108058 RVA: 0x000A1A18 File Offset: 0x0009FC18
		[Token(Token = "0x601A61A")]
		[Address(RVA = "0x134CF70", Offset = "0x134BB70", VA = "0x18134CF70", Slot = "14")]
		public override bool OnPageBackPressBtnClick()
		{
			return default(bool);
		}

		// Token: 0x0601A61B RID: 108059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A61B")]
		[Address(RVA = "0x134CD80", Offset = "0x134B980", VA = "0x18134CD80", Slot = "15")]
		public override void HandleCompDialogCallback(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601A61C RID: 108060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A61C")]
		[Address(RVA = "0x134F470", Offset = "0x134E070", VA = "0x18134F470")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A61D RID: 108061 RVA: 0x000A1A30 File Offset: 0x0009FC30
		[Token(Token = "0x601A61D")]
		[Address(RVA = "0x134D940", Offset = "0x134C540", VA = "0x18134D940")]
		private bool _CheckIsInChallenge()
		{
			return default(bool);
		}

		// Token: 0x0601A61E RID: 108062 RVA: 0x000A1A48 File Offset: 0x0009FC48
		[Token(Token = "0x601A61E")]
		[Address(RVA = "0x134FC60", Offset = "0x134E860", VA = "0x18134FC60")]
		private bool _IsHomeStateStable()
		{
			return default(bool);
		}

		// Token: 0x0601A61F RID: 108063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A61F")]
		[Address(RVA = "0x13501C0", Offset = "0x134EDC0", VA = "0x1813501C0")]
		private void _Refresh(bool isInit = false)
		{
		}

		// Token: 0x0601A620 RID: 108064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A620")]
		[Address(RVA = "0x134D9E0", Offset = "0x134C5E0", VA = "0x18134D9E0")]
		private void _EventEnterGame()
		{
		}

		// Token: 0x0601A621 RID: 108065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A621")]
		[Address(RVA = "0x1350050", Offset = "0x134EC50", VA = "0x181350050")]
		private void _OpenDungeonPage(string topic, bool isMonth = false)
		{
		}

		// Token: 0x0601A622 RID: 108066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A622")]
		[Address(RVA = "0x134DE70", Offset = "0x134CA70", VA = "0x18134DE70")]
		private void _EventOnEnterArchive()
		{
		}

		// Token: 0x0601A623 RID: 108067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A623")]
		[Address(RVA = "0x134E620", Offset = "0x134D220", VA = "0x18134E620")]
		private void _EventOnOpenShopPage()
		{
		}

		// Token: 0x0601A624 RID: 108068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A624")]
		[Address(RVA = "0x134ED00", Offset = "0x134D900", VA = "0x18134ED00")]
		private void _EventOpenMedalGroup()
		{
		}

		// Token: 0x0601A625 RID: 108069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A625")]
		[Address(RVA = "0x134DDF0", Offset = "0x134C9F0", VA = "0x18134DDF0")]
		private void _EventEnterMonth()
		{
		}

		// Token: 0x0601A626 RID: 108070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A626")]
		[Address(RVA = "0x134E580", Offset = "0x134D180", VA = "0x18134E580")]
		private void _EventOnOpenGuide()
		{
		}

		// Token: 0x0601A627 RID: 108071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A627")]
		[Address(RVA = "0x134EB20", Offset = "0x134D720", VA = "0x18134EB20")]
		private void _EventOnToggleChallenge(bool selected)
		{
		}

		// Token: 0x0601A628 RID: 108072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A628")]
		[Address(RVA = "0x134DFA0", Offset = "0x134CBA0", VA = "0x18134DFA0")]
		private void _EventOnEnterChallenge()
		{
		}

		// Token: 0x0601A629 RID: 108073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A629")]
		[Address(RVA = "0x134EEB0", Offset = "0x134DAB0", VA = "0x18134EEB0")]
		private void _HandleEnterChallengeConfirm()
		{
		}

		// Token: 0x0601A62A RID: 108074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A62A")]
		[Address(RVA = "0x134E840", Offset = "0x134D440", VA = "0x18134E840")]
		private void _EventOnSettleChallenge()
		{
		}

		// Token: 0x0601A62B RID: 108075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A62B")]
		[Address(RVA = "0x134D560", Offset = "0x134C160", VA = "0x18134D560")]
		private void _HandleSettleChallengeConfirm()
		{
		}

		// Token: 0x0601A62C RID: 108076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A62C")]
		[Address(RVA = "0x134E490", Offset = "0x134D090", VA = "0x18134E490")]
		private void _EventOnOpenChallengeReward()
		{
		}

		// Token: 0x0601A62D RID: 108077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A62D")]
		[Address(RVA = "0x134E2F0", Offset = "0x134CEF0", VA = "0x18134E2F0")]
		private void _EventOnExploreModeClicked()
		{
		}

		// Token: 0x0601A62E RID: 108078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A62E")]
		[Address(RVA = "0x13502B0", Offset = "0x134EEB0", VA = "0x1813502B0")]
		private void _SendSwitchExploreModeService(int mode)
		{
		}

		// Token: 0x0601A62F RID: 108079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A62F")]
		[Address(RVA = "0x134FDB0", Offset = "0x134E9B0", VA = "0x18134FDB0")]
		private void _OnExploreModeServiceCallback()
		{
		}

		// Token: 0x0601A630 RID: 108080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A630")]
		[Address(RVA = "0x134EE30", Offset = "0x134DA30", VA = "0x18134EE30")]
		private void _HandleChallengeRewardDialogCallback(ValueBundle output)
		{
		}

		// Token: 0x0601A631 RID: 108081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A631")]
		[Address(RVA = "0x134F0C0", Offset = "0x134DCC0", VA = "0x18134F0C0")]
		private void _HandleFirstGuideGiveUpConfirm(string topicId)
		{
		}

		// Token: 0x0601A632 RID: 108082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A632")]
		[Address(RVA = "0x134F220", Offset = "0x134DE20", VA = "0x18134F220")]
		private void _HandleSecondGuideGiveUpConfirm(string topicId)
		{
		}

		// Token: 0x0601A633 RID: 108083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A633")]
		[Address(RVA = "0x13505A0", Offset = "0x134F1A0", VA = "0x1813505A0")]
		private void _ShowFirstGuideGiveUpConfirmDialog(Action cancelAction, Action confirmAction)
		{
		}

		// Token: 0x0601A634 RID: 108084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A634")]
		[Address(RVA = "0x1350930", Offset = "0x134F530", VA = "0x181350930")]
		private void _ShowSecondGuideGiveUpConfirmDialog(Action cancelAction, Action confirmAction)
		{
		}

		// Token: 0x0601A635 RID: 108085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A635")]
		[Address(RVA = "0x1350E00", Offset = "0x134FA00", VA = "0x181350E00")]
		private void _TutorialOnly_TryTriggerTutorial()
		{
		}

		// Token: 0x0601A636 RID: 108086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A636")]
		[Address(RVA = "0x1350D50", Offset = "0x134F950", VA = "0x181350D50")]
		private IEnumerator _TryTriggerTutorial()
		{
			return null;
		}

		// Token: 0x0601A637 RID: 108087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A637")]
		[Address(RVA = "0x1350CC0", Offset = "0x134F8C0", VA = "0x181350CC0")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x0601A638 RID: 108088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A638")]
		[Address(RVA = "0x1350FB0", Offset = "0x134FBB0", VA = "0x181350FB0")]
		public SandboxV2HomeController()
		{
		}

		// Token: 0x0601A63F RID: 108095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A63F")]
		[Address(RVA = "0x134D540", Offset = "0x134C140", VA = "0x18134D540")]
		private void <>xLuaBaseProxy_OnResume(bool P0)
		{
		}

		// Token: 0x0601A640 RID: 108096 RVA: 0x000A1A60 File Offset: 0x0009FC60
		[Token(Token = "0x601A640")]
		[Address(RVA = "0x134D530", Offset = "0x134C130", VA = "0x18134D530")]
		private bool <>xLuaBaseProxy_OnPageBackPressBtnClick()
		{
			return default(bool);
		}

		// Token: 0x0601A641 RID: 108097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A641")]
		[Address(RVA = "0x134D500", Offset = "0x134C100", VA = "0x18134D500")]
		private void <>xLuaBaseProxy_HandleCompDialogCallback(int P0, ValueBundle P1)
		{
		}

		// Token: 0x040217FD RID: 137213
		[Token(Token = "0x40217FD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SandboxV2HomeView _homeView;

		// Token: 0x040217FE RID: 137214
		[Token(Token = "0x40217FE")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x040217FF RID: 137215
		[Token(Token = "0x40217FF")]
		[FieldOffset(Offset = "0x40")]
		private string m_topicId;

		// Token: 0x04021800 RID: 137216
		[Token(Token = "0x4021800")]
		[FieldOffset(Offset = "0x48")]
		private SandboxV2HomeModelProperty m_prop;

		// Token: 0x04021801 RID: 137217
		[Token(Token = "0x4021801")]
		[FieldOffset(Offset = "0x50")]
		private int m_challengeRewardDialogInst;

		// Token: 0x04021802 RID: 137218
		[Token(Token = "0x4021802")]
		[FieldOffset(Offset = "0x58")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x04021803 RID: 137219
		[Token(Token = "0x4021803")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04021804 RID: 137220
		[Token(Token = "0x4021804")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04021805 RID: 137221
		[Token(Token = "0x4021805")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTopicId;

		// Token: 0x04021806 RID: 137222
		[Token(Token = "0x4021806")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04021807 RID: 137223
		[Token(Token = "0x4021807")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04021808 RID: 137224
		[Token(Token = "0x4021808")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetNeedBindCanvas;

		// Token: 0x04021809 RID: 137225
		[Token(Token = "0x4021809")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetNeedBindEffectHolders;

		// Token: 0x0402180A RID: 137226
		[Token(Token = "0x402180A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetMedalGroupId;

		// Token: 0x0402180B RID: 137227
		[Token(Token = "0x402180B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PageOnlyStartShowEffects;

		// Token: 0x0402180C RID: 137228
		[Token(Token = "0x402180C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_PageOnlyDisposeEffects;

		// Token: 0x0402180D RID: 137229
		[Token(Token = "0x402180D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfUseFastEnter;

		// Token: 0x0402180E RID: 137230
		[Token(Token = "0x402180E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetDisplayTweenConfig;

		// Token: 0x0402180F RID: 137231
		[Token(Token = "0x402180F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnPageBackPressBtnClick;

		// Token: 0x04021810 RID: 137232
		[Token(Token = "0x4021810")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HandleCompDialogCallback;

		// Token: 0x04021811 RID: 137233
		[Token(Token = "0x4021811")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021812 RID: 137234
		[Token(Token = "0x4021812")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckIsInChallenge;

		// Token: 0x04021813 RID: 137235
		[Token(Token = "0x4021813")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__IsHomeStateStable;

		// Token: 0x04021814 RID: 137236
		[Token(Token = "0x4021814")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x04021815 RID: 137237
		[Token(Token = "0x4021815")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EventEnterGame;

		// Token: 0x04021816 RID: 137238
		[Token(Token = "0x4021816")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OpenDungeonPage;

		// Token: 0x04021817 RID: 137239
		[Token(Token = "0x4021817")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__EventOnEnterArchive;

		// Token: 0x04021818 RID: 137240
		[Token(Token = "0x4021818")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__EventOnOpenShopPage;

		// Token: 0x04021819 RID: 137241
		[Token(Token = "0x4021819")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__EventOpenMedalGroup;

		// Token: 0x0402181A RID: 137242
		[Token(Token = "0x402181A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__EventEnterMonth;

		// Token: 0x0402181B RID: 137243
		[Token(Token = "0x402181B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__EventOnOpenGuide;

		// Token: 0x0402181C RID: 137244
		[Token(Token = "0x402181C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__EventOnToggleChallenge;

		// Token: 0x0402181D RID: 137245
		[Token(Token = "0x402181D")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__EventOnEnterChallenge;

		// Token: 0x0402181E RID: 137246
		[Token(Token = "0x402181E")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__HandleEnterChallengeConfirm;

		// Token: 0x0402181F RID: 137247
		[Token(Token = "0x402181F")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__EventOnSettleChallenge;

		// Token: 0x04021820 RID: 137248
		[Token(Token = "0x4021820")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__HandleSettleChallengeConfirm;

		// Token: 0x04021821 RID: 137249
		[Token(Token = "0x4021821")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__EventOnOpenChallengeReward;

		// Token: 0x04021822 RID: 137250
		[Token(Token = "0x4021822")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__EventOnExploreModeClicked;

		// Token: 0x04021823 RID: 137251
		[Token(Token = "0x4021823")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__SendSwitchExploreModeService;

		// Token: 0x04021824 RID: 137252
		[Token(Token = "0x4021824")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__OnExploreModeServiceCallback;

		// Token: 0x04021825 RID: 137253
		[Token(Token = "0x4021825")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__HandleChallengeRewardDialogCallback;

		// Token: 0x04021826 RID: 137254
		[Token(Token = "0x4021826")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__HandleFirstGuideGiveUpConfirm;

		// Token: 0x04021827 RID: 137255
		[Token(Token = "0x4021827")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__HandleSecondGuideGiveUpConfirm;

		// Token: 0x04021828 RID: 137256
		[Token(Token = "0x4021828")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__ShowFirstGuideGiveUpConfirmDialog;

		// Token: 0x04021829 RID: 137257
		[Token(Token = "0x4021829")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__ShowSecondGuideGiveUpConfirmDialog;

		// Token: 0x0402182A RID: 137258
		[Token(Token = "0x402182A")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryTriggerTutorial;

		// Token: 0x0402182B RID: 137259
		[Token(Token = "0x402182B")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorial;

		// Token: 0x0402182C RID: 137260
		[Token(Token = "0x402182C")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0402182D RID: 137261
		[Token(Token = "0x402182D")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
