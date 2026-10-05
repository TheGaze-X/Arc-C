using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B38 RID: 27448
	[Token(Token = "0x2006B38")]
	public class ChaosItemModel : ArchiveItemModel
	{
		// Token: 0x060273CB RID: 160715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60273CB")]
		[Address(RVA = "0x2276DE0", Offset = "0x22759E0", VA = "0x182276DE0", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x060273CC RID: 160716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60273CC")]
		[Address(RVA = "0x2276D80", Offset = "0x2275980", VA = "0x182276D80", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x060273CD RID: 160717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273CD")]
		[Address(RVA = "0x2276E40", Offset = "0x2275A40", VA = "0x182276E40")]
		public ChaosItemModel()
		{
		}

		// Token: 0x04037844 RID: 227396
		[Token(Token = "0x4037844")]
		[FieldOffset(Offset = "0x30")]
		public string itemId;

		// Token: 0x04037845 RID: 227397
		[Token(Token = "0x4037845")]
		[FieldOffset(Offset = "0x38")]
		public ActArchiveTotemType type;

		// Token: 0x04037846 RID: 227398
		[Token(Token = "0x4037846")]
		[FieldOffset(Offset = "0x3C")]
		public bool attained;

		// Token: 0x04037847 RID: 227399
		[Token(Token = "0x4037847")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x04037848 RID: 227400
		[Token(Token = "0x4037848")]
		[FieldOffset(Offset = "0x48")]
		public string iconId;

		// Token: 0x04037849 RID: 227401
		[Token(Token = "0x4037849")]
		[FieldOffset(Offset = "0x50")]
		public string name;

		// Token: 0x0403784A RID: 227402
		[Token(Token = "0x403784A")]
		[FieldOffset(Offset = "0x58")]
		public string usage;

		// Token: 0x0403784B RID: 227403
		[Token(Token = "0x403784B")]
		[FieldOffset(Offset = "0x60")]
		public string description;

		// Token: 0x0403784C RID: 227404
		[Token(Token = "0x403784C")]
		[FieldOffset(Offset = "0x68")]
		public ChaosItemModel childItem;

		// Token: 0x0403784D RID: 227405
		[Token(Token = "0x403784D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x0403784E RID: 227406
		[Token(Token = "0x403784E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x0403784F RID: 227407
		[Token(Token = "0x403784F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
