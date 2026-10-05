using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002881 RID: 10369
	[Token(Token = "0x2002881")]
	[Serializable]
	public class ParamValue : IEquatable<ParamValue>
	{
		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x06011431 RID: 70705 RVA: 0x0006A5C0 File Offset: 0x000687C0
		[Token(Token = "0x17002624")]
		public bool isInvalid
		{
			[Token(Token = "0x6011431")]
			[Address(RVA = "0x9262F0", Offset = "0x924EF0", VA = "0x1809262F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011432 RID: 70706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011432")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ParamValue()
		{
		}

		// Token: 0x06011433 RID: 70707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011433")]
		public static ParamValue New<T>(T param)
		{
			return null;
		}

		// Token: 0x06011434 RID: 70708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011434")]
		public static ParamValue New<T>(List<T> param)
		{
			return null;
		}

		// Token: 0x06011435 RID: 70709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011435")]
		[Address(RVA = "0x925DA0", Offset = "0x9249A0", VA = "0x180925DA0")]
		public static ParamValue NewList(IList param)
		{
			return null;
		}

		// Token: 0x06011436 RID: 70710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011436")]
		[Address(RVA = "0x926060", Offset = "0x924C60", VA = "0x180926060")]
		public static ParamValue New(ParamRealType type)
		{
			return null;
		}

		// Token: 0x06011437 RID: 70711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011437")]
		[Address(RVA = "0x925D30", Offset = "0x924930", VA = "0x180925D30")]
		public static ParamValue NewEmpty()
		{
			return null;
		}

		// Token: 0x06011438 RID: 70712 RVA: 0x0006A5D8 File Offset: 0x000687D8
		[Token(Token = "0x6011438")]
		[Address(RVA = "0x925C20", Offset = "0x924820", VA = "0x180925C20")]
		public int GetListItemLength()
		{
			return 0;
		}

		// Token: 0x06011439 RID: 70713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011439")]
		[Address(RVA = "0x9256F0", Offset = "0x9242F0", VA = "0x1809256F0")]
		public ParamValue Duplicate()
		{
			return null;
		}

		// Token: 0x0601143A RID: 70714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601143A")]
		[Address(RVA = "0x9256D0", Offset = "0x9242D0", VA = "0x1809256D0")]
		public void Clear()
		{
		}

		// Token: 0x0601143B RID: 70715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601143B")]
		[Address(RVA = "0x9256A0", Offset = "0x9242A0", VA = "0x1809256A0")]
		public void ClearValue()
		{
		}

		// Token: 0x0601143C RID: 70716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601143C")]
		[Address(RVA = "0x926190", Offset = "0x924D90", VA = "0x180926190")]
		public void ToStringSingle(out string result, bool force = false)
		{
		}

		// Token: 0x0601143D RID: 70717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601143D")]
		[Address(RVA = "0x926070", Offset = "0x924C70", VA = "0x180926070")]
		public void ToStringList(List<string> result)
		{
		}

		// Token: 0x0601143E RID: 70718 RVA: 0x0006A5F0 File Offset: 0x000687F0
		[Token(Token = "0x601143E")]
		[Address(RVA = "0x9257E0", Offset = "0x9243E0", VA = "0x1809257E0", Slot = "4")]
		public bool Equals(ParamValue other)
		{
			return default(bool);
		}

		// Token: 0x0601143F RID: 70719 RVA: 0x0006A608 File Offset: 0x00068808
		[Token(Token = "0x601143F")]
		[Address(RVA = "0x925950", Offset = "0x924550", VA = "0x180925950", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06011440 RID: 70720 RVA: 0x0006A620 File Offset: 0x00068820
		[Token(Token = "0x6011440")]
		[Address(RVA = "0x925BB0", Offset = "0x9247B0", VA = "0x180925BB0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040134CD RID: 79053
		[Token(Token = "0x40134CD")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public ParamRealType type;

		// Token: 0x040134CE RID: 79054
		[Token(Token = "0x40134CE")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public ParamValueAtom[] valueArray;
	}
}
