using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051A9 RID: 20905
	[Token(Token = "0x20051A9")]
	public class RoguelikeTaskChoiceModel : RoguelikeDefaultChoiceModel
	{
		// Token: 0x0601EE11 RID: 126481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE11")]
		[Address(RVA = "0x18AB270", Offset = "0x18A9E70", VA = "0x1818AB270", Slot = "17")]
		protected override void OnDataUpdated()
		{
		}

		// Token: 0x170047F6 RID: 18422
		// (get) Token: 0x0601EE12 RID: 126482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047F6")]
		public override string choiceContent
		{
			[Token(Token = "0x601EE12")]
			[Address(RVA = "0x18AB4C0", Offset = "0x18AA0C0", VA = "0x1818AB4C0", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EE13 RID: 126483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE13")]
		[Address(RVA = "0x18AB420", Offset = "0x18AA020", VA = "0x1818AB420")]
		public RoguelikeTaskChoiceModel()
		{
		}

		// Token: 0x0601EE14 RID: 126484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE14")]
		[Address(RVA = "0x18A8DA0", Offset = "0x18A79A0", VA = "0x1818A8DA0")]
		private void <>xLuaBaseProxy_OnDataUpdated()
		{
		}

		// Token: 0x0601EE15 RID: 126485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE15")]
		[Address(RVA = "0x18AB340", Offset = "0x18A9F40", VA = "0x1818AB340")]
		private string <>xLuaBaseProxy_get_choiceContent()
		{
			return null;
		}

		// Token: 0x040296D5 RID: 169685
		[Token(Token = "0x40296D5")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeTaskData m_taskData;

		// Token: 0x040296D6 RID: 169686
		[Token(Token = "0x40296D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x040296D7 RID: 169687
		[Token(Token = "0x40296D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_choiceContent;

		// Token: 0x040296D8 RID: 169688
		[Token(Token = "0x40296D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
