using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EC2 RID: 20162
	[Token(Token = "0x2004EC2")]
	public class FifthAnnivExploreGroupChooseView : DataBinder<FifthAnnivExploreGroupChooseProperty>, IHotfixable
	{
		// Token: 0x0601E168 RID: 123240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E168")]
		[Address(RVA = "0x17BDCA0", Offset = "0x17BC8A0", VA = "0x1817BDCA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E169 RID: 123241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E169")]
		[Address(RVA = "0x17BDA30", Offset = "0x17BC630", VA = "0x1817BDA30", Slot = "7")]
		public override void OnValueChanged(FifthAnnivExploreGroupChooseProperty property)
		{
		}

		// Token: 0x0601E16A RID: 123242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E16A")]
		[Address(RVA = "0x17BDEE0", Offset = "0x17BCAE0", VA = "0x1817BDEE0")]
		private void _TryConsumeGuideAutoShow()
		{
		}

		// Token: 0x0601E16B RID: 123243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E16B")]
		[Address(RVA = "0x17BDF60", Offset = "0x17BCB60", VA = "0x1817BDF60")]
		public FifthAnnivExploreGroupChooseView()
		{
		}

		// Token: 0x0402805C RID: 163932
		[Token(Token = "0x402805C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _groupInfoToogle;

		// Token: 0x0402805D RID: 163933
		[Token(Token = "0x402805D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<FifthAnnivExploreGroupChoiceItemView> _groupChoiceItemViews;

		// Token: 0x0402805E RID: 163934
		[Token(Token = "0x402805E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _groupNameText;

		// Token: 0x0402805F RID: 163935
		[Token(Token = "0x402805F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _groupIconImg;

		// Token: 0x04028060 RID: 163936
		[Token(Token = "0x4028060")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _groupIconAtlasObject;

		// Token: 0x04028061 RID: 163937
		[Token(Token = "0x4028061")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _infoPanelSelectAnim;

		// Token: 0x04028062 RID: 163938
		[Token(Token = "0x4028062")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04028063 RID: 163939
		[Token(Token = "0x4028063")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x04028064 RID: 163940
		[Token(Token = "0x4028064")]
		[FieldOffset(Offset = "0x70")]
		private AnimationSwitchTween m_selectTween;

		// Token: 0x04028065 RID: 163941
		[Token(Token = "0x4028065")]
		[FieldOffset(Offset = "0x78")]
		private AnimationSwitchTween m_enterTween;

		// Token: 0x04028066 RID: 163942
		[Token(Token = "0x4028066")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028067 RID: 163943
		[Token(Token = "0x4028067")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028068 RID: 163944
		[Token(Token = "0x4028068")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryConsumeGuideAutoShow;

		// Token: 0x04028069 RID: 163945
		[Token(Token = "0x4028069")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
