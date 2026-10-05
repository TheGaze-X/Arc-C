using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DED RID: 19949
	[Token(Token = "0x2004DED")]
	public class NameCardSkinChangeView : DataBinder<NameCardSkinChangeProperty>
	{
		// Token: 0x0601DD1B RID: 122139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD1B")]
		[Address(RVA = "0x1755F60", Offset = "0x1754B60", VA = "0x181755F60", Slot = "7")]
		public override void OnValueChanged(NameCardSkinChangeProperty property)
		{
		}

		// Token: 0x0601DD1C RID: 122140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD1C")]
		[Address(RVA = "0x1756420", Offset = "0x1755020", VA = "0x181756420")]
		public NameCardSkinChangeView()
		{
		}

		// Token: 0x040277E6 RID: 161766
		[Token(Token = "0x40277E6")]
		private const string UNLCOK_CONDITION_TYPE = "    - {0}({1}/{2})";

		// Token: 0x040277E7 RID: 161767
		[Token(Token = "0x40277E7")]
		private const int CURRENT_PROGRESS_IDX = 0;

		// Token: 0x040277E8 RID: 161768
		[Token(Token = "0x40277E8")]
		private const int MAX_PROGRESS_IDX = 1;

		// Token: 0x040277E9 RID: 161769
		[Token(Token = "0x40277E9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _skinNameText;

		// Token: 0x040277EA RID: 161770
		[Token(Token = "0x40277EA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _skinNameBottomText;

		// Token: 0x040277EB RID: 161771
		[Token(Token = "0x40277EB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _skinDescText;

		// Token: 0x040277EC RID: 161772
		[Token(Token = "0x40277EC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lockIcon;

		// Token: 0x040277ED RID: 161773
		[Token(Token = "0x40277ED")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private NameCardSkinListAdapter _skinListAdapter;

		// Token: 0x040277EE RID: 161774
		[Token(Token = "0x40277EE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _confirmBtn;

		// Token: 0x040277EF RID: 161775
		[Token(Token = "0x40277EF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _disableConfirmObj;

		// Token: 0x040277F0 RID: 161776
		[Token(Token = "0x40277F0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _buttonGroup;

		// Token: 0x040277F1 RID: 161777
		[Token(Token = "0x40277F1")]
		[FieldOffset(Offset = "0x60")]
		private int m_focusSkinListSeqNum;

		// Token: 0x040277F2 RID: 161778
		[Token(Token = "0x40277F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040277F3 RID: 161779
		[Token(Token = "0x40277F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
