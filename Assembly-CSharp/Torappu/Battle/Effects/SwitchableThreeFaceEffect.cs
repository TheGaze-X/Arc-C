using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003272 RID: 12914
	[Token(Token = "0x2003272")]
	public class SwitchableThreeFaceEffect : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x060147AB RID: 83883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147AB")]
		[Address(RVA = "0xCBDA70", Offset = "0xCBC670", VA = "0x180CBDA70", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060147AC RID: 83884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147AC")]
		[Address(RVA = "0xCBDB70", Offset = "0xCBC770", VA = "0x180CBDB70")]
		private void _CreateEffectOnStart()
		{
		}

		// Token: 0x060147AD RID: 83885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147AD")]
		[Address(RVA = "0xCBD800", Offset = "0xCBC400", VA = "0x180CBD800", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060147AE RID: 83886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147AE")]
		[Address(RVA = "0xCBD910", Offset = "0xCBC510", VA = "0x180CBD910", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060147AF RID: 83887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147AF")]
		[Address(RVA = "0xCBDAF0", Offset = "0xCBC6F0", VA = "0x180CBDAF0")]
		private void Update()
		{
		}

		// Token: 0x060147B0 RID: 83888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147B0")]
		[Address(RVA = "0xCBDEB0", Offset = "0xCBCAB0", VA = "0x180CBDEB0")]
		private void _UpdateFace(bool force)
		{
		}

		// Token: 0x060147B1 RID: 83889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147B1")]
		[Address(RVA = "0xCBD7A0", Offset = "0xCBC3A0", VA = "0x180CBD7A0", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x060147B2 RID: 83890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147B2")]
		[Address(RVA = "0xCBE330", Offset = "0xCBCF30", VA = "0x180CBE330")]
		public SwitchableThreeFaceEffect()
		{
		}

		// Token: 0x060147B3 RID: 83891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147B3")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060147B4 RID: 83892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147B4")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0401834A RID: 99146
		[Token(Token = "0x401834A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _upEffect;

		// Token: 0x0401834B RID: 99147
		[Token(Token = "0x401834B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _downEffect;

		// Token: 0x0401834C RID: 99148
		[Token(Token = "0x401834C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _forceCheckInUpdate;

		// Token: 0x0401834D RID: 99149
		[Token(Token = "0x401834D")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _createEffectOnStart;

		// Token: 0x0401834E RID: 99150
		[Token(Token = "0x401834E")]
		[FieldOffset(Offset = "0x38")]
		private ObjectPtr<Effect> m_upEffect;

		// Token: 0x0401834F RID: 99151
		[Token(Token = "0x401834F")]
		[FieldOffset(Offset = "0x48")]
		private ObjectPtr<Effect> m_downEffect;

		// Token: 0x04018350 RID: 99152
		[Token(Token = "0x4018350")]
		[FieldOffset(Offset = "0x58")]
		private SwitchableThreeFaceEffect.FaceDirType m_cachedFaceDir;

		// Token: 0x04018351 RID: 99153
		[Token(Token = "0x4018351")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018352 RID: 99154
		[Token(Token = "0x4018352")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CreateEffectOnStart;

		// Token: 0x04018353 RID: 99155
		[Token(Token = "0x4018353")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04018354 RID: 99156
		[Token(Token = "0x4018354")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018355 RID: 99157
		[Token(Token = "0x4018355")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018356 RID: 99158
		[Token(Token = "0x4018356")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateFace;

		// Token: 0x04018357 RID: 99159
		[Token(Token = "0x4018357")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x04018358 RID: 99160
		[Token(Token = "0x4018358")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003273 RID: 12915
		[Token(Token = "0x2003273")]
		private enum FaceDirType
		{
			// Token: 0x0401835A RID: 99162
			[Token(Token = "0x401835A")]
			FRONT,
			// Token: 0x0401835B RID: 99163
			[Token(Token = "0x401835B")]
			UP,
			// Token: 0x0401835C RID: 99164
			[Token(Token = "0x401835C")]
			DOWN,
			// Token: 0x0401835D RID: 99165
			[Token(Token = "0x401835D")]
			ENUM
		}
	}
}
