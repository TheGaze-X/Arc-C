using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B88 RID: 19336
	[Token(Token = "0x2004B88")]
	public class RecruitTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700446C RID: 17516
		// (get) Token: 0x0601D18F RID: 119183 RVA: 0x000AA6A0 File Offset: 0x000A88A0
		[Token(Token = "0x1700446C")]
		public bool isShow
		{
			[Token(Token = "0x601D18F")]
			[Address(RVA = "0x16AF840", Offset = "0x16AE440", VA = "0x1816AF840", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700446D RID: 17517
		// (get) Token: 0x0601D190 RID: 119184 RVA: 0x000AA6B8 File Offset: 0x000A88B8
		[Token(Token = "0x1700446D")]
		public int finishedSlotNum
		{
			[Token(Token = "0x601D190")]
			[Address(RVA = "0x16AF7E0", Offset = "0x16AE3E0", VA = "0x1816AF7E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601D191 RID: 119185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D191")]
		[Address(RVA = "0x16AF630", Offset = "0x16AE230", VA = "0x1816AF630", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D192 RID: 119186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D192")]
		[Address(RVA = "0x16AF780", Offset = "0x16AE380", VA = "0x1816AF780")]
		public RecruitTrackPointModel()
		{
		}

		// Token: 0x040262FF RID: 156415
		[Token(Token = "0x40262FF")]
		[FieldOffset(Offset = "0x10")]
		private int m_finishedSlotNum;

		// Token: 0x04026300 RID: 156416
		[Token(Token = "0x4026300")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04026301 RID: 156417
		[Token(Token = "0x4026301")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_finishedSlotNum;

		// Token: 0x04026302 RID: 156418
		[Token(Token = "0x4026302")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04026303 RID: 156419
		[Token(Token = "0x4026303")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
