using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035CD RID: 13773
	[Token(Token = "0x20035CD")]
	public class DefaultCommonSquadPlugin : CommonSquadItemStructSquadPlugin<DefaultCommonCharCardViewModel>, ICommonSquadItemStructSquad, ICommonSquadPlugin, IHotfixable
	{
		// Token: 0x06015E98 RID: 89752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E98")]
		[Address(RVA = "0xE68000", Offset = "0xE66C00", VA = "0x180E68000", Slot = "66")]
		protected override TemplateCharSelectCardViewModel CreateCharSelectCardViewModel(int instId, TemplateCharSelectCharInputData inputNullable, [Optional] PlayerCharacter playerData)
		{
			return null;
		}

		// Token: 0x06015E99 RID: 89753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E99")]
		[Address(RVA = "0xE682B0", Offset = "0xE66EB0", VA = "0x180E682B0", Slot = "58")]
		protected override DefaultCommonCharCardViewModel GetCharViewModelFromCharSelect(TemplateCharSelectCardViewModel selectChar)
		{
			return null;
		}

		// Token: 0x06015E9A RID: 89754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E9A")]
		[Address(RVA = "0xE68690", Offset = "0xE67290", VA = "0x180E68690", Slot = "67")]
		public override List<CommonSquadSingleSquadViewModel> LoadSquadCache()
		{
			return null;
		}

		// Token: 0x06015E9B RID: 89755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E9B")]
		[Address(RVA = "0xE685C0", Offset = "0xE671C0", VA = "0x180E685C0", Slot = "40")]
		public override ICustomSquadGroupViewModel GetCustomViewModel()
		{
			return null;
		}

		// Token: 0x06015E9C RID: 89756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E9C")]
		[Address(RVA = "0xE689C0", Offset = "0xE675C0", VA = "0x180E689C0")]
		public DefaultCommonSquadPlugin()
		{
		}

		// Token: 0x0401A59A RID: 107930
		[Token(Token = "0x401A59A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateCharSelectCardViewModel;

		// Token: 0x0401A59B RID: 107931
		[Token(Token = "0x401A59B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCharViewModelFromCharSelect;

		// Token: 0x0401A59C RID: 107932
		[Token(Token = "0x401A59C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadSquadCache;

		// Token: 0x0401A59D RID: 107933
		[Token(Token = "0x401A59D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCustomViewModel;

		// Token: 0x0401A59E RID: 107934
		[Token(Token = "0x401A59E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
