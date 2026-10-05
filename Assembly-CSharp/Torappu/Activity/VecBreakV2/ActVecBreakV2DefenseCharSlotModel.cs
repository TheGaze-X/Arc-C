using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E22 RID: 28194
	[Token(Token = "0x2006E22")]
	public class ActVecBreakV2DefenseCharSlotModel : IHotfixable
	{
		// Token: 0x17005EE3 RID: 24291
		// (get) Token: 0x06028221 RID: 164385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EE3")]
		public string avatarId
		{
			[Token(Token = "0x6028221")]
			[Address(RVA = "0x2361AD0", Offset = "0x23606D0", VA = "0x182361AD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005EE4 RID: 24292
		// (get) Token: 0x06028222 RID: 164386 RVA: 0x000D0C08 File Offset: 0x000CEE08
		[Token(Token = "0x17005EE4")]
		public bool isValidChar
		{
			[Token(Token = "0x6028222")]
			[Address(RVA = "0x2361CF0", Offset = "0x23608F0", VA = "0x182361CF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06028223 RID: 164387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028223")]
		[Address(RVA = "0x2361960", Offset = "0x2360560", VA = "0x182361960")]
		public void SetCharInfo(int charInstId, string tmplId)
		{
		}

		// Token: 0x06028224 RID: 164388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028224")]
		[Address(RVA = "0x2361A00", Offset = "0x2360600", VA = "0x182361A00")]
		public void SetLockSlot()
		{
		}

		// Token: 0x06028225 RID: 164389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028225")]
		[Address(RVA = "0x2361A70", Offset = "0x2360670", VA = "0x182361A70")]
		public ActVecBreakV2DefenseCharSlotModel()
		{
		}

		// Token: 0x04038FB9 RID: 233401
		[Token(Token = "0x4038FB9")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x04038FBA RID: 233402
		[Token(Token = "0x4038FBA")]
		[FieldOffset(Offset = "0x18")]
		public string tmplId;

		// Token: 0x04038FBB RID: 233403
		[Token(Token = "0x4038FBB")]
		[FieldOffset(Offset = "0x20")]
		public ActVecBreakV2DefenseCharSlotModel.SlotType slotType;

		// Token: 0x04038FBC RID: 233404
		[Token(Token = "0x4038FBC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_avatarId;

		// Token: 0x04038FBD RID: 233405
		[Token(Token = "0x4038FBD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isValidChar;

		// Token: 0x04038FBE RID: 233406
		[Token(Token = "0x4038FBE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCharInfo;

		// Token: 0x04038FBF RID: 233407
		[Token(Token = "0x4038FBF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetLockSlot;

		// Token: 0x04038FC0 RID: 233408
		[Token(Token = "0x4038FC0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E23 RID: 28195
		[Token(Token = "0x2006E23")]
		public enum SlotType
		{
			// Token: 0x04038FC2 RID: 233410
			[Token(Token = "0x4038FC2")]
			UNLOCK,
			// Token: 0x04038FC3 RID: 233411
			[Token(Token = "0x4038FC3")]
			LOCK
		}
	}
}
