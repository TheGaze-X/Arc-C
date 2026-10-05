using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002878 RID: 10360
	[Token(Token = "0x2002878")]
	public class ParamParserVector2 : ParamParser<Vector2>
	{
		// Token: 0x1700260C RID: 9740
		// (get) Token: 0x060113F5 RID: 70645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700260C")]
		public override ParamRealType[] paramRealTypeMask
		{
			[Token(Token = "0x60113F5")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700260D RID: 9741
		// (get) Token: 0x060113F6 RID: 70646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700260D")]
		public override ParamValueType[] paramValueTypeMask
		{
			[Token(Token = "0x60113F6")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700260E RID: 9742
		// (get) Token: 0x060113F7 RID: 70647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700260E")]
		public override ParamRealType[] paramListRealTypeMask
		{
			[Token(Token = "0x60113F7")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x060113F8 RID: 70648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700260F")]
		public override ParamValueType[] paramListValueTypeMask
		{
			[Token(Token = "0x60113F8")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x060113F9 RID: 70649 RVA: 0x0006A488 File Offset: 0x00068688
		[Token(Token = "0x17002610")]
		public override int lengthPerItem
		{
			[Token(Token = "0x60113F9")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "22")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060113FA RID: 70650 RVA: 0x0006A4A0 File Offset: 0x000686A0
		[Token(Token = "0x60113FA")]
		[Address(RVA = "0x923A70", Offset = "0x922670", VA = "0x180923A70", Slot = "23")]
		protected override Vector2 ValueAtIndexGetter(ParamValue paramValue, int index)
		{
			return default(Vector2);
		}

		// Token: 0x060113FB RID: 70651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113FB")]
		[Address(RVA = "0x923BE0", Offset = "0x9227E0", VA = "0x180923BE0", Slot = "24")]
		protected override void ValueAtIndexSetter(ParamValue paramValue, Vector2 value, int index)
		{
		}

		// Token: 0x060113FC RID: 70652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113FC")]
		[Address(RVA = "0x923960", Offset = "0x922560", VA = "0x180923960", Slot = "25")]
		public override string ToStringPerItem(ParamValue paramValue, int itemIndex)
		{
			return null;
		}

		// Token: 0x060113FD RID: 70653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113FD")]
		[Address(RVA = "0x923CE0", Offset = "0x9228E0", VA = "0x180923CE0")]
		public ParamParserVector2()
		{
		}
	}
}
