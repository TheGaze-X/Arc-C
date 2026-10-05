using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003209 RID: 12809
	[Token(Token = "0x2003209")]
	public class Act38sideSwitchableEffect : Effect.Behaviour, IEffectSource
	{
		// Token: 0x06014540 RID: 83264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014540")]
		[Address(RVA = "0xC82090", Offset = "0xC80C90", VA = "0x180C82090")]
		private void Update()
		{
		}

		// Token: 0x06014541 RID: 83265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014541")]
		[Address(RVA = "0xC81D90", Offset = "0xC80990", VA = "0x180C81D90", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014542 RID: 83266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014542")]
		[Address(RVA = "0xC819D0", Offset = "0xC805D0", VA = "0x180C819D0", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06014543 RID: 83267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014543")]
		[Address(RVA = "0xC822D0", Offset = "0xC80ED0", VA = "0x180C822D0")]
		private void _PickOneEmitter()
		{
		}

		// Token: 0x06014544 RID: 83268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014544")]
		[Address(RVA = "0xC82160", Offset = "0xC80D60", VA = "0x180C82160")]
		private string _GetEffectKeyByFireworkType()
		{
			return null;
		}

		// Token: 0x06014545 RID: 83269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014545")]
		[Address(RVA = "0xC81B50", Offset = "0xC80750", VA = "0x180C81B50", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014546 RID: 83270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014546")]
		[Address(RVA = "0xC82760", Offset = "0xC81360", VA = "0x180C82760")]
		public Act38sideSwitchableEffect()
		{
		}

		// Token: 0x06014547 RID: 83271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014547")]
		[Address(RVA = "0xC82030", Offset = "0xC80C30", VA = "0x180C82030")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x06014548 RID: 83272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014548")]
		[Address(RVA = "0xC81FD0", Offset = "0xC80BD0", VA = "0x180C81FD0")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04017F7E RID: 98174
		[Token(Token = "0x4017F7E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _dontCheckOwner;

		// Token: 0x04017F7F RID: 98175
		[Token(Token = "0x4017F7F")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _finishEffectWhenSelfFinish;

		// Token: 0x04017F80 RID: 98176
		[Token(Token = "0x4017F80")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool _useMainEffectPos;

		// Token: 0x04017F81 RID: 98177
		[Token(Token = "0x4017F81")]
		[FieldOffset(Offset = "0x23")]
		[SerializeField]
		private bool _checkCarnivalFinished;

		// Token: 0x04017F82 RID: 98178
		[Token(Token = "0x4017F82")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _envSystemKey;

		// Token: 0x04017F83 RID: 98179
		[Token(Token = "0x4017F83")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Act38sideSwitchableEffect.EffectSetting> _effectSettings;

		// Token: 0x04017F84 RID: 98180
		[Token(Token = "0x4017F84")]
		[FieldOffset(Offset = "0x38")]
		private List<ObjectPtr<Effect>> m_effects;

		// Token: 0x04017F85 RID: 98181
		[Token(Token = "0x4017F85")]
		[FieldOffset(Offset = "0x40")]
		private Act38SideBattleManager m_envManager;

		// Token: 0x04017F86 RID: 98182
		[Token(Token = "0x4017F86")]
		[FieldOffset(Offset = "0x48")]
		private FireworkData.FireworkType m_fireworkType;

		// Token: 0x04017F87 RID: 98183
		[Token(Token = "0x4017F87")]
		[FieldOffset(Offset = "0x4C")]
		private int m_fireworkLevel;

		// Token: 0x04017F88 RID: 98184
		[Token(Token = "0x4017F88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04017F89 RID: 98185
		[Token(Token = "0x4017F89")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04017F8A RID: 98186
		[Token(Token = "0x4017F8A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04017F8B RID: 98187
		[Token(Token = "0x4017F8B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PickOneEmitter;

		// Token: 0x04017F8C RID: 98188
		[Token(Token = "0x4017F8C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetEffectKeyByFireworkType;

		// Token: 0x04017F8D RID: 98189
		[Token(Token = "0x4017F8D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04017F8E RID: 98190
		[Token(Token = "0x4017F8E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200320A RID: 12810
		[Token(Token = "0x200320A")]
		[Serializable]
		private struct EffectSetting
		{
			// Token: 0x04017F8F RID: 98191
			[Token(Token = "0x4017F8F")]
			[FieldOffset(Offset = "0x0")]
			public FireworkData.FireworkType fireworkType;

			// Token: 0x04017F90 RID: 98192
			[Token(Token = "0x4017F90")]
			[FieldOffset(Offset = "0x4")]
			public int fireworkLevel;

			// Token: 0x04017F91 RID: 98193
			[Token(Token = "0x4017F91")]
			[FieldOffset(Offset = "0x8")]
			public string effectKey;
		}
	}
}
