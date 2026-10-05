using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FA4 RID: 28580
	[Token(Token = "0x2006FA4")]
	public class ActMultiV3MatchTipModel : IHotfixable, IItemWithWeight
	{
		// Token: 0x17005FB9 RID: 24505
		// (get) Token: 0x06028952 RID: 166226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005FB9")]
		public string text
		{
			[Token(Token = "0x6028952")]
			[Address(RVA = "0x23D99E0", Offset = "0x23D85E0", VA = "0x1823D99E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005FBA RID: 24506
		// (get) Token: 0x06028953 RID: 166227 RVA: 0x000D2378 File Offset: 0x000D0578
		[Token(Token = "0x17005FBA")]
		public float weightValue
		{
			[Token(Token = "0x6028953")]
			[Address(RVA = "0x23D9A40", Offset = "0x23D8640", VA = "0x1823D9A40", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06028954 RID: 166228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028954")]
		[Address(RVA = "0x23D98F0", Offset = "0x23D84F0", VA = "0x1823D98F0")]
		public void LoadData(ActMultiV3TipsData tipData)
		{
		}

		// Token: 0x06028955 RID: 166229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028955")]
		[Address(RVA = "0x23D9980", Offset = "0x23D8580", VA = "0x1823D9980")]
		public ActMultiV3MatchTipModel()
		{
		}

		// Token: 0x04039CC5 RID: 236741
		[Token(Token = "0x4039CC5")]
		[FieldOffset(Offset = "0x10")]
		private float m_weight;

		// Token: 0x04039CC6 RID: 236742
		[Token(Token = "0x4039CC6")]
		[FieldOffset(Offset = "0x18")]
		private string m_text;

		// Token: 0x04039CC7 RID: 236743
		[Token(Token = "0x4039CC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_text;

		// Token: 0x04039CC8 RID: 236744
		[Token(Token = "0x4039CC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_weightValue;

		// Token: 0x04039CC9 RID: 236745
		[Token(Token = "0x4039CC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039CCA RID: 236746
		[Token(Token = "0x4039CCA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
