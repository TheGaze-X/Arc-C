using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200526B RID: 21099
	[Token(Token = "0x200526B")]
	public class RoguelikeFocusView : DataBinder<RoguelikeFocusViewProperty>
	{
		// Token: 0x170048E9 RID: 18665
		// (get) Token: 0x0601F216 RID: 127510 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F217 RID: 127511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170048E9")]
		public Action onEnemyClick
		{
			[Token(Token = "0x601F216")]
			[Address(RVA = "0x18D9850", Offset = "0x18D8450", VA = "0x1818D9850")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601F217")]
			[Address(RVA = "0x18D9D10", Offset = "0x18D8910", VA = "0x1818D9D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170048EA RID: 18666
		// (get) Token: 0x0601F218 RID: 127512 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F219 RID: 127513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170048EA")]
		public Action onConfirmClick
		{
			[Token(Token = "0x601F218")]
			[Address(RVA = "0x18D97F0", Offset = "0x18D83F0", VA = "0x1818D97F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601F219")]
			[Address(RVA = "0x18D9C90", Offset = "0x18D8890", VA = "0x1818D9C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170048EB RID: 18667
		// (get) Token: 0x0601F21A RID: 127514 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F21B RID: 127515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170048EB")]
		public Action onRollNodeClick
		{
			[Token(Token = "0x601F21A")]
			[Address(RVA = "0x18D98B0", Offset = "0x18D84B0", VA = "0x1818D98B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601F21B")]
			[Address(RVA = "0x18D9D90", Offset = "0x18D8990", VA = "0x1818D9D90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170048EC RID: 18668
		// (get) Token: 0x0601F21C RID: 127516 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F21D RID: 127517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170048EC")]
		public string cacheStageId
		{
			[Token(Token = "0x601F21C")]
			[Address(RVA = "0x18D9610", Offset = "0x18D8210", VA = "0x1818D9610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F21D")]
			[Address(RVA = "0x18D9C10", Offset = "0x18D8810", VA = "0x1818D9C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170048ED RID: 18669
		// (get) Token: 0x0601F21E RID: 127518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048ED")]
		public RoguelikeNodeViewData viewData
		{
			[Token(Token = "0x601F21E")]
			[Address(RVA = "0x18D9BB0", Offset = "0x18D87B0", VA = "0x1818D9BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048EE RID: 18670
		// (get) Token: 0x0601F21F RID: 127519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048EE")]
		public RectTransform panelEliteDesc
		{
			[Token(Token = "0x601F21F")]
			[Address(RVA = "0x18D99D0", Offset = "0x18D85D0", VA = "0x1818D99D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048EF RID: 18671
		// (get) Token: 0x0601F220 RID: 127520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048EF")]
		public GameObject canGoToBtn
		{
			[Token(Token = "0x601F220")]
			[Address(RVA = "0x18D9670", Offset = "0x18D8270", VA = "0x1818D9670")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048F0 RID: 18672
		// (get) Token: 0x0601F221 RID: 127521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048F0")]
		public GameObject effectPrefab
		{
			[Token(Token = "0x601F221")]
			[Address(RVA = "0x18D9730", Offset = "0x18D8330", VA = "0x1818D9730")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F222 RID: 127522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F222")]
		[Address(RVA = "0x18D7E80", Offset = "0x18D6A80", VA = "0x1818D7E80")]
		public void InitClosure(UIPage page)
		{
		}

		// Token: 0x0601F223 RID: 127523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F223")]
		[Address(RVA = "0x18D8590", Offset = "0x18D7190", VA = "0x1818D8590", Slot = "7")]
		public override void OnValueChanged(RoguelikeFocusViewProperty property)
		{
		}

		// Token: 0x0601F224 RID: 127524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F224")]
		[Address(RVA = "0x18D9200", Offset = "0x18D7E00", VA = "0x1818D9200")]
		public void ShowMapPreview()
		{
		}

		// Token: 0x0601F225 RID: 127525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F225")]
		[Address(RVA = "0x18D7DF0", Offset = "0x18D69F0", VA = "0x1818D7DF0")]
		public void HideMapPreview()
		{
		}

		// Token: 0x0601F226 RID: 127526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F226")]
		[Address(RVA = "0x18D8370", Offset = "0x18D6F70", VA = "0x1818D8370")]
		public void OnFocus()
		{
		}

		// Token: 0x0601F227 RID: 127527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F227")]
		[Address(RVA = "0x18D8260", Offset = "0x18D6E60", VA = "0x1818D8260")]
		public void OnEnemy()
		{
		}

		// Token: 0x0601F228 RID: 127528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F228")]
		[Address(RVA = "0x18D8480", Offset = "0x18D7080", VA = "0x1818D8480")]
		public void OnRoll()
		{
		}

		// Token: 0x0601F229 RID: 127529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F229")]
		[Address(RVA = "0x18D8A40", Offset = "0x18D7640", VA = "0x1818D8A40")]
		public void RenderFocusNode()
		{
		}

		// Token: 0x0601F22A RID: 127530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F22A")]
		[Address(RVA = "0x18D9140", Offset = "0x18D7D40", VA = "0x1818D9140")]
		public void RenderStage()
		{
		}

		// Token: 0x0601F22B RID: 127531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F22B")]
		[Address(RVA = "0x18D8B10", Offset = "0x18D7710", VA = "0x1818D8B10")]
		public void RenderImpl(string topicId, RoguelikeEventType type, int nodeDisplaySubType, string stageId, PlayerNodeForesightType forsightType)
		{
		}

		// Token: 0x0601F22C RID: 127532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F22C")]
		[Address(RVA = "0x18D8010", Offset = "0x18D6C10", VA = "0x1818D8010")]
		public void LoadPreviewMap(string stageId)
		{
		}

		// Token: 0x0601F22D RID: 127533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F22D")]
		[Address(RVA = "0x18D9500", Offset = "0x18D8100", VA = "0x1818D9500")]
		private void _UnloadPreviewMap()
		{
		}

		// Token: 0x0601F22E RID: 127534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F22E")]
		[Address(RVA = "0x18D9490", Offset = "0x18D8090", VA = "0x1818D9490")]
		private void _ShotBlurredSprite()
		{
		}

		// Token: 0x0601F22F RID: 127535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F22F")]
		[Address(RVA = "0x18D9380", Offset = "0x18D7F80", VA = "0x1818D9380")]
		private void _ClearBlurSprite()
		{
		}

		// Token: 0x0601F230 RID: 127536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F230")]
		[Address(RVA = "0x18D8200", Offset = "0x18D6E00", VA = "0x1818D8200")]
		public void OnDestroy()
		{
		}

		// Token: 0x170048F1 RID: 18673
		// (get) Token: 0x0601F231 RID: 127537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048F1")]
		public Image imageIcon
		{
			[Token(Token = "0x601F231")]
			[Address(RVA = "0x18D9790", Offset = "0x18D8390", VA = "0x1818D9790")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048F2 RID: 18674
		// (get) Token: 0x0601F232 RID: 127538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048F2")]
		public UIColorGraphic colorGraphic
		{
			[Token(Token = "0x601F232")]
			[Address(RVA = "0x18D96D0", Offset = "0x18D82D0", VA = "0x1818D96D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048F3 RID: 18675
		// (get) Token: 0x0601F233 RID: 127539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048F3")]
		public RectTransform panelBattleTitle
		{
			[Token(Token = "0x601F233")]
			[Address(RVA = "0x18D9970", Offset = "0x18D8570", VA = "0x1818D9970")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048F4 RID: 18676
		// (get) Token: 0x0601F234 RID: 127540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048F4")]
		public RectTransform panelNonBattleTitle
		{
			[Token(Token = "0x601F234")]
			[Address(RVA = "0x18D9A30", Offset = "0x18D8630", VA = "0x1818D9A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048F5 RID: 18677
		// (get) Token: 0x0601F235 RID: 127541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048F5")]
		public RectTransform panelBattleInfo
		{
			[Token(Token = "0x601F235")]
			[Address(RVA = "0x18D9910", Offset = "0x18D8510", VA = "0x1818D9910")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048F6 RID: 18678
		// (get) Token: 0x0601F236 RID: 127542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048F6")]
		public Text textNonBattleTitle
		{
			[Token(Token = "0x601F236")]
			[Address(RVA = "0x18D9B50", Offset = "0x18D8750", VA = "0x1818D9B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048F7 RID: 18679
		// (get) Token: 0x0601F237 RID: 127543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048F7")]
		public Text textBattleTitle
		{
			[Token(Token = "0x601F237")]
			[Address(RVA = "0x18D9A90", Offset = "0x18D8690", VA = "0x1818D9A90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048F8 RID: 18680
		// (get) Token: 0x0601F238 RID: 127544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048F8")]
		public Text textDesc
		{
			[Token(Token = "0x601F238")]
			[Address(RVA = "0x18D9AF0", Offset = "0x18D86F0", VA = "0x1818D9AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F239 RID: 127545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F239")]
		[Address(RVA = "0x18D95A0", Offset = "0x18D81A0", VA = "0x1818D95A0")]
		public RoguelikeFocusView()
		{
		}

		// Token: 0x04029C54 RID: 171092
		[Token(Token = "0x4029C54")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeNodeViewData _viewData;

		// Token: 0x04029C55 RID: 171093
		[Token(Token = "0x4029C55")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x04029C56 RID: 171094
		[Token(Token = "0x4029C56")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x04029C57 RID: 171095
		[Token(Token = "0x4029C57")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _panelBattleTitle;

		// Token: 0x04029C58 RID: 171096
		[Token(Token = "0x4029C58")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _panelNonBattleTitle;

		// Token: 0x04029C59 RID: 171097
		[Token(Token = "0x4029C59")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _panelEliteDesc;

		// Token: 0x04029C5A RID: 171098
		[Token(Token = "0x4029C5A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _panelBattleInfo;

		// Token: 0x04029C5B RID: 171099
		[Token(Token = "0x4029C5B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textNonBattleTitle;

		// Token: 0x04029C5C RID: 171100
		[Token(Token = "0x4029C5C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textBattleTitle;

		// Token: 0x04029C5D RID: 171101
		[Token(Token = "0x4029C5D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textBattleName;

		// Token: 0x04029C5E RID: 171102
		[Token(Token = "0x4029C5E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04029C5F RID: 171103
		[Token(Token = "0x4029C5F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textEliteDesc;

		// Token: 0x04029C60 RID: 171104
		[Token(Token = "0x4029C60")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _panelMapPreview;

		// Token: 0x04029C61 RID: 171105
		[Token(Token = "0x4029C61")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _imageMapPreivewBlur;

		// Token: 0x04029C62 RID: 171106
		[Token(Token = "0x4029C62")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _imageMapPreview;

		// Token: 0x04029C63 RID: 171107
		[Token(Token = "0x4029C63")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _imageMapPreviewMini;

		// Token: 0x04029C64 RID: 171108
		[Token(Token = "0x4029C64")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _haveCapsule;

		// Token: 0x04029C65 RID: 171109
		[Token(Token = "0x4029C65")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _capsuleName;

		// Token: 0x04029C66 RID: 171110
		[Token(Token = "0x4029C66")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _canGoToBtn;

		// Token: 0x04029C67 RID: 171111
		[Token(Token = "0x4029C67")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _effectPrefab;

		// Token: 0x04029C68 RID: 171112
		[Token(Token = "0x4029C68")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private List<RoguelikeFocusPlugin> _pluginList;

		// Token: 0x04029C6D RID: 171117
		[Token(Token = "0x4029C6D")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		public GameObject effectInst;

		// Token: 0x04029C6E RID: 171118
		[Token(Token = "0x4029C6E")]
		[FieldOffset(Offset = "0xF0")]
		private RoguelikeFocusViewModel m_cacheModel;

		// Token: 0x04029C6F RID: 171119
		[Token(Token = "0x4029C6F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onEnemyClick;

		// Token: 0x04029C70 RID: 171120
		[Token(Token = "0x4029C70")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onEnemyClick;

		// Token: 0x04029C71 RID: 171121
		[Token(Token = "0x4029C71")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onConfirmClick;

		// Token: 0x04029C72 RID: 171122
		[Token(Token = "0x4029C72")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onConfirmClick;

		// Token: 0x04029C73 RID: 171123
		[Token(Token = "0x4029C73")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onRollNodeClick;

		// Token: 0x04029C74 RID: 171124
		[Token(Token = "0x4029C74")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onRollNodeClick;

		// Token: 0x04029C75 RID: 171125
		[Token(Token = "0x4029C75")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_cacheStageId;

		// Token: 0x04029C76 RID: 171126
		[Token(Token = "0x4029C76")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_cacheStageId;

		// Token: 0x04029C77 RID: 171127
		[Token(Token = "0x4029C77")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_viewData;

		// Token: 0x04029C78 RID: 171128
		[Token(Token = "0x4029C78")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_panelEliteDesc;

		// Token: 0x04029C79 RID: 171129
		[Token(Token = "0x4029C79")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_canGoToBtn;

		// Token: 0x04029C7A RID: 171130
		[Token(Token = "0x4029C7A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_effectPrefab;

		// Token: 0x04029C7B RID: 171131
		[Token(Token = "0x4029C7B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_InitClosure;

		// Token: 0x04029C7C RID: 171132
		[Token(Token = "0x4029C7C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04029C7D RID: 171133
		[Token(Token = "0x4029C7D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ShowMapPreview;

		// Token: 0x04029C7E RID: 171134
		[Token(Token = "0x4029C7E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_HideMapPreview;

		// Token: 0x04029C7F RID: 171135
		[Token(Token = "0x4029C7F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnFocus;

		// Token: 0x04029C80 RID: 171136
		[Token(Token = "0x4029C80")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnEnemy;

		// Token: 0x04029C81 RID: 171137
		[Token(Token = "0x4029C81")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnRoll;

		// Token: 0x04029C82 RID: 171138
		[Token(Token = "0x4029C82")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_RenderFocusNode;

		// Token: 0x04029C83 RID: 171139
		[Token(Token = "0x4029C83")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_RenderStage;

		// Token: 0x04029C84 RID: 171140
		[Token(Token = "0x4029C84")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_RenderImpl;

		// Token: 0x04029C85 RID: 171141
		[Token(Token = "0x4029C85")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadPreviewMap;

		// Token: 0x04029C86 RID: 171142
		[Token(Token = "0x4029C86")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__UnloadPreviewMap;

		// Token: 0x04029C87 RID: 171143
		[Token(Token = "0x4029C87")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ShotBlurredSprite;

		// Token: 0x04029C88 RID: 171144
		[Token(Token = "0x4029C88")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ClearBlurSprite;

		// Token: 0x04029C89 RID: 171145
		[Token(Token = "0x4029C89")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04029C8A RID: 171146
		[Token(Token = "0x4029C8A")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_imageIcon;

		// Token: 0x04029C8B RID: 171147
		[Token(Token = "0x4029C8B")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_colorGraphic;

		// Token: 0x04029C8C RID: 171148
		[Token(Token = "0x4029C8C")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_panelBattleTitle;

		// Token: 0x04029C8D RID: 171149
		[Token(Token = "0x4029C8D")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_panelNonBattleTitle;

		// Token: 0x04029C8E RID: 171150
		[Token(Token = "0x4029C8E")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_panelBattleInfo;

		// Token: 0x04029C8F RID: 171151
		[Token(Token = "0x4029C8F")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_textNonBattleTitle;

		// Token: 0x04029C90 RID: 171152
		[Token(Token = "0x4029C90")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_textBattleTitle;

		// Token: 0x04029C91 RID: 171153
		[Token(Token = "0x4029C91")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_textDesc;

		// Token: 0x04029C92 RID: 171154
		[Token(Token = "0x4029C92")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
