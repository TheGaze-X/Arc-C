using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.RL04;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046B8 RID: 18104
	[Token(Token = "0x20046B8")]
	public class RL04NodeUpgradeModel : IHotfixable
	{
		// Token: 0x1700415C RID: 16732
		// (get) Token: 0x0601B751 RID: 112465 RVA: 0x000A5420 File Offset: 0x000A3620
		// (set) Token: 0x0601B752 RID: 112466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700415C")]
		public RoguelikeEventType nodeType
		{
			[Token(Token = "0x601B751")]
			[Address(RVA = "0x14CA440", Offset = "0x14C9040", VA = "0x1814CA440")]
			[CompilerGenerated]
			get
			{
				return RoguelikeEventType.NONE;
			}
			[Token(Token = "0x601B752")]
			[Address(RVA = "0x14CA690", Offset = "0x14C9290", VA = "0x1814CA690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700415D RID: 16733
		// (get) Token: 0x0601B753 RID: 112467 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B754 RID: 112468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700415D")]
		public string typeName
		{
			[Token(Token = "0x601B753")]
			[Address(RVA = "0x14CA5C0", Offset = "0x14C91C0", VA = "0x1814CA5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B754")]
			[Address(RVA = "0x14CA770", Offset = "0x14C9370", VA = "0x1814CA770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700415E RID: 16734
		// (get) Token: 0x0601B755 RID: 112469 RVA: 0x000A5438 File Offset: 0x000A3638
		// (set) Token: 0x0601B756 RID: 112470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700415E")]
		public int sortId
		{
			[Token(Token = "0x601B755")]
			[Address(RVA = "0x14CA500", Offset = "0x14C9100", VA = "0x1814CA500")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601B756")]
			[Address(RVA = "0x14CA700", Offset = "0x14C9300", VA = "0x1814CA700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700415F RID: 16735
		// (get) Token: 0x0601B757 RID: 112471 RVA: 0x000A5450 File Offset: 0x000A3650
		// (set) Token: 0x0601B758 RID: 112472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700415F")]
		public int currPermLevel
		{
			[Token(Token = "0x601B757")]
			[Address(RVA = "0x14CA3E0", Offset = "0x14C8FE0", VA = "0x1814CA3E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601B758")]
			[Address(RVA = "0x14CA620", Offset = "0x14C9220", VA = "0x1814CA620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004160 RID: 16736
		// (get) Token: 0x0601B759 RID: 112473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004160")]
		public List<RL04PermNodeUpgradeItemModel> permItemList
		{
			[Token(Token = "0x601B759")]
			[Address(RVA = "0x14CA4A0", Offset = "0x14C90A0", VA = "0x1814CA4A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004161 RID: 16737
		// (get) Token: 0x0601B75A RID: 112474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004161")]
		public List<RL04TempNodeUpgradeItemModel> tempItemList
		{
			[Token(Token = "0x601B75A")]
			[Address(RVA = "0x14CA560", Offset = "0x14C9160", VA = "0x1814CA560")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B75B RID: 112475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B75B")]
		[Address(RVA = "0x14C9890", Offset = "0x14C8490", VA = "0x1814C9890")]
		public string GetUpgradeTypeName()
		{
			return null;
		}

		// Token: 0x0601B75C RID: 112476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B75C")]
		[Address(RVA = "0x14C9AC0", Offset = "0x14C86C0", VA = "0x1814C9AC0")]
		public void LoadData(string topicId, RoguelikeNodeUpgradeData upgradeData, RoguelikeGameNodeTypeData typeData)
		{
		}

		// Token: 0x0601B75D RID: 112477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B75D")]
		[Address(RVA = "0x14CA040", Offset = "0x14C8C40", VA = "0x1814CA040")]
		private void _UpdatePlayerData()
		{
		}

		// Token: 0x0601B75E RID: 112478 RVA: 0x000A5468 File Offset: 0x000A3668
		[Token(Token = "0x601B75E")]
		[Address(RVA = "0x14C99E0", Offset = "0x14C85E0", VA = "0x1814C99E0")]
		public bool IsAllPermUnlock()
		{
			return default(bool);
		}

		// Token: 0x0601B75F RID: 112479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B75F")]
		[Address(RVA = "0x14CA2E0", Offset = "0x14C8EE0", VA = "0x1814CA2E0")]
		public RL04NodeUpgradeModel()
		{
		}

		// Token: 0x040238AE RID: 145582
		[Token(Token = "0x40238AE")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x040238B3 RID: 145587
		[Token(Token = "0x40238B3")]
		[FieldOffset(Offset = "0x30")]
		private List<RL04PermNodeUpgradeItemModel> m_permItemList;

		// Token: 0x040238B4 RID: 145588
		[Token(Token = "0x40238B4")]
		[FieldOffset(Offset = "0x38")]
		private List<RL04TempNodeUpgradeItemModel> m_tempItemList;

		// Token: 0x040238B5 RID: 145589
		[Token(Token = "0x40238B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x040238B6 RID: 145590
		[Token(Token = "0x40238B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_nodeType;

		// Token: 0x040238B7 RID: 145591
		[Token(Token = "0x40238B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_typeName;

		// Token: 0x040238B8 RID: 145592
		[Token(Token = "0x40238B8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_typeName;

		// Token: 0x040238B9 RID: 145593
		[Token(Token = "0x40238B9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x040238BA RID: 145594
		[Token(Token = "0x40238BA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x040238BB RID: 145595
		[Token(Token = "0x40238BB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_currPermLevel;

		// Token: 0x040238BC RID: 145596
		[Token(Token = "0x40238BC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_currPermLevel;

		// Token: 0x040238BD RID: 145597
		[Token(Token = "0x40238BD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_permItemList;

		// Token: 0x040238BE RID: 145598
		[Token(Token = "0x40238BE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_tempItemList;

		// Token: 0x040238BF RID: 145599
		[Token(Token = "0x40238BF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetUpgradeTypeName;

		// Token: 0x040238C0 RID: 145600
		[Token(Token = "0x40238C0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040238C1 RID: 145601
		[Token(Token = "0x40238C1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdatePlayerData;

		// Token: 0x040238C2 RID: 145602
		[Token(Token = "0x40238C2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_IsAllPermUnlock;

		// Token: 0x040238C3 RID: 145603
		[Token(Token = "0x40238C3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
