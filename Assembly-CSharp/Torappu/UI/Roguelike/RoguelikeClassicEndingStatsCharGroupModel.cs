using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052BC RID: 21180
	[Token(Token = "0x20052BC")]
	public class RoguelikeClassicEndingStatsCharGroupModel : RoguelikeClassicEndingStatsViewComponentModel
	{
		// Token: 0x0601F3CF RID: 127951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3CF")]
		[Address(RVA = "0x18F5120", Offset = "0x18F3D20", VA = "0x1818F5120", Slot = "4")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.EndingResult result)
		{
		}

		// Token: 0x0601F3D0 RID: 127952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F3D0")]
		[Address(RVA = "0x18F5440", Offset = "0x18F4040", VA = "0x1818F5440")]
		private List<RoguelikeCharCardViewModel> _GetCharList(PlayerRoguelikeV2.CurrentData current)
		{
			return null;
		}

		// Token: 0x0601F3D1 RID: 127953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3D1")]
		[Address(RVA = "0x18F5620", Offset = "0x18F4220", VA = "0x1818F5620")]
		public RoguelikeClassicEndingStatsCharGroupModel()
		{
		}

		// Token: 0x04029F3F RID: 171839
		[Token(Token = "0x4029F3F")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeCharCardViewModel> charViewModels;

		// Token: 0x04029F40 RID: 171840
		[Token(Token = "0x4029F40")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x04029F41 RID: 171841
		[Token(Token = "0x4029F41")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04029F42 RID: 171842
		[Token(Token = "0x4029F42")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetCharList;

		// Token: 0x04029F43 RID: 171843
		[Token(Token = "0x4029F43")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
