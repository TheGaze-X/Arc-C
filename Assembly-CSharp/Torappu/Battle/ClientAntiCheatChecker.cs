using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200214B RID: 8523
	[Token(Token = "0x200214B")]
	public class ClientAntiCheatChecker : IHotfixable
	{
		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x0600D1AF RID: 53679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700191C")]
		public ListDict<int, List<object>> errorLog
		{
			[Token(Token = "0x600D1AF")]
			[Address(RVA = "0x35351B0", Offset = "0x3533DB0", VA = "0x1835351B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D1B0 RID: 53680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1B0")]
		[Address(RVA = "0x3533930", Offset = "0x3532530", VA = "0x183533930")]
		public void Init(float moveMultiplier, FP costIncreaseTime)
		{
		}

		// Token: 0x0600D1B1 RID: 53681 RVA: 0x0004B8D0 File Offset: 0x00049AD0
		[Token(Token = "0x600D1B1")]
		[Address(RVA = "0x35345D0", Offset = "0x35331D0", VA = "0x1835345D0")]
		private bool _CheckEnemyMoveSpeed(Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x0600D1B2 RID: 53682 RVA: 0x0004B8E8 File Offset: 0x00049AE8
		[Token(Token = "0x600D1B2")]
		[Address(RVA = "0x3534250", Offset = "0x3532E50", VA = "0x183534250")]
		private bool _CheckCostIncreaseTime()
		{
			return default(bool);
		}

		// Token: 0x0600D1B3 RID: 53683 RVA: 0x0004B900 File Offset: 0x00049B00
		[Token(Token = "0x600D1B3")]
		[Address(RVA = "0x3533D60", Offset = "0x3532960", VA = "0x183533D60")]
		private bool _CheckCharacterAttackTime(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600D1B4 RID: 53684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1B4")]
		[Address(RVA = "0x3534970", Offset = "0x3533570", VA = "0x183534970")]
		private void _DoCheck()
		{
		}

		// Token: 0x0600D1B5 RID: 53685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1B5")]
		[Address(RVA = "0x3534DC0", Offset = "0x35339C0", VA = "0x183534DC0")]
		private void _ResetTimer()
		{
		}

		// Token: 0x0600D1B6 RID: 53686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1B6")]
		[Address(RVA = "0x3533AD0", Offset = "0x35326D0", VA = "0x183533AD0")]
		public void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x0600D1B7 RID: 53687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1B7")]
		[Address(RVA = "0x35337C0", Offset = "0x35323C0", VA = "0x1835337C0")]
		public void Clear()
		{
		}

		// Token: 0x0600D1B8 RID: 53688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D1B8")]
		[Address(RVA = "0x3535000", Offset = "0x3533C00", VA = "0x183535000")]
		public ClientAntiCheatChecker()
		{
		}

		// Token: 0x0400E033 RID: 57395
		[Token(Token = "0x400E033")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ObscuredVector2 RANDOM_TIME_RANGE;

		// Token: 0x0400E034 RID: 57396
		[Token(Token = "0x400E034")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly ObscuredInt MAX_CHECK_TIMES;

		// Token: 0x0400E035 RID: 57397
		[Token(Token = "0x400E035")]
		[FieldOffset(Offset = "0x10")]
		private ObscuredFloat m_moveMultiplier;

		// Token: 0x0400E036 RID: 57398
		[Token(Token = "0x400E036")]
		[FieldOffset(Offset = "0x28")]
		private ObscuredFP m_costIncreaseTime;

		// Token: 0x0400E037 RID: 57399
		[Token(Token = "0x400E037")]
		[FieldOffset(Offset = "0x50")]
		private PeriodicTimer m_checkTimer;

		// Token: 0x0400E038 RID: 57400
		[Token(Token = "0x400E038")]
		[FieldOffset(Offset = "0x58")]
		private ObscuredInt m_checkTimes;

		// Token: 0x0400E039 RID: 57401
		[Token(Token = "0x400E039")]
		[FieldOffset(Offset = "0x6C")]
		private ObscuredBool m_isValidBattle;

		// Token: 0x0400E03A RID: 57402
		[Token(Token = "0x400E03A")]
		[FieldOffset(Offset = "0x78")]
		private ListDict<int, List<object>> m_errorLog;

		// Token: 0x0400E03B RID: 57403
		[Token(Token = "0x400E03B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_errorLog;

		// Token: 0x0400E03C RID: 57404
		[Token(Token = "0x400E03C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400E03D RID: 57405
		[Token(Token = "0x400E03D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckEnemyMoveSpeed;

		// Token: 0x0400E03E RID: 57406
		[Token(Token = "0x400E03E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckCostIncreaseTime;

		// Token: 0x0400E03F RID: 57407
		[Token(Token = "0x400E03F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckCharacterAttackTime;

		// Token: 0x0400E040 RID: 57408
		[Token(Token = "0x400E040")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DoCheck;

		// Token: 0x0400E041 RID: 57409
		[Token(Token = "0x400E041")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ResetTimer;

		// Token: 0x0400E042 RID: 57410
		[Token(Token = "0x400E042")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x0400E043 RID: 57411
		[Token(Token = "0x400E043")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0400E044 RID: 57412
		[Token(Token = "0x400E044")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200214C RID: 8524
		[Token(Token = "0x200214C")]
		private enum AntiCheatType
		{
			// Token: 0x0400E046 RID: 57414
			[Token(Token = "0x400E046")]
			ENEMY_MOVE_SPEED,
			// Token: 0x0400E047 RID: 57415
			[Token(Token = "0x400E047")]
			LEVEL_OPTIONS_COST_INCREASE,
			// Token: 0x0400E048 RID: 57416
			[Token(Token = "0x400E048")]
			CHARACTER_ATTACK_TIME
		}
	}
}
