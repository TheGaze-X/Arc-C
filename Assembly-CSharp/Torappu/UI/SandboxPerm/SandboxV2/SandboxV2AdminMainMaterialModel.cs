using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004072 RID: 16498
	[Token(Token = "0x2004072")]
	public class SandboxV2AdminMainMaterialModel : IComparable<SandboxV2AdminMainMaterialModel>, IHotfixable
	{
		// Token: 0x0601985A RID: 104538 RVA: 0x0009E6D0 File Offset: 0x0009C8D0
		[Token(Token = "0x601985A")]
		[Address(RVA = "0x1230070", Offset = "0x122EC70", VA = "0x181230070", Slot = "4")]
		public int CompareTo(SandboxV2AdminMainMaterialModel other)
		{
			return 0;
		}

		// Token: 0x0601985B RID: 104539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601985B")]
		[Address(RVA = "0x12301E0", Offset = "0x122EDE0", VA = "0x1812301E0")]
		public SandboxV2AdminMainMaterialModel()
		{
		}

		// Token: 0x0401FCF2 RID: 130290
		[Token(Token = "0x401FCF2")]
		[FieldOffset(Offset = "0x10")]
		public UIItemViewModel itemModel;

		// Token: 0x0401FCF3 RID: 130291
		[Token(Token = "0x401FCF3")]
		[FieldOffset(Offset = "0x18")]
		public SandboxV2AdminMainMaterialModel.ColorType colorType;

		// Token: 0x0401FCF4 RID: 130292
		[Token(Token = "0x401FCF4")]
		[FieldOffset(Offset = "0x1C")]
		public bool isValid;

		// Token: 0x0401FCF5 RID: 130293
		[Token(Token = "0x401FCF5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0401FCF6 RID: 130294
		[Token(Token = "0x401FCF6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004073 RID: 16499
		[Token(Token = "0x2004073")]
		public enum ColorType
		{
			// Token: 0x0401FCF8 RID: 130296
			[Token(Token = "0x401FCF8")]
			NORMAL,
			// Token: 0x0401FCF9 RID: 130297
			[Token(Token = "0x401FCF9")]
			WATER,
			// Token: 0x0401FCFA RID: 130298
			[Token(Token = "0x401FCFA")]
			GOLD
		}
	}
}
