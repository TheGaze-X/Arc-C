using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078D2 RID: 30930
	[Token(Token = "0x20078D2")]
	public class Act1LockSquadAssistStateBean : IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x0602B5F2 RID: 177650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5F2")]
		[Address(RVA = "0x272E4C0", Offset = "0x272D0C0", VA = "0x18272E4C0")]
		public void SetData(Act1LockSquadAssistStateBean.Input input)
		{
		}

		// Token: 0x0602B5F3 RID: 177651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5F3")]
		[Address(RVA = "0x272E780", Offset = "0x272D380", VA = "0x18272E780")]
		public void SetSkillSelected(int index)
		{
		}

		// Token: 0x0602B5F4 RID: 177652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5F4")]
		[Address(RVA = "0x272E350", Offset = "0x272CF50", VA = "0x18272E350")]
		public void GeneSquadFriendData()
		{
		}

		// Token: 0x0602B5F5 RID: 177653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5F5")]
		[Address(RVA = "0x272E890", Offset = "0x272D490", VA = "0x18272E890")]
		public Act1LockSquadAssistStateBean()
		{
		}

		// Token: 0x0403EB84 RID: 256900
		[Token(Token = "0x403EB84")]
		[FieldOffset(Offset = "0x10")]
		public Act1LockAssistViewProperty assistViewProperty;

		// Token: 0x0403EB85 RID: 256901
		[Token(Token = "0x403EB85")]
		[FieldOffset(Offset = "0x18")]
		public SharedCharData assistData;

		// Token: 0x0403EB86 RID: 256902
		[Token(Token = "0x403EB86")]
		[FieldOffset(Offset = "0x20")]
		public SquadFriendData friendData;

		// Token: 0x0403EB87 RID: 256903
		[Token(Token = "0x403EB87")]
		[FieldOffset(Offset = "0x28")]
		public bool isSelected;

		// Token: 0x0403EB88 RID: 256904
		[Token(Token = "0x403EB88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0403EB89 RID: 256905
		[Token(Token = "0x403EB89")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSkillSelected;

		// Token: 0x0403EB8A RID: 256906
		[Token(Token = "0x403EB8A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GeneSquadFriendData;

		// Token: 0x0403EB8B RID: 256907
		[Token(Token = "0x403EB8B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020078D3 RID: 30931
		[Token(Token = "0x20078D3")]
		public struct Input
		{
			// Token: 0x0403EB8C RID: 256908
			[Token(Token = "0x403EB8C")]
			[FieldOffset(Offset = "0x0")]
			public SharedCharData assistData;

			// Token: 0x0403EB8D RID: 256909
			[Token(Token = "0x403EB8D")]
			[FieldOffset(Offset = "0x8")]
			public bool isSelected;
		}
	}
}
