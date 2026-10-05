using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x0200789B RID: 30875
	[Token(Token = "0x200789B")]
	public class Act1LockAssistSkillView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700653A RID: 25914
		// (get) Token: 0x0602B48E RID: 177294 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B48F RID: 177295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700653A")]
		public Action<int> onClickAction
		{
			[Token(Token = "0x602B48E")]
			[Address(RVA = "0x27070B0", Offset = "0x2705CB0", VA = "0x1827070B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B48F")]
			[Address(RVA = "0x2707110", Offset = "0x2705D10", VA = "0x182707110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B490 RID: 177296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B490")]
		[Address(RVA = "0x2706DF0", Offset = "0x27059F0", VA = "0x182706DF0")]
		public void Render(Act1LockAssistViewModel viewModel, int position, bool needDivider)
		{
		}

		// Token: 0x0602B491 RID: 177297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B491")]
		[Address(RVA = "0x2706CE0", Offset = "0x27058E0", VA = "0x182706CE0")]
		public void OnClick()
		{
		}

		// Token: 0x0602B492 RID: 177298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B492")]
		[Address(RVA = "0x2707040", Offset = "0x2705C40", VA = "0x182707040")]
		public Act1LockAssistSkillView()
		{
		}

		// Token: 0x0403E8DD RID: 256221
		[Token(Token = "0x403E8DD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectedPanel;

		// Token: 0x0403E8DE RID: 256222
		[Token(Token = "0x403E8DE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _dividerPanel;

		// Token: 0x0403E8DF RID: 256223
		[Token(Token = "0x403E8DF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _skillImg;

		// Token: 0x0403E8E0 RID: 256224
		[Token(Token = "0x403E8E0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _skillLevelText;

		// Token: 0x0403E8E1 RID: 256225
		[Token(Token = "0x403E8E1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _skillNameText;

		// Token: 0x0403E8E2 RID: 256226
		[Token(Token = "0x403E8E2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UISkillTagGroup _sillTagGroup;

		// Token: 0x0403E8E3 RID: 256227
		[Token(Token = "0x403E8E3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UICommentedText _skillDescText;

		// Token: 0x0403E8E4 RID: 256228
		[Token(Token = "0x403E8E4")]
		[FieldOffset(Offset = "0x50")]
		private int m_position;

		// Token: 0x0403E8E6 RID: 256230
		[Token(Token = "0x403E8E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickAction;

		// Token: 0x0403E8E7 RID: 256231
		[Token(Token = "0x403E8E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickAction;

		// Token: 0x0403E8E8 RID: 256232
		[Token(Token = "0x403E8E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E8E9 RID: 256233
		[Token(Token = "0x403E8E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403E8EA RID: 256234
		[Token(Token = "0x403E8EA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
