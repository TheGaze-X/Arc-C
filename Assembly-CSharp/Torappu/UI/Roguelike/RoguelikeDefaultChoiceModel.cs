using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051AF RID: 20911
	[Token(Token = "0x20051AF")]
	public class RoguelikeDefaultChoiceModel : IRoguelikeGameChoice, IHotfixable
	{
		// Token: 0x170047FE RID: 18430
		// (get) Token: 0x0601EE2D RID: 126509 RVA: 0x000B00A0 File Offset: 0x000AE2A0
		[Token(Token = "0x170047FE")]
		protected RoguelikeGameChoiceType m_choiceType
		{
			[Token(Token = "0x601EE2D")]
			[Address(RVA = "0x18A9770", Offset = "0x18A8370", VA = "0x1818A9770")]
			get
			{
				return RoguelikeGameChoiceType.NONE;
			}
		}

		// Token: 0x0601EE2E RID: 126510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE2E")]
		[Address(RVA = "0x18A8E00", Offset = "0x18A7A00", VA = "0x1818A8E00")]
		public void UpdateData(string topicId, RoguelikeGameChoiceData data, RoguelikeChoiceDisplayData displayData, PlayerRoguelikePendingEvent.ChoiceAddition additionData, bool selectable, RoguelikeChoiceHintFactory hintFactory)
		{
		}

		// Token: 0x0601EE2F RID: 126511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE2F")]
		[Address(RVA = "0x18A8FD0", Offset = "0x18A7BD0", VA = "0x1818A8FD0")]
		private void _GenerateChoiceHint()
		{
		}

		// Token: 0x0601EE30 RID: 126512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE30")]
		[Address(RVA = "0x18A8DA0", Offset = "0x18A79A0", VA = "0x1818A8DA0", Slot = "17")]
		protected virtual void OnDataUpdated()
		{
		}

		// Token: 0x0601EE31 RID: 126513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE31")]
		[Address(RVA = "0x18A8D00", Offset = "0x18A7900", VA = "0x1818A8D00", Slot = "18")]
		protected virtual IRoguelikeChoiceHintContext GetChoiceHintContext()
		{
			return null;
		}

		// Token: 0x170047FF RID: 18431
		// (get) Token: 0x0601EE32 RID: 126514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047FF")]
		public RoguelikeGameChoiceData choiceData
		{
			[Token(Token = "0x601EE32")]
			[Address(RVA = "0x18A92B0", Offset = "0x18A7EB0", VA = "0x1818A92B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004800 RID: 18432
		// (get) Token: 0x0601EE33 RID: 126515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004800")]
		public PlayerRoguelikePendingEvent.ChoiceAddition playerAdditionData
		{
			[Token(Token = "0x601EE33")]
			[Address(RVA = "0x18A97E0", Offset = "0x18A83E0", VA = "0x1818A97E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004801 RID: 18433
		// (get) Token: 0x0601EE34 RID: 126516 RVA: 0x000B00B8 File Offset: 0x000AE2B8
		[Token(Token = "0x17004801")]
		public RoguelikeChoiceLeftDecoType leftDecoType
		{
			[Token(Token = "0x601EE34")]
			[Address(RVA = "0x18A9700", Offset = "0x18A8300", VA = "0x1818A9700", Slot = "16")]
			get
			{
				return RoguelikeChoiceLeftDecoType.NONE;
			}
		}

		// Token: 0x17004802 RID: 18434
		// (get) Token: 0x0601EE35 RID: 126517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004802")]
		public virtual string choiceTitle
		{
			[Token(Token = "0x601EE35")]
			[Address(RVA = "0x18A9390", Offset = "0x18A7F90", VA = "0x1818A9390", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004803 RID: 18435
		// (get) Token: 0x0601EE36 RID: 126518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004803")]
		public virtual string choiceContent
		{
			[Token(Token = "0x601EE36")]
			[Address(RVA = "0x18A91D0", Offset = "0x18A7DD0", VA = "0x1818A91D0", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004804 RID: 18436
		// (get) Token: 0x0601EE37 RID: 126519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004804")]
		public string choiceHint
		{
			[Token(Token = "0x601EE37")]
			[Address(RVA = "0x18A9310", Offset = "0x18A7F10", VA = "0x1818A9310", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004805 RID: 18437
		// (get) Token: 0x0601EE38 RID: 126520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004805")]
		public virtual string itemName
		{
			[Token(Token = "0x601EE38")]
			[Address(RVA = "0x18A9630", Offset = "0x18A8230", VA = "0x1818A9630", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004806 RID: 18438
		// (get) Token: 0x0601EE39 RID: 126521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004806")]
		public virtual string itemDesc
		{
			[Token(Token = "0x601EE39")]
			[Address(RVA = "0x18A9560", Offset = "0x18A8160", VA = "0x1818A9560", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004807 RID: 18439
		// (get) Token: 0x0601EE3A RID: 126522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004807")]
		public virtual string funcIconName
		{
			[Token(Token = "0x601EE3A")]
			[Address(RVA = "0x18A9480", Offset = "0x18A8080", VA = "0x1818A9480", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004808 RID: 18440
		// (get) Token: 0x0601EE3B RID: 126523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004808")]
		public virtual string itemId
		{
			[Token(Token = "0x601EE3B")]
			[Address(RVA = "0x18A95D0", Offset = "0x18A81D0", VA = "0x1818A95D0", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004809 RID: 18441
		// (get) Token: 0x0601EE3C RID: 126524 RVA: 0x000B00D0 File Offset: 0x000AE2D0
		[Token(Token = "0x17004809")]
		public virtual RoguelikeGameItemType itemType
		{
			[Token(Token = "0x601EE3C")]
			[Address(RVA = "0x18A96A0", Offset = "0x18A82A0", VA = "0x1818A96A0", Slot = "25")]
			get
			{
				return RoguelikeGameItemType.NONE;
			}
		}

		// Token: 0x1700480A RID: 18442
		// (get) Token: 0x0601EE3D RID: 126525 RVA: 0x000B00E8 File Offset: 0x000AE2E8
		[Token(Token = "0x1700480A")]
		public virtual bool enabled
		{
			[Token(Token = "0x601EE3D")]
			[Address(RVA = "0x18A9420", Offset = "0x18A8020", VA = "0x1818A9420", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700480B RID: 18443
		// (get) Token: 0x0601EE3E RID: 126526 RVA: 0x000B0100 File Offset: 0x000AE300
		[Token(Token = "0x1700480B")]
		public virtual bool isLeave
		{
			[Token(Token = "0x601EE3E")]
			[Address(RVA = "0x18A94E0", Offset = "0x18A80E0", VA = "0x1818A94E0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601EE3F RID: 126527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE3F")]
		[Address(RVA = "0x18A9170", Offset = "0x18A7D70", VA = "0x1818A9170")]
		public RoguelikeDefaultChoiceModel()
		{
		}

		// Token: 0x040296EA RID: 169706
		[Token(Token = "0x40296EA")]
		[FieldOffset(Offset = "0x10")]
		private RoguelikeGameChoiceData m_data;

		// Token: 0x040296EB RID: 169707
		[Token(Token = "0x40296EB")]
		[FieldOffset(Offset = "0x18")]
		private PlayerRoguelikePendingEvent.ChoiceAddition m_playerAdditionData;

		// Token: 0x040296EC RID: 169708
		[Token(Token = "0x40296EC")]
		[FieldOffset(Offset = "0x20")]
		private bool m_selectable;

		// Token: 0x040296ED RID: 169709
		[Token(Token = "0x40296ED")]
		[FieldOffset(Offset = "0x28")]
		private IRoguelikeChoiceHintModel m_choiceCostHintModel;

		// Token: 0x040296EE RID: 169710
		[Token(Token = "0x40296EE")]
		[FieldOffset(Offset = "0x30")]
		private IRoguelikeChoiceHintModel m_choiceEffectHintModel;

		// Token: 0x040296EF RID: 169711
		[Token(Token = "0x40296EF")]
		[FieldOffset(Offset = "0x38")]
		private string m_choiceHint;

		// Token: 0x040296F0 RID: 169712
		[Token(Token = "0x40296F0")]
		[FieldOffset(Offset = "0x40")]
		protected string m_topicId;

		// Token: 0x040296F1 RID: 169713
		[Token(Token = "0x40296F1")]
		[FieldOffset(Offset = "0x48")]
		protected RoguelikeChoiceDisplayData m_displayData;

		// Token: 0x040296F2 RID: 169714
		[Token(Token = "0x40296F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_m_choiceType;

		// Token: 0x040296F3 RID: 169715
		[Token(Token = "0x40296F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040296F4 RID: 169716
		[Token(Token = "0x40296F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenerateChoiceHint;

		// Token: 0x040296F5 RID: 169717
		[Token(Token = "0x40296F5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x040296F6 RID: 169718
		[Token(Token = "0x40296F6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetChoiceHintContext;

		// Token: 0x040296F7 RID: 169719
		[Token(Token = "0x40296F7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_choiceData;

		// Token: 0x040296F8 RID: 169720
		[Token(Token = "0x40296F8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_playerAdditionData;

		// Token: 0x040296F9 RID: 169721
		[Token(Token = "0x40296F9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_leftDecoType;

		// Token: 0x040296FA RID: 169722
		[Token(Token = "0x40296FA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_choiceTitle;

		// Token: 0x040296FB RID: 169723
		[Token(Token = "0x40296FB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_choiceContent;

		// Token: 0x040296FC RID: 169724
		[Token(Token = "0x40296FC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_choiceHint;

		// Token: 0x040296FD RID: 169725
		[Token(Token = "0x40296FD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_itemName;

		// Token: 0x040296FE RID: 169726
		[Token(Token = "0x40296FE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_itemDesc;

		// Token: 0x040296FF RID: 169727
		[Token(Token = "0x40296FF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_funcIconName;

		// Token: 0x04029700 RID: 169728
		[Token(Token = "0x4029700")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x04029701 RID: 169729
		[Token(Token = "0x4029701")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x04029702 RID: 169730
		[Token(Token = "0x4029702")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_enabled;

		// Token: 0x04029703 RID: 169731
		[Token(Token = "0x4029703")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_isLeave;

		// Token: 0x04029704 RID: 169732
		[Token(Token = "0x4029704")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020051B0 RID: 20912
		[Token(Token = "0x20051B0")]
		public class Context : IRoguelikeChoiceHintContext, IHotfixable
		{
			// Token: 0x1700480C RID: 18444
			// (get) Token: 0x0601EE40 RID: 126528 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700480C")]
			public string topicId
			{
				[Token(Token = "0x601EE40")]
				[Address(RVA = "0x18970F0", Offset = "0x1895CF0", VA = "0x1818970F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700480D RID: 18445
			// (get) Token: 0x0601EE41 RID: 126529 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700480D")]
			public RoguelikeChoiceDisplayData displayData
			{
				[Token(Token = "0x601EE41")]
				[Address(RVA = "0x1896FA0", Offset = "0x1895BA0", VA = "0x181896FA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601EE42 RID: 126530 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EE42")]
			[Address(RVA = "0x1896EA0", Offset = "0x1895AA0", VA = "0x181896EA0")]
			public Context(RoguelikeDefaultChoiceModel closure)
			{
			}

			// Token: 0x04029705 RID: 169733
			[Token(Token = "0x4029705")]
			[FieldOffset(Offset = "0x10")]
			private RoguelikeDefaultChoiceModel m_closure;

			// Token: 0x04029706 RID: 169734
			[Token(Token = "0x4029706")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_topicId;

			// Token: 0x04029707 RID: 169735
			[Token(Token = "0x4029707")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_displayData;

			// Token: 0x04029708 RID: 169736
			[Token(Token = "0x4029708")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
