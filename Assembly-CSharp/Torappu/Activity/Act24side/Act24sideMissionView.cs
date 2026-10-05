using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075F4 RID: 30196
	[Token(Token = "0x20075F4")]
	public class Act24sideMissionView : DataBinder<Act24sideMissionProp>
	{
		// Token: 0x0602A842 RID: 174146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A842")]
		[Address(RVA = "0x262E9C0", Offset = "0x262D5C0", VA = "0x18262E9C0", Slot = "7")]
		public override void OnValueChanged(Act24sideMissionProp property)
		{
		}

		// Token: 0x0602A843 RID: 174147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A843")]
		[Address(RVA = "0x262E950", Offset = "0x262D550", VA = "0x18262E950")]
		public void OnClickOneClickBtn()
		{
		}

		// Token: 0x0602A844 RID: 174148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A844")]
		[Address(RVA = "0x262EC80", Offset = "0x262D880", VA = "0x18262EC80")]
		public Act24sideMissionView()
		{
		}

		// Token: 0x0403D31E RID: 250654
		[Token(Token = "0x403D31E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act24sideMissionLoopAdapter _loopAdapter;

		// Token: 0x0403D31F RID: 250655
		[Token(Token = "0x403D31F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _missionNum;

		// Token: 0x0403D320 RID: 250656
		[Token(Token = "0x403D320")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _bottomBar;

		// Token: 0x0403D321 RID: 250657
		[Token(Token = "0x403D321")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LoopVerticalScrollRect _scrollRect;

		// Token: 0x0403D322 RID: 250658
		[Token(Token = "0x403D322")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0403D323 RID: 250659
		[Token(Token = "0x403D323")]
		[FieldOffset(Offset = "0x48")]
		private Act24sideMissionViewModel m_model;

		// Token: 0x0403D324 RID: 250660
		[Token(Token = "0x403D324")]
		[FieldOffset(Offset = "0x50")]
		private float m_cachedSequenceNum;

		// Token: 0x0403D325 RID: 250661
		[Token(Token = "0x403D325")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<string> onClickDetailBtn;

		// Token: 0x0403D326 RID: 250662
		[Token(Token = "0x403D326")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action<string> onClickCompleteBtn;

		// Token: 0x0403D327 RID: 250663
		[Token(Token = "0x403D327")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action onClickOneClickBtn;

		// Token: 0x0403D328 RID: 250664
		[Token(Token = "0x403D328")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403D329 RID: 250665
		[Token(Token = "0x403D329")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickOneClickBtn;

		// Token: 0x0403D32A RID: 250666
		[Token(Token = "0x403D32A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
