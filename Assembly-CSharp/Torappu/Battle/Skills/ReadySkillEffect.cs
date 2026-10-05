using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Skills
{
	// Token: 0x020028B7 RID: 10423
	[Token(Token = "0x20028B7")]
	public class ReadySkillEffect : BasicSkill.Behaviour, IEffectSource
	{
		// Token: 0x06011556 RID: 70998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011556")]
		[Address(RVA = "0x928530", Offset = "0x927130", VA = "0x180928530", Slot = "16")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x17002652 RID: 9810
		// (get) Token: 0x06011557 RID: 70999 RVA: 0x0006AB30 File Offset: 0x00068D30
		[Token(Token = "0x17002652")]
		protected bool effectsCreated
		{
			[Token(Token = "0x6011557")]
			[Address(RVA = "0x928CD0", Offset = "0x9278D0", VA = "0x180928CD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002653 RID: 9811
		// (get) Token: 0x06011558 RID: 71000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002653")]
		protected List<ObjectPtr<Effect>> effects
		{
			[Token(Token = "0x6011558")]
			[Address(RVA = "0x928D30", Offset = "0x927930", VA = "0x180928D30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011559 RID: 71001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011559")]
		[Address(RVA = "0x9287E0", Offset = "0x9273E0", VA = "0x1809287E0", Slot = "14")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0601155A RID: 71002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601155A")]
		[Address(RVA = "0x928760", Offset = "0x927360", VA = "0x180928760", Slot = "9")]
		public override void OnSkillStart()
		{
		}

		// Token: 0x0601155B RID: 71003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601155B")]
		[Address(RVA = "0x9286F0", Offset = "0x9272F0", VA = "0x1809286F0", Slot = "10")]
		public override void OnSkillEnd()
		{
		}

		// Token: 0x0601155C RID: 71004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601155C")]
		[Address(RVA = "0x928610", Offset = "0x927210", VA = "0x180928610", Slot = "11")]
		public override void OnInit()
		{
		}

		// Token: 0x0601155D RID: 71005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601155D")]
		[Address(RVA = "0x928680", Offset = "0x927280", VA = "0x180928680", Slot = "12")]
		public override void OnOwnerFinish()
		{
		}

		// Token: 0x0601155E RID: 71006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601155E")]
		[Address(RVA = "0x928A30", Offset = "0x927630", VA = "0x180928A30")]
		private void _ClearEffect()
		{
		}

		// Token: 0x0601155F RID: 71007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601155F")]
		[Address(RVA = "0x928C20", Offset = "0x927820", VA = "0x180928C20")]
		public ReadySkillEffect()
		{
		}

		// Token: 0x06011560 RID: 71008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011560")]
		[Address(RVA = "0x91E1E0", Offset = "0x91CDE0", VA = "0x18091E1E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011561 RID: 71009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011561")]
		[Address(RVA = "0x91D780", Offset = "0x91C380", VA = "0x18091D780")]
		private void <>xLuaBaseProxy_OnSkillStart()
		{
		}

		// Token: 0x06011562 RID: 71010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011562")]
		[Address(RVA = "0x91D770", Offset = "0x91C370", VA = "0x18091D770")]
		private void <>xLuaBaseProxy_OnSkillEnd()
		{
		}

		// Token: 0x06011563 RID: 71011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011563")]
		[Address(RVA = "0x91E1D0", Offset = "0x91CDD0", VA = "0x18091E1D0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06011564 RID: 71012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011564")]
		[Address(RVA = "0x921D90", Offset = "0x920990", VA = "0x180921D90")]
		private void <>xLuaBaseProxy_OnOwnerFinish()
		{
		}

		// Token: 0x040135FD RID: 79357
		[Token(Token = "0x40135FD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] _effects;

		// Token: 0x040135FE RID: 79358
		[Token(Token = "0x40135FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _stopBeforeCast;

		// Token: 0x040135FF RID: 79359
		[Token(Token = "0x40135FF")]
		[FieldOffset(Offset = "0x30")]
		private List<ObjectPtr<Effect>> m_effects;

		// Token: 0x04013600 RID: 79360
		[Token(Token = "0x4013600")]
		[FieldOffset(Offset = "0x38")]
		private bool m_effectsCreated;

		// Token: 0x04013601 RID: 79361
		[Token(Token = "0x4013601")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04013602 RID: 79362
		[Token(Token = "0x4013602")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_effectsCreated;

		// Token: 0x04013603 RID: 79363
		[Token(Token = "0x4013603")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_effects;

		// Token: 0x04013604 RID: 79364
		[Token(Token = "0x4013604")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013605 RID: 79365
		[Token(Token = "0x4013605")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSkillStart;

		// Token: 0x04013606 RID: 79366
		[Token(Token = "0x4013606")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSkillEnd;

		// Token: 0x04013607 RID: 79367
		[Token(Token = "0x4013607")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013608 RID: 79368
		[Token(Token = "0x4013608")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnOwnerFinish;

		// Token: 0x04013609 RID: 79369
		[Token(Token = "0x4013609")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClearEffect;

		// Token: 0x0401360A RID: 79370
		[Token(Token = "0x401360A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
