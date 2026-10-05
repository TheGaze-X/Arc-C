using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006524 RID: 25892
	[Token(Token = "0x2006524")]
	public class ArtMagazineCoverViewModel : IHotfixable
	{
		// Token: 0x170057D2 RID: 22482
		// (get) Token: 0x06025367 RID: 152423 RVA: 0x000C7068 File Offset: 0x000C5268
		// (set) Token: 0x06025368 RID: 152424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057D2")]
		public int currentLeafDisplayNum
		{
			[Token(Token = "0x6025367")]
			[Address(RVA = "0x2036CD0", Offset = "0x20358D0", VA = "0x182036CD0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6025368")]
			[Address(RVA = "0x2036E50", Offset = "0x2035A50", VA = "0x182036E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057D3 RID: 22483
		// (get) Token: 0x06025369 RID: 152425 RVA: 0x000C7080 File Offset: 0x000C5280
		// (set) Token: 0x0602536A RID: 152426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057D3")]
		public int leafDisplayMaxNum
		{
			[Token(Token = "0x6025369")]
			[Address(RVA = "0x2036DF0", Offset = "0x20359F0", VA = "0x182036DF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602536A")]
			[Address(RVA = "0x2036FA0", Offset = "0x2035BA0", VA = "0x182036FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057D4 RID: 22484
		// (get) Token: 0x0602536B RID: 152427 RVA: 0x000C7098 File Offset: 0x000C5298
		// (set) Token: 0x0602536C RID: 152428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057D4")]
		public bool isAllEmptyLeafsDisplay
		{
			[Token(Token = "0x602536B")]
			[Address(RVA = "0x2036D30", Offset = "0x2035930", VA = "0x182036D30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602536C")]
			[Address(RVA = "0x2036EC0", Offset = "0x2035AC0", VA = "0x182036EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057D5 RID: 22485
		// (get) Token: 0x0602536D RID: 152429 RVA: 0x000C70B0 File Offset: 0x000C52B0
		// (set) Token: 0x0602536E RID: 152430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057D5")]
		public bool isAllSlotDisplay
		{
			[Token(Token = "0x602536D")]
			[Address(RVA = "0x2036D90", Offset = "0x2035990", VA = "0x182036D90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602536E")]
			[Address(RVA = "0x2036F30", Offset = "0x2035B30", VA = "0x182036F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602536F RID: 152431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602536F")]
		[Address(RVA = "0x2036260", Offset = "0x2034E60", VA = "0x182036260")]
		public void LoadData()
		{
		}

		// Token: 0x06025370 RID: 152432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025370")]
		[Address(RVA = "0x20366B0", Offset = "0x20352B0", VA = "0x1820366B0")]
		public void RefreshData()
		{
		}

		// Token: 0x06025371 RID: 152433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025371")]
		[Address(RVA = "0x2036C20", Offset = "0x2035820", VA = "0x182036C20")]
		public ArtMagazineCoverViewModel()
		{
		}

		// Token: 0x0403432E RID: 213806
		[Token(Token = "0x403432E")]
		[FieldOffset(Offset = "0x20")]
		public List<ArtMagazineCoverLeafItemViewModel> leafItemViewModels;

		// Token: 0x0403432F RID: 213807
		[Token(Token = "0x403432F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentLeafDisplayNum;

		// Token: 0x04034330 RID: 213808
		[Token(Token = "0x4034330")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_currentLeafDisplayNum;

		// Token: 0x04034331 RID: 213809
		[Token(Token = "0x4034331")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_leafDisplayMaxNum;

		// Token: 0x04034332 RID: 213810
		[Token(Token = "0x4034332")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_leafDisplayMaxNum;

		// Token: 0x04034333 RID: 213811
		[Token(Token = "0x4034333")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isAllEmptyLeafsDisplay;

		// Token: 0x04034334 RID: 213812
		[Token(Token = "0x4034334")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isAllEmptyLeafsDisplay;

		// Token: 0x04034335 RID: 213813
		[Token(Token = "0x4034335")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isAllSlotDisplay;

		// Token: 0x04034336 RID: 213814
		[Token(Token = "0x4034336")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isAllSlotDisplay;

		// Token: 0x04034337 RID: 213815
		[Token(Token = "0x4034337")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034338 RID: 213816
		[Token(Token = "0x4034338")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04034339 RID: 213817
		[Token(Token = "0x4034339")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
