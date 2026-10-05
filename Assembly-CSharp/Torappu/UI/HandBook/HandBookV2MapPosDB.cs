using System;
using Il2CppDummyDll;
using Torappu.DB;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066DF RID: 26335
	[Token(Token = "0x20066DF")]
	public class HandBookV2MapPosDB : DBComponent<HandBookV2MapPosData>
	{
		// Token: 0x1700598D RID: 22925
		// (get) Token: 0x06025C9C RID: 154780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700598D")]
		protected override string dataURL
		{
			[Token(Token = "0x6025C9C")]
			[Address(RVA = "0x20C80B0", Offset = "0x20C6CB0", VA = "0x1820C80B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025C9D RID: 154781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C9D")]
		[Address(RVA = "0x20C8040", Offset = "0x20C6C40", VA = "0x1820C8040")]
		public HandBookV2MapPosDB()
		{
		}

		// Token: 0x04035227 RID: 217639
		[Token(Token = "0x4035227")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataURL;

		// Token: 0x04035228 RID: 217640
		[Token(Token = "0x4035228")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
