using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063DD RID: 25565
	[Token(Token = "0x20063DD")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class AutoChessServiceObjPool
	{
		// Token: 0x06024DC8 RID: 150984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DC8")]
		[Address(RVA = "0x1FC09F0", Offset = "0x1FBF5F0", VA = "0x181FC09F0")]
		public static void Init()
		{
		}

		// Token: 0x06024DC9 RID: 150985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DC9")]
		[Address(RVA = "0x1FC0910", Offset = "0x1FBF510", VA = "0x181FC0910")]
		public static void Dispose()
		{
		}

		// Token: 0x06024DCA RID: 150986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024DCA")]
		[Address(RVA = "0x1FC0830", Offset = "0x1FBF430", VA = "0x181FC0830")]
		public static AutoChessBattleStepData AllocateStepData()
		{
			return null;
		}

		// Token: 0x06024DCB RID: 150987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024DCB")]
		[Address(RVA = "0x1FC07C0", Offset = "0x1FBF3C0", VA = "0x181FC07C0")]
		public static AutoChessBattleStepActionData AllocateStepActionData()
		{
			return null;
		}

		// Token: 0x06024DCC RID: 150988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024DCC")]
		[Address(RVA = "0x1FC08A0", Offset = "0x1FBF4A0", VA = "0x181FC08A0")]
		public static AutoChessBattleStepUpData AllocateStepUpData()
		{
			return null;
		}

		// Token: 0x06024DCD RID: 150989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DCD")]
		[Address(RVA = "0x1FC0F20", Offset = "0x1FBFB20", VA = "0x181FC0F20")]
		public static void Recycle(AutoChessBattleStepData stepInfo)
		{
		}

		// Token: 0x06024DCE RID: 150990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DCE")]
		[Address(RVA = "0x1FC0EB0", Offset = "0x1FBFAB0", VA = "0x181FC0EB0")]
		public static void Recycle(AutoChessBattleStepActionData stepActionInfo)
		{
		}

		// Token: 0x06024DCF RID: 150991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DCF")]
		[Address(RVA = "0x1FC0E40", Offset = "0x1FBFA40", VA = "0x181FC0E40")]
		public static void Recycle(AutoChessBattleStepUpData stepUpInfo)
		{
		}

		// Token: 0x06024DD0 RID: 150992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024DD0")]
		private static T _Allocate<T>(ObjectPool<T> pool) where T : class, IReusable, new()
		{
			return null;
		}

		// Token: 0x06024DD1 RID: 150993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DD1")]
		private static void _Recycle<T>(ObjectPool<T> pool, T obj) where T : class, IReusable, new()
		{
		}

		// Token: 0x0403386D RID: 211053
		[Token(Token = "0x403386D")]
		[FieldOffset(Offset = "0x0")]
		private static ObjectPool<AutoChessBattleStepData> s_stepDataPool;

		// Token: 0x0403386E RID: 211054
		[Token(Token = "0x403386E")]
		[FieldOffset(Offset = "0x8")]
		private static ObjectPool<AutoChessBattleStepActionData> s_stepActionDataPool;

		// Token: 0x0403386F RID: 211055
		[Token(Token = "0x403386F")]
		[FieldOffset(Offset = "0x10")]
		private static ObjectPool<AutoChessBattleStepUpData> s_stepUpDataPool;

		// Token: 0x04033870 RID: 211056
		[Token(Token = "0x4033870")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04033871 RID: 211057
		[Token(Token = "0x4033871")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04033872 RID: 211058
		[Token(Token = "0x4033872")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AllocateStepData;

		// Token: 0x04033873 RID: 211059
		[Token(Token = "0x4033873")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AllocateStepActionData;

		// Token: 0x04033874 RID: 211060
		[Token(Token = "0x4033874")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_AllocateStepUpData;

		// Token: 0x04033875 RID: 211061
		[Token(Token = "0x4033875")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Recycle;

		// Token: 0x04033876 RID: 211062
		[Token(Token = "0x4033876")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_Recycle;

		// Token: 0x04033877 RID: 211063
		[Token(Token = "0x4033877")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix2_Recycle;

		// Token: 0x04033878 RID: 211064
		[Token(Token = "0x4033878")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__Allocate;

		// Token: 0x04033879 RID: 211065
		[Token(Token = "0x4033879")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__Recycle;
	}
}
