using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004737 RID: 18231
	[Token(Token = "0x2004737")]
	public class RecruitBuildConfigTagView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170041B8 RID: 16824
		// (get) Token: 0x0601BA18 RID: 113176 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BA19 RID: 113177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041B8")]
		public Action<int> onClick
		{
			[Token(Token = "0x601BA18")]
			[Address(RVA = "0x14F7FB0", Offset = "0x14F6BB0", VA = "0x1814F7FB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BA19")]
			[Address(RVA = "0x14F8010", Offset = "0x14F6C10", VA = "0x1814F8010")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601BA1A RID: 113178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA1A")]
		[Address(RVA = "0x14F7D40", Offset = "0x14F6940", VA = "0x1814F7D40")]
		public void Render(BuildConfigTagViewModel viewModel)
		{
		}

		// Token: 0x0601BA1B RID: 113179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA1B")]
		[Address(RVA = "0x14F7C30", Offset = "0x14F6830", VA = "0x1814F7C30")]
		public void EventOnTagClick()
		{
		}

		// Token: 0x0601BA1C RID: 113180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA1C")]
		[Address(RVA = "0x14F7F40", Offset = "0x14F6B40", VA = "0x1814F7F40")]
		public RecruitBuildConfigTagView()
		{
		}

		// Token: 0x04023D47 RID: 146759
		[Token(Token = "0x4023D47")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x04023D48 RID: 146760
		[Token(Token = "0x4023D48")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x04023D49 RID: 146761
		[Token(Token = "0x4023D49")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _toggleSpecial;

		// Token: 0x04023D4A RID: 146762
		[Token(Token = "0x4023D4A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelContent;

		// Token: 0x04023D4B RID: 146763
		[Token(Token = "0x4023D4B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelSpecial;

		// Token: 0x04023D4D RID: 146765
		[Token(Token = "0x4023D4D")]
		[FieldOffset(Offset = "0x48")]
		private int m_tagIndex;

		// Token: 0x04023D4E RID: 146766
		[Token(Token = "0x4023D4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x04023D4F RID: 146767
		[Token(Token = "0x4023D4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x04023D50 RID: 146768
		[Token(Token = "0x4023D50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023D51 RID: 146769
		[Token(Token = "0x4023D51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnTagClick;

		// Token: 0x04023D52 RID: 146770
		[Token(Token = "0x4023D52")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
