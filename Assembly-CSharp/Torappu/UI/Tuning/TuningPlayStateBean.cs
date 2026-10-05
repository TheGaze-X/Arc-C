using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CD0 RID: 15568
	[Token(Token = "0x2003CD0")]
	public class TuningPlayStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170039ED RID: 14829
		// (get) Token: 0x0601846A RID: 99434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039ED")]
		public TuningPlayProperty prop
		{
			[Token(Token = "0x601846A")]
			[Address(RVA = "0x10C4610", Offset = "0x10C3210", VA = "0x1810C4610")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601846B RID: 99435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601846B")]
		[Address(RVA = "0x10C4140", Offset = "0x10C2D40", VA = "0x1810C4140")]
		public void InitData(string actId)
		{
		}

		// Token: 0x0601846C RID: 99436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601846C")]
		[Address(RVA = "0x10C43A0", Offset = "0x10C2FA0", VA = "0x1810C43A0")]
		public void UpdateData(bool isResumeFromStack)
		{
		}

		// Token: 0x0601846D RID: 99437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601846D")]
		[Address(RVA = "0x10C4320", Offset = "0x10C2F20", VA = "0x1810C4320")]
		public void SetSelectProductTypeId(string inputProductTypeId)
		{
		}

		// Token: 0x0601846E RID: 99438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601846E")]
		[Address(RVA = "0x10C4520", Offset = "0x10C3120", VA = "0x1810C4520")]
		public TuningPlayStateBean()
		{
		}

		// Token: 0x0401D9FF RID: 121343
		[Token(Token = "0x401D9FF")]
		[FieldOffset(Offset = "0x10")]
		private TuningPlayProperty m_prop;

		// Token: 0x0401DA00 RID: 121344
		[Token(Token = "0x401DA00")]
		[FieldOffset(Offset = "0x18")]
		private int m_enterSequenceNum;

		// Token: 0x0401DA01 RID: 121345
		[Token(Token = "0x401DA01")]
		[FieldOffset(Offset = "0x1C")]
		private int m_eyeShowSequenceNum;

		// Token: 0x0401DA02 RID: 121346
		[Token(Token = "0x401DA02")]
		[FieldOffset(Offset = "0x20")]
		private int m_cardChangeSequenceNum;

		// Token: 0x0401DA03 RID: 121347
		[Token(Token = "0x401DA03")]
		[FieldOffset(Offset = "0x28")]
		private string m_inputProductTypeId;

		// Token: 0x0401DA04 RID: 121348
		[Token(Token = "0x401DA04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0401DA05 RID: 121349
		[Token(Token = "0x401DA05")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401DA06 RID: 121350
		[Token(Token = "0x401DA06")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401DA07 RID: 121351
		[Token(Token = "0x401DA07")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetSelectProductTypeId;

		// Token: 0x0401DA08 RID: 121352
		[Token(Token = "0x401DA08")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
