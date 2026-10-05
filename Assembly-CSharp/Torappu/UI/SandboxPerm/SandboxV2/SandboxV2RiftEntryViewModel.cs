using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200439F RID: 17311
	[Token(Token = "0x200439F")]
	public class SandboxV2RiftEntryViewModel : IHotfixable
	{
		// Token: 0x0601A923 RID: 108835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A923")]
		[Address(RVA = "0x13B53F0", Offset = "0x13B3FF0", VA = "0x1813B53F0")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x0601A924 RID: 108836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A924")]
		[Address(RVA = "0x13B5E90", Offset = "0x13B4A90", VA = "0x1813B5E90")]
		public void RefreshData(string topicId)
		{
		}

		// Token: 0x0601A925 RID: 108837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A925")]
		[Address(RVA = "0x13B68B0", Offset = "0x13B54B0", VA = "0x1813B68B0")]
		private void _ProcessParamData(SandboxV2RiftParamData gameData, ref SandboxV2RiftEntryViewModel.RiftParam param)
		{
		}

		// Token: 0x0601A926 RID: 108838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A926")]
		[Address(RVA = "0x13B6A40", Offset = "0x13B5640", VA = "0x1813B6A40")]
		public SandboxV2RiftEntryViewModel()
		{
		}

		// Token: 0x04021D96 RID: 138646
		[Token(Token = "0x4021D96")]
		private const int DEFAULT_DISPLAY_ITEM_COUNT = 1;

		// Token: 0x04021D97 RID: 138647
		[Token(Token = "0x4021D97")]
		[FieldOffset(Offset = "0x10")]
		public string riftId;

		// Token: 0x04021D98 RID: 138648
		[Token(Token = "0x4021D98")]
		[FieldOffset(Offset = "0x18")]
		public bool isRiftReservated;

		// Token: 0x04021D99 RID: 138649
		[Token(Token = "0x4021D99")]
		[FieldOffset(Offset = "0x19")]
		public bool isRandomRift;

		// Token: 0x04021D9A RID: 138650
		[Token(Token = "0x4021D9A")]
		[FieldOffset(Offset = "0x1A")]
		public bool isPreyRift;

		// Token: 0x04021D9B RID: 138651
		[Token(Token = "0x4021D9B")]
		[FieldOffset(Offset = "0x1B")]
		public bool useDifficulty;

		// Token: 0x04021D9C RID: 138652
		[Token(Token = "0x4021D9C")]
		[FieldOffset(Offset = "0x20")]
		public string mainTargetTitle;

		// Token: 0x04021D9D RID: 138653
		[Token(Token = "0x4021D9D")]
		[FieldOffset(Offset = "0x28")]
		public string mainTargetDesc;

		// Token: 0x04021D9E RID: 138654
		[Token(Token = "0x4021D9E")]
		[FieldOffset(Offset = "0x30")]
		public int mainTargetDayCount;

		// Token: 0x04021D9F RID: 138655
		[Token(Token = "0x4021D9F")]
		[FieldOffset(Offset = "0x38")]
		public SandboxV2RiftEntryViewModel.RiftParam climateParam;

		// Token: 0x04021DA0 RID: 138656
		[Token(Token = "0x4021DA0")]
		[FieldOffset(Offset = "0x40")]
		public SandboxV2RiftEntryViewModel.RiftParam terrainParam;

		// Token: 0x04021DA1 RID: 138657
		[Token(Token = "0x4021DA1")]
		[FieldOffset(Offset = "0x48")]
		public SandboxV2RiftEntryViewModel.RiftParam enemyParam;

		// Token: 0x04021DA2 RID: 138658
		[Token(Token = "0x4021DA2")]
		[FieldOffset(Offset = "0x50")]
		public string riftGlobalEffectDesc;

		// Token: 0x04021DA3 RID: 138659
		[Token(Token = "0x4021DA3")]
		[FieldOffset(Offset = "0x58")]
		public string subTargetDesc;

		// Token: 0x04021DA4 RID: 138660
		[Token(Token = "0x4021DA4")]
		[FieldOffset(Offset = "0x60")]
		public List<UIItemViewModel> rewards;

		// Token: 0x04021DA5 RID: 138661
		[Token(Token = "0x4021DA5")]
		[FieldOffset(Offset = "0x68")]
		public List<string> difficultyDescs;

		// Token: 0x04021DA6 RID: 138662
		[Token(Token = "0x4021DA6")]
		[FieldOffset(Offset = "0x70")]
		public int randomRiftDifficultyLevel;

		// Token: 0x04021DA7 RID: 138663
		[Token(Token = "0x4021DA7")]
		[FieldOffset(Offset = "0x78")]
		public string riftTeamId;

		// Token: 0x04021DA8 RID: 138664
		[Token(Token = "0x4021DA8")]
		[FieldOffset(Offset = "0x80")]
		public string riftTeamIconId;

		// Token: 0x04021DA9 RID: 138665
		[Token(Token = "0x4021DA9")]
		[FieldOffset(Offset = "0x88")]
		public string riftTeamName;

		// Token: 0x04021DAA RID: 138666
		[Token(Token = "0x4021DAA")]
		[FieldOffset(Offset = "0x90")]
		public int riftTeamLevel;

		// Token: 0x04021DAB RID: 138667
		[Token(Token = "0x4021DAB")]
		[FieldOffset(Offset = "0x94")]
		public int remainDayCount;

		// Token: 0x04021DAC RID: 138668
		[Token(Token = "0x4021DAC")]
		[FieldOffset(Offset = "0x98")]
		public bool canStartRift;

		// Token: 0x04021DAD RID: 138669
		[Token(Token = "0x4021DAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021DAE RID: 138670
		[Token(Token = "0x4021DAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04021DAF RID: 138671
		[Token(Token = "0x4021DAF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ProcessParamData;

		// Token: 0x04021DB0 RID: 138672
		[Token(Token = "0x4021DB0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020043A0 RID: 17312
		[Token(Token = "0x20043A0")]
		public class RiftParam : IHotfixable
		{
			// Token: 0x0601A927 RID: 108839 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A927")]
			[Address(RVA = "0x13A7EF0", Offset = "0x13A6AF0", VA = "0x1813A7EF0")]
			public RiftParam()
			{
			}

			// Token: 0x04021DB1 RID: 138673
			[Token(Token = "0x4021DB1")]
			[FieldOffset(Offset = "0x10")]
			public string desc;

			// Token: 0x04021DB2 RID: 138674
			[Token(Token = "0x4021DB2")]
			[FieldOffset(Offset = "0x18")]
			public Color bkColor;

			// Token: 0x04021DB3 RID: 138675
			[Token(Token = "0x4021DB3")]
			[FieldOffset(Offset = "0x28")]
			public string iconId;

			// Token: 0x04021DB4 RID: 138676
			[Token(Token = "0x4021DB4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
