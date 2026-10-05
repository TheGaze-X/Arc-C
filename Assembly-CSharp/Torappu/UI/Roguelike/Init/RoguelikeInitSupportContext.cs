using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057D1 RID: 22481
	[Token(Token = "0x20057D1")]
	public class RoguelikeInitSupportContext : RoguelikeInitOptionContext
	{
		// Token: 0x17004D1E RID: 19742
		// (get) Token: 0x06020E15 RID: 134677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D1E")]
		public override List<RoguelikeInitOption.Model> list
		{
			[Token(Token = "0x6020E15")]
			[Address(RVA = "0x1B43440", Offset = "0x1B42040", VA = "0x181B43440", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D1F RID: 19743
		// (get) Token: 0x06020E16 RID: 134678 RVA: 0x000B7A38 File Offset: 0x000B5C38
		[Token(Token = "0x17004D1F")]
		public override bool showHint
		{
			[Token(Token = "0x6020E16")]
			[Address(RVA = "0x1B43520", Offset = "0x1B42120", VA = "0x181B43520", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004D20 RID: 19744
		// (get) Token: 0x06020E17 RID: 134679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D20")]
		public override string name
		{
			[Token(Token = "0x6020E17")]
			[Address(RVA = "0x1B434A0", Offset = "0x1B420A0", VA = "0x181B434A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020E18 RID: 134680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E18")]
		[Address(RVA = "0x1B428C0", Offset = "0x1B414C0", VA = "0x181B428C0", Slot = "4")]
		public override void Load(PlayerRoguelikePendingEvent evt)
		{
		}

		// Token: 0x06020E19 RID: 134681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E19")]
		[Address(RVA = "0x1B42E30", Offset = "0x1B41A30", VA = "0x181B42E30", Slot = "8")]
		public override void OnSelect(int idx)
		{
		}

		// Token: 0x06020E1A RID: 134682 RVA: 0x000B7A50 File Offset: 0x000B5C50
		[Token(Token = "0x6020E1A")]
		[Address(RVA = "0x1B431A0", Offset = "0x1B41DA0", VA = "0x181B431A0")]
		private RoguelikeRewardShowType _GetUnderText(RoguelikeGameChoiceData choiceData, out string itemIcon)
		{
			return RoguelikeRewardShowType.NONE;
		}

		// Token: 0x06020E1B RID: 134683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E1B")]
		[Address(RVA = "0x1B43340", Offset = "0x1B41F40", VA = "0x181B43340")]
		public RoguelikeInitSupportContext()
		{
		}

		// Token: 0x06020E1D RID: 134685 RVA: 0x000B7A68 File Offset: 0x000B5C68
		[Token(Token = "0x6020E1D")]
		[Address(RVA = "0x1B3D260", Offset = "0x1B3BE60", VA = "0x181B3D260")]
		private bool <>xLuaBaseProxy_get_showHint()
		{
			return default(bool);
		}

		// Token: 0x0402CAD8 RID: 183000
		[Token(Token = "0x402CAD8")]
		[FieldOffset(Offset = "0x28")]
		private List<RoguelikeInitOption.Model> m_list;

		// Token: 0x0402CAD9 RID: 183001
		[Token(Token = "0x402CAD9")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_choices;

		// Token: 0x0402CADA RID: 183002
		[Token(Token = "0x402CADA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_list;

		// Token: 0x0402CADB RID: 183003
		[Token(Token = "0x402CADB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showHint;

		// Token: 0x0402CADC RID: 183004
		[Token(Token = "0x402CADC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402CADD RID: 183005
		[Token(Token = "0x402CADD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0402CADE RID: 183006
		[Token(Token = "0x402CADE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSelect;

		// Token: 0x0402CADF RID: 183007
		[Token(Token = "0x402CADF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetUnderText;

		// Token: 0x0402CAE0 RID: 183008
		[Token(Token = "0x402CAE0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
