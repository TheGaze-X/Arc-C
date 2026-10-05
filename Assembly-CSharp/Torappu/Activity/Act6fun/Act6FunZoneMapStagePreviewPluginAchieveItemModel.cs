using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071BA RID: 29114
	[Token(Token = "0x20071BA")]
	public class Act6FunZoneMapStagePreviewPluginAchieveItemModel : IHotfixable, IComparable<Act6FunZoneMapStagePreviewPluginAchieveItemModel>
	{
		// Token: 0x170061CF RID: 25039
		// (get) Token: 0x06029506 RID: 169222 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06029507 RID: 169223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061CF")]
		public string achievementId
		{
			[Token(Token = "0x6029506")]
			[Address(RVA = "0x24B68C0", Offset = "0x24B54C0", VA = "0x1824B68C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6029507")]
			[Address(RVA = "0x24B6A40", Offset = "0x24B5640", VA = "0x1824B6A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061D0 RID: 25040
		// (get) Token: 0x06029508 RID: 169224 RVA: 0x000D5528 File Offset: 0x000D3728
		// (set) Token: 0x06029509 RID: 169225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061D0")]
		public int sortId
		{
			[Token(Token = "0x6029508")]
			[Address(RVA = "0x24B69E0", Offset = "0x24B55E0", VA = "0x1824B69E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6029509")]
			[Address(RVA = "0x24B6BB0", Offset = "0x24B57B0", VA = "0x1824B6BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061D1 RID: 25041
		// (get) Token: 0x0602950A RID: 169226 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602950B RID: 169227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061D1")]
		public string desc
		{
			[Token(Token = "0x602950A")]
			[Address(RVA = "0x24B6920", Offset = "0x24B5520", VA = "0x1824B6920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602950B")]
			[Address(RVA = "0x24B6AC0", Offset = "0x24B56C0", VA = "0x1824B6AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061D2 RID: 25042
		// (get) Token: 0x0602950C RID: 169228 RVA: 0x000D5540 File Offset: 0x000D3740
		// (set) Token: 0x0602950D RID: 169229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061D2")]
		public bool hasComplete
		{
			[Token(Token = "0x602950C")]
			[Address(RVA = "0x24B6980", Offset = "0x24B5580", VA = "0x1824B6980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602950D")]
			[Address(RVA = "0x24B6B40", Offset = "0x24B5740", VA = "0x1824B6B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602950E RID: 169230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602950E")]
		[Address(RVA = "0x24B6650", Offset = "0x24B5250", VA = "0x1824B6650")]
		public void LoadData(Act6FunAchievementData data)
		{
		}

		// Token: 0x0602950F RID: 169231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602950F")]
		[Address(RVA = "0x24B67C0", Offset = "0x24B53C0", VA = "0x1824B67C0")]
		public void RefreshData(bool complete)
		{
		}

		// Token: 0x06029510 RID: 169232 RVA: 0x000D5558 File Offset: 0x000D3758
		[Token(Token = "0x6029510")]
		[Address(RVA = "0x24B6470", Offset = "0x24B5070", VA = "0x1824B6470", Slot = "4")]
		public int CompareTo(Act6FunZoneMapStagePreviewPluginAchieveItemModel other)
		{
			return 0;
		}

		// Token: 0x06029511 RID: 169233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029511")]
		[Address(RVA = "0x24B6860", Offset = "0x24B5460", VA = "0x1824B6860")]
		public Act6FunZoneMapStagePreviewPluginAchieveItemModel()
		{
		}

		// Token: 0x0403AFFA RID: 241658
		[Token(Token = "0x403AFFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_achievementId;

		// Token: 0x0403AFFB RID: 241659
		[Token(Token = "0x403AFFB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_achievementId;

		// Token: 0x0403AFFC RID: 241660
		[Token(Token = "0x403AFFC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0403AFFD RID: 241661
		[Token(Token = "0x403AFFD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x0403AFFE RID: 241662
		[Token(Token = "0x403AFFE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x0403AFFF RID: 241663
		[Token(Token = "0x403AFFF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_desc;

		// Token: 0x0403B000 RID: 241664
		[Token(Token = "0x403B000")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_hasComplete;

		// Token: 0x0403B001 RID: 241665
		[Token(Token = "0x403B001")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_hasComplete;

		// Token: 0x0403B002 RID: 241666
		[Token(Token = "0x403B002")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403B003 RID: 241667
		[Token(Token = "0x403B003")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403B004 RID: 241668
		[Token(Token = "0x403B004")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403B005 RID: 241669
		[Token(Token = "0x403B005")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
