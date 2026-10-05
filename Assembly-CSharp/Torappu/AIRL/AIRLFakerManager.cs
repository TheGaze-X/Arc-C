using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AIRL
{
	// Token: 0x0200202C RID: 8236
	[Token(Token = "0x200202C")]
	public class AIRLFakerManager : Singleton<AIRLFakerManager>
	{
		// Token: 0x0600CAF4 RID: 51956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAF4")]
		[Address(RVA = "0x34BDC90", Offset = "0x34BC890", VA = "0x1834BDC90")]
		private AIRLFakerManager()
		{
		}

		// Token: 0x0600CAF5 RID: 51957 RVA: 0x00049740 File Offset: 0x00047940
		[Token(Token = "0x600CAF5")]
		[Address(RVA = "0x34BDBD0", Offset = "0x34BC7D0", VA = "0x1834BDBD0")]
		public static bool Start(AIRLBridge.Options options)
		{
			return default(bool);
		}

		// Token: 0x0600CAF6 RID: 51958 RVA: 0x00049758 File Offset: 0x00047958
		[Token(Token = "0x600CAF6")]
		[Address(RVA = "0x34BDC40", Offset = "0x34BC840", VA = "0x1834BDC40")]
		public static bool Stop()
		{
			return default(bool);
		}

		// Token: 0x0600CAF7 RID: 51959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAF7")]
		[Address(RVA = "0x34BD990", Offset = "0x34BC590", VA = "0x1834BD990")]
		public void DoFixedUpdate()
		{
		}

		// Token: 0x0600CAF8 RID: 51960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAF8")]
		[Address(RVA = "0x34BDB10", Offset = "0x34BC710", VA = "0x1834BDB10")]
		public void OnGameReset()
		{
		}

		// Token: 0x0600CAF9 RID: 51961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAF9")]
		[Address(RVA = "0x34BD9F0", Offset = "0x34BC5F0", VA = "0x1834BD9F0")]
		public void OnGameInit()
		{
		}

		// Token: 0x0600CAFA RID: 51962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAFA")]
		[Address(RVA = "0x34BDAB0", Offset = "0x34BC6B0", VA = "0x1834BDAB0")]
		public void OnGameReady()
		{
		}

		// Token: 0x0600CAFB RID: 51963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAFB")]
		[Address(RVA = "0x34BDB70", Offset = "0x34BC770", VA = "0x1834BDB70")]
		public void OnGameStart()
		{
		}

		// Token: 0x0600CAFC RID: 51964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAFC")]
		[Address(RVA = "0x34BDA50", Offset = "0x34BC650", VA = "0x1834BDA50")]
		public void OnGameOver(int result)
		{
		}

		// Token: 0x0400D4D5 RID: 54485
		[Token(Token = "0x400D4D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400D4D6 RID: 54486
		[Token(Token = "0x400D4D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400D4D7 RID: 54487
		[Token(Token = "0x400D4D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0400D4D8 RID: 54488
		[Token(Token = "0x400D4D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoFixedUpdate;

		// Token: 0x0400D4D9 RID: 54489
		[Token(Token = "0x400D4D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameReset;

		// Token: 0x0400D4DA RID: 54490
		[Token(Token = "0x400D4DA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x0400D4DB RID: 54491
		[Token(Token = "0x400D4DB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x0400D4DC RID: 54492
		[Token(Token = "0x400D4DC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x0400D4DD RID: 54493
		[Token(Token = "0x400D4DD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnGameOver;
	}
}
