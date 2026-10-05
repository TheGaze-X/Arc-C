using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x020017F3 RID: 6131
	[Token(Token = "0x20017F3")]
	public struct BuildingAssistantModel : IHotfixable
	{
		// Token: 0x06009AC7 RID: 39623 RVA: 0x0003C1C8 File Offset: 0x0003A3C8
		[Token(Token = "0x6009AC7")]
		[Address(RVA = "0x3150250", Offset = "0x314EE50", VA = "0x183150250")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06009AC8 RID: 39624 RVA: 0x0003C1E0 File Offset: 0x0003A3E0
		[Token(Token = "0x170010DC")]
		public int instId
		{
			[Token(Token = "0x6009AC8")]
			[Address(RVA = "0x3151530", Offset = "0x3150130", VA = "0x183151530")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06009AC9 RID: 39625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010DD")]
		public string staySlotId
		{
			[Token(Token = "0x6009AC9")]
			[Address(RVA = "0x3151610", Offset = "0x3150210", VA = "0x183151610")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009ACA RID: 39626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009ACA")]
		[Address(RVA = "0x3150570", Offset = "0x314F170", VA = "0x183150570")]
		public static List<BuildingAssistantModel> LoadAssistants(List<int> playerAssists, Dictionary<string, PlayerBuildingChar> playerChars, Dictionary<string, RoomSlotModel> roomSlots)
		{
			return null;
		}

		// Token: 0x06009ACB RID: 39627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009ACB")]
		[Address(RVA = "0x3150330", Offset = "0x314EF30", VA = "0x183150330")]
		public static List<string> LoadAssistTargetSlotsWhenIdel()
		{
			return null;
		}

		// Token: 0x06009ACC RID: 39628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009ACC")]
		[Address(RVA = "0x3151190", Offset = "0x314FD90", VA = "0x183151190")]
		private static ListDict<string, int> _LoadSortedDorms4Assits()
		{
			return null;
		}

		// Token: 0x06009ACD RID: 39629 RVA: 0x0003C1F8 File Offset: 0x0003A3F8
		[Token(Token = "0x6009ACD")]
		[Address(RVA = "0x3150890", Offset = "0x314F490", VA = "0x183150890")]
		private static int _CompareDormSlotOffsetPair(KeyValuePair<string, int> lhs, KeyValuePair<string, int> rhs)
		{
			return 0;
		}

		// Token: 0x06009ACE RID: 39630 RVA: 0x0003C210 File Offset: 0x0003A410
		[Token(Token = "0x6009ACE")]
		[Address(RVA = "0x3150950", Offset = "0x314F550", VA = "0x183150950")]
		private static BuildingAssistantModel _LoadSingleAssist(int instId, int index, Dictionary<string, PlayerBuildingChar> playerChars, Dictionary<string, RoomSlotModel> roomSlots, List<string> assistsSlotWhenIdel)
		{
			return default(BuildingAssistantModel);
		}

		// Token: 0x04009128 RID: 37160
		[Token(Token = "0x4009128")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BuildingAssistantModel EMPTY;

		// Token: 0x04009129 RID: 37161
		[Token(Token = "0x4009129")]
		[FieldOffset(Offset = "0x0")]
		private string m_targetSlotWhenIdel;

		// Token: 0x0400912A RID: 37162
		[Token(Token = "0x400912A")]
		[FieldOffset(Offset = "0x8")]
		public BuildingAssistantType type;

		// Token: 0x0400912B RID: 37163
		[Token(Token = "0x400912B")]
		[FieldOffset(Offset = "0x10")]
		public BuildingCharModel charModel;

		// Token: 0x0400912C RID: 37164
		[Token(Token = "0x400912C")]
		[FieldOffset(Offset = "0x88")]
		public int index;

		// Token: 0x0400912D RID: 37165
		[Token(Token = "0x400912D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x0400912E RID: 37166
		[Token(Token = "0x400912E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x0400912F RID: 37167
		[Token(Token = "0x400912F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_staySlotId;

		// Token: 0x04009130 RID: 37168
		[Token(Token = "0x4009130")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadAssistants;

		// Token: 0x04009131 RID: 37169
		[Token(Token = "0x4009131")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadAssistTargetSlotsWhenIdel;

		// Token: 0x04009132 RID: 37170
		[Token(Token = "0x4009132")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__LoadSortedDorms4Assits;

		// Token: 0x04009133 RID: 37171
		[Token(Token = "0x4009133")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CompareDormSlotOffsetPair;

		// Token: 0x04009134 RID: 37172
		[Token(Token = "0x4009134")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__LoadSingleAssist;
	}
}
