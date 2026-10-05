using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005867 RID: 22631
	[Token(Token = "0x2005867")]
	public class RL03TotemBuffMapNodeViewModel : IHotfixable
	{
		// Token: 0x17004D8B RID: 19851
		// (get) Token: 0x060210DA RID: 135386 RVA: 0x000B85A8 File Offset: 0x000B67A8
		[Token(Token = "0x17004D8B")]
		public bool isSelectable
		{
			[Token(Token = "0x60210DA")]
			[Address(RVA = "0x1B62F10", Offset = "0x1B61B10", VA = "0x181B62F10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060210DB RID: 135387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210DB")]
		[Address(RVA = "0x1B62EB0", Offset = "0x1B61AB0", VA = "0x181B62EB0")]
		public RL03TotemBuffMapNodeViewModel()
		{
		}

		// Token: 0x0402CFA9 RID: 184233
		[Token(Token = "0x402CFA9")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0402CFAA RID: 184234
		[Token(Token = "0x402CFAA")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeDungeonNode node;

		// Token: 0x0402CFAB RID: 184235
		[Token(Token = "0x402CFAB")]
		[FieldOffset(Offset = "0x20")]
		public TotemMapNodeSelectType selectType;

		// Token: 0x0402CFAC RID: 184236
		[Token(Token = "0x402CFAC")]
		[FieldOffset(Offset = "0x24")]
		public bool isManualSelected;

		// Token: 0x0402CFAD RID: 184237
		[Token(Token = "0x402CFAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isSelectable;

		// Token: 0x0402CFAE RID: 184238
		[Token(Token = "0x402CFAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
