using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C9A RID: 19610
	[Token(Token = "0x2004C9A")]
	public class OpenServerV2TotalCheckinItemData : ICheckinItemData, IHotfixable
	{
		// Token: 0x0601D634 RID: 120372 RVA: 0x000AB588 File Offset: 0x000A9788
		[Token(Token = "0x601D634")]
		[Address(RVA = "0x16F1A40", Offset = "0x16F0640", VA = "0x1816F1A40", Slot = "4")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601D635 RID: 120373 RVA: 0x000AB5A0 File Offset: 0x000A97A0
		[Token(Token = "0x601D635")]
		[Address(RVA = "0x16F1960", Offset = "0x16F0560", VA = "0x1816F1960", Slot = "5")]
		public int GetColorId()
		{
			return 0;
		}

		// Token: 0x0601D636 RID: 120374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D636")]
		[Address(RVA = "0x16F19D0", Offset = "0x16F05D0", VA = "0x1816F19D0", Slot = "6")]
		public OpenServerItemData GetOpenServerItemData()
		{
			return null;
		}

		// Token: 0x0601D637 RID: 120375 RVA: 0x000AB5B8 File Offset: 0x000A97B8
		[Token(Token = "0x601D637")]
		[Address(RVA = "0x16F1900", Offset = "0x16F0500", VA = "0x1816F1900", Slot = "7")]
		public OpenServerCheckinItemState GetCheckinState()
		{
			return OpenServerCheckinItemState.LOCKED;
		}

		// Token: 0x0601D638 RID: 120376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D638")]
		[Address(RVA = "0x16F1AB0", Offset = "0x16F06B0", VA = "0x1816F1AB0")]
		public OpenServerV2TotalCheckinItemData()
		{
		}

		// Token: 0x04026B0C RID: 158476
		[Token(Token = "0x4026B0C")]
		[FieldOffset(Offset = "0x10")]
		public TotalCheckinData totalCheckinData;

		// Token: 0x04026B0D RID: 158477
		[Token(Token = "0x4026B0D")]
		[FieldOffset(Offset = "0x18")]
		public OpenServerCheckinItemState state;

		// Token: 0x04026B0E RID: 158478
		[Token(Token = "0x4026B0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x04026B0F RID: 158479
		[Token(Token = "0x4026B0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetColorId;

		// Token: 0x04026B10 RID: 158480
		[Token(Token = "0x4026B10")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetOpenServerItemData;

		// Token: 0x04026B11 RID: 158481
		[Token(Token = "0x4026B11")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCheckinState;

		// Token: 0x04026B12 RID: 158482
		[Token(Token = "0x4026B12")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
