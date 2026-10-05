using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006033 RID: 24627
	[Token(Token = "0x2006033")]
	public class CarvingMainBoardOutputMaterialModel : IHotfixable
	{
		// Token: 0x060239D0 RID: 145872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239D0")]
		[Address(RVA = "0x1E46F80", Offset = "0x1E45B80", VA = "0x181E46F80")]
		public void LoadOutputModel(Act35SideData actData, List<CarvingMaterialModel> inputList, ListDict<string, CarvingMainCardViewModel> slotCardList, string actId)
		{
		}

		// Token: 0x060239D1 RID: 145873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239D1")]
		[Address(RVA = "0x1E47270", Offset = "0x1E45E70", VA = "0x181E47270")]
		private void _CalcCurSpineState(string actId, Act35SideData actData)
		{
		}

		// Token: 0x060239D2 RID: 145874 RVA: 0x000C15A8 File Offset: 0x000BF7A8
		[Token(Token = "0x60239D2")]
		[Address(RVA = "0x1E474A0", Offset = "0x1E460A0", VA = "0x181E474A0")]
		private bool _DiffSlotCardList(ListDict<string, CarvingMainCardViewModel> newSlotCardList)
		{
			return default(bool);
		}

		// Token: 0x060239D3 RID: 145875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239D3")]
		[Address(RVA = "0x1E476A0", Offset = "0x1E462A0", VA = "0x181E476A0")]
		public CarvingMainBoardOutputMaterialModel()
		{
		}

		// Token: 0x040314E7 RID: 201959
		[Token(Token = "0x40314E7")]
		[FieldOffset(Offset = "0x10")]
		public List<CarvingMaterialModel> outputMaterialItemList;

		// Token: 0x040314E8 RID: 201960
		[Token(Token = "0x40314E8")]
		[FieldOffset(Offset = "0x18")]
		public int point;

		// Token: 0x040314E9 RID: 201961
		[Token(Token = "0x40314E9")]
		[FieldOffset(Offset = "0x1C")]
		public CarvingMainBoardOutputMaterialModel.BirdSpineState spineState;

		// Token: 0x040314EA RID: 201962
		[Token(Token = "0x40314EA")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, CarvingMainCardViewModel> m_cachedSlotCardList;

		// Token: 0x040314EB RID: 201963
		[Token(Token = "0x40314EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadOutputModel;

		// Token: 0x040314EC RID: 201964
		[Token(Token = "0x40314EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CalcCurSpineState;

		// Token: 0x040314ED RID: 201965
		[Token(Token = "0x40314ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DiffSlotCardList;

		// Token: 0x040314EE RID: 201966
		[Token(Token = "0x40314EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006034 RID: 24628
		[Token(Token = "0x2006034")]
		public enum BirdSpineState
		{
			// Token: 0x040314F0 RID: 201968
			[Token(Token = "0x40314F0")]
			NONE,
			// Token: 0x040314F1 RID: 201969
			[Token(Token = "0x40314F1")]
			SLEEP,
			// Token: 0x040314F2 RID: 201970
			[Token(Token = "0x40314F2")]
			NORMAL,
			// Token: 0x040314F3 RID: 201971
			[Token(Token = "0x40314F3")]
			HAPPY
		}
	}
}
