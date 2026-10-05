using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200326C RID: 12908
	[Token(Token = "0x200326C")]
	public class SwitchableEffectByModeIndex : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x06014787 RID: 83847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014787")]
		[Address(RVA = "0xCBB810", Offset = "0xCBA410", VA = "0x180CBB810", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06014788 RID: 83848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014788")]
		[Address(RVA = "0xCBBA90", Offset = "0xCBA690", VA = "0x180CBBA90", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014789 RID: 83849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014789")]
		[Address(RVA = "0xCBB9A0", Offset = "0xCBA5A0", VA = "0x180CBB9A0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x0601478A RID: 83850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601478A")]
		[Address(RVA = "0xCBB7B0", Offset = "0xCBA3B0", VA = "0x180CBB7B0", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x0601478B RID: 83851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601478B")]
		[Address(RVA = "0xCBBDC0", Offset = "0xCBA9C0", VA = "0x180CBBDC0")]
		public SwitchableEffectByModeIndex()
		{
		}

		// Token: 0x0601478C RID: 83852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601478C")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x0601478D RID: 83853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601478D")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0401831B RID: 99099
		[Token(Token = "0x401831B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<SwitchableEffectByModeIndex.EffectModeIndexPair> _optionalEffects;

		// Token: 0x0401831C RID: 99100
		[Token(Token = "0x401831C")]
		[FieldOffset(Offset = "0x28")]
		private ObjectPtr<Effect> m_optionalEffect;

		// Token: 0x0401831D RID: 99101
		[Token(Token = "0x401831D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401831E RID: 99102
		[Token(Token = "0x401831E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x0401831F RID: 99103
		[Token(Token = "0x401831F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018320 RID: 99104
		[Token(Token = "0x4018320")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x04018321 RID: 99105
		[Token(Token = "0x4018321")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200326D RID: 12909
		[Token(Token = "0x200326D")]
		[Serializable]
		public class EffectModeIndexPair
		{
			// Token: 0x0601478E RID: 83854 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601478E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EffectModeIndexPair()
			{
			}

			// Token: 0x04018322 RID: 99106
			[Token(Token = "0x4018322")]
			[FieldOffset(Offset = "0x10")]
			public int modeIndex;

			// Token: 0x04018323 RID: 99107
			[Token(Token = "0x4018323")]
			[FieldOffset(Offset = "0x18")]
			public string effectId;
		}
	}
}
