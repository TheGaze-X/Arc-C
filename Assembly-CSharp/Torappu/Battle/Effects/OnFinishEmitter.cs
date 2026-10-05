using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003239 RID: 12857
	[Token(Token = "0x2003239")]
	public class OnFinishEmitter : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x06014651 RID: 83537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014651")]
		[Address(RVA = "0xCA5A50", Offset = "0xCA4650", VA = "0x180CA5A50", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014652 RID: 83538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014652")]
		[Address(RVA = "0xCA59B0", Offset = "0xCA45B0", VA = "0x180CA59B0", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06014653 RID: 83539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014653")]
		[Address(RVA = "0xCA5950", Offset = "0xCA4550", VA = "0x180CA5950", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x06014654 RID: 83540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014654")]
		[Address(RVA = "0xCA5E00", Offset = "0xCA4A00", VA = "0x180CA5E00")]
		public OnFinishEmitter()
		{
		}

		// Token: 0x06014655 RID: 83541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014655")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0401813D RID: 98621
		[Token(Token = "0x401813D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] _effects;

		// Token: 0x0401813E RID: 98622
		[Token(Token = "0x401813E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _useFaceVector;

		// Token: 0x0401813F RID: 98623
		[Token(Token = "0x401813F")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _useEffectPosition;

		// Token: 0x04018140 RID: 98624
		[Token(Token = "0x4018140")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018141 RID: 98625
		[Token(Token = "0x4018141")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04018142 RID: 98626
		[Token(Token = "0x4018142")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x04018143 RID: 98627
		[Token(Token = "0x4018143")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
