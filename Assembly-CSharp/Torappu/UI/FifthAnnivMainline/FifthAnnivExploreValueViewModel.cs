using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004ECB RID: 20171
	[Token(Token = "0x2004ECB")]
	public class FifthAnnivExploreValueViewModel : IHotfixable
	{
		// Token: 0x1700469F RID: 18079
		// (get) Token: 0x0601E188 RID: 123272 RVA: 0x000AD7D8 File Offset: 0x000AB9D8
		// (set) Token: 0x0601E187 RID: 123271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700469F")]
		public int curValue
		{
			[Token(Token = "0x601E188")]
			[Address(RVA = "0x17DB290", Offset = "0x17D9E90", VA = "0x1817DB290")]
			[CompilerGenerated]
			private get
			{
				return 0;
			}
			[Token(Token = "0x601E187")]
			[Address(RVA = "0x17DB3A0", Offset = "0x17D9FA0", VA = "0x1817DB3A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170046A0 RID: 18080
		// (get) Token: 0x0601E189 RID: 123273 RVA: 0x000AD7F0 File Offset: 0x000AB9F0
		[Token(Token = "0x170046A0")]
		public int displayCurValue
		{
			[Token(Token = "0x601E189")]
			[Address(RVA = "0x17DB2F0", Offset = "0x17D9EF0", VA = "0x1817DB2F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170046A1 RID: 18081
		// (get) Token: 0x0601E18A RID: 123274 RVA: 0x000AD808 File Offset: 0x000ABA08
		[Token(Token = "0x170046A1")]
		public float curNormalizedValue
		{
			[Token(Token = "0x601E18A")]
			[Address(RVA = "0x17DB1C0", Offset = "0x17D9DC0", VA = "0x1817DB1C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170046A2 RID: 18082
		// (get) Token: 0x0601E18B RID: 123275 RVA: 0x000AD820 File Offset: 0x000ABA20
		[Token(Token = "0x170046A2")]
		public float beforeDeltaNormalizedValue
		{
			[Token(Token = "0x601E18B")]
			[Address(RVA = "0x17DB0B0", Offset = "0x17D9CB0", VA = "0x1817DB0B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0601E18C RID: 123276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E18C")]
		[Address(RVA = "0x17DAED0", Offset = "0x17D9AD0", VA = "0x1817DAED0")]
		public void LoadData(int curValue, bool hasDeltaValue = false, int deltaValue = 0)
		{
		}

		// Token: 0x0601E18D RID: 123277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E18D")]
		[Address(RVA = "0x17DB050", Offset = "0x17D9C50", VA = "0x1817DB050")]
		public FifthAnnivExploreValueViewModel()
		{
		}

		// Token: 0x04028099 RID: 163993
		[Token(Token = "0x4028099")]
		[FieldOffset(Offset = "0x10")]
		public int minValue;

		// Token: 0x0402809A RID: 163994
		[Token(Token = "0x402809A")]
		[FieldOffset(Offset = "0x14")]
		public int maxValue;

		// Token: 0x0402809B RID: 163995
		[Token(Token = "0x402809B")]
		[FieldOffset(Offset = "0x18")]
		public int deltaValue;

		// Token: 0x0402809C RID: 163996
		[Token(Token = "0x402809C")]
		[FieldOffset(Offset = "0x1C")]
		public bool hasDeltaValue;

		// Token: 0x0402809D RID: 163997
		[Token(Token = "0x402809D")]
		[FieldOffset(Offset = "0x1D")]
		public bool showDeltaValue;

		// Token: 0x0402809F RID: 163999
		[Token(Token = "0x402809F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_curValue;

		// Token: 0x040280A0 RID: 164000
		[Token(Token = "0x40280A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_curValue;

		// Token: 0x040280A1 RID: 164001
		[Token(Token = "0x40280A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_displayCurValue;

		// Token: 0x040280A2 RID: 164002
		[Token(Token = "0x40280A2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_curNormalizedValue;

		// Token: 0x040280A3 RID: 164003
		[Token(Token = "0x40280A3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_beforeDeltaNormalizedValue;

		// Token: 0x040280A4 RID: 164004
		[Token(Token = "0x40280A4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040280A5 RID: 164005
		[Token(Token = "0x40280A5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
