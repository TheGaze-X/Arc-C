using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003238 RID: 12856
	[Token(Token = "0x2003238")]
	public class OnFinishAnime : Effect.Behaviour
	{
		// Token: 0x0601464C RID: 83532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601464C")]
		[Address(RVA = "0xCA5710", Offset = "0xCA4310", VA = "0x180CA5710", Slot = "4")]
		public override void Init(Effect effect)
		{
		}

		// Token: 0x0601464D RID: 83533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601464D")]
		[Address(RVA = "0xCA5800", Offset = "0xCA4400", VA = "0x180CA5800", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x0601464E RID: 83534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601464E")]
		[Address(RVA = "0xCA58C0", Offset = "0xCA44C0", VA = "0x180CA58C0")]
		public OnFinishAnime()
		{
		}

		// Token: 0x0601464F RID: 83535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601464F")]
		[Address(RVA = "0xC9CCD0", Offset = "0xC9B8D0", VA = "0x180C9CCD0")]
		private void <>xLuaBaseProxy_Init(Effect P0)
		{
		}

		// Token: 0x06014650 RID: 83536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014650")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04018134 RID: 98612
		[Token(Token = "0x4018134")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _triggerName;

		// Token: 0x04018135 RID: 98613
		[Token(Token = "0x4018135")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isTrigger;

		// Token: 0x04018136 RID: 98614
		[Token(Token = "0x4018136")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _triggerValue;

		// Token: 0x04018137 RID: 98615
		[Token(Token = "0x4018137")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _isInt;

		// Token: 0x04018138 RID: 98616
		[Token(Token = "0x4018138")]
		[FieldOffset(Offset = "0x30")]
		private Animator m_animator;

		// Token: 0x04018139 RID: 98617
		[Token(Token = "0x4018139")]
		[FieldOffset(Offset = "0x38")]
		private int m_property;

		// Token: 0x0401813A RID: 98618
		[Token(Token = "0x401813A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401813B RID: 98619
		[Token(Token = "0x401813B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0401813C RID: 98620
		[Token(Token = "0x401813C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
