using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002193 RID: 8595
	[Token(Token = "0x2002193")]
	public class BattleInitializer : SingletonMonoBehaviour<BattleInitializer>, ISingletonNotAutoCreate
	{
		// Token: 0x0600D4CF RID: 54479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4CF")]
		[Address(RVA = "0x3586570", Offset = "0x3585170", VA = "0x183586570")]
		protected void DoPreProcess()
		{
		}

		// Token: 0x0600D4D0 RID: 54480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4D0")]
		[Address(RVA = "0x3586850", Offset = "0x3585450", VA = "0x183586850", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600D4D1 RID: 54481 RVA: 0x0004CF80 File Offset: 0x0004B180
		[Token(Token = "0x600D4D1")]
		[Address(RVA = "0x35867B0", Offset = "0x35853B0", VA = "0x1835867B0", Slot = "8")]
		protected virtual GameModeMeta GetDefaultMeta()
		{
			return default(GameModeMeta);
		}

		// Token: 0x0600D4D2 RID: 54482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4D2")]
		[Address(RVA = "0x3586AE0", Offset = "0x35856E0", VA = "0x183586AE0")]
		public BattleInitializer()
		{
		}

		// Token: 0x0400E464 RID: 58468
		[Token(Token = "0x400E464")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreProcess;

		// Token: 0x0400E465 RID: 58469
		[Token(Token = "0x400E465")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400E466 RID: 58470
		[Token(Token = "0x400E466")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDefaultMeta;

		// Token: 0x0400E467 RID: 58471
		[Token(Token = "0x400E467")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
