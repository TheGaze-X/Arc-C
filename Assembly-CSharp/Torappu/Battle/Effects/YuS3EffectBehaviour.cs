using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200325C RID: 12892
	[Token(Token = "0x200325C")]
	public class YuS3EffectBehaviour : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x06014719 RID: 83737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014719")]
		[Address(RVA = "0xCC2100", Offset = "0xCC0D00", VA = "0x180CC2100", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x0601471A RID: 83738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601471A")]
		[Address(RVA = "0xCC1F20", Offset = "0xCC0B20", VA = "0x180CC1F20", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x0601471B RID: 83739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601471B")]
		[Address(RVA = "0xCC1E90", Offset = "0xCC0A90", VA = "0x180CC1E90", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601471C RID: 83740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601471C")]
		[Address(RVA = "0xCC1DC0", Offset = "0xCC09C0", VA = "0x180CC1DC0", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x0601471D RID: 83741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601471D")]
		[Address(RVA = "0xCC2630", Offset = "0xCC1230", VA = "0x180CC2630")]
		private string _ReplaceEffectName(string effectName, string ext)
		{
			return null;
		}

		// Token: 0x0601471E RID: 83742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601471E")]
		[Address(RVA = "0xCC26D0", Offset = "0xCC12D0", VA = "0x180CC26D0")]
		public YuS3EffectBehaviour()
		{
		}

		// Token: 0x0601471F RID: 83743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601471F")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x06014720 RID: 83744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014720")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0401826D RID: 98925
		[Token(Token = "0x401826D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _effectEachGrid;

		// Token: 0x0401826E RID: 98926
		[Token(Token = "0x401826E")]
		[FieldOffset(Offset = "0x28")]
		private bool m_inited;

		// Token: 0x0401826F RID: 98927
		[Token(Token = "0x401826F")]
		[FieldOffset(Offset = "0x30")]
		private List<ObjectPtr<Effect>> m_effects;

		// Token: 0x04018270 RID: 98928
		[Token(Token = "0x4018270")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018271 RID: 98929
		[Token(Token = "0x4018271")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018272 RID: 98930
		[Token(Token = "0x4018272")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04018273 RID: 98931
		[Token(Token = "0x4018273")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x04018274 RID: 98932
		[Token(Token = "0x4018274")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ReplaceEffectName;

		// Token: 0x04018275 RID: 98933
		[Token(Token = "0x4018275")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
