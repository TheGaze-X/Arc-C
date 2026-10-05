using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071BB RID: 29115
	[Token(Token = "0x20071BB")]
	public class Act6FunZoneMapStagePreviewPluginViewModel : IHotfixable
	{
		// Token: 0x170061D3 RID: 25043
		// (get) Token: 0x06029512 RID: 169234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061D3")]
		public List<Act6FunZoneMapStagePreviewPluginAchieveItemModel> achieveItemModelList
		{
			[Token(Token = "0x6029512")]
			[Address(RVA = "0x24B71F0", Offset = "0x24B5DF0", VA = "0x1824B71F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170061D4 RID: 25044
		// (get) Token: 0x06029513 RID: 169235 RVA: 0x000D5570 File Offset: 0x000D3770
		// (set) Token: 0x06029514 RID: 169236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061D4")]
		public long passTime
		{
			[Token(Token = "0x6029513")]
			[Address(RVA = "0x24B7310", Offset = "0x24B5F10", VA = "0x1824B7310")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6029514")]
			[Address(RVA = "0x24B7470", Offset = "0x24B6070", VA = "0x1824B7470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061D5 RID: 25045
		// (get) Token: 0x06029515 RID: 169237 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06029516 RID: 169238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061D5")]
		public string npcDialog
		{
			[Token(Token = "0x6029515")]
			[Address(RVA = "0x24B72B0", Offset = "0x24B5EB0", VA = "0x1824B72B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6029516")]
			[Address(RVA = "0x24B73F0", Offset = "0x24B5FF0", VA = "0x1824B73F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170061D6 RID: 25046
		// (get) Token: 0x06029517 RID: 169239 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06029518 RID: 169240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061D6")]
		public string charPicId
		{
			[Token(Token = "0x6029517")]
			[Address(RVA = "0x24B7250", Offset = "0x24B5E50", VA = "0x1824B7250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6029518")]
			[Address(RVA = "0x24B7370", Offset = "0x24B5F70", VA = "0x1824B7370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06029519 RID: 169241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029519")]
		[Address(RVA = "0x24B6C20", Offset = "0x24B5820", VA = "0x1824B6C20")]
		public void LoadData(string stageId, Act6FunData act6FunData)
		{
		}

		// Token: 0x0602951A RID: 169242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602951A")]
		[Address(RVA = "0x24B6F50", Offset = "0x24B5B50", VA = "0x1824B6F50")]
		public void RefreshData(PlayerActFun6Stage playerActFun6Stage)
		{
		}

		// Token: 0x0602951B RID: 169243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602951B")]
		[Address(RVA = "0x24B7140", Offset = "0x24B5D40", VA = "0x1824B7140")]
		public Act6FunZoneMapStagePreviewPluginViewModel()
		{
		}

		// Token: 0x0403B009 RID: 241673
		[Token(Token = "0x403B009")]
		[FieldOffset(Offset = "0x28")]
		private List<Act6FunZoneMapStagePreviewPluginAchieveItemModel> m_achieveItemModelList;

		// Token: 0x0403B00A RID: 241674
		[Token(Token = "0x403B00A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_achieveItemModelList;

		// Token: 0x0403B00B RID: 241675
		[Token(Token = "0x403B00B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_passTime;

		// Token: 0x0403B00C RID: 241676
		[Token(Token = "0x403B00C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_passTime;

		// Token: 0x0403B00D RID: 241677
		[Token(Token = "0x403B00D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_npcDialog;

		// Token: 0x0403B00E RID: 241678
		[Token(Token = "0x403B00E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_npcDialog;

		// Token: 0x0403B00F RID: 241679
		[Token(Token = "0x403B00F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_charPicId;

		// Token: 0x0403B010 RID: 241680
		[Token(Token = "0x403B010")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_charPicId;

		// Token: 0x0403B011 RID: 241681
		[Token(Token = "0x403B011")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403B012 RID: 241682
		[Token(Token = "0x403B012")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403B013 RID: 241683
		[Token(Token = "0x403B013")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
