using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007775 RID: 30581
	[Token(Token = "0x2007775")]
	public class Act1VHalfidlePlotSquadGroupAdapter : SimpleLayoutAdapter
	{
		// Token: 0x170064B5 RID: 25781
		// (get) Token: 0x0602AF4E RID: 175950 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AF4F RID: 175951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064B5")]
		public List<Act1VHalfIdlePlotSquadGroupViewModel> dataSet
		{
			[Token(Token = "0x602AF4E")]
			[Address(RVA = "0x26D5B10", Offset = "0x26D4710", VA = "0x1826D5B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602AF4F")]
			[Address(RVA = "0x26D5BD0", Offset = "0x26D47D0", VA = "0x1826D5BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170064B6 RID: 25782
		// (get) Token: 0x0602AF50 RID: 175952 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AF51 RID: 175953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064B6")]
		public Act1VHalfIdlePlotType[] groupTypeArray
		{
			[Token(Token = "0x602AF50")]
			[Address(RVA = "0x26D5B70", Offset = "0x26D4770", VA = "0x1826D5B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602AF51")]
			[Address(RVA = "0x26D5C50", Offset = "0x26D4850", VA = "0x1826D5C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170064B7 RID: 25783
		// (get) Token: 0x0602AF52 RID: 175954 RVA: 0x000DA820 File Offset: 0x000D8A20
		[Token(Token = "0x170064B7")]
		public override int count
		{
			[Token(Token = "0x602AF52")]
			[Address(RVA = "0x26D5A60", Offset = "0x26D4660", VA = "0x1826D5A60", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602AF53 RID: 175955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF53")]
		[Address(RVA = "0x26D5810", Offset = "0x26D4410", VA = "0x1826D5810", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0602AF54 RID: 175956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF54")]
		[Address(RVA = "0x26D5690", Offset = "0x26D4290", VA = "0x1826D5690")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x0602AF55 RID: 175957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF55")]
		[Address(RVA = "0x26D5A00", Offset = "0x26D4600", VA = "0x1826D5A00")]
		public Act1VHalfidlePlotSquadGroupAdapter()
		{
		}

		// Token: 0x0403DFB3 RID: 253875
		[Token(Token = "0x403DFB3")]
		private const int TUTORIAL_GO_NUM = 4;

		// Token: 0x0403DFB6 RID: 253878
		[Token(Token = "0x403DFB6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataSet;

		// Token: 0x0403DFB7 RID: 253879
		[Token(Token = "0x403DFB7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_dataSet;

		// Token: 0x0403DFB8 RID: 253880
		[Token(Token = "0x403DFB8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_groupTypeArray;

		// Token: 0x0403DFB9 RID: 253881
		[Token(Token = "0x403DFB9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_groupTypeArray;

		// Token: 0x0403DFBA RID: 253882
		[Token(Token = "0x403DFBA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0403DFBB RID: 253883
		[Token(Token = "0x403DFBB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403DFBC RID: 253884
		[Token(Token = "0x403DFBC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403DFBD RID: 253885
		[Token(Token = "0x403DFBD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
