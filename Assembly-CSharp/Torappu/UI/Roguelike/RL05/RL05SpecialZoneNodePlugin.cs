using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005629 RID: 22057
	[Token(Token = "0x2005629")]
	public class RL05SpecialZoneNodePlugin : RoguelikeDungeonNode.SpecialZonePlugin
	{
		// Token: 0x17004BC1 RID: 19393
		// (get) Token: 0x060205EF RID: 132591 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060205F0 RID: 132592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BC1")]
		public string topicId
		{
			[Token(Token = "0x60205EF")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60205F0")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004BC2 RID: 19394
		// (get) Token: 0x060205F1 RID: 132593 RVA: 0x000B5968 File Offset: 0x000B3B68
		// (set) Token: 0x060205F2 RID: 132594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BC2")]
		public RoguelikeSkyZoneNodeType eventType
		{
			[Token(Token = "0x60205F1")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return RoguelikeSkyZoneNodeType.NONE;
			}
			[Token(Token = "0x60205F2")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004BC3 RID: 19395
		// (get) Token: 0x060205F3 RID: 132595 RVA: 0x000B5980 File Offset: 0x000B3B80
		// (set) Token: 0x060205F4 RID: 132596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BC3")]
		public RL05SpecialZoneNodeState state
		{
			[Token(Token = "0x60205F3")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			[CompilerGenerated]
			get
			{
				return RL05SpecialZoneNodeState.NOMRAL;
			}
			[Token(Token = "0x60205F4")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004BC4 RID: 19396
		// (get) Token: 0x060205F5 RID: 132597 RVA: 0x000B5998 File Offset: 0x000B3B98
		// (set) Token: 0x060205F6 RID: 132598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BC4")]
		public float battlePrg
		{
			[Token(Token = "0x60205F5")]
			[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60205F6")]
			[Address(RVA = "0x73B900", Offset = "0x73A500", VA = "0x18073B900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004BC5 RID: 19397
		// (get) Token: 0x060205F7 RID: 132599 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060205F8 RID: 132600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BC5")]
		public RoguelikeSkyNodeSubTypeData subTypeData
		{
			[Token(Token = "0x60205F7")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60205F8")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004BC6 RID: 19398
		// (get) Token: 0x060205F9 RID: 132601 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060205FA RID: 132602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BC6")]
		public RoguelikeSkyNodeData spNodeData
		{
			[Token(Token = "0x60205F9")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60205FA")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004BC7 RID: 19399
		// (get) Token: 0x060205FB RID: 132603 RVA: 0x000B59B0 File Offset: 0x000B3BB0
		[Token(Token = "0x17004BC7")]
		public override bool isBattleNode
		{
			[Token(Token = "0x60205FB")]
			[Address(RVA = "0x1A86140", Offset = "0x1A84D40", VA = "0x181A86140", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004BC8 RID: 19400
		// (get) Token: 0x060205FC RID: 132604 RVA: 0x000B59C8 File Offset: 0x000B3BC8
		[Token(Token = "0x17004BC8")]
		public override bool isChoiceNode
		{
			[Token(Token = "0x60205FC")]
			[Address(RVA = "0x1A86150", Offset = "0x1A84D50", VA = "0x181A86150", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004BC9 RID: 19401
		// (get) Token: 0x060205FD RID: 132605 RVA: 0x000B59E0 File Offset: 0x000B3BE0
		[Token(Token = "0x17004BC9")]
		public override bool isShopNode
		{
			[Token(Token = "0x60205FD")]
			[Address(RVA = "0x1A86160", Offset = "0x1A84D60", VA = "0x181A86160", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060205FE RID: 132606 RVA: 0x000B59F8 File Offset: 0x000B3BF8
		[Token(Token = "0x60205FE")]
		[Address(RVA = "0x1A85B60", Offset = "0x1A84760", VA = "0x181A85B60", Slot = "8")]
		public override bool CanMoveToDirectly()
		{
			return default(bool);
		}

		// Token: 0x060205FF RID: 132607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205FF")]
		[Address(RVA = "0x1A85B70", Offset = "0x1A84770", VA = "0x181A85B70", Slot = "9")]
		public override void CheckIfMoveTo(Action onMoveTo)
		{
		}

		// Token: 0x06020600 RID: 132608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020600")]
		[Address(RVA = "0x1A85D40", Offset = "0x1A84940", VA = "0x181A85D40", Slot = "10")]
		public override string GetNodeTypeString()
		{
			return null;
		}

		// Token: 0x06020601 RID: 132609 RVA: 0x000B5A10 File Offset: 0x000B3C10
		[Token(Token = "0x6020601")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "11")]
		public override RoguelikeSpZoneNodeType GetSpZoneNodeType()
		{
			return RoguelikeSpZoneNodeType.NORMAL;
		}

		// Token: 0x06020602 RID: 132610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020602")]
		[Address(RVA = "0x1A85DA0", Offset = "0x1A849A0", VA = "0x181A85DA0")]
		public void LoadData(string topicId, PlayerRoguelikeV2.CurrentData.Module.SkyZoneNodeInfo skyZoneNodeInfo)
		{
		}

		// Token: 0x06020603 RID: 132611 RVA: 0x000B5A28 File Offset: 0x000B3C28
		[Token(Token = "0x6020603")]
		[Address(RVA = "0x1A85F60", Offset = "0x1A84B60", VA = "0x181A85F60")]
		private RL05SpecialZoneNodeState _GetNodeStateBySkyInfo(PlayerRoguelikeV2.CurrentData.Module.SkyZoneNodeState skyZoneNodeState)
		{
			return RL05SpecialZoneNodeState.NOMRAL;
		}

		// Token: 0x06020604 RID: 132612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020604")]
		[Address(RVA = "0x1A85F80", Offset = "0x1A84B80", VA = "0x181A85F80")]
		private void _LoadSkyNodeData(string topicId, int subTypeId)
		{
		}

		// Token: 0x06020605 RID: 132613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020605")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RL05SpecialZoneNodePlugin()
		{
		}

		// Token: 0x0402BD3D RID: 179517
		[Token(Token = "0x402BD3D")]
		[FieldOffset(Offset = "0x38")]
		public RL05SpecialZoneNodePlugin.ShopInfo shopInfo;

		// Token: 0x0402BD3E RID: 179518
		[Token(Token = "0x402BD3E")]
		[FieldOffset(Offset = "0x50")]
		public bool hasPassed;

		// Token: 0x0200562A RID: 22058
		[Token(Token = "0x200562A")]
		public struct ShopInfo
		{
			// Token: 0x06020606 RID: 132614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020606")]
			[Address(RVA = "0x1A89650", Offset = "0x1A88250", VA = "0x181A89650")]
			public void LoadGoods(List<string> goods, string topicId)
			{
			}

			// Token: 0x06020607 RID: 132615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020607")]
			[Address(RVA = "0x1A89630", Offset = "0x1A88230", VA = "0x181A89630")]
			public void Clear()
			{
			}

			// Token: 0x0402BD3F RID: 179519
			[Token(Token = "0x402BD3F")]
			[FieldOffset(Offset = "0x0")]
			public bool isEmpty;

			// Token: 0x0402BD40 RID: 179520
			[Token(Token = "0x402BD40")]
			[FieldOffset(Offset = "0x1")]
			public bool showRefresh;

			// Token: 0x0402BD41 RID: 179521
			[Token(Token = "0x402BD41")]
			[FieldOffset(Offset = "0x4")]
			public int refreshCnt;

			// Token: 0x0402BD42 RID: 179522
			[Token(Token = "0x402BD42")]
			[FieldOffset(Offset = "0x8")]
			public int refreshCost;

			// Token: 0x0402BD43 RID: 179523
			[Token(Token = "0x402BD43")]
			[FieldOffset(Offset = "0x10")]
			public List<RoguelikeTopicItemModel> shopItems;
		}
	}
}
