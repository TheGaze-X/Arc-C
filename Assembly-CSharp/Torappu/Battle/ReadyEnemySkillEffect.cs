using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021F9 RID: 8697
	[Token(Token = "0x20021F9")]
	public class ReadyEnemySkillEffect : EnemySkill.Behaviour, IEffectSource
	{
		// Token: 0x0600D9A1 RID: 55713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9A1")]
		[Address(RVA = "0x35EB600", Offset = "0x35EA200", VA = "0x1835EB600", Slot = "11")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600D9A2 RID: 55714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9A2")]
		[Address(RVA = "0x35EB6A0", Offset = "0x35EA2A0", VA = "0x1835EB6A0", Slot = "6")]
		public override void OnAttach()
		{
		}

		// Token: 0x0600D9A3 RID: 55715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9A3")]
		[Address(RVA = "0x35EB810", Offset = "0x35EA410", VA = "0x1835EB810", Slot = "7")]
		public override void OnDetach()
		{
		}

		// Token: 0x0600D9A4 RID: 55716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9A4")]
		[Address(RVA = "0x35EB880", Offset = "0x35EA480", VA = "0x1835EB880", Slot = "8")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600D9A5 RID: 55717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9A5")]
		[Address(RVA = "0x35EB790", Offset = "0x35EA390", VA = "0x1835EB790", Slot = "9")]
		public override void OnCastStart()
		{
		}

		// Token: 0x0600D9A6 RID: 55718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9A6")]
		[Address(RVA = "0x35EB710", Offset = "0x35EA310", VA = "0x1835EB710", Slot = "10")]
		public override void OnCastFinish(Ability.FinishReason reason)
		{
		}

		// Token: 0x0600D9A7 RID: 55719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9A7")]
		[Address(RVA = "0x35EBA70", Offset = "0x35EA670", VA = "0x1835EBA70")]
		private void _ClearEffect()
		{
		}

		// Token: 0x0600D9A8 RID: 55720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9A8")]
		[Address(RVA = "0x35EBB50", Offset = "0x35EA750", VA = "0x1835EBB50")]
		public ReadyEnemySkillEffect()
		{
		}

		// Token: 0x0600D9A9 RID: 55721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9A9")]
		[Address(RVA = "0x35EBA20", Offset = "0x35EA620", VA = "0x1835EBA20")]
		private void <>xLuaBaseProxy_OnAttach()
		{
		}

		// Token: 0x0600D9AA RID: 55722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9AA")]
		[Address(RVA = "0x35EBA50", Offset = "0x35EA650", VA = "0x1835EBA50")]
		private void <>xLuaBaseProxy_OnDetach()
		{
		}

		// Token: 0x0600D9AB RID: 55723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9AB")]
		[Address(RVA = "0x35EBA60", Offset = "0x35EA660", VA = "0x1835EBA60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600D9AC RID: 55724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9AC")]
		[Address(RVA = "0x35EBA40", Offset = "0x35EA640", VA = "0x1835EBA40")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x0600D9AD RID: 55725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9AD")]
		[Address(RVA = "0x35EBA30", Offset = "0x35EA630", VA = "0x1835EBA30")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability.FinishReason P0)
		{
		}

		// Token: 0x0400EAE0 RID: 60128
		[Token(Token = "0x400EAE0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _effect;

		// Token: 0x0400EAE1 RID: 60129
		[Token(Token = "0x400EAE1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _stopBeforeCast;

		// Token: 0x0400EAE2 RID: 60130
		[Token(Token = "0x400EAE2")]
		[FieldOffset(Offset = "0x30")]
		private ObjectPtr<Effect> m_effectPtr;

		// Token: 0x0400EAE3 RID: 60131
		[Token(Token = "0x400EAE3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400EAE4 RID: 60132
		[Token(Token = "0x400EAE4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x0400EAE5 RID: 60133
		[Token(Token = "0x400EAE5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x0400EAE6 RID: 60134
		[Token(Token = "0x400EAE6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400EAE7 RID: 60135
		[Token(Token = "0x400EAE7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x0400EAE8 RID: 60136
		[Token(Token = "0x400EAE8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x0400EAE9 RID: 60137
		[Token(Token = "0x400EAE9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearEffect;

		// Token: 0x0400EAEA RID: 60138
		[Token(Token = "0x400EAEA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
