using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200429E RID: 17054
	[Token(Token = "0x200429E")]
	public class SandboxV2DungeonMaterialViewModel : IHotfixable
	{
		// Token: 0x0601A446 RID: 107590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A446")]
		[Address(RVA = "0x132F390", Offset = "0x132DF90", VA = "0x18132F390")]
		private UIItemViewModel _GetMaterialItemViewModel(string itemId)
		{
			return null;
		}

		// Token: 0x0601A447 RID: 107591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A447")]
		[Address(RVA = "0x132EE40", Offset = "0x132DA40", VA = "0x18132EE40")]
		public void LoadData(string topicId, SandboxV2Data topicDetailData, PlayerSandboxV2 playerTopicData)
		{
		}

		// Token: 0x0601A448 RID: 107592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A448")]
		[Address(RVA = "0x132F490", Offset = "0x132E090", VA = "0x18132F490")]
		public SandboxV2DungeonMaterialViewModel()
		{
		}

		// Token: 0x0402143D RID: 136253
		[Token(Token = "0x402143D")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0402143E RID: 136254
		[Token(Token = "0x402143E")]
		[FieldOffset(Offset = "0x18")]
		public UIItemViewModel goldItemViewModel;

		// Token: 0x0402143F RID: 136255
		[Token(Token = "0x402143F")]
		[FieldOffset(Offset = "0x20")]
		public UIItemViewModel dimensionCoinItemViewModel;

		// Token: 0x04021440 RID: 136256
		[Token(Token = "0x4021440")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<string, UIItemViewModel> materials;

		// Token: 0x04021441 RID: 136257
		[Token(Token = "0x4021441")]
		private const string IGNOR_MAT_SUBTYPE = "COMMON";

		// Token: 0x04021442 RID: 136258
		[Token(Token = "0x4021442")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetMaterialItemViewModel;

		// Token: 0x04021443 RID: 136259
		[Token(Token = "0x4021443")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021444 RID: 136260
		[Token(Token = "0x4021444")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
