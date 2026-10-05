using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067D8 RID: 26584
	[Token(Token = "0x20067D8")]
	public class ZoneHomeToDoItemModel : IHotfixable
	{
		// Token: 0x17005A23 RID: 23075
		// (get) Token: 0x060261D3 RID: 156115 RVA: 0x000CA1A0 File Offset: 0x000C83A0
		// (set) Token: 0x060261D4 RID: 156116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A23")]
		public HomeToDoFuncType funcType
		{
			[Token(Token = "0x60261D3")]
			[Address(RVA = "0x2146910", Offset = "0x2145510", VA = "0x182146910")]
			get
			{
				return HomeToDoFuncType.NONE;
			}
			[Token(Token = "0x60261D4")]
			[Address(RVA = "0x2146A80", Offset = "0x2145680", VA = "0x182146A80")]
			set
			{
			}
		}

		// Token: 0x17005A24 RID: 23076
		// (get) Token: 0x060261D5 RID: 156117 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060261D6 RID: 156118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A24")]
		public string funcId
		{
			[Token(Token = "0x60261D5")]
			[Address(RVA = "0x21468B0", Offset = "0x21454B0", VA = "0x1821468B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60261D6")]
			[Address(RVA = "0x21469D0", Offset = "0x21455D0", VA = "0x1821469D0")]
			set
			{
			}
		}

		// Token: 0x17005A25 RID: 23077
		// (get) Token: 0x060261D7 RID: 156119 RVA: 0x000CA1B8 File Offset: 0x000C83B8
		// (set) Token: 0x060261D8 RID: 156120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A25")]
		public HomeToDoSortIndex sortIndex
		{
			[Token(Token = "0x60261D7")]
			[Address(RVA = "0x2146970", Offset = "0x2145570", VA = "0x182146970")]
			[CompilerGenerated]
			get
			{
				return HomeToDoSortIndex.NONE;
			}
			[Token(Token = "0x60261D8")]
			[Address(RVA = "0x2146B00", Offset = "0x2145700", VA = "0x182146B00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060261D9 RID: 156121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60261D9")]
		[Address(RVA = "0x2146650", Offset = "0x2145250", VA = "0x182146650")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x060261DA RID: 156122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261DA")]
		[Address(RVA = "0x2146840", Offset = "0x2145440", VA = "0x182146840")]
		public ZoneHomeToDoItemModel()
		{
		}

		// Token: 0x04035AA3 RID: 219811
		[Token(Token = "0x4035AA3")]
		[FieldOffset(Offset = "0x10")]
		private HomeToDoFuncType m_funcType;

		// Token: 0x04035AA4 RID: 219812
		[Token(Token = "0x4035AA4")]
		[FieldOffset(Offset = "0x18")]
		private string m_funcId;

		// Token: 0x04035AA6 RID: 219814
		[Token(Token = "0x4035AA6")]
		[FieldOffset(Offset = "0x24")]
		public int viewIndex;

		// Token: 0x04035AA7 RID: 219815
		[Token(Token = "0x4035AA7")]
		[FieldOffset(Offset = "0x28")]
		public long endTs;

		// Token: 0x04035AA8 RID: 219816
		[Token(Token = "0x4035AA8")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedId;

		// Token: 0x04035AA9 RID: 219817
		[Token(Token = "0x4035AA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_funcType;

		// Token: 0x04035AAA RID: 219818
		[Token(Token = "0x4035AAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_funcType;

		// Token: 0x04035AAB RID: 219819
		[Token(Token = "0x4035AAB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_funcId;

		// Token: 0x04035AAC RID: 219820
		[Token(Token = "0x4035AAC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_funcId;

		// Token: 0x04035AAD RID: 219821
		[Token(Token = "0x4035AAD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortIndex;

		// Token: 0x04035AAE RID: 219822
		[Token(Token = "0x4035AAE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_sortIndex;

		// Token: 0x04035AAF RID: 219823
		[Token(Token = "0x4035AAF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetId;

		// Token: 0x04035AB0 RID: 219824
		[Token(Token = "0x4035AB0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
