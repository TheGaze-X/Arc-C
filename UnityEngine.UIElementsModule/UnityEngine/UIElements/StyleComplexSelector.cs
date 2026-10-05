using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000248 RID: 584
	[Token(Token = "0x2000248")]
	[Serializable]
	internal class StyleComplexSelector
	{
		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x00009270 File Offset: 0x00007470
		[Token(Token = "0x17000443")]
		public int specificity
		{
			[Token(Token = "0x60010BF")]
			[Address(RVA = "0x592C450", Offset = "0x592B050", VA = "0x18592C450")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060010C1 RID: 4289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000444")]
		public StyleRule rule
		{
			[Token(Token = "0x60010C0")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010C1")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000445")]
		public StyleSelector[] selectors
		{
			[Token(Token = "0x60010C2")]
			[Address(RVA = "0x5911BE0", Offset = "0x59107E0", VA = "0x185911BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010C3")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			internal set
			{
			}
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C4")]
		[Address(RVA = "0x5B206A0", Offset = "0x5B1F2A0", VA = "0x185B206A0")]
		internal void CachePseudoStateMasks()
		{
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60010C5")]
		[Address(RVA = "0x5B20C80", Offset = "0x5B1F880", VA = "0x185B20C80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StyleComplexSelector()
		{
		}

		// Token: 0x04000887 RID: 2183
		[Token(Token = "0x4000887")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_Specificity;

		// Token: 0x04000889 RID: 2185
		[Token(Token = "0x4000889")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StyleSelector[] m_Selectors;

		// Token: 0x0400088A RID: 2186
		[Token(Token = "0x400088A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal int ruleIndex;

		// Token: 0x0400088B RID: 2187
		[Token(Token = "0x400088B")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		internal StyleComplexSelector nextInTable;

		// Token: 0x0400088C RID: 2188
		[Token(Token = "0x400088C")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		internal int orderInStyleSheet;

		// Token: 0x0400088D RID: 2189
		[Token(Token = "0x400088D")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, StyleComplexSelector.PseudoStateData> s_PseudoStates;

		// Token: 0x02000249 RID: 585
		[Token(Token = "0x2000249")]
		private struct PseudoStateData
		{
			// Token: 0x060010C7 RID: 4295 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60010C7")]
			[Address(RVA = "0x4006D40", Offset = "0x4005940", VA = "0x184006D40")]
			public PseudoStateData(PseudoStates state, bool negate)
			{
			}

			// Token: 0x0400088E RID: 2190
			[Token(Token = "0x400088E")]
			[FieldOffset(Offset = "0x0")]
			public readonly PseudoStates state;

			// Token: 0x0400088F RID: 2191
			[Token(Token = "0x400088F")]
			[FieldOffset(Offset = "0x4")]
			public readonly bool negate;
		}
	}
}
