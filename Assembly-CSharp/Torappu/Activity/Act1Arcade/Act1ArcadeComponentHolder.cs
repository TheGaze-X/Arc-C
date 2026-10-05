using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007945 RID: 31045
	[Token(Token = "0x2007945")]
	public class Act1ArcadeComponentHolder : CustomPageActivityComponentHolder
	{
		// Token: 0x0602B8F0 RID: 178416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8F0")]
		[Address(RVA = "0x2773130", Offset = "0x2771D30", VA = "0x182773130", Slot = "12")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x0602B8F1 RID: 178417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8F1")]
		[Address(RVA = "0x2773400", Offset = "0x2772000", VA = "0x182773400", Slot = "13")]
		public override void RefreshData()
		{
		}

		// Token: 0x0602B8F2 RID: 178418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B8F2")]
		[Address(RVA = "0x27735B0", Offset = "0x27721B0", VA = "0x1827735B0")]
		private TemplateActivityMedalViewModel _GenMedalViewModel()
		{
			return null;
		}

		// Token: 0x0602B8F3 RID: 178419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B8F3")]
		[Address(RVA = "0x27736B0", Offset = "0x27722B0", VA = "0x1827736B0")]
		private TemplateActivityMilestoneGroupViewModel _GenMilestoneViewModel()
		{
			return null;
		}

		// Token: 0x0602B8F4 RID: 178420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8F4")]
		[Address(RVA = "0x27737C0", Offset = "0x27723C0", VA = "0x1827737C0")]
		public Act1ArcadeComponentHolder()
		{
		}

		// Token: 0x0602B8F5 RID: 178421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8F5")]
		[Address(RVA = "0x27735A0", Offset = "0x27721A0", VA = "0x1827735A0")]
		private void <>xLuaBaseProxy_RefreshData()
		{
		}

		// Token: 0x0403F013 RID: 258067
		[Token(Token = "0x403F013")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403F014 RID: 258068
		[Token(Token = "0x403F014")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403F015 RID: 258069
		[Token(Token = "0x403F015")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenMedalViewModel;

		// Token: 0x0403F016 RID: 258070
		[Token(Token = "0x403F016")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenMilestoneViewModel;

		// Token: 0x0403F017 RID: 258071
		[Token(Token = "0x403F017")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
