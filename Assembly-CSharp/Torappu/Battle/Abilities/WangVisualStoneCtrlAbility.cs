using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BBC RID: 11196
	[Token(Token = "0x2002BBC")]
	public class WangVisualStoneCtrlAbility : CastOnTileAbility
	{
		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x06012E85 RID: 77445 RVA: 0x00073E78 File Offset: 0x00072078
		[Token(Token = "0x170029B8")]
		public bool hasRemainingBuildCnt
		{
			[Token(Token = "0x6012E85")]
			[Address(RVA = "0xAD7200", Offset = "0xAD5E00", VA = "0x180AD7200")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012E86 RID: 77446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E86")]
		[Address(RVA = "0xAD68D0", Offset = "0xAD54D0", VA = "0x180AD68D0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012E87 RID: 77447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E87")]
		[Address(RVA = "0xAD6D60", Offset = "0xAD5960", VA = "0x180AD6D60", Slot = "58")]
		public override void PreloadSpecialAudioSignals(string abilityId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x06012E88 RID: 77448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E88")]
		[Address(RVA = "0xAD6CC0", Offset = "0xAD58C0", VA = "0x180AD6CC0", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012E89 RID: 77449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E89")]
		[Address(RVA = "0xAD6AF0", Offset = "0xAD56F0", VA = "0x180AD6AF0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012E8A RID: 77450 RVA: 0x00073E90 File Offset: 0x00072090
		[Token(Token = "0x6012E8A")]
		[Address(RVA = "0xAD6570", Offset = "0xAD5170", VA = "0x180AD6570", Slot = "33")]
		public override bool CastDirectly([Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012E8B RID: 77451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E8B")]
		[Address(RVA = "0xAD67A0", Offset = "0xAD53A0", VA = "0x180AD67A0")]
		public void ClearAllPendingRequests()
		{
		}

		// Token: 0x06012E8C RID: 77452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E8C")]
		[Address(RVA = "0xAD6FE0", Offset = "0xAD5BE0", VA = "0x180AD6FE0")]
		public void RemoveStoneMark(GridPosition pos, bool isOverlapped = false)
		{
		}

		// Token: 0x06012E8D RID: 77453 RVA: 0x00073EA8 File Offset: 0x000720A8
		[Token(Token = "0x6012E8D")]
		[Address(RVA = "0xAD61F0", Offset = "0xAD4DF0", VA = "0x180AD61F0")]
		public bool BuildStone(WangStoneTriggerManager.BuildStoneRequest request, out bool extraBuildUsedUp, out bool buildPosUsedUp)
		{
			return default(bool);
		}

		// Token: 0x06012E8E RID: 77454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E8E")]
		[Address(RVA = "0xAD6EF0", Offset = "0xAD5AF0", VA = "0x180AD6EF0")]
		public void RemoveBuildRequest(WangStoneTriggerManager.BuildStoneRequest request)
		{
		}

		// Token: 0x06012E8F RID: 77455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E8F")]
		[Address(RVA = "0xAD7090", Offset = "0xAD5C90", VA = "0x180AD7090")]
		private void _OnSubAbilityFinished(Ability ability, Ability.FinishReason reason, bool resetCd)
		{
		}

		// Token: 0x06012E90 RID: 77456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012E90")]
		[Address(RVA = "0xAD6C50", Offset = "0xAD5850", VA = "0x180AD6C50", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012E91 RID: 77457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E91")]
		[Address(RVA = "0xAD7170", Offset = "0xAD5D70", VA = "0x180AD7170")]
		public WangVisualStoneCtrlAbility()
		{
		}

		// Token: 0x06012E92 RID: 77458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E92")]
		[Address(RVA = "0xA27580", Offset = "0xA26180", VA = "0x180A27580")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012E93 RID: 77459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E93")]
		[Address(RVA = "0xA66040", Offset = "0xA64C40", VA = "0x180A66040")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x06012E94 RID: 77460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E94")]
		[Address(RVA = "0xA4FF70", Offset = "0xA4EB70", VA = "0x180A4FF70")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012E95 RID: 77461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E95")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012E96 RID: 77462 RVA: 0x00073EC0 File Offset: 0x000720C0
		[Token(Token = "0x6012E96")]
		[Address(RVA = "0xA225E0", Offset = "0xA211E0", VA = "0x180A225E0")]
		private bool <>xLuaBaseProxy_CastDirectly(Ability.FinishCallbackDelegate P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0401554B RID: 87371
		[Token(Token = "0x401554B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[SerializeField]
		private string _envSystemId;

		// Token: 0x0401554C RID: 87372
		[Token(Token = "0x401554C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		[SerializeField]
		private WangVisualStoneMarkAbility _buildStoneAbility;

		// Token: 0x0401554D RID: 87373
		[Token(Token = "0x401554D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[SerializeField]
		private int _extraBuildCnt;

		// Token: 0x0401554E RID: 87374
		[Token(Token = "0x401554E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private AbilityEventCounter m_progressSource;

		// Token: 0x0401554F RID: 87375
		[Token(Token = "0x401554F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private WangStoneTriggerManager m_stoneManager;

		// Token: 0x04015550 RID: 87376
		[Token(Token = "0x4015550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private WangStoneTriggerManager.StoneType m_stoneType;

		// Token: 0x04015551 RID: 87377
		[Token(Token = "0x4015551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		private int m_remainingBuildCnt;

		// Token: 0x04015552 RID: 87378
		[Token(Token = "0x4015552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private ObjectPtr<Character> m_charOwner;

		// Token: 0x04015553 RID: 87379
		[Token(Token = "0x4015553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasRemainingBuildCnt;

		// Token: 0x04015554 RID: 87380
		[Token(Token = "0x4015554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04015555 RID: 87381
		[Token(Token = "0x4015555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x04015556 RID: 87382
		[Token(Token = "0x4015556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04015557 RID: 87383
		[Token(Token = "0x4015557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015558 RID: 87384
		[Token(Token = "0x4015558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CastDirectly;

		// Token: 0x04015559 RID: 87385
		[Token(Token = "0x4015559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ClearAllPendingRequests;

		// Token: 0x0401555A RID: 87386
		[Token(Token = "0x401555A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RemoveStoneMark;

		// Token: 0x0401555B RID: 87387
		[Token(Token = "0x401555B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_BuildStone;

		// Token: 0x0401555C RID: 87388
		[Token(Token = "0x401555C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RemoveBuildRequest;

		// Token: 0x0401555D RID: 87389
		[Token(Token = "0x401555D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnSubAbilityFinished;

		// Token: 0x0401555E RID: 87390
		[Token(Token = "0x401555E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x0401555F RID: 87391
		[Token(Token = "0x401555F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
