using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003224 RID: 12836
	[Token(Token = "0x2003224")]
	public class EffectRandomRotate : Effect.Behaviour
	{
		// Token: 0x060145C4 RID: 83396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145C4")]
		[Address(RVA = "0xC9AD60", Offset = "0xC99960", VA = "0x180C9AD60", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060145C5 RID: 83397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145C5")]
		[Address(RVA = "0xC9B000", Offset = "0xC99C00", VA = "0x180C9B000")]
		public EffectRandomRotate()
		{
		}

		// Token: 0x060145C6 RID: 83398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145C6")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x04018049 RID: 98377
		[Token(Token = "0x4018049")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _rotateAlongXAxis;

		// Token: 0x0401804A RID: 98378
		[Token(Token = "0x401804A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _minRotateAngleAlongXAxis;

		// Token: 0x0401804B RID: 98379
		[Token(Token = "0x401804B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _maxRotateAngleAlongXAxis;

		// Token: 0x0401804C RID: 98380
		[Token(Token = "0x401804C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _rotateAlongYAxis;

		// Token: 0x0401804D RID: 98381
		[Token(Token = "0x401804D")]
		[FieldOffset(Offset = "0x2D")]
		[SerializeField]
		private bool _rotateYFlipLOrR;

		// Token: 0x0401804E RID: 98382
		[Token(Token = "0x401804E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _minRotateAngleAlongYAxis;

		// Token: 0x0401804F RID: 98383
		[Token(Token = "0x401804F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _maxRotateAngleAlongYAxis;

		// Token: 0x04018050 RID: 98384
		[Token(Token = "0x4018050")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _rotateAlongZAxis;

		// Token: 0x04018051 RID: 98385
		[Token(Token = "0x4018051")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _minRotateAngleAlongZAxis;

		// Token: 0x04018052 RID: 98386
		[Token(Token = "0x4018052")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _maxRotateAngleAlongZAxis;

		// Token: 0x04018053 RID: 98387
		[Token(Token = "0x4018053")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool _ignoreOwnerValid;

		// Token: 0x04018054 RID: 98388
		[Token(Token = "0x4018054")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018055 RID: 98389
		[Token(Token = "0x4018055")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
