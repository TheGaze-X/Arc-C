using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057CA RID: 22474
	[Token(Token = "0x20057CA")]
	public class RoguelikeInitExploreToolContext : RoguelikeInitOptionContext
	{
		// Token: 0x06020DF0 RID: 134640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DF0")]
		[Address(RVA = "0x1B39C90", Offset = "0x1B38890", VA = "0x181B39C90", Slot = "4")]
		public override void Load(PlayerRoguelikePendingEvent evt)
		{
		}

		// Token: 0x17004D13 RID: 19731
		// (get) Token: 0x06020DF1 RID: 134641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D13")]
		public override string name
		{
			[Token(Token = "0x6020DF1")]
			[Address(RVA = "0x1B3A890", Offset = "0x1B39490", VA = "0x181B3A890", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D14 RID: 19732
		// (get) Token: 0x06020DF2 RID: 134642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D14")]
		public override List<RoguelikeInitOption.Model> list
		{
			[Token(Token = "0x6020DF2")]
			[Address(RVA = "0x1B3A830", Offset = "0x1B39430", VA = "0x181B3A830", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020DF3 RID: 134643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DF3")]
		[Address(RVA = "0x1B3A120", Offset = "0x1B38D20", VA = "0x181B3A120", Slot = "8")]
		public override void OnSelect(int idx)
		{
		}

		// Token: 0x06020DF4 RID: 134644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DF4")]
		[Address(RVA = "0x1B3A450", Offset = "0x1B39050", VA = "0x181B3A450")]
		private void _AddExploreTool(string index, RoguelikeTopicItemModel itemData)
		{
		}

		// Token: 0x06020DF5 RID: 134645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DF5")]
		[Address(RVA = "0x1B3A730", Offset = "0x1B39330", VA = "0x181B3A730")]
		public RoguelikeInitExploreToolContext()
		{
		}

		// Token: 0x0402CAAD RID: 182957
		[Token(Token = "0x402CAAD")]
		[FieldOffset(Offset = "0x28")]
		private List<RoguelikeInitOption.Model> m_list;

		// Token: 0x0402CAAE RID: 182958
		[Token(Token = "0x402CAAE")]
		[FieldOffset(Offset = "0x30")]
		private List<KeyValuePair<string, string>> m_exploreTools;

		// Token: 0x0402CAAF RID: 182959
		[Token(Token = "0x402CAAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0402CAB0 RID: 182960
		[Token(Token = "0x402CAB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402CAB1 RID: 182961
		[Token(Token = "0x402CAB1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_list;

		// Token: 0x0402CAB2 RID: 182962
		[Token(Token = "0x402CAB2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSelect;

		// Token: 0x0402CAB3 RID: 182963
		[Token(Token = "0x402CAB3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__AddExploreTool;

		// Token: 0x0402CAB4 RID: 182964
		[Token(Token = "0x402CAB4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
