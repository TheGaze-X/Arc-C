using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041BA RID: 16826
	[Token(Token = "0x20041BA")]
	public class SandboxV2DungeonQuestStatusDialog : UICompDialog<SandboxV2DungeonQuestStatusDialog.Option>
	{
		// Token: 0x06019F27 RID: 106279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F27")]
		[Address(RVA = "0x12DEAD0", Offset = "0x12DD6D0", VA = "0x1812DEAD0", Slot = "18")]
		protected override void OnRender(SandboxV2DungeonQuestStatusDialog.Option input)
		{
		}

		// Token: 0x06019F28 RID: 106280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019F28")]
		[Address(RVA = "0x12DEF10", Offset = "0x12DDB10", VA = "0x1812DEF10")]
		private SandboxV2DungeonQuestBannerView.Param _CreateBannerViewParam()
		{
			return null;
		}

		// Token: 0x06019F29 RID: 106281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F29")]
		[Address(RVA = "0x12DF0F0", Offset = "0x12DDCF0", VA = "0x1812DF0F0")]
		private void _OnBannerQuit()
		{
		}

		// Token: 0x06019F2A RID: 106282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F2A")]
		[Address(RVA = "0x12DF1B0", Offset = "0x12DDDB0", VA = "0x1812DF1B0")]
		public SandboxV2DungeonQuestStatusDialog()
		{
		}

		// Token: 0x04020AC1 RID: 133825
		[Token(Token = "0x4020AC1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<SandboxV2DungeonQuestStatusDialog.QuestLineIcon> _questLineIcons;

		// Token: 0x04020AC2 RID: 133826
		[Token(Token = "0x4020AC2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasObject _iconAtalsObject;

		// Token: 0x04020AC3 RID: 133827
		[Token(Token = "0x4020AC3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SandboxV2DungeonQuestBannerView _completedView;

		// Token: 0x04020AC4 RID: 133828
		[Token(Token = "0x4020AC4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SandboxV2DungeonQuestBannerView _startView;

		// Token: 0x04020AC5 RID: 133829
		[Token(Token = "0x4020AC5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SandboxV2DungeonQuestBannerView _faieldView;

		// Token: 0x04020AC6 RID: 133830
		[Token(Token = "0x4020AC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04020AC7 RID: 133831
		[Token(Token = "0x4020AC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CreateBannerViewParam;

		// Token: 0x04020AC8 RID: 133832
		[Token(Token = "0x4020AC8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnBannerQuit;

		// Token: 0x04020AC9 RID: 133833
		[Token(Token = "0x4020AC9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020041BB RID: 16827
		[Token(Token = "0x20041BB")]
		[Serializable]
		public struct QuestLineIcon
		{
			// Token: 0x04020ACA RID: 133834
			[Token(Token = "0x4020ACA")]
			[FieldOffset(Offset = "0x0")]
			public SandboxV2QuestLineBadgeType type;

			// Token: 0x04020ACB RID: 133835
			[Token(Token = "0x4020ACB")]
			[FieldOffset(Offset = "0x8")]
			public string iconId;
		}

		// Token: 0x020041BC RID: 16828
		[Token(Token = "0x20041BC")]
		public class Option
		{
			// Token: 0x06019F2B RID: 106283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019F2B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x04020ACC RID: 133836
			[Token(Token = "0x4020ACC")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x04020ACD RID: 133837
			[Token(Token = "0x4020ACD")]
			[FieldOffset(Offset = "0x18")]
			public string questId;

			// Token: 0x04020ACE RID: 133838
			[Token(Token = "0x4020ACE")]
			[FieldOffset(Offset = "0x20")]
			public bool isRift;

			// Token: 0x04020ACF RID: 133839
			[Token(Token = "0x4020ACF")]
			[FieldOffset(Offset = "0x24")]
			public SandboxV2DungeonDialogQuestProcessType questProcessType;
		}
	}
}
