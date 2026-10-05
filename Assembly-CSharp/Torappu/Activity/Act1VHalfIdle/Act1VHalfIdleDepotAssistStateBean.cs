using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200778A RID: 30602
	[Token(Token = "0x200778A")]
	public class Act1VHalfIdleDepotAssistStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602AFA5 RID: 176037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFA5")]
		[Address(RVA = "0x26C3D20", Offset = "0x26C2920", VA = "0x1826C3D20")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602AFA6 RID: 176038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFA6")]
		[Address(RVA = "0x26C3F30", Offset = "0x26C2B30", VA = "0x1826C3F30")]
		public void UpdateData()
		{
		}

		// Token: 0x0602AFA7 RID: 176039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFA7")]
		[Address(RVA = "0x26C3FC0", Offset = "0x26C2BC0", VA = "0x1826C3FC0")]
		public Act1VHalfIdleDepotAssistStateBean()
		{
		}

		// Token: 0x0403E046 RID: 254022
		[Token(Token = "0x403E046")]
		[FieldOffset(Offset = "0x10")]
		public Act1VHalfIdleDepotAssistProperty property;

		// Token: 0x0403E047 RID: 254023
		[Token(Token = "0x403E047")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403E048 RID: 254024
		[Token(Token = "0x403E048")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0403E049 RID: 254025
		[Token(Token = "0x403E049")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
