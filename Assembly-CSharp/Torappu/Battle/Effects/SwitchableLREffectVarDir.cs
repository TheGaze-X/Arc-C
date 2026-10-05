using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200326E RID: 12910
	[Token(Token = "0x200326E")]
	public class SwitchableLREffectVarDir : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x0601478F RID: 83855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601478F")]
		[Address(RVA = "0xCBC060", Offset = "0xCBAC60", VA = "0x180CBC060", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014790 RID: 83856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014790")]
		[Address(RVA = "0xCBBED0", Offset = "0xCBAAD0", VA = "0x180CBBED0", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06014791 RID: 83857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014791")]
		[Address(RVA = "0xCBBF70", Offset = "0xCBAB70", VA = "0x180CBBF70", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014792 RID: 83858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014792")]
		[Address(RVA = "0xCBC0D0", Offset = "0xCBACD0", VA = "0x180CBC0D0")]
		private void Update()
		{
		}

		// Token: 0x06014793 RID: 83859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014793")]
		[Address(RVA = "0xCBC150", Offset = "0xCBAD50", VA = "0x180CBC150")]
		private void _UpdateFace(bool force)
		{
		}

		// Token: 0x06014794 RID: 83860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014794")]
		[Address(RVA = "0xCBBE70", Offset = "0xCBAA70", VA = "0x180CBBE70", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x06014795 RID: 83861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014795")]
		[Address(RVA = "0xCBC410", Offset = "0xCBB010", VA = "0x180CBC410")]
		public SwitchableLREffectVarDir()
		{
		}

		// Token: 0x06014796 RID: 83862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014796")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x06014797 RID: 83863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014797")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04018324 RID: 99108
		[Token(Token = "0x4018324")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _rightEffect;

		// Token: 0x04018325 RID: 99109
		[Token(Token = "0x4018325")]
		[FieldOffset(Offset = "0x28")]
		private ObjectPtr<Effect> m_rightEffect;

		// Token: 0x04018326 RID: 99110
		[Token(Token = "0x4018326")]
		[FieldOffset(Offset = "0x38")]
		private bool m_cachedIsRight;

		// Token: 0x04018327 RID: 99111
		[Token(Token = "0x4018327")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018328 RID: 99112
		[Token(Token = "0x4018328")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04018329 RID: 99113
		[Token(Token = "0x4018329")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0401832A RID: 99114
		[Token(Token = "0x401832A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401832B RID: 99115
		[Token(Token = "0x401832B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateFace;

		// Token: 0x0401832C RID: 99116
		[Token(Token = "0x401832C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x0401832D RID: 99117
		[Token(Token = "0x401832D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
