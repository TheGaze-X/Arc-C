using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002460 RID: 9312
	[Token(Token = "0x2002460")]
	public class ToggleSkillWithEndAnimation : ToggleSkill
	{
		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x0600EF89 RID: 61321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F13")]
		public override string beginAnim
		{
			[Token(Token = "0x600EF89")]
			[Address(RVA = "0x67E170", Offset = "0x67CD70", VA = "0x18067E170", Slot = "44")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x0600EF8A RID: 61322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F14")]
		public override string[] beginEffect
		{
			[Token(Token = "0x600EF8A")]
			[Address(RVA = "0x67E230", Offset = "0x67CE30", VA = "0x18067E230", Slot = "46")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x0600EF8B RID: 61323 RVA: 0x00058338 File Offset: 0x00056538
		[Token(Token = "0x17001F15")]
		public override bool hasPlayedBeginAnim
		{
			[Token(Token = "0x600EF8B")]
			[Address(RVA = "0x67E2F0", Offset = "0x67CEF0", VA = "0x18067E2F0", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EF8C RID: 61324 RVA: 0x00058350 File Offset: 0x00056550
		[Token(Token = "0x600EF8C")]
		[Address(RVA = "0x67D9D0", Offset = "0x67C5D0", VA = "0x18067D9D0", Slot = "20")]
		public override bool IsClickable(PlayerSide side = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF8D RID: 61325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF8D")]
		[Address(RVA = "0x67D850", Offset = "0x67C450", VA = "0x18067D850", Slot = "48")]
		public override void AssignData(SkillData data, Character owner, Blackboard externalBlackboard, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600EF8E RID: 61326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF8E")]
		[Address(RVA = "0x67DA60", Offset = "0x67C660", VA = "0x18067DA60", Slot = "69")]
		public override void OnBeforeSkillBeginAnim()
		{
		}

		// Token: 0x0600EF8F RID: 61327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF8F")]
		[Address(RVA = "0x67DAD0", Offset = "0x67C6D0", VA = "0x18067DAD0", Slot = "54")]
		public override void OnEnterSkillState()
		{
		}

		// Token: 0x0600EF90 RID: 61328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF90")]
		[Address(RVA = "0x67DB40", Offset = "0x67C740", VA = "0x18067DB40", Slot = "50")]
		protected override void OnSkillEnd()
		{
		}

		// Token: 0x0600EF91 RID: 61329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF91")]
		[Address(RVA = "0x67D960", Offset = "0x67C560", VA = "0x18067D960", Slot = "53")]
		public override void InterruptIfNot()
		{
		}

		// Token: 0x0600EF92 RID: 61330 RVA: 0x00058368 File Offset: 0x00056568
		[Token(Token = "0x600EF92")]
		[Address(RVA = "0x67E040", Offset = "0x67CC40", VA = "0x18067E040", Slot = "51")]
		public override bool UseSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF93 RID: 61331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF93")]
		[Address(RVA = "0x67DE70", Offset = "0x67CA70", VA = "0x18067DE70", Slot = "66")]
		public override void PlayBeginEffectAndAudio()
		{
		}

		// Token: 0x0600EF94 RID: 61332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF94")]
		[Address(RVA = "0x67DBB0", Offset = "0x67C7B0", VA = "0x18067DBB0", Slot = "68")]
		public override void PlayBeginAudio()
		{
		}

		// Token: 0x0600EF95 RID: 61333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF95")]
		[Address(RVA = "0x67E0C0", Offset = "0x67CCC0", VA = "0x18067E0C0")]
		public ToggleSkillWithEndAnimation()
		{
		}

		// Token: 0x0600EF96 RID: 61334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EF96")]
		[Address(RVA = "0x67E010", Offset = "0x67CC10", VA = "0x18067E010")]
		private string <>xLuaBaseProxy_get_beginAnim()
		{
			return null;
		}

		// Token: 0x0600EF97 RID: 61335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EF97")]
		[Address(RVA = "0x67E020", Offset = "0x67CC20", VA = "0x18067E020")]
		private string[] <>xLuaBaseProxy_get_beginEffect()
		{
			return null;
		}

		// Token: 0x0600EF98 RID: 61336 RVA: 0x00058380 File Offset: 0x00056580
		[Token(Token = "0x600EF98")]
		[Address(RVA = "0x67E030", Offset = "0x67CC30", VA = "0x18067E030")]
		private bool <>xLuaBaseProxy_get_hasPlayedBeginAnim()
		{
			return default(bool);
		}

		// Token: 0x0600EF99 RID: 61337 RVA: 0x00058398 File Offset: 0x00056598
		[Token(Token = "0x600EF99")]
		[Address(RVA = "0x67DFB0", Offset = "0x67CBB0", VA = "0x18067DFB0")]
		private bool <>xLuaBaseProxy_IsClickable(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600EF9A RID: 61338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF9A")]
		[Address(RVA = "0x635EA0", Offset = "0x634AA0", VA = "0x180635EA0")]
		private void <>xLuaBaseProxy_AssignData(SkillData P0, Character P1, Blackboard P2, UnitDataFlowConfig.Delta P3)
		{
		}

		// Token: 0x0600EF9B RID: 61339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF9B")]
		[Address(RVA = "0x67DFC0", Offset = "0x67CBC0", VA = "0x18067DFC0")]
		private void <>xLuaBaseProxy_OnBeforeSkillBeginAnim()
		{
		}

		// Token: 0x0600EF9C RID: 61340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF9C")]
		[Address(RVA = "0x67DFD0", Offset = "0x67CBD0", VA = "0x18067DFD0")]
		private void <>xLuaBaseProxy_OnEnterSkillState()
		{
		}

		// Token: 0x0600EF9D RID: 61341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF9D")]
		[Address(RVA = "0x67A300", Offset = "0x678F00", VA = "0x18067A300")]
		private void <>xLuaBaseProxy_OnSkillEnd()
		{
		}

		// Token: 0x0600EF9E RID: 61342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF9E")]
		[Address(RVA = "0x674810", Offset = "0x673410", VA = "0x180674810")]
		private void <>xLuaBaseProxy_InterruptIfNot()
		{
		}

		// Token: 0x0600EF9F RID: 61343 RVA: 0x000583B0 File Offset: 0x000565B0
		[Token(Token = "0x600EF9F")]
		[Address(RVA = "0x67E000", Offset = "0x67CC00", VA = "0x18067E000")]
		private bool <>xLuaBaseProxy_UseSkill(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600EFA0 RID: 61344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFA0")]
		[Address(RVA = "0x67DFF0", Offset = "0x67CBF0", VA = "0x18067DFF0")]
		private void <>xLuaBaseProxy_PlayBeginEffectAndAudio()
		{
		}

		// Token: 0x0600EFA1 RID: 61345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFA1")]
		[Address(RVA = "0x67DFE0", Offset = "0x67CBE0", VA = "0x18067DFE0")]
		private void <>xLuaBaseProxy_PlayBeginAudio()
		{
		}

		// Token: 0x040108E4 RID: 67812
		[Token(Token = "0x40108E4")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Animation", Priority = 2)]
		[Inspect("playSkillBeginAnim")]
		private string _endAnim;

		// Token: 0x040108E5 RID: 67813
		[Token(Token = "0x40108E5")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Animation", Priority = 2)]
		[Inspect("playSkillBeginAnim")]
		private string[] _endEffect;

		// Token: 0x040108E6 RID: 67814
		[Token(Token = "0x40108E6")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private bool _playExtraSignalAtSkillBegin;

		// Token: 0x040108E7 RID: 67815
		[Token(Token = "0x40108E7")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private TargetValidator _audioValidator;

		// Token: 0x040108E8 RID: 67816
		[Token(Token = "0x40108E8")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private bool _appendModeIndexToBeginAudioSignal;

		// Token: 0x040108E9 RID: 67817
		[Token(Token = "0x40108E9")]
		[FieldOffset(Offset = "0x151")]
		private bool m_skillBeginAnimAlreadyOn;

		// Token: 0x040108EA RID: 67818
		[Token(Token = "0x40108EA")]
		[FieldOffset(Offset = "0x152")]
		private bool m_hasPlayedBeginAnim;

		// Token: 0x040108EB RID: 67819
		[Token(Token = "0x40108EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_beginAnim;

		// Token: 0x040108EC RID: 67820
		[Token(Token = "0x40108EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_beginEffect;

		// Token: 0x040108ED RID: 67821
		[Token(Token = "0x40108ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasPlayedBeginAnim;

		// Token: 0x040108EE RID: 67822
		[Token(Token = "0x40108EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsClickable;

		// Token: 0x040108EF RID: 67823
		[Token(Token = "0x40108EF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x040108F0 RID: 67824
		[Token(Token = "0x40108F0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBeforeSkillBeginAnim;

		// Token: 0x040108F1 RID: 67825
		[Token(Token = "0x40108F1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnterSkillState;

		// Token: 0x040108F2 RID: 67826
		[Token(Token = "0x40108F2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSkillEnd;

		// Token: 0x040108F3 RID: 67827
		[Token(Token = "0x40108F3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_InterruptIfNot;

		// Token: 0x040108F4 RID: 67828
		[Token(Token = "0x40108F4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UseSkill;

		// Token: 0x040108F5 RID: 67829
		[Token(Token = "0x40108F5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_PlayBeginEffectAndAudio;

		// Token: 0x040108F6 RID: 67830
		[Token(Token = "0x40108F6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_PlayBeginAudio;

		// Token: 0x040108F7 RID: 67831
		[Token(Token = "0x40108F7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
