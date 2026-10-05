using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BC2 RID: 15298
	[Token(Token = "0x2003BC2")]
	public class VoicelangTypeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017F45 RID: 98117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F45")]
		[Address(RVA = "0x1074D00", Offset = "0x1073900", VA = "0x181074D00")]
		public void Render(VoicelangSettingConfirmViewModel model)
		{
		}

		// Token: 0x06017F46 RID: 98118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F46")]
		[Address(RVA = "0x10749D0", Offset = "0x10735D0", VA = "0x1810749D0")]
		public void Init(VoiceLangType type, UISelectLangTypeEvent listener)
		{
		}

		// Token: 0x06017F47 RID: 98119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F47")]
		[Address(RVA = "0x1075330", Offset = "0x1073F30", VA = "0x181075330")]
		private void _TryPlayVoice(bool isSelect, VoicelangCardViewModel singleSelectChar)
		{
		}

		// Token: 0x06017F48 RID: 98120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F48")]
		[Address(RVA = "0x1075030", Offset = "0x1073C30", VA = "0x181075030")]
		private void Select()
		{
		}

		// Token: 0x06017F49 RID: 98121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F49")]
		[Address(RVA = "0x1074960", Offset = "0x1073560", VA = "0x181074960")]
		public void CancelSelect()
		{
		}

		// Token: 0x06017F4A RID: 98122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F4A")]
		[Address(RVA = "0x10752B0", Offset = "0x1073EB0", VA = "0x1810752B0")]
		private void StopAnim()
		{
		}

		// Token: 0x06017F4B RID: 98123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F4B")]
		[Address(RVA = "0x1074C80", Offset = "0x1073880", VA = "0x181074C80")]
		private void PlayAnim()
		{
		}

		// Token: 0x06017F4C RID: 98124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F4C")]
		[Address(RVA = "0x1074B90", Offset = "0x1073790", VA = "0x181074B90")]
		public void OnClick()
		{
		}

		// Token: 0x06017F4D RID: 98125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F4D")]
		[Address(RVA = "0x1075570", Offset = "0x1074170", VA = "0x181075570")]
		public VoicelangTypeItemView()
		{
		}

		// Token: 0x0401CFB0 RID: 118704
		[Token(Token = "0x401CFB0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text lb_langType;

		// Token: 0x0401CFB1 RID: 118705
		[Token(Token = "0x401CFB1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject go_new;

		// Token: 0x0401CFB2 RID: 118706
		[Token(Token = "0x401CFB2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject go_selected;

		// Token: 0x0401CFB3 RID: 118707
		[Token(Token = "0x401CFB3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject goInvalid;

		// Token: 0x0401CFB4 RID: 118708
		[Token(Token = "0x401CFB4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color color_valid;

		// Token: 0x0401CFB5 RID: 118709
		[Token(Token = "0x401CFB5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color color_invalid;

		// Token: 0x0401CFB6 RID: 118710
		[Token(Token = "0x401CFB6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Animation anim_voice;

		// Token: 0x0401CFB7 RID: 118711
		[Token(Token = "0x401CFB7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image img_voice;

		// Token: 0x0401CFB8 RID: 118712
		[Token(Token = "0x401CFB8")]
		[FieldOffset(Offset = "0x68")]
		private VoiceLangType m_type;

		// Token: 0x0401CFB9 RID: 118713
		[Token(Token = "0x401CFB9")]
		[FieldOffset(Offset = "0x70")]
		private UISelectLangTypeEvent m_onSelctLangType;

		// Token: 0x0401CFBA RID: 118714
		[Token(Token = "0x401CFBA")]
		[FieldOffset(Offset = "0x78")]
		private VoicelangSettingConfirmViewModel m_model;

		// Token: 0x0401CFBB RID: 118715
		[Token(Token = "0x401CFBB")]
		[FieldOffset(Offset = "0x80")]
		private bool m_lastSelected;

		// Token: 0x0401CFBC RID: 118716
		[Token(Token = "0x401CFBC")]
		[FieldOffset(Offset = "0x88")]
		private string m_lastCharId;

		// Token: 0x0401CFBD RID: 118717
		[Token(Token = "0x401CFBD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401CFBE RID: 118718
		[Token(Token = "0x401CFBE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401CFBF RID: 118719
		[Token(Token = "0x401CFBF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryPlayVoice;

		// Token: 0x0401CFC0 RID: 118720
		[Token(Token = "0x401CFC0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Select;

		// Token: 0x0401CFC1 RID: 118721
		[Token(Token = "0x401CFC1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CancelSelect;

		// Token: 0x0401CFC2 RID: 118722
		[Token(Token = "0x401CFC2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_StopAnim;

		// Token: 0x0401CFC3 RID: 118723
		[Token(Token = "0x401CFC3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x0401CFC4 RID: 118724
		[Token(Token = "0x401CFC4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401CFC5 RID: 118725
		[Token(Token = "0x401CFC5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
