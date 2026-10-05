using System;
using Il2CppDummyDll;
using Torappu.DB;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200665E RID: 26206
	[Token(Token = "0x200665E")]
	public class HandBookTeamIconDB : DBComponent<string, HandbookTeamIconData>
	{
		// Token: 0x1700592D RID: 22829
		// (get) Token: 0x06025A21 RID: 154145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700592D")]
		protected override string dataURL
		{
			[Token(Token = "0x6025A21")]
			[Address(RVA = "0x209D2D0", Offset = "0x209BED0", VA = "0x18209D2D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025A22 RID: 154146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A22")]
		[Address(RVA = "0x209D260", Offset = "0x209BE60", VA = "0x18209D260")]
		public HandBookTeamIconDB()
		{
		}

		// Token: 0x04034DDB RID: 216539
		[Token(Token = "0x4034DDB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataURL;

		// Token: 0x04034DDC RID: 216540
		[Token(Token = "0x4034DDC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
