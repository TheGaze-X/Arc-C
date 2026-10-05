using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200542B RID: 21547
	[Token(Token = "0x200542B")]
	public class RoguelikeDungeonPage : StateEnginePage, IMobileTouchPage, IHotfixable
	{
		// Token: 0x17004A43 RID: 19011
		// (get) Token: 0x0601FB1D RID: 129821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A43")]
		public string topicId
		{
			[Token(Token = "0x601FB1D")]
			[Address(RVA = "0x196AF20", Offset = "0x1969B20", VA = "0x18196AF20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FB1E RID: 129822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB1E")]
		public TEffect AttachRoguelikeEffect<TEffect>(TEffect effectPrefab) where TEffect : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0601FB1F RID: 129823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FB1F")]
		[Address(RVA = "0x1969A20", Offset = "0x1968620", VA = "0x181969A20", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601FB20 RID: 129824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB20")]
		[Address(RVA = "0x1969970", Offset = "0x1968570", VA = "0x181969970", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601FB21 RID: 129825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB21")]
		[Address(RVA = "0x19697C0", Offset = "0x19683C0", VA = "0x1819697C0", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0601FB22 RID: 129826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB22")]
		[Address(RVA = "0x19696E0", Offset = "0x19682E0", VA = "0x1819696E0", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0601FB23 RID: 129827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FB23")]
		[Address(RVA = "0x1969880", Offset = "0x1968480", VA = "0x181969880", Slot = "29")]
		public void EnableMobileTouch(bool enable)
		{
		}

		// Token: 0x0601FB24 RID: 129828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB24")]
		[Address(RVA = "0x196AD60", Offset = "0x1969960", VA = "0x18196AD60")]
		private IEnumerator _RouteToProperState()
		{
			return null;
		}

		// Token: 0x0601FB25 RID: 129829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB25")]
		[Address(RVA = "0x196A710", Offset = "0x1969310", VA = "0x18196A710")]
		private IEnumerator _JumpToInitProcess()
		{
			return null;
		}

		// Token: 0x0601FB26 RID: 129830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB26")]
		[Address(RVA = "0x196A010", Offset = "0x1968C10", VA = "0x18196A010")]
		private IEnumerator _HandlePending()
		{
			return null;
		}

		// Token: 0x0601FB27 RID: 129831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB27")]
		[Address(RVA = "0x196AB50", Offset = "0x1969750", VA = "0x18196AB50")]
		private IEnumerator _JumpToSacrificeInChoiceScene()
		{
			return null;
		}

		// Token: 0x0601FB28 RID: 129832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB28")]
		[Address(RVA = "0x196A660", Offset = "0x1969260", VA = "0x18196A660")]
		private IEnumerator _JumpToGildInChoiceScene()
		{
			return null;
		}

		// Token: 0x0601FB29 RID: 129833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB29")]
		[Address(RVA = "0x196AC00", Offset = "0x1969800", VA = "0x18196AC00")]
		private IEnumerator _JumpToStashedTicketUseInChoiceScene()
		{
			return null;
		}

		// Token: 0x0601FB2A RID: 129834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB2A")]
		[Address(RVA = "0x196A500", Offset = "0x1969100", VA = "0x18196A500")]
		private IEnumerator _JumpToExpeditionInChoiceScene()
		{
			return null;
		}

		// Token: 0x0601FB2B RID: 129835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB2B")]
		[Address(RVA = "0x196A0C0", Offset = "0x1968CC0", VA = "0x18196A0C0")]
		private IEnumerator _JumpToAlchemy()
		{
			return null;
		}

		// Token: 0x0601FB2C RID: 129836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB2C")]
		[Address(RVA = "0x196ACB0", Offset = "0x19698B0", VA = "0x18196ACB0")]
		private IEnumerator _JumpToSwapCopper()
		{
			return null;
		}

		// Token: 0x0601FB2D RID: 129837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB2D")]
		[Address(RVA = "0x196A2F0", Offset = "0x1968EF0", VA = "0x18196A2F0")]
		private IEnumerator _JumpToDrawCopper()
		{
			return null;
		}

		// Token: 0x0601FB2E RID: 129838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB2E")]
		[Address(RVA = "0x1969F60", Offset = "0x1968B60", VA = "0x181969F60")]
		private IEnumerator _HandleDice()
		{
			return null;
		}

		// Token: 0x0601FB2F RID: 129839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB2F")]
		[Address(RVA = "0x196AE10", Offset = "0x1969A10", VA = "0x18196AE10")]
		private IEnumerator _RouteToRoguelikeDicePage()
		{
			return null;
		}

		// Token: 0x0601FB30 RID: 129840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FB30")]
		[Address(RVA = "0x1969C30", Offset = "0x1968830", VA = "0x181969C30")]
		private void _CreateRecruitInput(PlayerRoguelikePendingEvent firstPendingEvent)
		{
		}

		// Token: 0x0601FB31 RID: 129841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB31")]
		[Address(RVA = "0x196A920", Offset = "0x1969520", VA = "0x18196A920")]
		private IEnumerator _JumpToRecruitInCommonShop(bool canBattle)
		{
			return null;
		}

		// Token: 0x0601FB32 RID: 129842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB32")]
		[Address(RVA = "0x196A7C0", Offset = "0x19693C0", VA = "0x18196A7C0")]
		private IEnumerator _JumpToRecruitInBattleReward()
		{
			return null;
		}

		// Token: 0x0601FB33 RID: 129843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB33")]
		[Address(RVA = "0x196A9F0", Offset = "0x19695F0", VA = "0x18196A9F0")]
		private IEnumerator _JumpToRecruitInStashedTicketUse()
		{
			return null;
		}

		// Token: 0x0601FB34 RID: 129844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB34")]
		[Address(RVA = "0x196A870", Offset = "0x1969470", VA = "0x18196A870")]
		private IEnumerator _JumpToRecruitInChoiceScene()
		{
			return null;
		}

		// Token: 0x0601FB35 RID: 129845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB35")]
		[Address(RVA = "0x196AAA0", Offset = "0x19696A0", VA = "0x18196AAA0")]
		private IEnumerator _JumpToReward()
		{
			return null;
		}

		// Token: 0x0601FB36 RID: 129846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB36")]
		[Address(RVA = "0x196A220", Offset = "0x1968E20", VA = "0x18196A220")]
		private IEnumerator _JumpToCommonShop(bool canBattle)
		{
			return null;
		}

		// Token: 0x0601FB37 RID: 129847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB37")]
		[Address(RVA = "0x196A170", Offset = "0x1968D70", VA = "0x18196A170")]
		private IEnumerator _JumpToChoiceScene()
		{
			return null;
		}

		// Token: 0x0601FB38 RID: 129848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB38")]
		[Address(RVA = "0x196A5B0", Offset = "0x19691B0", VA = "0x18196A5B0")]
		private IEnumerator _JumpToFocus()
		{
			return null;
		}

		// Token: 0x0601FB39 RID: 129849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB39")]
		[Address(RVA = "0x196A3A0", Offset = "0x1968FA0", VA = "0x18196A3A0")]
		private IEnumerator _JumpToDungeon()
		{
			return null;
		}

		// Token: 0x0601FB3A RID: 129850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB3A")]
		[Address(RVA = "0x196A450", Offset = "0x1969050", VA = "0x18196A450")]
		private IEnumerator _JumpToEnd()
		{
			return null;
		}

		// Token: 0x0601FB3B RID: 129851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB3B")]
		[Address(RVA = "0x1969EB0", Offset = "0x1968AB0", VA = "0x181969EB0")]
		private IEnumerator _EffectOnShow()
		{
			return null;
		}

		// Token: 0x0601FB3C RID: 129852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB3C")]
		[Address(RVA = "0x1969E00", Offset = "0x1968A00", VA = "0x181969E00")]
		private IEnumerator _EffectOnHide()
		{
			return null;
		}

		// Token: 0x0601FB3D RID: 129853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB3D")]
		[Address(RVA = "0x1969AB0", Offset = "0x19686B0", VA = "0x181969AB0")]
		private List<CanvasGroup> _AchievePageCanvasGroups()
		{
			return null;
		}

		// Token: 0x0601FB3E RID: 129854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FB3E")]
		[Address(RVA = "0x196AEC0", Offset = "0x1969AC0", VA = "0x18196AEC0")]
		public RoguelikeDungeonPage()
		{
		}

		// Token: 0x0601FB40 RID: 129856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FB40")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601FB41 RID: 129857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB41")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601FB42 RID: 129858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB42")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0601FB43 RID: 129859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FB43")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0402ABE0 RID: 175072
		[Token(Token = "0x402ABE0")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CanvasGroup _fadeFloatPanel;

		// Token: 0x0402ABE1 RID: 175073
		[Token(Token = "0x402ABE1")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RoguelikeEffectManager _effectManager;

		// Token: 0x0402ABE2 RID: 175074
		[Token(Token = "0x402ABE2")]
		[FieldOffset(Offset = "0x100")]
		private DataBundle m_savedInst;

		// Token: 0x0402ABE3 RID: 175075
		[Token(Token = "0x402ABE3")]
		[FieldOffset(Offset = "0x108")]
		private bool m_routeToAnotherPage;

		// Token: 0x0402ABE4 RID: 175076
		[Token(Token = "0x402ABE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402ABE5 RID: 175077
		[Token(Token = "0x402ABE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AttachRoguelikeEffect;

		// Token: 0x0402ABE6 RID: 175078
		[Token(Token = "0x402ABE6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402ABE7 RID: 175079
		[Token(Token = "0x402ABE7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x0402ABE8 RID: 175080
		[Token(Token = "0x402ABE8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0402ABE9 RID: 175081
		[Token(Token = "0x402ABE9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x0402ABEA RID: 175082
		[Token(Token = "0x402ABEA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EnableMobileTouch;

		// Token: 0x0402ABEB RID: 175083
		[Token(Token = "0x402ABEB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RouteToProperState;

		// Token: 0x0402ABEC RID: 175084
		[Token(Token = "0x402ABEC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__JumpToInitProcess;

		// Token: 0x0402ABED RID: 175085
		[Token(Token = "0x402ABED")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HandlePending;

		// Token: 0x0402ABEE RID: 175086
		[Token(Token = "0x402ABEE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__JumpToSacrificeInChoiceScene;

		// Token: 0x0402ABEF RID: 175087
		[Token(Token = "0x402ABEF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__JumpToGildInChoiceScene;

		// Token: 0x0402ABF0 RID: 175088
		[Token(Token = "0x402ABF0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__JumpToStashedTicketUseInChoiceScene;

		// Token: 0x0402ABF1 RID: 175089
		[Token(Token = "0x402ABF1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__JumpToExpeditionInChoiceScene;

		// Token: 0x0402ABF2 RID: 175090
		[Token(Token = "0x402ABF2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__JumpToAlchemy;

		// Token: 0x0402ABF3 RID: 175091
		[Token(Token = "0x402ABF3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__JumpToSwapCopper;

		// Token: 0x0402ABF4 RID: 175092
		[Token(Token = "0x402ABF4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__JumpToDrawCopper;

		// Token: 0x0402ABF5 RID: 175093
		[Token(Token = "0x402ABF5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HandleDice;

		// Token: 0x0402ABF6 RID: 175094
		[Token(Token = "0x402ABF6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__RouteToRoguelikeDicePage;

		// Token: 0x0402ABF7 RID: 175095
		[Token(Token = "0x402ABF7")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CreateRecruitInput;

		// Token: 0x0402ABF8 RID: 175096
		[Token(Token = "0x402ABF8")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__JumpToRecruitInCommonShop;

		// Token: 0x0402ABF9 RID: 175097
		[Token(Token = "0x402ABF9")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__JumpToRecruitInBattleReward;

		// Token: 0x0402ABFA RID: 175098
		[Token(Token = "0x402ABFA")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__JumpToRecruitInStashedTicketUse;

		// Token: 0x0402ABFB RID: 175099
		[Token(Token = "0x402ABFB")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__JumpToRecruitInChoiceScene;

		// Token: 0x0402ABFC RID: 175100
		[Token(Token = "0x402ABFC")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__JumpToReward;

		// Token: 0x0402ABFD RID: 175101
		[Token(Token = "0x402ABFD")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__JumpToCommonShop;

		// Token: 0x0402ABFE RID: 175102
		[Token(Token = "0x402ABFE")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__JumpToChoiceScene;

		// Token: 0x0402ABFF RID: 175103
		[Token(Token = "0x402ABFF")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__JumpToFocus;

		// Token: 0x0402AC00 RID: 175104
		[Token(Token = "0x402AC00")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__JumpToDungeon;

		// Token: 0x0402AC01 RID: 175105
		[Token(Token = "0x402AC01")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__JumpToEnd;

		// Token: 0x0402AC02 RID: 175106
		[Token(Token = "0x402AC02")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__EffectOnShow;

		// Token: 0x0402AC03 RID: 175107
		[Token(Token = "0x402AC03")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__EffectOnHide;

		// Token: 0x0402AC04 RID: 175108
		[Token(Token = "0x402AC04")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__AchievePageCanvasGroups;

		// Token: 0x0402AC05 RID: 175109
		[Token(Token = "0x402AC05")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200542C RID: 21548
		[Token(Token = "0x200542C")]
		public class Params
		{
			// Token: 0x0601FB44 RID: 129860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FB44")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0402AC06 RID: 175110
			[Token(Token = "0x402AC06")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0402AC07 RID: 175111
			[Token(Token = "0x402AC07")]
			[FieldOffset(Offset = "0x18")]
			public bool needCleanSquadLocalCache;

			// Token: 0x0402AC08 RID: 175112
			[Token(Token = "0x402AC08")]
			[FieldOffset(Offset = "0x20")]
			public List<RoguelikeItemBundle> itemsBeforeStart;
		}
	}
}
