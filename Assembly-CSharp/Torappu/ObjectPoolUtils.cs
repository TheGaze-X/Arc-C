using System;
using System.Collections.Generic;
using System.Text;
using Hypergryph.ToolKits;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013E8 RID: 5096
	[Token(Token = "0x20013E8")]
	public static class ObjectPoolUtils
	{
		// Token: 0x0600744B RID: 29771 RVA: 0x00033BB8 File Offset: 0x00031DB8
		[Token(Token = "0x600744B")]
		[Address(RVA = "0x2208860", Offset = "0x2207460", VA = "0x182208860")]
		[Obsolete("Use \"StringBuilderPool\" instead.")]
		public static GenericPool<StringBuilder>.Ref GetStringBuilder()
		{
			return default(GenericPool<StringBuilder>.Ref);
		}

		// Token: 0x0600744C RID: 29772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600744C")]
		[Address(RVA = "0x2208990", Offset = "0x2207590", VA = "0x182208990")]
		private static void _ResetStringBuilder(StringBuilder inst)
		{
		}

		// Token: 0x0600744D RID: 29773 RVA: 0x00033BD0 File Offset: 0x00031DD0
		[Token(Token = "0x600744D")]
		[Obsolete("Use \"GenericListPool<T>\" instead.")]
		public static GenericPool<List<T>>.Ref GetList<T>()
		{
			return default(GenericPool<List<T>>.Ref);
		}

		// Token: 0x0600744E RID: 29774 RVA: 0x00033BE8 File Offset: 0x00031DE8
		[Token(Token = "0x600744E")]
		[Obsolete("Use \"GenericListPool<T>\" instead.")]
		public static GenericPool<List<T>>.Ref GetList<T>(out List<T> result)
		{
			return default(GenericPool<List<T>>.Ref);
		}

		// Token: 0x0600744F RID: 29775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600744F")]
		private static void _ResetList<T>(List<T> inst)
		{
		}

		// Token: 0x06007450 RID: 29776 RVA: 0x00033C00 File Offset: 0x00031E00
		[Token(Token = "0x6007450")]
		[Obsolete("Use \"GenericDictPool<K, V>\" instead.")]
		public static GenericPool<Dictionary<TKey, TValue>>.Ref GetDict<TKey, TValue>()
		{
			return default(GenericPool<Dictionary<TKey, TValue>>.Ref);
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007451")]
		private static void _ResetDict<TKey, TValue>(Dictionary<TKey, TValue> inst)
		{
		}

		// Token: 0x06007452 RID: 29778 RVA: 0x00033C18 File Offset: 0x00031E18
		[Token(Token = "0x6007452")]
		[Address(RVA = "0x2208790", Offset = "0x2207390", VA = "0x182208790")]
		public static GenericPool<Blackboard>.Ref GetBlackboard()
		{
			return default(GenericPool<Blackboard>.Ref);
		}

		// Token: 0x06007453 RID: 29779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007453")]
		[Address(RVA = "0x2208930", Offset = "0x2207530", VA = "0x182208930")]
		private static void _ResetBlackboard(Blackboard blackboard)
		{
		}
	}
}
