using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005406 RID: 21510
	[Token(Token = "0x2005406")]
	[Serializable]
	public class RoguelikeRewardShowTypeSet : ISerializationCallbackReceiver
	{
		// Token: 0x0601FA55 RID: 129621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA55")]
		[Address(RVA = "0x195FFA0", Offset = "0x195EBA0", VA = "0x18195FFA0")]
		public void Add(RoguelikeRewardShowType type)
		{
		}

		// Token: 0x0601FA56 RID: 129622 RVA: 0x000B2770 File Offset: 0x000B0970
		[Token(Token = "0x601FA56")]
		[Address(RVA = "0x1960290", Offset = "0x195EE90", VA = "0x181960290")]
		public bool Contains(RoguelikeRewardShowType type)
		{
			return default(bool);
		}

		// Token: 0x0601FA57 RID: 129623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA57")]
		[Address(RVA = "0x1960800", Offset = "0x195F400", VA = "0x181960800")]
		public void Remove(RoguelikeRewardShowType type)
		{
		}

		// Token: 0x0601FA58 RID: 129624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA58")]
		[Address(RVA = "0x1960010", Offset = "0x195EC10", VA = "0x181960010")]
		public void Clear()
		{
		}

		// Token: 0x0601FA59 RID: 129625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA59")]
		[Address(RVA = "0x19606A0", Offset = "0x195F2A0", VA = "0x1819606A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x0601FA5A RID: 129626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA5A")]
		[Address(RVA = "0x1960510", Offset = "0x195F110", VA = "0x181960510", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x0601FA5B RID: 129627 RVA: 0x000B2788 File Offset: 0x000B0988
		[Token(Token = "0x601FA5B")]
		[Address(RVA = "0x1960440", Offset = "0x195F040", VA = "0x181960440")]
		private bool IsValidType(RoguelikeRewardShowType type)
		{
			return default(bool);
		}

		// Token: 0x0601FA5C RID: 129628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FA5C")]
		[Address(RVA = "0x1960190", Offset = "0x195ED90", VA = "0x181960190")]
		public static RoguelikeRewardShowTypeSet Combine(RoguelikeRewardShowType type1, RoguelikeRewardShowType type2)
		{
			return null;
		}

		// Token: 0x0601FA5D RID: 129629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FA5D")]
		[Address(RVA = "0x1960110", Offset = "0x195ED10", VA = "0x181960110")]
		public static RoguelikeRewardShowTypeSet Combine(RoguelikeRewardShowType type1, RoguelikeRewardShowType type2, RoguelikeRewardShowType type3)
		{
			return null;
		}

		// Token: 0x0601FA5E RID: 129630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FA5E")]
		[Address(RVA = "0x1960060", Offset = "0x195EC60", VA = "0x181960060")]
		public static RoguelikeRewardShowTypeSet Combine(params RoguelikeRewardShowType[] types)
		{
			return null;
		}

		// Token: 0x0601FA5F RID: 129631 RVA: 0x000B27A0 File Offset: 0x000B09A0
		[Token(Token = "0x601FA5F")]
		[Address(RVA = "0x19602F0", Offset = "0x195EEF0", VA = "0x1819602F0")]
		public bool HasOverlap(RoguelikeRewardShowTypeSet other)
		{
			return default(bool);
		}

		// Token: 0x0601FA60 RID: 129632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FA60")]
		[Address(RVA = "0x1960930", Offset = "0x195F530", VA = "0x181960930")]
		public static implicit operator RoguelikeRewardShowTypeSet(RoguelikeRewardShowType type)
		{
			return null;
		}

		// Token: 0x0601FA61 RID: 129633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA61")]
		[Address(RVA = "0x1960860", Offset = "0x195F460", VA = "0x181960860")]
		public RoguelikeRewardShowTypeSet()
		{
		}

		// Token: 0x0402AA64 RID: 174692
		[Token(Token = "0x402AA64")]
		[FieldOffset(Offset = "0x10")]
		private HashSet<RoguelikeRewardShowType> _typeSet;

		// Token: 0x0402AA65 RID: 174693
		[Token(Token = "0x402AA65")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<RoguelikeRewardShowType> _serializedList;
	}
}
