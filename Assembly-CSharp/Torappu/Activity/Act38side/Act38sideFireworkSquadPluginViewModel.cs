using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Firework;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.Act38side
{
	// Token: 0x0200743B RID: 29755
	[Token(Token = "0x200743B")]
	public class Act38sideFireworkSquadPluginViewModel : IHotfixable
	{
		// Token: 0x06029FDA RID: 171994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FDA")]
		[Address(RVA = "0x25A68B0", Offset = "0x25A54B0", VA = "0x1825A68B0")]
		public void LoadData(SquadHomePlugin.PluginInputParams param)
		{
		}

		// Token: 0x06029FDB RID: 171995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029FDB")]
		[Address(RVA = "0x25A71F0", Offset = "0x25A5DF0", VA = "0x1825A71F0")]
		private string _GetRetroGroupIdByStageId(string stageId)
		{
			return null;
		}

		// Token: 0x06029FDC RID: 171996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FDC")]
		[Address(RVA = "0x25A72D0", Offset = "0x25A5ED0", VA = "0x1825A72D0")]
		public Act38sideFireworkSquadPluginViewModel()
		{
		}

		// Token: 0x0403C373 RID: 246643
		[Token(Token = "0x403C373")]
		[FieldOffset(Offset = "0x10")]
		public bool isUnlock;

		// Token: 0x0403C374 RID: 246644
		[Token(Token = "0x403C374")]
		[FieldOffset(Offset = "0x18")]
		public string groupId;

		// Token: 0x0403C375 RID: 246645
		[Token(Token = "0x403C375")]
		[FieldOffset(Offset = "0x20")]
		public string stageId;

		// Token: 0x0403C376 RID: 246646
		[Token(Token = "0x403C376")]
		[FieldOffset(Offset = "0x28")]
		public bool canEdit;

		// Token: 0x0403C377 RID: 246647
		[Token(Token = "0x403C377")]
		[FieldOffset(Offset = "0x30")]
		public string currentAnimId;

		// Token: 0x0403C378 RID: 246648
		[Token(Token = "0x403C378")]
		[FieldOffset(Offset = "0x38")]
		public List<Act38sideFireworkSquadPluginItemViewModel> itemModelList;

		// Token: 0x0403C379 RID: 246649
		[Token(Token = "0x403C379")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, Act38sideFireworkSquadPluginItemViewModel> itemModelMap;

		// Token: 0x0403C37A RID: 246650
		[Token(Token = "0x403C37A")]
		[FieldOffset(Offset = "0x48")]
		public FireworkPlateModel plateModel;

		// Token: 0x0403C37B RID: 246651
		[Token(Token = "0x403C37B")]
		[FieldOffset(Offset = "0x50")]
		public StageData stageData;

		// Token: 0x0403C37C RID: 246652
		[Token(Token = "0x403C37C")]
		[FieldOffset(Offset = "0x58")]
		public bool isShow;

		// Token: 0x0403C37D RID: 246653
		[Token(Token = "0x403C37D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403C37E RID: 246654
		[Token(Token = "0x403C37E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetRetroGroupIdByStageId;

		// Token: 0x0403C37F RID: 246655
		[Token(Token = "0x403C37F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
