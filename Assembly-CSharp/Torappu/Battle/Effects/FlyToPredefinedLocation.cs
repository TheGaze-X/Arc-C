using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200322B RID: 12843
	[Token(Token = "0x200322B")]
	public class FlyToPredefinedLocation : Effect.Behaviour
	{
		// Token: 0x060145E1 RID: 83425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145E1")]
		[Address(RVA = "0xC9C690", Offset = "0xC9B290", VA = "0x180C9C690", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060145E2 RID: 83426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145E2")]
		[Address(RVA = "0xC9CA40", Offset = "0xC9B640", VA = "0x180C9CA40", Slot = "7")]
		public override void OnRecycle()
		{
		}

		// Token: 0x060145E3 RID: 83427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145E3")]
		[Address(RVA = "0xC9CBB0", Offset = "0xC9B7B0", VA = "0x180C9CBB0")]
		public FlyToPredefinedLocation()
		{
		}

		// Token: 0x060145E6 RID: 83430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145E6")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060145E7 RID: 83431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145E7")]
		[Address(RVA = "0xC9CBA0", Offset = "0xC9B7A0", VA = "0x180C9CBA0")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x04018080 RID: 98432
		[Token(Token = "0x4018080")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PredefinedLocation _location;

		// Token: 0x04018081 RID: 98433
		[Token(Token = "0x4018081")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _duration;

		// Token: 0x04018082 RID: 98434
		[Token(Token = "0x4018082")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Ease _easeType;

		// Token: 0x04018083 RID: 98435
		[Token(Token = "0x4018083")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _isIndependentUpdate;

		// Token: 0x04018084 RID: 98436
		[Token(Token = "0x4018084")]
		[FieldOffset(Offset = "0x2D")]
		[SerializeField]
		private bool _inversStartEnd;

		// Token: 0x04018085 RID: 98437
		[Token(Token = "0x4018085")]
		[FieldOffset(Offset = "0x2E")]
		[SerializeField]
		private bool _ignorePlayerSide;

		// Token: 0x04018086 RID: 98438
		[Token(Token = "0x4018086")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_tween;

		// Token: 0x04018087 RID: 98439
		[Token(Token = "0x4018087")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018088 RID: 98440
		[Token(Token = "0x4018088")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04018089 RID: 98441
		[Token(Token = "0x4018089")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
