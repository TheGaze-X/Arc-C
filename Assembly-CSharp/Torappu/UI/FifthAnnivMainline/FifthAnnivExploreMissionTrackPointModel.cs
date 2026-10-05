using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F01 RID: 20225
	[Token(Token = "0x2004F01")]
	public class FifthAnnivExploreMissionTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x0601E272 RID: 123506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E272")]
		[Address(RVA = "0x17D53D0", Offset = "0x17D3FD0", VA = "0x1817D53D0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x170046BA RID: 18106
		// (get) Token: 0x0601E273 RID: 123507 RVA: 0x000ADAC0 File Offset: 0x000ABCC0
		// (set) Token: 0x0601E274 RID: 123508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046BA")]
		public bool isShow
		{
			[Token(Token = "0x601E273")]
			[Address(RVA = "0x17D54F0", Offset = "0x17D40F0", VA = "0x1817D54F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601E274")]
			[Address(RVA = "0x17D5550", Offset = "0x17D4150", VA = "0x1817D5550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601E275 RID: 123509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E275")]
		[Address(RVA = "0x17D5490", Offset = "0x17D4090", VA = "0x1817D5490")]
		public FifthAnnivExploreMissionTrackPointModel()
		{
		}

		// Token: 0x0402823C RID: 164412
		[Token(Token = "0x402823C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0402823D RID: 164413
		[Token(Token = "0x402823D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0402823E RID: 164414
		[Token(Token = "0x402823E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x0402823F RID: 164415
		[Token(Token = "0x402823F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
