using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200226B RID: 8811
	[Token(Token = "0x200226B")]
	public class CooperateCommonGlobalBuff : GlobalBuff
	{
		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x0600DD8C RID: 56716 RVA: 0x00050D18 File Offset: 0x0004EF18
		[Token(Token = "0x17001BE6")]
		public FP reviveInterval
		{
			[Token(Token = "0x600DD8C")]
			[Address(RVA = "0x362F090", Offset = "0x362DC90", VA = "0x18362F090")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x0600DD8D RID: 56717 RVA: 0x00050D30 File Offset: 0x0004EF30
		[Token(Token = "0x17001BE7")]
		public FP curReviveRemainingTime
		{
			[Token(Token = "0x600DD8D")]
			[Address(RVA = "0x362EFE0", Offset = "0x362DBE0", VA = "0x18362EFE0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x0600DD8E RID: 56718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD8E")]
		[Address(RVA = "0x362E620", Offset = "0x362D220", VA = "0x18362E620", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DD8F RID: 56719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD8F")]
		[Address(RVA = "0x362E8C0", Offset = "0x362D4C0", VA = "0x18362E8C0", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DD90 RID: 56720 RVA: 0x00050D48 File Offset: 0x0004EF48
		[Token(Token = "0x600DD90")]
		[Address(RVA = "0x362EC90", Offset = "0x362D890", VA = "0x18362EC90")]
		private int _GetReviveLifePoint(int currentLife)
		{
			return 0;
		}

		// Token: 0x0600DD91 RID: 56721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD91")]
		[Address(RVA = "0x362EE00", Offset = "0x362DA00", VA = "0x18362EE00")]
		private void _OnCooperateLifeZero(object arg)
		{
		}

		// Token: 0x0600DD92 RID: 56722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD92")]
		[Address(RVA = "0x362EBF0", Offset = "0x362D7F0", VA = "0x18362EBF0")]
		private void _BeforeResting(object arg)
		{
		}

		// Token: 0x0600DD93 RID: 56723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD93")]
		[Address(RVA = "0x362EF20", Offset = "0x362DB20", VA = "0x18362EF20")]
		public CooperateCommonGlobalBuff()
		{
		}

		// Token: 0x0600DD94 RID: 56724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD94")]
		[Address(RVA = "0x362AB00", Offset = "0x3629700", VA = "0x18362AB00")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0600DD95 RID: 56725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD95")]
		[Address(RVA = "0x362C380", Offset = "0x362AF80", VA = "0x18362C380")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F008 RID: 61448
		[Token(Token = "0x400F008")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private float _reviveInterval;

		// Token: 0x0400F009 RID: 61449
		[Token(Token = "0x400F009")]
		[FieldOffset(Offset = "0x14C")]
		[SerializeField]
		private int _reviveLifePoint;

		// Token: 0x0400F00A RID: 61450
		[Token(Token = "0x400F00A")]
		[FieldOffset(Offset = "0x150")]
		private GameModeFactory.CooperateGameMode m_gameMode;

		// Token: 0x0400F00B RID: 61451
		[Token(Token = "0x400F00B")]
		[FieldOffset(Offset = "0x158")]
		private readonly PeriodicTimer m_intervalTicker;

		// Token: 0x0400F00C RID: 61452
		[Token(Token = "0x400F00C")]
		[FieldOffset(Offset = "0x160")]
		private PlayerSide m_dyingSide;

		// Token: 0x0400F00D RID: 61453
		[Token(Token = "0x400F00D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_reviveInterval;

		// Token: 0x0400F00E RID: 61454
		[Token(Token = "0x400F00E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_curReviveRemainingTime;

		// Token: 0x0400F00F RID: 61455
		[Token(Token = "0x400F00F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400F010 RID: 61456
		[Token(Token = "0x400F010")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F011 RID: 61457
		[Token(Token = "0x400F011")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetReviveLifePoint;

		// Token: 0x0400F012 RID: 61458
		[Token(Token = "0x400F012")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnCooperateLifeZero;

		// Token: 0x0400F013 RID: 61459
		[Token(Token = "0x400F013")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__BeforeResting;

		// Token: 0x0400F014 RID: 61460
		[Token(Token = "0x400F014")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
