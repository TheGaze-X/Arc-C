using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200720E RID: 29198
	[Token(Token = "0x200720E")]
	public class Act5D1DataHolder : ActivityStageSingleComponent
	{
		// Token: 0x17006209 RID: 25097
		// (get) Token: 0x0602964C RID: 169548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006209")]
		protected ActivityDataFromServer<Act5D1Data> actDataWrapper
		{
			[Token(Token = "0x602964C")]
			[Address(RVA = "0x24C5470", Offset = "0x24C4070", VA = "0x1824C5470")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700620A RID: 25098
		// (get) Token: 0x0602964D RID: 169549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700620A")]
		public Act5D1Data actData
		{
			[Token(Token = "0x602964D")]
			[Address(RVA = "0x24C5540", Offset = "0x24C4140", VA = "0x1824C5540")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602964E RID: 169550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602964E")]
		[Address(RVA = "0x24C4E50", Offset = "0x24C3A50", VA = "0x1824C4E50")]
		public void RefreshActData(Action actionWhenHaveData)
		{
		}

		// Token: 0x0602964F RID: 169551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602964F")]
		[Address(RVA = "0x24C50C0", Offset = "0x24C3CC0", VA = "0x1824C50C0")]
		private void _TrySendDataRequest()
		{
		}

		// Token: 0x06029650 RID: 169552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029650")]
		[Address(RVA = "0x24C5410", Offset = "0x24C4010", VA = "0x1824C5410")]
		public Act5D1DataHolder()
		{
		}

		// Token: 0x0403B205 RID: 242181
		[Token(Token = "0x403B205")]
		[FieldOffset(Offset = "0x20")]
		private Action m_actionWhenHaveData;

		// Token: 0x0403B206 RID: 242182
		[Token(Token = "0x403B206")]
		[FieldOffset(Offset = "0x28")]
		private ActivityDataFromServer<Act5D1Data> m_wrappedData;

		// Token: 0x0403B207 RID: 242183
		[Token(Token = "0x403B207")]
		[FieldOffset(Offset = "0x30")]
		private UISender.ResultHandler<Act5D1GetDetailResponse> m_dataRequest;

		// Token: 0x0403B208 RID: 242184
		[Token(Token = "0x403B208")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isCrossDay;

		// Token: 0x0403B209 RID: 242185
		[Token(Token = "0x403B209")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actDataWrapper;

		// Token: 0x0403B20A RID: 242186
		[Token(Token = "0x403B20A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_actData;

		// Token: 0x0403B20B RID: 242187
		[Token(Token = "0x403B20B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshActData;

		// Token: 0x0403B20C RID: 242188
		[Token(Token = "0x403B20C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TrySendDataRequest;

		// Token: 0x0403B20D RID: 242189
		[Token(Token = "0x403B20D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
