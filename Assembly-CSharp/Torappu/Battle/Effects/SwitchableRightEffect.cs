using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003271 RID: 12913
	[Token(Token = "0x2003271")]
	public class SwitchableRightEffect : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x060147A2 RID: 83874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147A2")]
		[Address(RVA = "0xCBD390", Offset = "0xCBBF90", VA = "0x180CBD390", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060147A3 RID: 83875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147A3")]
		[Address(RVA = "0xCBD200", Offset = "0xCBBE00", VA = "0x180CBD200", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060147A4 RID: 83876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147A4")]
		[Address(RVA = "0xCBD2A0", Offset = "0xCBBEA0", VA = "0x180CBD2A0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060147A5 RID: 83877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147A5")]
		[Address(RVA = "0xCBD400", Offset = "0xCBC000", VA = "0x180CBD400")]
		private void Update()
		{
		}

		// Token: 0x060147A6 RID: 83878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147A6")]
		[Address(RVA = "0xCBD480", Offset = "0xCBC080", VA = "0x180CBD480")]
		private void _UpdateFace(bool force)
		{
		}

		// Token: 0x060147A7 RID: 83879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147A7")]
		[Address(RVA = "0xCBD1A0", Offset = "0xCBBDA0", VA = "0x180CBD1A0", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x060147A8 RID: 83880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147A8")]
		[Address(RVA = "0xCBD740", Offset = "0xCBC340", VA = "0x180CBD740")]
		public SwitchableRightEffect()
		{
		}

		// Token: 0x060147A9 RID: 83881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147A9")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060147AA RID: 83882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147AA")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0401833F RID: 99135
		[Token(Token = "0x401833F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _rightEffect;

		// Token: 0x04018340 RID: 99136
		[Token(Token = "0x4018340")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _onlyCheckOnPlay;

		// Token: 0x04018341 RID: 99137
		[Token(Token = "0x4018341")]
		[FieldOffset(Offset = "0x30")]
		private ObjectPtr<Effect> m_rightEffect;

		// Token: 0x04018342 RID: 99138
		[Token(Token = "0x4018342")]
		[FieldOffset(Offset = "0x40")]
		private bool m_cachedIsRight;

		// Token: 0x04018343 RID: 99139
		[Token(Token = "0x4018343")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018344 RID: 99140
		[Token(Token = "0x4018344")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04018345 RID: 99141
		[Token(Token = "0x4018345")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018346 RID: 99142
		[Token(Token = "0x4018346")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018347 RID: 99143
		[Token(Token = "0x4018347")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateFace;

		// Token: 0x04018348 RID: 99144
		[Token(Token = "0x4018348")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x04018349 RID: 99145
		[Token(Token = "0x4018349")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
