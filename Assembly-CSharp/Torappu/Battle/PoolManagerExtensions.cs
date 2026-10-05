using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002161 RID: 8545
	[Token(Token = "0x2002161")]
	public static class PoolManagerExtensions
	{
		// Token: 0x0600D255 RID: 53845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D255")]
		[Address(RVA = "0x3536F20", Offset = "0x3535B20", VA = "0x183536F20")]
		private static void _RecycleInternal(this PoolManager pool, GameObject obj, float delay)
		{
		}

		// Token: 0x0600D256 RID: 53846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D256")]
		[Address(RVA = "0x3536E00", Offset = "0x3535A00", VA = "0x183536E00")]
		private static void _RecycleInternal(this PoolManager pool, Component comp, float delay)
		{
		}

		// Token: 0x0600D257 RID: 53847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D257")]
		[Address(RVA = "0x3536CC0", Offset = "0x35358C0", VA = "0x183536CC0")]
		private static IEnumerator _RecycleAsync(this PoolManager pool, GameObject obj, float delay)
		{
			return null;
		}

		// Token: 0x0600D258 RID: 53848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D258")]
		[Address(RVA = "0x3536D60", Offset = "0x3535960", VA = "0x183536D60")]
		private static IEnumerator _RecycleAsync(this PoolManager pool, Component comp, float delay)
		{
			return null;
		}

		// Token: 0x0600D259 RID: 53849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D259")]
		[Address(RVA = "0x3536B30", Offset = "0x3535730", VA = "0x183536B30")]
		public static void RecycleAsyncByBattleCoroutine(GameObject obj, float delay)
		{
		}

		// Token: 0x0600D25A RID: 53850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D25A")]
		[Address(RVA = "0x3536930", Offset = "0x3535530", VA = "0x183536930")]
		public static void RecycleAsyncByBattleCoroutine(Component comp, float delay)
		{
		}
	}
}
