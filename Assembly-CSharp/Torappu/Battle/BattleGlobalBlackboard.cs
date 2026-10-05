using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002190 RID: 8592
	[Token(Token = "0x2002190")]
	public sealed class BattleGlobalBlackboard : IHotfixable
	{
		// Token: 0x0600D4BF RID: 54463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4BF")]
		[Address(RVA = "0x3585A10", Offset = "0x3584610", VA = "0x183585A10")]
		public void Assign(BattleGlobalBlackboard.BlackboardChannel channel, string key, float value)
		{
		}

		// Token: 0x0600D4C0 RID: 54464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4C0")]
		[Address(RVA = "0x35858A0", Offset = "0x35844A0", VA = "0x1835858A0")]
		public void Assign(BattleGlobalBlackboard.BlackboardChannel channel, string key, int value)
		{
		}

		// Token: 0x0600D4C1 RID: 54465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4C1")]
		[Address(RVA = "0x3585AC0", Offset = "0x35846C0", VA = "0x183585AC0")]
		public void Assign(BattleGlobalBlackboard.BlackboardChannel channel, string key, FP value)
		{
		}

		// Token: 0x0600D4C2 RID: 54466 RVA: 0x0004CEA8 File Offset: 0x0004B0A8
		[Token(Token = "0x600D4C2")]
		[Address(RVA = "0x3586100", Offset = "0x3584D00", VA = "0x183586100")]
		public bool TryGetFP(BattleGlobalBlackboard.BlackboardChannel channel, string key, out FP value)
		{
			return default(bool);
		}

		// Token: 0x0600D4C3 RID: 54467 RVA: 0x0004CEC0 File Offset: 0x0004B0C0
		[Token(Token = "0x600D4C3")]
		[Address(RVA = "0x3585E60", Offset = "0x3584A60", VA = "0x183585E60")]
		public FP GetFpOrDefault(BattleGlobalBlackboard.BlackboardChannel channel, string key, FP defaultValue, bool showWarning = false)
		{
			return default(FP);
		}

		// Token: 0x0600D4C4 RID: 54468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4C4")]
		[Address(RVA = "0x3585960", Offset = "0x3584560", VA = "0x183585960")]
		public void Assign(BattleGlobalBlackboard.BlackboardChannel channel, string key, string value)
		{
		}

		// Token: 0x0600D4C5 RID: 54469 RVA: 0x0004CED8 File Offset: 0x0004B0D8
		[Token(Token = "0x600D4C5")]
		[Address(RVA = "0x3585CE0", Offset = "0x35848E0", VA = "0x183585CE0")]
		public bool ContainsKey(BattleGlobalBlackboard.BlackboardChannel channel, string key)
		{
			return default(bool);
		}

		// Token: 0x0600D4C6 RID: 54470 RVA: 0x0004CEF0 File Offset: 0x0004B0F0
		[Token(Token = "0x600D4C6")]
		[Address(RVA = "0x3585C10", Offset = "0x3584810", VA = "0x183585C10")]
		public bool ContainsKey(BattleGlobalBlackboard.BlackboardChannelMask channelMask, string key)
		{
			return default(bool);
		}

		// Token: 0x0600D4C7 RID: 54471 RVA: 0x0004CF08 File Offset: 0x0004B108
		[Token(Token = "0x600D4C7")]
		[Address(RVA = "0x3586260", Offset = "0x3584E60", VA = "0x183586260")]
		public bool TryGetInt(BattleGlobalBlackboard.BlackboardChannel channel, string key, out int value)
		{
			return default(bool);
		}

		// Token: 0x0600D4C8 RID: 54472 RVA: 0x0004CF20 File Offset: 0x0004B120
		[Token(Token = "0x600D4C8")]
		[Address(RVA = "0x35861B0", Offset = "0x3584DB0", VA = "0x1835861B0")]
		public bool TryGetFloat(BattleGlobalBlackboard.BlackboardChannel channel, string key, out float value)
		{
			return default(bool);
		}

		// Token: 0x0600D4C9 RID: 54473 RVA: 0x0004CF38 File Offset: 0x0004B138
		[Token(Token = "0x600D4C9")]
		[Address(RVA = "0x3586310", Offset = "0x3584F10", VA = "0x183586310")]
		public bool TryGetString(BattleGlobalBlackboard.BlackboardChannel channel, string key, out string value)
		{
			return default(bool);
		}

		// Token: 0x0600D4CA RID: 54474 RVA: 0x0004CF50 File Offset: 0x0004B150
		[Token(Token = "0x600D4CA")]
		[Address(RVA = "0x3585F30", Offset = "0x3584B30", VA = "0x183585F30")]
		public int GetIntOrDefault(BattleGlobalBlackboard.BlackboardChannel channel, string key, int defaultValue, bool showWarning = false)
		{
			return 0;
		}

		// Token: 0x0600D4CB RID: 54475 RVA: 0x0004CF68 File Offset: 0x0004B168
		[Token(Token = "0x600D4CB")]
		[Address(RVA = "0x3585D90", Offset = "0x3584990", VA = "0x183585D90")]
		public float GetFloatOrDefault(BattleGlobalBlackboard.BlackboardChannel channel, string key, float defaultValue, bool showWarning = false)
		{
			return 0f;
		}

		// Token: 0x0600D4CC RID: 54476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4CC")]
		[Address(RVA = "0x3586000", Offset = "0x3584C00", VA = "0x183586000")]
		public void Reset()
		{
		}

		// Token: 0x0600D4CD RID: 54477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D4CD")]
		[Address(RVA = "0x35863C0", Offset = "0x3584FC0", VA = "0x1835863C0")]
		private Blackboard _EnsureChannel(BattleGlobalBlackboard.BlackboardChannel channel)
		{
			return null;
		}

		// Token: 0x0600D4CE RID: 54478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4CE")]
		[Address(RVA = "0x35864E0", Offset = "0x35850E0", VA = "0x1835864E0")]
		public BattleGlobalBlackboard()
		{
		}

		// Token: 0x0400E443 RID: 58435
		[Token(Token = "0x400E443")]
		public const BattleGlobalBlackboard.BlackboardChannelMask ALL_CHANNEL_MASK = BattleGlobalBlackboard.BlackboardChannelMask.CHARACTER | BattleGlobalBlackboard.BlackboardChannelMask.ENEMY | BattleGlobalBlackboard.BlackboardChannelMask.LEVEL | BattleGlobalBlackboard.BlackboardChannelMask.ROGUELIKE | BattleGlobalBlackboard.BlackboardChannelMask.AUTOCHESS | BattleGlobalBlackboard.BlackboardChannelMask.COOPERATE;

		// Token: 0x0400E444 RID: 58436
		[Token(Token = "0x400E444")]
		[FieldOffset(Offset = "0x10")]
		private Blackboard[] m_blackboards;

		// Token: 0x0400E445 RID: 58437
		[Token(Token = "0x400E445")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Assign;

		// Token: 0x0400E446 RID: 58438
		[Token(Token = "0x400E446")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Assign;

		// Token: 0x0400E447 RID: 58439
		[Token(Token = "0x400E447")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix2_Assign;

		// Token: 0x0400E448 RID: 58440
		[Token(Token = "0x400E448")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryGetFP;

		// Token: 0x0400E449 RID: 58441
		[Token(Token = "0x400E449")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetFpOrDefault;

		// Token: 0x0400E44A RID: 58442
		[Token(Token = "0x400E44A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix3_Assign;

		// Token: 0x0400E44B RID: 58443
		[Token(Token = "0x400E44B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ContainsKey;

		// Token: 0x0400E44C RID: 58444
		[Token(Token = "0x400E44C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_ContainsKey;

		// Token: 0x0400E44D RID: 58445
		[Token(Token = "0x400E44D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryGetInt;

		// Token: 0x0400E44E RID: 58446
		[Token(Token = "0x400E44E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryGetFloat;

		// Token: 0x0400E44F RID: 58447
		[Token(Token = "0x400E44F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TryGetString;

		// Token: 0x0400E450 RID: 58448
		[Token(Token = "0x400E450")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetIntOrDefault;

		// Token: 0x0400E451 RID: 58449
		[Token(Token = "0x400E451")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetFloatOrDefault;

		// Token: 0x0400E452 RID: 58450
		[Token(Token = "0x400E452")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0400E453 RID: 58451
		[Token(Token = "0x400E453")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EnsureChannel;

		// Token: 0x0400E454 RID: 58452
		[Token(Token = "0x400E454")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002191 RID: 8593
		[Token(Token = "0x2002191")]
		public enum BlackboardChannel
		{
			// Token: 0x0400E456 RID: 58454
			[Token(Token = "0x400E456")]
			CHARACTER,
			// Token: 0x0400E457 RID: 58455
			[Token(Token = "0x400E457")]
			ENEMY,
			// Token: 0x0400E458 RID: 58456
			[Token(Token = "0x400E458")]
			LEVEL,
			// Token: 0x0400E459 RID: 58457
			[Token(Token = "0x400E459")]
			ROGUELIKE,
			// Token: 0x0400E45A RID: 58458
			[Token(Token = "0x400E45A")]
			AUTOCHESS,
			// Token: 0x0400E45B RID: 58459
			[Token(Token = "0x400E45B")]
			COOPERATE,
			// Token: 0x0400E45C RID: 58460
			[Token(Token = "0x400E45C")]
			E_NUM
		}

		// Token: 0x02002192 RID: 8594
		[Token(Token = "0x2002192")]
		[Flags]
		public enum BlackboardChannelMask
		{
			// Token: 0x0400E45E RID: 58462
			[Token(Token = "0x400E45E")]
			CHARACTER = 1,
			// Token: 0x0400E45F RID: 58463
			[Token(Token = "0x400E45F")]
			ENEMY = 2,
			// Token: 0x0400E460 RID: 58464
			[Token(Token = "0x400E460")]
			LEVEL = 4,
			// Token: 0x0400E461 RID: 58465
			[Token(Token = "0x400E461")]
			ROGUELIKE = 8,
			// Token: 0x0400E462 RID: 58466
			[Token(Token = "0x400E462")]
			AUTOCHESS = 16,
			// Token: 0x0400E463 RID: 58467
			[Token(Token = "0x400E463")]
			COOPERATE = 32
		}
	}
}
