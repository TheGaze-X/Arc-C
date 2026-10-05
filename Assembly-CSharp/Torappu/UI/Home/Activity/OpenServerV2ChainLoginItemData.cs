using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C96 RID: 19606
	[Token(Token = "0x2004C96")]
	public class OpenServerV2ChainLoginItemData : ICheckinItemData, IHotfixable
	{
		// Token: 0x0601D626 RID: 120358 RVA: 0x000AB510 File Offset: 0x000A9710
		[Token(Token = "0x601D626")]
		[Address(RVA = "0x16ED550", Offset = "0x16EC150", VA = "0x1816ED550", Slot = "4")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601D627 RID: 120359 RVA: 0x000AB528 File Offset: 0x000A9728
		[Token(Token = "0x601D627")]
		[Address(RVA = "0x16ED470", Offset = "0x16EC070", VA = "0x1816ED470", Slot = "5")]
		public int GetColorId()
		{
			return 0;
		}

		// Token: 0x0601D628 RID: 120360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D628")]
		[Address(RVA = "0x16ED4E0", Offset = "0x16EC0E0", VA = "0x1816ED4E0", Slot = "6")]
		public OpenServerItemData GetOpenServerItemData()
		{
			return null;
		}

		// Token: 0x0601D629 RID: 120361 RVA: 0x000AB540 File Offset: 0x000A9740
		[Token(Token = "0x601D629")]
		[Address(RVA = "0x16ED410", Offset = "0x16EC010", VA = "0x1816ED410", Slot = "7")]
		public OpenServerCheckinItemState GetCheckinState()
		{
			return OpenServerCheckinItemState.LOCKED;
		}

		// Token: 0x0601D62A RID: 120362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D62A")]
		[Address(RVA = "0x16ED5C0", Offset = "0x16EC1C0", VA = "0x1816ED5C0")]
		public OpenServerV2ChainLoginItemData()
		{
		}

		// Token: 0x04026AF4 RID: 158452
		[Token(Token = "0x4026AF4")]
		[FieldOffset(Offset = "0x10")]
		public ChainLoginData chainLoginData;

		// Token: 0x04026AF5 RID: 158453
		[Token(Token = "0x4026AF5")]
		[FieldOffset(Offset = "0x18")]
		public OpenServerCheckinItemState state;

		// Token: 0x04026AF6 RID: 158454
		[Token(Token = "0x4026AF6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x04026AF7 RID: 158455
		[Token(Token = "0x4026AF7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetColorId;

		// Token: 0x04026AF8 RID: 158456
		[Token(Token = "0x4026AF8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetOpenServerItemData;

		// Token: 0x04026AF9 RID: 158457
		[Token(Token = "0x4026AF9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCheckinState;

		// Token: 0x04026AFA RID: 158458
		[Token(Token = "0x4026AFA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
