using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200326F RID: 12911
	[Token(Token = "0x200326F")]
	public class SwitchableMultiEffectByBuffStackCnt : Effect.Behaviour, IEffectSource
	{
		// Token: 0x06014798 RID: 83864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014798")]
		[Address(RVA = "0xCBC660", Offset = "0xCBB260", VA = "0x180CBC660", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014799 RID: 83865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014799")]
		[Address(RVA = "0xCBC470", Offset = "0xCBB070", VA = "0x180CBC470", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601479A RID: 83866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601479A")]
		[Address(RVA = "0xCBC5F0", Offset = "0xCBB1F0", VA = "0x180CBC5F0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x0601479B RID: 83867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601479B")]
		[Address(RVA = "0xCBC790", Offset = "0xCBB390", VA = "0x180CBC790")]
		private void _FinishStackEffect()
		{
		}

		// Token: 0x0601479C RID: 83868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601479C")]
		[Address(RVA = "0xCBC6E0", Offset = "0xCBB2E0", VA = "0x180CBC6E0")]
		private void Update()
		{
		}

		// Token: 0x0601479D RID: 83869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601479D")]
		[Address(RVA = "0xCBC9E0", Offset = "0xCBB5E0", VA = "0x180CBC9E0")]
		private void _UpdateEffectWithBuffStackCnt()
		{
		}

		// Token: 0x0601479E RID: 83870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601479E")]
		[Address(RVA = "0xCBD130", Offset = "0xCBBD30", VA = "0x180CBD130")]
		public SwitchableMultiEffectByBuffStackCnt()
		{
		}

		// Token: 0x0601479F RID: 83871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601479F")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060147A0 RID: 83872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147A0")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0401832E RID: 99118
		[Token(Token = "0x401832E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x0401832F RID: 99119
		[Token(Token = "0x401832F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<SwitchableMultiEffectByBuffStackCnt.EffectData> _effects;

		// Token: 0x04018330 RID: 99120
		[Token(Token = "0x4018330")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _updateInterval;

		// Token: 0x04018331 RID: 99121
		[Token(Token = "0x4018331")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _updateOnPlay;

		// Token: 0x04018332 RID: 99122
		[Token(Token = "0x4018332")]
		[FieldOffset(Offset = "0x35")]
		[SerializeField]
		private bool _onlyUpdateOnPlay;

		// Token: 0x04018333 RID: 99123
		[Token(Token = "0x4018333")]
		[FieldOffset(Offset = "0x38")]
		private float m_updateInterval;

		// Token: 0x04018334 RID: 99124
		[Token(Token = "0x4018334")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<int, ObjectPtr<Effect>> m_stackEffects;

		// Token: 0x04018335 RID: 99125
		[Token(Token = "0x4018335")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018336 RID: 99126
		[Token(Token = "0x4018336")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04018337 RID: 99127
		[Token(Token = "0x4018337")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018338 RID: 99128
		[Token(Token = "0x4018338")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FinishStackEffect;

		// Token: 0x04018339 RID: 99129
		[Token(Token = "0x4018339")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401833A RID: 99130
		[Token(Token = "0x401833A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateEffectWithBuffStackCnt;

		// Token: 0x0401833B RID: 99131
		[Token(Token = "0x401833B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003270 RID: 12912
		[Token(Token = "0x2003270")]
		[Serializable]
		public class EffectData
		{
			// Token: 0x060147A1 RID: 83873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60147A1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EffectData()
			{
			}

			// Token: 0x0401833C RID: 99132
			[Token(Token = "0x401833C")]
			[FieldOffset(Offset = "0x10")]
			public string effect;

			// Token: 0x0401833D RID: 99133
			[Token(Token = "0x401833D")]
			[FieldOffset(Offset = "0x18")]
			public int stackCnt;

			// Token: 0x0401833E RID: 99134
			[Token(Token = "0x401833E")]
			[FieldOffset(Offset = "0x1C")]
			public CompareType compareType;
		}
	}
}
