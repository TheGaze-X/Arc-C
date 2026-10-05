using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200324F RID: 12879
	[Token(Token = "0x200324F")]
	public class RandomFinishEmitter : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x060146D2 RID: 83666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146D2")]
		[Address(RVA = "0xCAC000", Offset = "0xCAAC00", VA = "0x180CAC000", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060146D3 RID: 83667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146D3")]
		[Address(RVA = "0xCABF60", Offset = "0xCAAB60", VA = "0x180CABF60", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060146D4 RID: 83668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146D4")]
		[Address(RVA = "0xCAC280", Offset = "0xCAAE80", VA = "0x180CAC280")]
		private void _DoEmit()
		{
		}

		// Token: 0x060146D5 RID: 83669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146D5")]
		[Address(RVA = "0xCABF00", Offset = "0xCAAB00", VA = "0x180CABF00", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x060146D6 RID: 83670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146D6")]
		[Address(RVA = "0xCAC4D0", Offset = "0xCAB0D0", VA = "0x180CAC4D0")]
		public RandomFinishEmitter()
		{
		}

		// Token: 0x060146D7 RID: 83671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60146D7")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04018200 RID: 98816
		[Token(Token = "0x4018200")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _count;

		// Token: 0x04018201 RID: 98817
		[Token(Token = "0x4018201")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _effect;

		// Token: 0x04018202 RID: 98818
		[Token(Token = "0x4018202")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 _randomRangeFrom;

		// Token: 0x04018203 RID: 98819
		[Token(Token = "0x4018203")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector3 _randomRangeTo;

		// Token: 0x04018204 RID: 98820
		[Token(Token = "0x4018204")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018205 RID: 98821
		[Token(Token = "0x4018205")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04018206 RID: 98822
		[Token(Token = "0x4018206")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DoEmit;

		// Token: 0x04018207 RID: 98823
		[Token(Token = "0x4018207")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x04018208 RID: 98824
		[Token(Token = "0x4018208")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
