using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003266 RID: 12902
	[Token(Token = "0x2003266")]
	public class SwitchableBackEffect : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x0601474B RID: 83787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601474B")]
		[Address(RVA = "0xCB79C0", Offset = "0xCB65C0", VA = "0x180CB79C0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x0601474C RID: 83788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601474C")]
		[Address(RVA = "0xCB7AC0", Offset = "0xCB66C0", VA = "0x180CB7AC0")]
		private void _CreateEffectOnStart()
		{
		}

		// Token: 0x0601474D RID: 83789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601474D")]
		[Address(RVA = "0xCB7820", Offset = "0xCB6420", VA = "0x180CB7820", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601474E RID: 83790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601474E")]
		[Address(RVA = "0xCB78C0", Offset = "0xCB64C0", VA = "0x180CB78C0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x0601474F RID: 83791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601474F")]
		[Address(RVA = "0xCB7A40", Offset = "0xCB6640", VA = "0x180CB7A40")]
		private void Update()
		{
		}

		// Token: 0x06014750 RID: 83792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014750")]
		[Address(RVA = "0xCB7E70", Offset = "0xCB6A70", VA = "0x180CB7E70")]
		private void _UpdateFace(bool force)
		{
		}

		// Token: 0x06014751 RID: 83793 RVA: 0x00086E50 File Offset: 0x00085050
		[Token(Token = "0x6014751")]
		[Address(RVA = "0xCB7D20", Offset = "0xCB6920", VA = "0x180CB7D20")]
		private bool _PredictFaceDirection()
		{
			return default(bool);
		}

		// Token: 0x06014752 RID: 83794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014752")]
		[Address(RVA = "0xCB77C0", Offset = "0xCB63C0", VA = "0x180CB77C0", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x06014753 RID: 83795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014753")]
		[Address(RVA = "0xCB8310", Offset = "0xCB6F10", VA = "0x180CB8310")]
		public SwitchableBackEffect()
		{
		}

		// Token: 0x06014754 RID: 83796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014754")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x06014755 RID: 83797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014755")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x040182BC RID: 99004
		[Token(Token = "0x40182BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _backEffect;

		// Token: 0x040182BD RID: 99005
		[Token(Token = "0x40182BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("True, will calculate the animator's direction based on owner.faceTo.\nFalse: Use current owner.faceToBack (Animator's direction, might lagging for certain frames).")]
		private bool _predictFaceDirection;

		// Token: 0x040182BE RID: 99006
		[Token(Token = "0x40182BE")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _forceCheckInUpdate;

		// Token: 0x040182BF RID: 99007
		[Token(Token = "0x40182BF")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _oneShot;

		// Token: 0x040182C0 RID: 99008
		[Token(Token = "0x40182C0")]
		[FieldOffset(Offset = "0x2B")]
		[SerializeField]
		private bool _useBehaviourPause;

		// Token: 0x040182C1 RID: 99009
		[Token(Token = "0x40182C1")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _syncPlayBackSpeed;

		// Token: 0x040182C2 RID: 99010
		[Token(Token = "0x40182C2")]
		[FieldOffset(Offset = "0x2D")]
		[SerializeField]
		private bool _createEffectOnStart;

		// Token: 0x040182C3 RID: 99011
		[Token(Token = "0x40182C3")]
		[FieldOffset(Offset = "0x30")]
		private ObjectPtr<Effect> m_backEffect;

		// Token: 0x040182C4 RID: 99012
		[Token(Token = "0x40182C4")]
		[FieldOffset(Offset = "0x40")]
		private bool m_cachedIsBack;

		// Token: 0x040182C5 RID: 99013
		[Token(Token = "0x40182C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040182C6 RID: 99014
		[Token(Token = "0x40182C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CreateEffectOnStart;

		// Token: 0x040182C7 RID: 99015
		[Token(Token = "0x40182C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040182C8 RID: 99016
		[Token(Token = "0x40182C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040182C9 RID: 99017
		[Token(Token = "0x40182C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040182CA RID: 99018
		[Token(Token = "0x40182CA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateFace;

		// Token: 0x040182CB RID: 99019
		[Token(Token = "0x40182CB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PredictFaceDirection;

		// Token: 0x040182CC RID: 99020
		[Token(Token = "0x40182CC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x040182CD RID: 99021
		[Token(Token = "0x40182CD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
