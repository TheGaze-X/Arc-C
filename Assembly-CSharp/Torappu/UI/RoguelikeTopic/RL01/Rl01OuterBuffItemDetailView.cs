using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x0200463F RID: 17983
	[Token(Token = "0x200463F")]
	public class Rl01OuterBuffItemDetailView : DataBinder<RoguelikeTopicOuterBuffSkillTreeProperty>
	{
		// Token: 0x17004111 RID: 16657
		// (get) Token: 0x0601B4F6 RID: 111862 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B4F7 RID: 111863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004111")]
		private Rl01TopicOuterBuffController bindTopicController
		{
			[Token(Token = "0x601B4F6")]
			[Address(RVA = "0x14A43C0", Offset = "0x14A2FC0", VA = "0x1814A43C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B4F7")]
			[Address(RVA = "0x14A44E0", Offset = "0x14A30E0", VA = "0x1814A44E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004112 RID: 16658
		// (get) Token: 0x0601B4F8 RID: 111864 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B4F9 RID: 111865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004112")]
		private Rl01OuterBuffView outerBuffView
		{
			[Token(Token = "0x601B4F8")]
			[Address(RVA = "0x14A4420", Offset = "0x14A3020", VA = "0x1814A4420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B4F9")]
			[Address(RVA = "0x14A4560", Offset = "0x14A3160", VA = "0x1814A4560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004113 RID: 16659
		// (get) Token: 0x0601B4FA RID: 111866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004113")]
		public RectTransform panel
		{
			[Token(Token = "0x601B4FA")]
			[Address(RVA = "0x14A4480", Offset = "0x14A3080", VA = "0x1814A4480")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B4FB RID: 111867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4FB")]
		[Address(RVA = "0x14A3B30", Offset = "0x14A2730", VA = "0x1814A3B30")]
		public void Init(Rl01OuterBuffView view, Rl01TopicOuterBuffController topicController)
		{
		}

		// Token: 0x0601B4FC RID: 111868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4FC")]
		[Address(RVA = "0x14A3C70", Offset = "0x14A2870", VA = "0x1814A3C70", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicOuterBuffSkillTreeProperty property)
		{
		}

		// Token: 0x0601B4FD RID: 111869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4FD")]
		[Address(RVA = "0x14A3F70", Offset = "0x14A2B70", VA = "0x1814A3F70")]
		private void _Render(RoguelikeTopicOuterBuffSkillTreeModel model)
		{
		}

		// Token: 0x0601B4FE RID: 111870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4FE")]
		[Address(RVA = "0x14A3D10", Offset = "0x14A2910", VA = "0x1814A3D10")]
		public void UpgradeNodeClicked()
		{
		}

		// Token: 0x0601B4FF RID: 111871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4FF")]
		[Address(RVA = "0x14A4350", Offset = "0x14A2F50", VA = "0x1814A4350")]
		public Rl01OuterBuffItemDetailView()
		{
		}

		// Token: 0x04023463 RID: 144483
		[Token(Token = "0x4023463")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _panel;

		// Token: 0x04023464 RID: 144484
		[Token(Token = "0x4023464")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _buffIcon;

		// Token: 0x04023465 RID: 144485
		[Token(Token = "0x4023465")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _buffName;

		// Token: 0x04023466 RID: 144486
		[Token(Token = "0x4023466")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _buffType;

		// Token: 0x04023467 RID: 144487
		[Token(Token = "0x4023467")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _buffEffect;

		// Token: 0x04023468 RID: 144488
		[Token(Token = "0x4023468")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Rl01OuterBuffItemDetailView.Rl01OuterBuffConfirmButton _confirmButton;

		// Token: 0x04023469 RID: 144489
		[Token(Token = "0x4023469")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedBuffId;

		// Token: 0x0402346A RID: 144490
		[Token(Token = "0x402346A")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeTopicOuterBuffSkillTreeModel m_cachedModel;

		// Token: 0x0402346D RID: 144493
		[Token(Token = "0x402346D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bindTopicController;

		// Token: 0x0402346E RID: 144494
		[Token(Token = "0x402346E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bindTopicController;

		// Token: 0x0402346F RID: 144495
		[Token(Token = "0x402346F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_outerBuffView;

		// Token: 0x04023470 RID: 144496
		[Token(Token = "0x4023470")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_outerBuffView;

		// Token: 0x04023471 RID: 144497
		[Token(Token = "0x4023471")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_panel;

		// Token: 0x04023472 RID: 144498
		[Token(Token = "0x4023472")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04023473 RID: 144499
		[Token(Token = "0x4023473")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023474 RID: 144500
		[Token(Token = "0x4023474")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04023475 RID: 144501
		[Token(Token = "0x4023475")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpgradeNodeClicked;

		// Token: 0x04023476 RID: 144502
		[Token(Token = "0x4023476")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004640 RID: 17984
		[Token(Token = "0x2004640")]
		[Serializable]
		public class Rl01OuterBuffConfirmButton : IHotfixable
		{
			// Token: 0x0601B500 RID: 111872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B500")]
			[Address(RVA = "0x14A3880", Offset = "0x14A2480", VA = "0x1814A3880")]
			public void Render(RoguelikeTopicOuterBuffSkillTreeModel model)
			{
			}

			// Token: 0x0601B501 RID: 111873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B501")]
			[Address(RVA = "0x14A3AD0", Offset = "0x14A26D0", VA = "0x1814A3AD0")]
			public Rl01OuterBuffConfirmButton()
			{
			}

			// Token: 0x04023477 RID: 144503
			[Token(Token = "0x4023477")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _pnlUnlockPart;

			// Token: 0x04023478 RID: 144504
			[Token(Token = "0x4023478")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _pnlNotUpgraded;

			// Token: 0x04023479 RID: 144505
			[Token(Token = "0x4023479")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject _pnlAlreadyUpgraded;

			// Token: 0x0402347A RID: 144506
			[Token(Token = "0x402347A")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private GameObject _pnlForbidden;

			// Token: 0x0402347B RID: 144507
			[Token(Token = "0x402347B")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Text _textForbidden;

			// Token: 0x0402347C RID: 144508
			[Token(Token = "0x402347C")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Text _textToken;

			// Token: 0x0402347D RID: 144509
			[Token(Token = "0x402347D")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Button _btnConfirm;

			// Token: 0x0402347E RID: 144510
			[Token(Token = "0x402347E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402347F RID: 144511
			[Token(Token = "0x402347F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
