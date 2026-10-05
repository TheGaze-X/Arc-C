using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E05 RID: 28165
	[Token(Token = "0x2006E05")]
	public class ActVecBreakV2DefenseShareItemModel : CrossAppShareComponentBaseModel
	{
		// Token: 0x06028183 RID: 164227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028183")]
		[Address(RVA = "0x2363A10", Offset = "0x2362610", VA = "0x182363A10")]
		public ActVecBreakV2DefenseShareItemModel()
		{
		}

		// Token: 0x04038E44 RID: 233028
		[Token(Token = "0x4038E44")]
		[FieldOffset(Offset = "0x18")]
		public string actId;

		// Token: 0x04038E45 RID: 233029
		[Token(Token = "0x4038E45")]
		[FieldOffset(Offset = "0x20")]
		public ActVecBreakV2DefenseStageBaseItem.InputParam inputParam;

		// Token: 0x04038E46 RID: 233030
		[Token(Token = "0x4038E46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
