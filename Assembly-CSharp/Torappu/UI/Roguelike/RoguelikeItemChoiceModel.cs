using System;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051AA RID: 20906
	[Token(Token = "0x20051AA")]
	public class RoguelikeItemChoiceModel : RoguelikeDefaultChoiceModel
	{
		// Token: 0x170047F7 RID: 18423
		// (get) Token: 0x0601EE16 RID: 126486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047F7")]
		protected string topicId
		{
			[Token(Token = "0x601EE16")]
			[Address(RVA = "0x18AA2F0", Offset = "0x18A8EF0", VA = "0x1818AA2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170047F8 RID: 18424
		// (get) Token: 0x0601EE17 RID: 126487 RVA: 0x000B0040 File Offset: 0x000AE240
		[Token(Token = "0x170047F8")]
		protected RoguelikeTopicItemModel itemModel
		{
			[Token(Token = "0x601EE17")]
			[Address(RVA = "0x18AA0C0", Offset = "0x18A8CC0", VA = "0x1818AA0C0")]
			get
			{
				return default(RoguelikeTopicItemModel);
			}
		}

		// Token: 0x0601EE18 RID: 126488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE18")]
		[Address(RVA = "0x18A9930", Offset = "0x18A8530", VA = "0x1818A9930", Slot = "17")]
		protected override void OnDataUpdated()
		{
		}

		// Token: 0x0601EE19 RID: 126489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE19")]
		[Address(RVA = "0x18A9DB0", Offset = "0x18A89B0", VA = "0x1818A9DB0")]
		private void _GetItemModelIfNecessary()
		{
		}

		// Token: 0x0601EE1A RID: 126490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE1A")]
		[Address(RVA = "0x18A9BE0", Offset = "0x18A87E0", VA = "0x1818A9BE0")]
		private void _GetDifficultyUpgradeRelicItemModelIfNecessary()
		{
		}

		// Token: 0x170047F9 RID: 18425
		// (get) Token: 0x0601EE1B RID: 126491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047F9")]
		public override string itemName
		{
			[Token(Token = "0x601EE1B")]
			[Address(RVA = "0x18AA190", Offset = "0x18A8D90", VA = "0x1818AA190", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x170047FA RID: 18426
		// (get) Token: 0x0601EE1C RID: 126492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047FA")]
		public override string itemDesc
		{
			[Token(Token = "0x601EE1C")]
			[Address(RVA = "0x18A9F50", Offset = "0x18A8B50", VA = "0x1818A9F50", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x170047FB RID: 18427
		// (get) Token: 0x0601EE1D RID: 126493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047FB")]
		public override string itemId
		{
			[Token(Token = "0x601EE1D")]
			[Address(RVA = "0x18AA020", Offset = "0x18A8C20", VA = "0x1818AA020", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x170047FC RID: 18428
		// (get) Token: 0x0601EE1E RID: 126494 RVA: 0x000B0058 File Offset: 0x000AE258
		[Token(Token = "0x170047FC")]
		public override RoguelikeGameItemType itemType
		{
			[Token(Token = "0x601EE1E")]
			[Address(RVA = "0x18AA250", Offset = "0x18A8E50", VA = "0x1818AA250", Slot = "25")]
			get
			{
				return RoguelikeGameItemType.NONE;
			}
		}

		// Token: 0x0601EE1F RID: 126495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE1F")]
		[Address(RVA = "0x18A9840", Offset = "0x18A8440", VA = "0x1818A9840", Slot = "18")]
		protected override IRoguelikeChoiceHintContext GetChoiceHintContext()
		{
			return null;
		}

		// Token: 0x0601EE20 RID: 126496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE20")]
		[Address(RVA = "0x18A9E40", Offset = "0x18A8A40", VA = "0x1818A9E40")]
		public RoguelikeItemChoiceModel()
		{
		}

		// Token: 0x0601EE21 RID: 126497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE21")]
		[Address(RVA = "0x18A8DA0", Offset = "0x18A79A0", VA = "0x1818A8DA0")]
		private void <>xLuaBaseProxy_OnDataUpdated()
		{
		}

		// Token: 0x0601EE22 RID: 126498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE22")]
		[Address(RVA = "0x18A9B70", Offset = "0x18A8770", VA = "0x1818A9B70")]
		private string <>xLuaBaseProxy_get_itemName()
		{
			return null;
		}

		// Token: 0x0601EE23 RID: 126499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE23")]
		[Address(RVA = "0x18A9B00", Offset = "0x18A8700", VA = "0x1818A9B00")]
		private string <>xLuaBaseProxy_get_itemDesc()
		{
			return null;
		}

		// Token: 0x0601EE24 RID: 126500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE24")]
		[Address(RVA = "0x18A95D0", Offset = "0x18A81D0", VA = "0x1818A95D0")]
		private string <>xLuaBaseProxy_get_itemId()
		{
			return null;
		}

		// Token: 0x0601EE25 RID: 126501 RVA: 0x000B0070 File Offset: 0x000AE270
		[Token(Token = "0x601EE25")]
		[Address(RVA = "0x18A96A0", Offset = "0x18A82A0", VA = "0x1818A96A0")]
		private RoguelikeGameItemType <>xLuaBaseProxy_get_itemType()
		{
			return RoguelikeGameItemType.NONE;
		}

		// Token: 0x0601EE26 RID: 126502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE26")]
		[Address(RVA = "0x18A9A60", Offset = "0x18A8660", VA = "0x1818A9A60")]
		private IRoguelikeChoiceHintContext <>xLuaBaseProxy_GetChoiceHintContext()
		{
			return null;
		}

		// Token: 0x040296D9 RID: 169689
		[Token(Token = "0x40296D9")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeTopicItemModel m_itemModel;

		// Token: 0x040296DA RID: 169690
		[Token(Token = "0x40296DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x040296DB RID: 169691
		[Token(Token = "0x40296DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemModel;

		// Token: 0x040296DC RID: 169692
		[Token(Token = "0x40296DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x040296DD RID: 169693
		[Token(Token = "0x40296DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetItemModelIfNecessary;

		// Token: 0x040296DE RID: 169694
		[Token(Token = "0x40296DE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetDifficultyUpgradeRelicItemModelIfNecessary;

		// Token: 0x040296DF RID: 169695
		[Token(Token = "0x40296DF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_itemName;

		// Token: 0x040296E0 RID: 169696
		[Token(Token = "0x40296E0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_itemDesc;

		// Token: 0x040296E1 RID: 169697
		[Token(Token = "0x40296E1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x040296E2 RID: 169698
		[Token(Token = "0x40296E2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x040296E3 RID: 169699
		[Token(Token = "0x40296E3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetChoiceHintContext;

		// Token: 0x040296E4 RID: 169700
		[Token(Token = "0x40296E4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020051AB RID: 20907
		[Token(Token = "0x20051AB")]
		public new class Context : RoguelikeDefaultChoiceModel.Context
		{
			// Token: 0x170047FD RID: 18429
			// (get) Token: 0x0601EE27 RID: 126503 RVA: 0x000B0088 File Offset: 0x000AE288
			[Token(Token = "0x170047FD")]
			public RoguelikeTopicItemModel itemModel
			{
				[Token(Token = "0x601EE27")]
				[Address(RVA = "0x1897010", Offset = "0x1895C10", VA = "0x181897010")]
				get
				{
					return default(RoguelikeTopicItemModel);
				}
			}

			// Token: 0x0601EE28 RID: 126504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EE28")]
			[Address(RVA = "0x1896F20", Offset = "0x1895B20", VA = "0x181896F20")]
			public Context(RoguelikeItemChoiceModel closure)
			{
			}

			// Token: 0x040296E5 RID: 169701
			[Token(Token = "0x40296E5")]
			[FieldOffset(Offset = "0x18")]
			private RoguelikeItemChoiceModel m_closure;

			// Token: 0x040296E6 RID: 169702
			[Token(Token = "0x40296E6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_itemModel;

			// Token: 0x040296E7 RID: 169703
			[Token(Token = "0x40296E7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
