using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200437F RID: 17279
	[Token(Token = "0x200437F")]
	public class SandboxV2RacerTempInventoryViewModel : IHotfixable
	{
		// Token: 0x17003EF4 RID: 16116
		// (get) Token: 0x0601A882 RID: 108674 RVA: 0x000A24E0 File Offset: 0x000A06E0
		[Token(Token = "0x17003EF4")]
		public bool isEmpty
		{
			[Token(Token = "0x601A882")]
			[Address(RVA = "0x13AFE70", Offset = "0x13AEA70", VA = "0x1813AFE70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601A883 RID: 108675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A883")]
		[Address(RVA = "0x13AF620", Offset = "0x13AE220", VA = "0x1813AF620")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x0601A884 RID: 108676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A884")]
		[Address(RVA = "0x13AF770", Offset = "0x13AE370", VA = "0x1813AF770")]
		public void RefreshData()
		{
		}

		// Token: 0x0601A885 RID: 108677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A885")]
		[Address(RVA = "0x13AFDC0", Offset = "0x13AE9C0", VA = "0x1813AFDC0")]
		public SandboxV2RacerTempInventoryViewModel()
		{
		}

		// Token: 0x04021C47 RID: 138311
		[Token(Token = "0x4021C47")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, SandboxV2RacerModel> racerList;

		// Token: 0x04021C48 RID: 138312
		[Token(Token = "0x4021C48")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x04021C49 RID: 138313
		[Token(Token = "0x4021C49")]
		[FieldOffset(Offset = "0x20")]
		public string selectInstId;

		// Token: 0x04021C4A RID: 138314
		[Token(Token = "0x4021C4A")]
		[FieldOffset(Offset = "0x28")]
		public string bagName;

		// Token: 0x04021C4B RID: 138315
		[Token(Token = "0x4021C4B")]
		[FieldOffset(Offset = "0x30")]
		public string tempBagName;

		// Token: 0x04021C4C RID: 138316
		[Token(Token = "0x4021C4C")]
		[FieldOffset(Offset = "0x38")]
		public string emptyLeftDesc;

		// Token: 0x04021C4D RID: 138317
		[Token(Token = "0x4021C4D")]
		[FieldOffset(Offset = "0x40")]
		public string emptyRightDesc;

		// Token: 0x04021C4E RID: 138318
		[Token(Token = "0x4021C4E")]
		[FieldOffset(Offset = "0x48")]
		public int bagCapacity;

		// Token: 0x04021C4F RID: 138319
		[Token(Token = "0x4021C4F")]
		[FieldOffset(Offset = "0x4C")]
		public int racerCount;

		// Token: 0x04021C50 RID: 138320
		[Token(Token = "0x4021C50")]
		[FieldOffset(Offset = "0x50")]
		public int tempBagCapacity;

		// Token: 0x04021C51 RID: 138321
		[Token(Token = "0x4021C51")]
		[FieldOffset(Offset = "0x54")]
		public int tempRacerCount;

		// Token: 0x04021C52 RID: 138322
		[Token(Token = "0x4021C52")]
		[FieldOffset(Offset = "0x58")]
		public int focusSequenceNum;

		// Token: 0x04021C53 RID: 138323
		[Token(Token = "0x4021C53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x04021C54 RID: 138324
		[Token(Token = "0x4021C54")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021C55 RID: 138325
		[Token(Token = "0x4021C55")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04021C56 RID: 138326
		[Token(Token = "0x4021C56")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
