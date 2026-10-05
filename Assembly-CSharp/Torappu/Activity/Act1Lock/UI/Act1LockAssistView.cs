using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x0200789C RID: 30876
	[Token(Token = "0x200789C")]
	public class Act1LockAssistView : DataBinder<Act1LockAssistViewProperty>
	{
		// Token: 0x0602B493 RID: 177299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B493")]
		[Address(RVA = "0x2707820", Offset = "0x2706420", VA = "0x182707820")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B494 RID: 177300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B494")]
		[Address(RVA = "0x2707350", Offset = "0x2705F50", VA = "0x182707350", Slot = "7")]
		public override void OnValueChanged(Act1LockAssistViewProperty property)
		{
		}

		// Token: 0x0602B495 RID: 177301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B495")]
		[Address(RVA = "0x2707920", Offset = "0x2706520", VA = "0x182707920")]
		private void _LoadAndSetIllusts(CharUISkinStruct skinStruct)
		{
		}

		// Token: 0x0602B496 RID: 177302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B496")]
		[Address(RVA = "0x2707750", Offset = "0x2706350", VA = "0x182707750")]
		private void _ClearIllusts()
		{
		}

		// Token: 0x0602B497 RID: 177303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B497")]
		[Address(RVA = "0x2707C90", Offset = "0x2706890", VA = "0x182707C90")]
		private void _OnSkillViewClick(int position)
		{
		}

		// Token: 0x0602B498 RID: 177304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B498")]
		[Address(RVA = "0x2707190", Offset = "0x2705D90", VA = "0x182707190")]
		public void OnConfirmBtnClick()
		{
		}

		// Token: 0x0602B499 RID: 177305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B499")]
		[Address(RVA = "0x2707200", Offset = "0x2705E00", VA = "0x182707200")]
		public void OnDetailBtnClick()
		{
		}

		// Token: 0x0602B49A RID: 177306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B49A")]
		[Address(RVA = "0x2707D10", Offset = "0x2706910", VA = "0x182707D10")]
		public Act1LockAssistView()
		{
		}

		// Token: 0x0403E8EB RID: 256235
		[Token(Token = "0x403E8EB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _illustrationLayout;

		// Token: 0x0403E8EC RID: 256236
		[Token(Token = "0x403E8EC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(0.1f, 2f)]
		private float _illustScaleFactor;

		// Token: 0x0403E8ED RID: 256237
		[Token(Token = "0x403E8ED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x0403E8EE RID: 256238
		[Token(Token = "0x403E8EE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _eliteImg;

		// Token: 0x0403E8EF RID: 256239
		[Token(Token = "0x403E8EF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _rarityImg;

		// Token: 0x0403E8F0 RID: 256240
		[Token(Token = "0x403E8F0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _nickNameText;

		// Token: 0x0403E8F1 RID: 256241
		[Token(Token = "0x403E8F1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _professionImg;

		// Token: 0x0403E8F2 RID: 256242
		[Token(Token = "0x403E8F2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _realNameText;

		// Token: 0x0403E8F3 RID: 256243
		[Token(Token = "0x403E8F3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _skillLayoutContent;

		// Token: 0x0403E8F4 RID: 256244
		[Token(Token = "0x403E8F4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TwoStateToggle _confirmToggle;

		// Token: 0x0403E8F5 RID: 256245
		[Token(Token = "0x403E8F5")]
		[FieldOffset(Offset = "0x70")]
		public Action<int> onSkillClick;

		// Token: 0x0403E8F6 RID: 256246
		[Token(Token = "0x403E8F6")]
		[FieldOffset(Offset = "0x78")]
		public Action onConfirmClick;

		// Token: 0x0403E8F7 RID: 256247
		[Token(Token = "0x403E8F7")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0403E8F8 RID: 256248
		[Token(Token = "0x403E8F8")]
		[FieldOffset(Offset = "0x88")]
		private UICharacterIllust m_illust;

		// Token: 0x0403E8F9 RID: 256249
		[Token(Token = "0x403E8F9")]
		[FieldOffset(Offset = "0x90")]
		private PlayerCharacter m_playerCharacter;

		// Token: 0x0403E8FA RID: 256250
		[Token(Token = "0x403E8FA")]
		[FieldOffset(Offset = "0x98")]
		private CharUISkinStruct m_skinStruct;

		// Token: 0x0403E8FB RID: 256251
		[Token(Token = "0x403E8FB")]
		[FieldOffset(Offset = "0xB0")]
		private Act1LockAssistView.SkillViewAdapter m_adapter;

		// Token: 0x0403E8FC RID: 256252
		[Token(Token = "0x403E8FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E8FD RID: 256253
		[Token(Token = "0x403E8FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403E8FE RID: 256254
		[Token(Token = "0x403E8FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadAndSetIllusts;

		// Token: 0x0403E8FF RID: 256255
		[Token(Token = "0x403E8FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ClearIllusts;

		// Token: 0x0403E900 RID: 256256
		[Token(Token = "0x403E900")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSkillViewClick;

		// Token: 0x0403E901 RID: 256257
		[Token(Token = "0x403E901")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClick;

		// Token: 0x0403E902 RID: 256258
		[Token(Token = "0x403E902")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDetailBtnClick;

		// Token: 0x0403E903 RID: 256259
		[Token(Token = "0x403E903")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200789D RID: 30877
		[Token(Token = "0x200789D")]
		private class SkillViewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700653B RID: 25915
			// (get) Token: 0x0602B49B RID: 177307 RVA: 0x000DB5A0 File Offset: 0x000D97A0
			[Token(Token = "0x1700653B")]
			public override int count
			{
				[Token(Token = "0x602B49B")]
				[Address(RVA = "0x271C380", Offset = "0x271AF80", VA = "0x18271C380", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B49C RID: 177308 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B49C")]
			[Address(RVA = "0x271C110", Offset = "0x271AD10", VA = "0x18271C110", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602B49D RID: 177309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B49D")]
			[Address(RVA = "0x271C320", Offset = "0x271AF20", VA = "0x18271C320")]
			public SkillViewAdapter()
			{
			}

			// Token: 0x0403E904 RID: 256260
			[Token(Token = "0x403E904")]
			[FieldOffset(Offset = "0x20")]
			public Act1LockAssistViewModel viewModel;

			// Token: 0x0403E905 RID: 256261
			[Token(Token = "0x403E905")]
			[FieldOffset(Offset = "0x28")]
			public Action<int> onSkillViewClick;

			// Token: 0x0403E906 RID: 256262
			[Token(Token = "0x403E906")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403E907 RID: 256263
			[Token(Token = "0x403E907")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403E908 RID: 256264
			[Token(Token = "0x403E908")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
