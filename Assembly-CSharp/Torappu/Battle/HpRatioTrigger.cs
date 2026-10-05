using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002568 RID: 9576
	[Token(Token = "0x2002568")]
	public class HpRatioTrigger : TargetTrigger
	{
		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x0600F722 RID: 63266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002067")]
		public override Entity target
		{
			[Token(Token = "0x600F722")]
			[Address(RVA = "0x70EA20", Offset = "0x70D620", VA = "0x18070EA20", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x0600F723 RID: 63267 RVA: 0x0005C3D0 File Offset: 0x0005A5D0
		[Token(Token = "0x17002068")]
		public override bool isReadyToTrig
		{
			[Token(Token = "0x600F723")]
			[Address(RVA = "0x70E9C0", Offset = "0x70D5C0", VA = "0x18070E9C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F724 RID: 63268 RVA: 0x0005C3E8 File Offset: 0x0005A5E8
		[Token(Token = "0x600F724")]
		[Address(RVA = "0x70E740", Offset = "0x70D340", VA = "0x18070E740", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F725 RID: 63269 RVA: 0x0005C400 File Offset: 0x0005A600
		[Token(Token = "0x600F725")]
		[Address(RVA = "0x70E6D0", Offset = "0x70D2D0", VA = "0x18070E6D0", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F726 RID: 63270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F726")]
		[Address(RVA = "0x70E910", Offset = "0x70D510", VA = "0x18070E910")]
		public HpRatioTrigger()
		{
		}

		// Token: 0x0600F727 RID: 63271 RVA: 0x0005C418 File Offset: 0x0005A618
		[Token(Token = "0x600F727")]
		[Address(RVA = "0x6EF7F0", Offset = "0x6EE3F0", VA = "0x1806EF7F0")]
		private bool <>xLuaBaseProxy_get_isReadyToTrig()
		{
			return default(bool);
		}

		// Token: 0x04011287 RID: 70279
		[Token(Token = "0x4011287")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CompareType _compareType;

		// Token: 0x04011288 RID: 70280
		[Token(Token = "0x4011288")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FP _hpRatio;

		// Token: 0x04011289 RID: 70281
		[Token(Token = "0x4011289")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x0401128A RID: 70282
		[Token(Token = "0x401128A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isReadyToTrig;

		// Token: 0x0401128B RID: 70283
		[Token(Token = "0x401128B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x0401128C RID: 70284
		[Token(Token = "0x401128C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x0401128D RID: 70285
		[Token(Token = "0x401128D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
