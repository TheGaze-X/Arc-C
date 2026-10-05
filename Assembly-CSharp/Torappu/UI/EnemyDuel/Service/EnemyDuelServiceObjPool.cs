using System;
using System.Text;
using Il2CppDummyDll;
using Torappu.ObjectPool;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x0200506B RID: 20587
	[Token(Token = "0x200506B")]
	internal static class EnemyDuelServiceObjPool
	{
		// Token: 0x0601E83C RID: 124988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E83C")]
		[Address(RVA = "0x18444C0", Offset = "0x18430C0", VA = "0x1818444C0")]
		public static EnemyDuelServiceStepData AllocateStepData()
		{
			return null;
		}

		// Token: 0x0601E83D RID: 124989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E83D")]
		[Address(RVA = "0x1844CD0", Offset = "0x18438D0", VA = "0x181844CD0")]
		public static void Recycle(EnemyDuelServiceStepData sd)
		{
		}

		// Token: 0x0601E83E RID: 124990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E83E")]
		[Address(RVA = "0x1844420", Offset = "0x1843020", VA = "0x181844420")]
		public static EnemyDuelServiceAction AllocateActionData()
		{
			return null;
		}

		// Token: 0x0601E83F RID: 124991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E83F")]
		[Address(RVA = "0x1844D30", Offset = "0x1843930", VA = "0x181844D30")]
		public static void Recycle(EnemyDuelServiceAction od)
		{
		}

		// Token: 0x0601E840 RID: 124992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E840")]
		[Address(RVA = "0x1844470", Offset = "0x1843070", VA = "0x181844470")]
		public static EnemyDuelEmojiData AllocateEmojiData()
		{
			return null;
		}

		// Token: 0x0601E841 RID: 124993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E841")]
		[Address(RVA = "0x1844D90", Offset = "0x1843990", VA = "0x181844D90")]
		public static void Recycle(EnemyDuelEmojiData od)
		{
		}

		// Token: 0x0601E842 RID: 124994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E842")]
		[Address(RVA = "0x1844890", Offset = "0x1843490", VA = "0x181844890")]
		public static void Init()
		{
		}

		// Token: 0x0601E843 RID: 124995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E843")]
		[Address(RVA = "0x18447D0", Offset = "0x18433D0", VA = "0x1818447D0")]
		public static void Dispose()
		{
		}

		// Token: 0x0601E844 RID: 124996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E844")]
		private static T _Allocate<T>(ObjectPool<T> pool) where T : class, IReusable, new()
		{
			return null;
		}

		// Token: 0x0601E845 RID: 124997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E845")]
		private static void _Recycle<T>(ObjectPool<T> pool, T obj) where T : class, IReusable
		{
		}

		// Token: 0x0601E846 RID: 124998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E846")]
		[Address(RVA = "0x1844510", Offset = "0x1843110", VA = "0x181844510")]
		public static void AppendPoolInfo(StringBuilder strbuild)
		{
		}

		// Token: 0x04028DEB RID: 167403
		[Token(Token = "0x4028DEB")]
		[FieldOffset(Offset = "0x0")]
		private static ObjectPool<EnemyDuelServiceStepData> s_stepDataPool;

		// Token: 0x04028DEC RID: 167404
		[Token(Token = "0x4028DEC")]
		[FieldOffset(Offset = "0x8")]
		private static ObjectPool<EnemyDuelServiceAction> s_actionDataPool;

		// Token: 0x04028DED RID: 167405
		[Token(Token = "0x4028DED")]
		[FieldOffset(Offset = "0x10")]
		private static ObjectPool<EnemyDuelEmojiData> s_emojiDataPool;
	}
}
