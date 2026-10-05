using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200326B RID: 12907
	[Token(Token = "0x200326B")]
	public class SwitchableEffectByFaceDirection : Effect.Behaviour, IEffectSource
	{
		// Token: 0x0601477F RID: 83839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601477F")]
		[Address(RVA = "0xCBAEA0", Offset = "0xCB9AA0", VA = "0x180CBAEA0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014780 RID: 83840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014780")]
		[Address(RVA = "0xCBACE0", Offset = "0xCB98E0", VA = "0x180CBACE0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014781 RID: 83841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014781")]
		[Address(RVA = "0xCBABE0", Offset = "0xCB97E0", VA = "0x180CBABE0", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06014782 RID: 83842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014782")]
		[Address(RVA = "0xCBB0C0", Offset = "0xCB9CC0", VA = "0x180CBB0C0")]
		private void _UpdateFace()
		{
		}

		// Token: 0x06014783 RID: 83843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014783")]
		[Address(RVA = "0xCBAFF0", Offset = "0xCB9BF0", VA = "0x180CBAFF0")]
		private void _ClearSpawnedEffect()
		{
		}

		// Token: 0x06014784 RID: 83844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014784")]
		[Address(RVA = "0xCBB750", Offset = "0xCBA350", VA = "0x180CBB750")]
		public SwitchableEffectByFaceDirection()
		{
		}

		// Token: 0x06014785 RID: 83845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014785")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x06014786 RID: 83846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014786")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0401830E RID: 99086
		[Token(Token = "0x401830E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _upEffect;

		// Token: 0x0401830F RID: 99087
		[Token(Token = "0x401830F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _downEffect;

		// Token: 0x04018310 RID: 99088
		[Token(Token = "0x4018310")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _leftEffect;

		// Token: 0x04018311 RID: 99089
		[Token(Token = "0x4018311")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _oneShot;

		// Token: 0x04018312 RID: 99090
		[Token(Token = "0x4018312")]
		[FieldOffset(Offset = "0x40")]
		private ObjectPtr<Effect> m_downEffect;

		// Token: 0x04018313 RID: 99091
		[Token(Token = "0x4018313")]
		[FieldOffset(Offset = "0x50")]
		private ObjectPtr<Effect> m_upEffect;

		// Token: 0x04018314 RID: 99092
		[Token(Token = "0x4018314")]
		[FieldOffset(Offset = "0x60")]
		private ObjectPtr<Effect> m_leftEffect;

		// Token: 0x04018315 RID: 99093
		[Token(Token = "0x4018315")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018316 RID: 99094
		[Token(Token = "0x4018316")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018317 RID: 99095
		[Token(Token = "0x4018317")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04018318 RID: 99096
		[Token(Token = "0x4018318")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateFace;

		// Token: 0x04018319 RID: 99097
		[Token(Token = "0x4018319")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearSpawnedEffect;

		// Token: 0x0401831A RID: 99098
		[Token(Token = "0x401831A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
