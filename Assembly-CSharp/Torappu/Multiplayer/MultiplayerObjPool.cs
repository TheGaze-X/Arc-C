using System;
using System.Text;
using Il2CppDummyDll;
using Torappu.ObjectPool;

namespace Torappu.Multiplayer
{
	// Token: 0x02001559 RID: 5465
	[Token(Token = "0x2001559")]
	internal static class MultiplayerObjPool
	{
		// Token: 0x06007CF5 RID: 31989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CF5")]
		[Address(RVA = "0x2848100", Offset = "0x2846D00", VA = "0x182848100")]
		public static StepData AllocateStepData()
		{
			return null;
		}

		// Token: 0x06007CF6 RID: 31990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CF6")]
		[Address(RVA = "0x2848970", Offset = "0x2847570", VA = "0x182848970")]
		public static StepData Recycle(StepData sd)
		{
			return null;
		}

		// Token: 0x06007CF7 RID: 31991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CF7")]
		[Address(RVA = "0x28480B0", Offset = "0x2846CB0", VA = "0x1828480B0")]
		public static PlayerOprtData AllocateOprtData()
		{
			return null;
		}

		// Token: 0x06007CF8 RID: 31992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CF8")]
		[Address(RVA = "0x2848910", Offset = "0x2847510", VA = "0x182848910")]
		public static PlayerOprtData Recycle(PlayerOprtData od)
		{
			return null;
		}

		// Token: 0x06007CF9 RID: 31993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CF9")]
		[Address(RVA = "0x2848060", Offset = "0x2846C60", VA = "0x182848060")]
		public static GameMarkData AllocateMarkData()
		{
			return null;
		}

		// Token: 0x06007CFA RID: 31994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CFA")]
		[Address(RVA = "0x28489D0", Offset = "0x28475D0", VA = "0x1828489D0")]
		public static GameMarkData Recycle(GameMarkData md)
		{
			return null;
		}

		// Token: 0x06007CFB RID: 31995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CFB")]
		[Address(RVA = "0x28484D0", Offset = "0x28470D0", VA = "0x1828484D0")]
		public static void Init()
		{
		}

		// Token: 0x06007CFC RID: 31996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CFC")]
		[Address(RVA = "0x2848410", Offset = "0x2847010", VA = "0x182848410")]
		public static void Dispose()
		{
		}

		// Token: 0x06007CFD RID: 31997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007CFD")]
		private static T _Allocate<T>(ObjectPool<T> pool) where T : class, IReusable, new()
		{
			return null;
		}

		// Token: 0x06007CFE RID: 31998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CFE")]
		private static void _Recycle<T>(ObjectPool<T> pool, T obj) where T : class, IReusable
		{
		}

		// Token: 0x06007CFF RID: 31999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CFF")]
		[Address(RVA = "0x2848150", Offset = "0x2846D50", VA = "0x182848150")]
		public static void AppendPoolInfo(StringBuilder strbuild)
		{
		}

		// Token: 0x04007DB1 RID: 32177
		[Token(Token = "0x4007DB1")]
		[FieldOffset(Offset = "0x0")]
		private static ObjectPool<StepData> s_stepDataPool;

		// Token: 0x04007DB2 RID: 32178
		[Token(Token = "0x4007DB2")]
		[FieldOffset(Offset = "0x8")]
		private static ObjectPool<PlayerOprtData> s_oprtDataPool;

		// Token: 0x04007DB3 RID: 32179
		[Token(Token = "0x4007DB3")]
		[FieldOffset(Offset = "0x10")]
		private static ObjectPool<GameMarkData> s_markDataPool;
	}
}
