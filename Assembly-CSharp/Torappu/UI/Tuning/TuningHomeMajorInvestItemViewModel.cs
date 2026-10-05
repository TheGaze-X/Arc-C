using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CBD RID: 15549
	[Token(Token = "0x2003CBD")]
	public class TuningHomeMajorInvestItemViewModel : IHotfixable
	{
		// Token: 0x060183FD RID: 99325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183FD")]
		[Address(RVA = "0x10BDF60", Offset = "0x10BCB60", VA = "0x1810BDF60")]
		public TuningHomeMajorInvestItemViewModel()
		{
		}

		// Token: 0x0401D938 RID: 121144
		[Token(Token = "0x401D938")]
		[FieldOffset(Offset = "0x10")]
		public TuningHomeMajorInvestItemViewModel.Status status;

		// Token: 0x0401D939 RID: 121145
		[Token(Token = "0x401D939")]
		[FieldOffset(Offset = "0x18")]
		public string avatarName;

		// Token: 0x0401D93A RID: 121146
		[Token(Token = "0x401D93A")]
		[FieldOffset(Offset = "0x20")]
		public string unknownAvatarName;

		// Token: 0x0401D93B RID: 121147
		[Token(Token = "0x401D93B")]
		[FieldOffset(Offset = "0x28")]
		public string investId;

		// Token: 0x0401D93C RID: 121148
		[Token(Token = "0x401D93C")]
		[FieldOffset(Offset = "0x30")]
		public UIItemViewModel reward;

		// Token: 0x0401D93D RID: 121149
		[Token(Token = "0x401D93D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CBE RID: 15550
		[Token(Token = "0x2003CBE")]
		public enum Status
		{
			// Token: 0x0401D93F RID: 121151
			[Token(Token = "0x401D93F")]
			UNKNOWN,
			// Token: 0x0401D940 RID: 121152
			[Token(Token = "0x401D940")]
			UNLOCKED,
			// Token: 0x0401D941 RID: 121153
			[Token(Token = "0x401D941")]
			COMPLETE
		}
	}
}
