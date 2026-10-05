using System;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002265 RID: 8805
	[Token(Token = "0x2002265")]
	public class AutoChessTimeOutGlobalBuff : GlobalBuff
	{
		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x0600DD67 RID: 56679 RVA: 0x00050CD0 File Offset: 0x0004EED0
		// (set) Token: 0x0600DD68 RID: 56680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001BE4")]
		private bool isTimeReached
		{
			[Token(Token = "0x600DD67")]
			[Address(RVA = "0x362C990", Offset = "0x362B590", VA = "0x18362C990")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600DD68")]
			[Address(RVA = "0x362C9F0", Offset = "0x362B5F0", VA = "0x18362C9F0")]
			set
			{
			}
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x0600DD69 RID: 56681 RVA: 0x00050CE8 File Offset: 0x0004EEE8
		[Token(Token = "0x17001BE5")]
		private bool isGlobalBuffValid
		{
			[Token(Token = "0x600DD69")]
			[Address(RVA = "0x362C880", Offset = "0x362B480", VA = "0x18362C880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600DD6A RID: 56682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD6A")]
		[Address(RVA = "0x362BE10", Offset = "0x362AA10", VA = "0x18362BE10", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DD6B RID: 56683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD6B")]
		[Address(RVA = "0x362C100", Offset = "0x362AD00", VA = "0x18362C100", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DD6C RID: 56684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD6C")]
		[Address(RVA = "0x362C2D0", Offset = "0x362AED0", VA = "0x18362C2D0", Slot = "12")]
		public override void TryAddBuff(Unit unit, bool isInit = true)
		{
		}

		// Token: 0x0600DD6D RID: 56685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD6D")]
		[Address(RVA = "0x362C3E0", Offset = "0x362AFE0", VA = "0x18362C3E0")]
		private void _SetLevelTimer()
		{
		}

		// Token: 0x0600DD6E RID: 56686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD6E")]
		[Address(RVA = "0x362C4C0", Offset = "0x362B0C0", VA = "0x18362C4C0")]
		private void _UpdateBuffsWhenValidChanged()
		{
		}

		// Token: 0x0600DD6F RID: 56687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD6F")]
		[Address(RVA = "0x362C6A0", Offset = "0x362B2A0", VA = "0x18362C6A0")]
		private void _UpdateTimeOutCameraEffect()
		{
		}

		// Token: 0x0600DD70 RID: 56688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD70")]
		[Address(RVA = "0x362BFD0", Offset = "0x362ABD0", VA = "0x18362BFD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600DD71 RID: 56689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD71")]
		[Address(RVA = "0x362BD20", Offset = "0x362A920", VA = "0x18362BD20")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600DD72 RID: 56690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD72")]
		[Address(RVA = "0x362C820", Offset = "0x362B420", VA = "0x18362C820")]
		public AutoChessTimeOutGlobalBuff()
		{
		}

		// Token: 0x0600DD73 RID: 56691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD73")]
		[Address(RVA = "0x362AB00", Offset = "0x3629700", VA = "0x18362AB00")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0600DD74 RID: 56692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD74")]
		[Address(RVA = "0x362C380", Offset = "0x362AF80", VA = "0x18362C380")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600DD75 RID: 56693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD75")]
		[Address(RVA = "0x362AB70", Offset = "0x3629770", VA = "0x18362AB70")]
		private void <>xLuaBaseProxy_TryAddBuff(Unit P0, bool P1)
		{
		}

		// Token: 0x0600DD76 RID: 56694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD76")]
		[Address(RVA = "0x362AB10", Offset = "0x3629710", VA = "0x18362AB10")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0400EFD8 RID: 61400
		[Token(Token = "0x400EFD8")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private bool _assginOnTimeNotReach;

		// Token: 0x0400EFD9 RID: 61401
		[Token(Token = "0x400EFD9")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private string _timeOutCameraEffect;

		// Token: 0x0400EFDA RID: 61402
		[Token(Token = "0x400EFDA")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private bool _useStateEndTime;

		// Token: 0x0400EFDB RID: 61403
		[Token(Token = "0x400EFDB")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private string _audioSignalWhenReached;

		// Token: 0x0400EFDC RID: 61404
		[Token(Token = "0x400EFDC")]
		[FieldOffset(Offset = "0x168")]
		private bool m_isTimeReached;

		// Token: 0x0400EFDD RID: 61405
		[Token(Token = "0x400EFDD")]
		[FieldOffset(Offset = "0x170")]
		private CameraEffect m_timeOutCameraEffect;

		// Token: 0x0400EFDE RID: 61406
		[Token(Token = "0x400EFDE")]
		[FieldOffset(Offset = "0x178")]
		private DateTime m_timeOut;

		// Token: 0x0400EFDF RID: 61407
		[Token(Token = "0x400EFDF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isTimeReached;

		// Token: 0x0400EFE0 RID: 61408
		[Token(Token = "0x400EFE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isTimeReached;

		// Token: 0x0400EFE1 RID: 61409
		[Token(Token = "0x400EFE1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isGlobalBuffValid;

		// Token: 0x0400EFE2 RID: 61410
		[Token(Token = "0x400EFE2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400EFE3 RID: 61411
		[Token(Token = "0x400EFE3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400EFE4 RID: 61412
		[Token(Token = "0x400EFE4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryAddBuff;

		// Token: 0x0400EFE5 RID: 61413
		[Token(Token = "0x400EFE5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetLevelTimer;

		// Token: 0x0400EFE6 RID: 61414
		[Token(Token = "0x400EFE6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateBuffsWhenValidChanged;

		// Token: 0x0400EFE7 RID: 61415
		[Token(Token = "0x400EFE7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateTimeOutCameraEffect;

		// Token: 0x0400EFE8 RID: 61416
		[Token(Token = "0x400EFE8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400EFE9 RID: 61417
		[Token(Token = "0x400EFE9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400EFEA RID: 61418
		[Token(Token = "0x400EFEA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
