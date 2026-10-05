using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x0200613B RID: 24891
	[Token(Token = "0x200613B")]
	public class CampaignZoneMapStageListAdapter : LoopScrollAdapter<CampaignZoneMapStageListAdapter.ViewHolder, CampaignZoneMapStageViewModel>, IHotfixable
	{
		// Token: 0x170054D6 RID: 21718
		// (get) Token: 0x06023EF6 RID: 147190 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023EF7 RID: 147191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054D6")]
		public string selectedStage
		{
			[Token(Token = "0x6023EF6")]
			[Address(RVA = "0x1E952A0", Offset = "0x1E93EA0", VA = "0x181E952A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6023EF7")]
			[Address(RVA = "0x1E95370", Offset = "0x1E93F70", VA = "0x181E95370")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170054D7 RID: 21719
		// (get) Token: 0x06023EF8 RID: 147192 RVA: 0x000C26D0 File Offset: 0x000C08D0
		// (set) Token: 0x06023EF9 RID: 147193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054D7")]
		public bool isTrainingAllOpen
		{
			[Token(Token = "0x6023EF8")]
			[Address(RVA = "0x1E95240", Offset = "0x1E93E40", VA = "0x181E95240")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x6023EF9")]
			[Address(RVA = "0x1E95300", Offset = "0x1E93F00", VA = "0x181E95300")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06023EFA RID: 147194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023EFA")]
		[Address(RVA = "0x1E94F20", Offset = "0x1E93B20", VA = "0x181E94F20", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06023EFB RID: 147195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EFB")]
		[Address(RVA = "0x1E94FD0", Offset = "0x1E93BD0", VA = "0x181E94FD0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, CampaignZoneMapStageListAdapter.ViewHolder holder, CampaignZoneMapStageViewModel data)
		{
		}

		// Token: 0x06023EFC RID: 147196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EFC")]
		[Address(RVA = "0x1E951D0", Offset = "0x1E93DD0", VA = "0x181E951D0")]
		public CampaignZoneMapStageListAdapter()
		{
		}

		// Token: 0x04031E39 RID: 204345
		[Token(Token = "0x4031E39")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x04031E3C RID: 204348
		[Token(Token = "0x4031E3C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedStage;

		// Token: 0x04031E3D RID: 204349
		[Token(Token = "0x4031E3D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedStage;

		// Token: 0x04031E3E RID: 204350
		[Token(Token = "0x4031E3E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isTrainingAllOpen;

		// Token: 0x04031E3F RID: 204351
		[Token(Token = "0x4031E3F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isTrainingAllOpen;

		// Token: 0x04031E40 RID: 204352
		[Token(Token = "0x4031E40")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04031E41 RID: 204353
		[Token(Token = "0x4031E41")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04031E42 RID: 204354
		[Token(Token = "0x4031E42")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200613C RID: 24892
		[Token(Token = "0x200613C")]
		public class ViewHolder
		{
			// Token: 0x06023EFD RID: 147197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023EFD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x04031E43 RID: 204355
			[Token(Token = "0x4031E43")]
			[FieldOffset(Offset = "0x10")]
			public CampaignZoneMapStageListItemView view;
		}
	}
}
