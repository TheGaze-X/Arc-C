using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003242 RID: 12866
	[Token(Token = "0x2003242")]
	public class PauseEffectIfBuffStackCnt : Effect.Behaviour, IHotfixable
	{
		// Token: 0x06014691 RID: 83601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014691")]
		[Address(RVA = "0xCA7620", Offset = "0xCA6220", VA = "0x180CA7620", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014692 RID: 83602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014692")]
		[Address(RVA = "0xCA76E0", Offset = "0xCA62E0", VA = "0x180CA76E0")]
		private void Update()
		{
		}

		// Token: 0x06014693 RID: 83603 RVA: 0x00086CE8 File Offset: 0x00084EE8
		[Token(Token = "0x6014693")]
		[Address(RVA = "0xCA79D0", Offset = "0xCA65D0", VA = "0x180CA79D0")]
		private int _GetBuffStackCnt()
		{
			return 0;
		}

		// Token: 0x06014694 RID: 83604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014694")]
		[Address(RVA = "0xCA7B40", Offset = "0xCA6740", VA = "0x180CA7B40")]
		public PauseEffectIfBuffStackCnt()
		{
		}

		// Token: 0x06014695 RID: 83605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014695")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x040181A5 RID: 98725
		[Token(Token = "0x40181A5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x040181A6 RID: 98726
		[Token(Token = "0x40181A6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _targetCnt;

		// Token: 0x040181A7 RID: 98727
		[Token(Token = "0x40181A7")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private CompareType _compareType;

		// Token: 0x040181A8 RID: 98728
		[Token(Token = "0x40181A8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _interval;

		// Token: 0x040181A9 RID: 98729
		[Token(Token = "0x40181A9")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _checkBuffCntFromAllBuffs;

		// Token: 0x040181AA RID: 98730
		[Token(Token = "0x40181AA")]
		[FieldOffset(Offset = "0x35")]
		[SerializeField]
		private bool _unpauseIf;

		// Token: 0x040181AB RID: 98731
		[Token(Token = "0x40181AB")]
		[FieldOffset(Offset = "0x38")]
		private PeriodicTimer m_timer;

		// Token: 0x040181AC RID: 98732
		[Token(Token = "0x40181AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040181AD RID: 98733
		[Token(Token = "0x40181AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040181AE RID: 98734
		[Token(Token = "0x40181AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetBuffStackCnt;

		// Token: 0x040181AF RID: 98735
		[Token(Token = "0x40181AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
