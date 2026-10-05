using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CharSelect;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AF8 RID: 6904
	[Token(Token = "0x2001AF8")]
	public class BuildingCharSelectMaskPlugin : CharSelectCardMaskPlugin
	{
		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x0600AE69 RID: 44649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014A1")]
		public BuildingCharSelectRoomConfig roomConfig
		{
			[Token(Token = "0x600AE69")]
			[Address(RVA = "0x3290510", Offset = "0x328F110", VA = "0x183290510")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AE6A RID: 44650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE6A")]
		[Address(RVA = "0x328EE30", Offset = "0x328DA30", VA = "0x18328EE30", Slot = "4")]
		public override void Init(CharSelectCardView cardView, CharSelectStateBean stateBean, object context)
		{
		}

		// Token: 0x0600AE6B RID: 44651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE6B")]
		[Address(RVA = "0x328EF00", Offset = "0x328DB00", VA = "0x18328EF00", Slot = "5")]
		public override void Render(CharacterCardViewModel cardModel)
		{
		}

		// Token: 0x0600AE6C RID: 44652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE6C")]
		[Address(RVA = "0x3290190", Offset = "0x328ED90", VA = "0x183290190")]
		private void _RenderWorking()
		{
		}

		// Token: 0x0600AE6D RID: 44653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE6D")]
		[Address(RVA = "0x328EFA0", Offset = "0x328DBA0", VA = "0x18328EFA0")]
		private void _RenderDormLock()
		{
		}

		// Token: 0x0600AE6E RID: 44654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE6E")]
		[Address(RVA = "0x328F220", Offset = "0x328DE20", VA = "0x18328F220")]
		private void _RenderExclusiveInfo()
		{
		}

		// Token: 0x0600AE6F RID: 44655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE6F")]
		[Address(RVA = "0x328FFF0", Offset = "0x328EBF0", VA = "0x18328FFF0")]
		private void _RenderInvalid()
		{
		}

		// Token: 0x0600AE70 RID: 44656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE70")]
		[Address(RVA = "0x32904B0", Offset = "0x328F0B0", VA = "0x1832904B0")]
		public BuildingCharSelectMaskPlugin()
		{
		}

		// Token: 0x0400A701 RID: 42753
		[Token(Token = "0x400A701")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingCharSelectMaskPlugin.PanelWorking _panelWorking;

		// Token: 0x0400A702 RID: 42754
		[Token(Token = "0x400A702")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingCharSelectMaskPlugin.PanelExclusiveInfo _panelExcluInfo;

		// Token: 0x0400A703 RID: 42755
		[Token(Token = "0x400A703")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingCharSelectMaskPlugin.PanelDormLock _panelDormLock;

		// Token: 0x0400A704 RID: 42756
		[Token(Token = "0x400A704")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _panelInvalid;

		// Token: 0x0400A705 RID: 42757
		[Token(Token = "0x400A705")]
		[FieldOffset(Offset = "0x38")]
		private CharSelectStateBean m_stateBean;

		// Token: 0x0400A706 RID: 42758
		[Token(Token = "0x400A706")]
		[FieldOffset(Offset = "0x40")]
		private IBuildingCharSelectContext m_context;

		// Token: 0x0400A707 RID: 42759
		[Token(Token = "0x400A707")]
		[FieldOffset(Offset = "0x48")]
		private CharacterCardViewModel m_cacheModel;

		// Token: 0x0400A708 RID: 42760
		[Token(Token = "0x400A708")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_roomConfig;

		// Token: 0x0400A709 RID: 42761
		[Token(Token = "0x400A709")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400A70A RID: 42762
		[Token(Token = "0x400A70A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400A70B RID: 42763
		[Token(Token = "0x400A70B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderWorking;

		// Token: 0x0400A70C RID: 42764
		[Token(Token = "0x400A70C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderDormLock;

		// Token: 0x0400A70D RID: 42765
		[Token(Token = "0x400A70D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderExclusiveInfo;

		// Token: 0x0400A70E RID: 42766
		[Token(Token = "0x400A70E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderInvalid;

		// Token: 0x0400A70F RID: 42767
		[Token(Token = "0x400A70F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001AF9 RID: 6905
		[Token(Token = "0x2001AF9")]
		[Serializable]
		private class PanelWorking
		{
			// Token: 0x0600AE71 RID: 44657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE71")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PanelWorking()
			{
			}

			// Token: 0x0400A710 RID: 42768
			[Token(Token = "0x400A710")]
			[FieldOffset(Offset = "0x10")]
			public GameObject go;

			// Token: 0x0400A711 RID: 42769
			[Token(Token = "0x400A711")]
			[FieldOffset(Offset = "0x18")]
			public Text textRoomInfo;
		}

		// Token: 0x02001AFA RID: 6906
		[Token(Token = "0x2001AFA")]
		[Serializable]
		private class PanelExclusiveInfo
		{
			// Token: 0x0600AE72 RID: 44658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE72")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PanelExclusiveInfo()
			{
			}

			// Token: 0x0400A712 RID: 42770
			[Token(Token = "0x400A712")]
			[FieldOffset(Offset = "0x10")]
			public GameObject go;

			// Token: 0x0400A713 RID: 42771
			[Token(Token = "0x400A713")]
			[FieldOffset(Offset = "0x18")]
			public Text textName;

			// Token: 0x0400A714 RID: 42772
			[Token(Token = "0x400A714")]
			[FieldOffset(Offset = "0x20")]
			public Image imageRoomColorLabel;

			// Token: 0x0400A715 RID: 42773
			[Token(Token = "0x400A715")]
			[FieldOffset(Offset = "0x28")]
			public Text textSelected;

			// Token: 0x0400A716 RID: 42774
			[Token(Token = "0x400A716")]
			[FieldOffset(Offset = "0x30")]
			public Text textTraining;

			// Token: 0x0400A717 RID: 42775
			[Token(Token = "0x400A717")]
			[FieldOffset(Offset = "0x38")]
			public Image imageRoomIcon;

			// Token: 0x0400A718 RID: 42776
			[Token(Token = "0x400A718")]
			[FieldOffset(Offset = "0x40")]
			public Text textRoomCode;

			// Token: 0x0400A719 RID: 42777
			[Token(Token = "0x400A719")]
			[FieldOffset(Offset = "0x48")]
			public GameObject imageAssistWorking;

			// Token: 0x0400A71A RID: 42778
			[Token(Token = "0x400A71A")]
			[FieldOffset(Offset = "0x50")]
			public GameObject imageAssistNonWorking;
		}

		// Token: 0x02001AFB RID: 6907
		[Token(Token = "0x2001AFB")]
		[Serializable]
		private class PanelDormLock
		{
			// Token: 0x0600AE73 RID: 44659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE73")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PanelDormLock()
			{
			}

			// Token: 0x0400A71B RID: 42779
			[Token(Token = "0x400A71B")]
			[FieldOffset(Offset = "0x10")]
			public GameObject go;

			// Token: 0x0400A71C RID: 42780
			[Token(Token = "0x400A71C")]
			[FieldOffset(Offset = "0x18")]
			public Text textRoomInfo;
		}
	}
}
