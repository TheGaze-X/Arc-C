using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051C1 RID: 20929
	[Token(Token = "0x20051C1")]
	public class RoguelikeChoiceScene : IHotfixable
	{
		// Token: 0x17004823 RID: 18467
		// (set) Token: 0x0601EE98 RID: 126616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004823")]
		public RoguelikeChoiceHintFactory hintFactory
		{
			[Token(Token = "0x601EE98")]
			[Address(RVA = "0x18A46E0", Offset = "0x18A32E0", VA = "0x1818A46E0")]
			set
			{
			}
		}

		// Token: 0x17004824 RID: 18468
		// (get) Token: 0x0601EE99 RID: 126617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004824")]
		public string topicId
		{
			[Token(Token = "0x601EE99")]
			[Address(RVA = "0x18A4610", Offset = "0x18A3210", VA = "0x1818A4610")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004825 RID: 18469
		// (get) Token: 0x0601EE9A RID: 126618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004825")]
		public string sceneId
		{
			[Token(Token = "0x601EE9A")]
			[Address(RVA = "0x18A4530", Offset = "0x18A3130", VA = "0x1818A4530")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EE9B RID: 126619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE9B")]
		[Address(RVA = "0x18A4140", Offset = "0x18A2D40", VA = "0x1818A4140")]
		private void _ClearData()
		{
		}

		// Token: 0x0601EE9C RID: 126620 RVA: 0x000B01C0 File Offset: 0x000AE3C0
		[Token(Token = "0x601EE9C")]
		[Address(RVA = "0x18A3D10", Offset = "0x18A2910", VA = "0x1818A3D10")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601EE9D RID: 126621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE9D")]
		[Address(RVA = "0x18A3DA0", Offset = "0x18A29A0", VA = "0x1818A3DA0")]
		public void UpdateData(string topicId, PlayerRoguelikePendingEvent.SceneContent sceneContent)
		{
		}

		// Token: 0x17004826 RID: 18470
		// (get) Token: 0x0601EE9E RID: 126622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004826")]
		public string dialogTitle
		{
			[Token(Token = "0x601EE9E")]
			[Address(RVA = "0x18A44A0", Offset = "0x18A30A0", VA = "0x1818A44A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004827 RID: 18471
		// (get) Token: 0x0601EE9F RID: 126623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004827")]
		public string dialogContent
		{
			[Token(Token = "0x601EE9F")]
			[Address(RVA = "0x18A4410", Offset = "0x18A3010", VA = "0x1818A4410")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004828 RID: 18472
		// (get) Token: 0x0601EEA0 RID: 126624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004828")]
		public string titleIconName
		{
			[Token(Token = "0x601EEA0")]
			[Address(RVA = "0x18A45A0", Offset = "0x18A31A0", VA = "0x1818A45A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004829 RID: 18473
		// (get) Token: 0x0601EEA1 RID: 126625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004829")]
		public string bgName
		{
			[Token(Token = "0x601EEA1")]
			[Address(RVA = "0x18A4330", Offset = "0x18A2F30", VA = "0x1818A4330")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700482A RID: 18474
		// (get) Token: 0x0601EEA2 RID: 126626 RVA: 0x000B01D8 File Offset: 0x000AE3D8
		[Token(Token = "0x1700482A")]
		public bool useHiddenMusic
		{
			[Token(Token = "0x601EEA2")]
			[Address(RVA = "0x18A4670", Offset = "0x18A3270", VA = "0x1818A4670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700482B RID: 18475
		// (get) Token: 0x0601EEA3 RID: 126627 RVA: 0x000B01F0 File Offset: 0x000AE3F0
		[Token(Token = "0x1700482B")]
		public int choiceCount
		{
			[Token(Token = "0x601EEA3")]
			[Address(RVA = "0x18A43A0", Offset = "0x18A2FA0", VA = "0x1818A43A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601EEA4 RID: 126628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EEA4")]
		[Address(RVA = "0x18A3C80", Offset = "0x18A2880", VA = "0x1818A3C80")]
		public IRoguelikeGameChoice GetChoice(int idx)
		{
			return null;
		}

		// Token: 0x0601EEA5 RID: 126629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEA5")]
		[Address(RVA = "0x18A4200", Offset = "0x18A2E00", VA = "0x1818A4200")]
		public RoguelikeChoiceScene()
		{
		}

		// Token: 0x0402977A RID: 169850
		[Token(Token = "0x402977A")]
		[FieldOffset(Offset = "0x10")]
		private PlayerRoguelikePendingEvent.SceneContent m_playerScene;

		// Token: 0x0402977B RID: 169851
		[Token(Token = "0x402977B")]
		[FieldOffset(Offset = "0x18")]
		private List<IRoguelikeGameChoice> m_choices;

		// Token: 0x0402977C RID: 169852
		[Token(Token = "0x402977C")]
		[FieldOffset(Offset = "0x20")]
		private RoguelikeChoiceFactory m_choiceFactory;

		// Token: 0x0402977D RID: 169853
		[Token(Token = "0x402977D")]
		[FieldOffset(Offset = "0x28")]
		private RoguelikeChoiceHintFactory m_hintFactory;

		// Token: 0x0402977E RID: 169854
		[Token(Token = "0x402977E")]
		[FieldOffset(Offset = "0x30")]
		private string m_topicId;

		// Token: 0x0402977F RID: 169855
		[Token(Token = "0x402977F")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeGameChoiceSceneData m_data;

		// Token: 0x04029780 RID: 169856
		[Token(Token = "0x4029780")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_hintFactory;

		// Token: 0x04029781 RID: 169857
		[Token(Token = "0x4029781")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04029782 RID: 169858
		[Token(Token = "0x4029782")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_sceneId;

		// Token: 0x04029783 RID: 169859
		[Token(Token = "0x4029783")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ClearData;

		// Token: 0x04029784 RID: 169860
		[Token(Token = "0x4029784")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x04029785 RID: 169861
		[Token(Token = "0x4029785")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04029786 RID: 169862
		[Token(Token = "0x4029786")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_dialogTitle;

		// Token: 0x04029787 RID: 169863
		[Token(Token = "0x4029787")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_dialogContent;

		// Token: 0x04029788 RID: 169864
		[Token(Token = "0x4029788")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_titleIconName;

		// Token: 0x04029789 RID: 169865
		[Token(Token = "0x4029789")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_bgName;

		// Token: 0x0402978A RID: 169866
		[Token(Token = "0x402978A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_useHiddenMusic;

		// Token: 0x0402978B RID: 169867
		[Token(Token = "0x402978B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_choiceCount;

		// Token: 0x0402978C RID: 169868
		[Token(Token = "0x402978C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetChoice;

		// Token: 0x0402978D RID: 169869
		[Token(Token = "0x402978D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
