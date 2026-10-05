using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003258 RID: 12888
	[Token(Token = "0x2003258")]
	public class AutoChessSpellEffectBehaviour : Effect.Behaviour
	{
		// Token: 0x06014704 RID: 83716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014704")]
		[Address(RVA = "0xCAFD10", Offset = "0xCAE910", VA = "0x180CAFD10", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014705 RID: 83717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014705")]
		[Address(RVA = "0xCAFDB0", Offset = "0xCAE9B0", VA = "0x180CAFDB0")]
		private void Update()
		{
		}

		// Token: 0x06014706 RID: 83718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014706")]
		[Address(RVA = "0xCAFBE0", Offset = "0xCAE7E0", VA = "0x180CAFBE0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014707 RID: 83719 RVA: 0x00086D90 File Offset: 0x00084F90
		[Token(Token = "0x6014707")]
		[Address(RVA = "0xCAF970", Offset = "0xCAE570", VA = "0x180CAF970")]
		private bool NeedHook()
		{
			return default(bool);
		}

		// Token: 0x06014708 RID: 83720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014708")]
		[Address(RVA = "0xCB0070", Offset = "0xCAEC70", VA = "0x180CB0070")]
		public AutoChessSpellEffectBehaviour()
		{
		}

		// Token: 0x06014709 RID: 83721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014709")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x0601470A RID: 83722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601470A")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0401824D RID: 98893
		[Token(Token = "0x401824D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _battleEffect;

		// Token: 0x0401824E RID: 98894
		[Token(Token = "0x401824E")]
		[FieldOffset(Offset = "0x28")]
		private ObjectPtr<Effect> m_battleEffect;

		// Token: 0x0401824F RID: 98895
		[Token(Token = "0x401824F")]
		[FieldOffset(Offset = "0x38")]
		private GridPosition m_cachedPos;

		// Token: 0x04018250 RID: 98896
		[Token(Token = "0x4018250")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isPlaying;

		// Token: 0x04018251 RID: 98897
		[Token(Token = "0x4018251")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018252 RID: 98898
		[Token(Token = "0x4018252")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018253 RID: 98899
		[Token(Token = "0x4018253")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018254 RID: 98900
		[Token(Token = "0x4018254")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NeedHook;

		// Token: 0x04018255 RID: 98901
		[Token(Token = "0x4018255")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
