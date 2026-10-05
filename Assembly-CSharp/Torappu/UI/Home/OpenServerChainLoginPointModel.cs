using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BB9 RID: 19385
	[Token(Token = "0x2004BB9")]
	public class OpenServerChainLoginPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004490 RID: 17552
		// (get) Token: 0x0601D228 RID: 119336 RVA: 0x000AAAA8 File Offset: 0x000A8CA8
		[Token(Token = "0x17004490")]
		public bool isShow
		{
			[Token(Token = "0x601D228")]
			[Address(RVA = "0x16ACF10", Offset = "0x16ABB10", VA = "0x1816ACF10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D229 RID: 119337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D229")]
		[Address(RVA = "0x16ACE50", Offset = "0x16ABA50", VA = "0x1816ACE50", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D22A RID: 119338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D22A")]
		[Address(RVA = "0x16ACEB0", Offset = "0x16ABAB0", VA = "0x1816ACEB0")]
		public OpenServerChainLoginPointModel()
		{
		}

		// Token: 0x040263C8 RID: 156616
		[Token(Token = "0x40263C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040263C9 RID: 156617
		[Token(Token = "0x40263C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040263CA RID: 156618
		[Token(Token = "0x40263CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
