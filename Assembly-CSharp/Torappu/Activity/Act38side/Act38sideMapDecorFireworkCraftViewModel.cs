using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.Firework;
using XLua;

namespace Torappu.Activity.Act38side
{
	// Token: 0x02007434 RID: 29748
	[Token(Token = "0x2007434")]
	public class Act38sideMapDecorFireworkCraftViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x06029FBD RID: 171965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FBD")]
		[Address(RVA = "0x25A8C80", Offset = "0x25A7880", VA = "0x1825A8C80")]
		public Act38sideMapDecorFireworkCraftViewModel(object param)
		{
		}

		// Token: 0x06029FBE RID: 171966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FBE")]
		[Address(RVA = "0x25A8AE0", Offset = "0x25A76E0", VA = "0x1825A8AE0")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0403C330 RID: 246576
		[Token(Token = "0x403C330")]
		[FieldOffset(Offset = "0x20")]
		public bool isUnlock;

		// Token: 0x0403C331 RID: 246577
		[Token(Token = "0x403C331")]
		[FieldOffset(Offset = "0x28")]
		public string animalIconId;

		// Token: 0x0403C332 RID: 246578
		[Token(Token = "0x403C332")]
		[FieldOffset(Offset = "0x30")]
		public string animId;

		// Token: 0x0403C333 RID: 246579
		[Token(Token = "0x403C333")]
		[FieldOffset(Offset = "0x38")]
		public bool isNew;

		// Token: 0x0403C334 RID: 246580
		[Token(Token = "0x403C334")]
		[FieldOffset(Offset = "0x40")]
		public FireworkPlateModel plateModel;

		// Token: 0x0403C335 RID: 246581
		[Token(Token = "0x403C335")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403C336 RID: 246582
		[Token(Token = "0x403C336")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;
	}
}
