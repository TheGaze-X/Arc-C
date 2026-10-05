using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HiddenStage
{
	// Token: 0x02004CAA RID: 19626
	[Token(Token = "0x2004CAA")]
	public class HiddenStageMissionViewModel : IHotfixable
	{
		// Token: 0x0601D6B5 RID: 120501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6B5")]
		[Address(RVA = "0x170AD30", Offset = "0x1709930", VA = "0x18170AD30")]
		public HiddenStageMissionViewModel()
		{
		}

		// Token: 0x04026BEF RID: 158703
		[Token(Token = "0x4026BEF")]
		[FieldOffset(Offset = "0x10")]
		public string bindStageId;

		// Token: 0x04026BF0 RID: 158704
		[Token(Token = "0x4026BF0")]
		[FieldOffset(Offset = "0x18")]
		public string missionStageId;

		// Token: 0x04026BF1 RID: 158705
		[Token(Token = "0x4026BF1")]
		[FieldOffset(Offset = "0x20")]
		public string unlockedDes;

		// Token: 0x04026BF2 RID: 158706
		[Token(Token = "0x4026BF2")]
		[FieldOffset(Offset = "0x28")]
		public string templateDesc;

		// Token: 0x04026BF3 RID: 158707
		[Token(Token = "0x4026BF3")]
		[FieldOffset(Offset = "0x30")]
		public string desc;

		// Token: 0x04026BF4 RID: 158708
		[Token(Token = "0x4026BF4")]
		[FieldOffset(Offset = "0x38")]
		public string riddle;

		// Token: 0x04026BF5 RID: 158709
		[Token(Token = "0x4026BF5")]
		[FieldOffset(Offset = "0x40")]
		public string lockedName;

		// Token: 0x04026BF6 RID: 158710
		[Token(Token = "0x4026BF6")]
		[FieldOffset(Offset = "0x48")]
		public string unlockedName;

		// Token: 0x04026BF7 RID: 158711
		[Token(Token = "0x4026BF7")]
		[FieldOffset(Offset = "0x50")]
		public string missionCode;

		// Token: 0x04026BF8 RID: 158712
		[Token(Token = "0x4026BF8")]
		[FieldOffset(Offset = "0x58")]
		public bool locked;

		// Token: 0x04026BF9 RID: 158713
		[Token(Token = "0x4026BF9")]
		[FieldOffset(Offset = "0x59")]
		public bool complete;

		// Token: 0x04026BFA RID: 158714
		[Token(Token = "0x4026BFA")]
		[FieldOffset(Offset = "0x5A")]
		public bool showComplete;

		// Token: 0x04026BFB RID: 158715
		[Token(Token = "0x4026BFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
