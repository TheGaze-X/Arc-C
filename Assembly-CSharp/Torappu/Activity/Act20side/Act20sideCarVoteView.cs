using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200767F RID: 30335
	[Token(Token = "0x200767F")]
	public class Act20sideCarVoteView : DataBinder<Act20sideCarVoteProperty>
	{
		// Token: 0x0602AAB4 RID: 174772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAB4")]
		[Address(RVA = "0x266E210", Offset = "0x266CE10", VA = "0x18266E210", Slot = "7")]
		public override void OnValueChanged(Act20sideCarVoteProperty property)
		{
		}

		// Token: 0x0602AAB5 RID: 174773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAB5")]
		[Address(RVA = "0x266E580", Offset = "0x266D180", VA = "0x18266E580")]
		public void PlayEnterAnim()
		{
		}

		// Token: 0x0602AAB6 RID: 174774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAB6")]
		[Address(RVA = "0x266E670", Offset = "0x266D270", VA = "0x18266E670")]
		public Act20sideCarVoteView()
		{
		}

		// Token: 0x0403D75F RID: 251743
		[Token(Token = "0x403D75F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act20sideCarVoteItemView[] _itemViews;

		// Token: 0x0403D760 RID: 251744
		[Token(Token = "0x403D760")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _roundText;

		// Token: 0x0403D761 RID: 251745
		[Token(Token = "0x403D761")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelVote;

		// Token: 0x0403D762 RID: 251746
		[Token(Token = "0x403D762")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelOver;

		// Token: 0x0403D763 RID: 251747
		[Token(Token = "0x403D763")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403D764 RID: 251748
		[Token(Token = "0x403D764")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_cachedEnterTween;

		// Token: 0x0403D765 RID: 251749
		[Token(Token = "0x403D765")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403D766 RID: 251750
		[Token(Token = "0x403D766")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayEnterAnim;

		// Token: 0x0403D767 RID: 251751
		[Token(Token = "0x403D767")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
