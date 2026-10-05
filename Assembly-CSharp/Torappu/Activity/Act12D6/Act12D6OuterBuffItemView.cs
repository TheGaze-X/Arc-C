using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AF6 RID: 31478
	[Token(Token = "0x2007AF6")]
	public class Act12D6OuterBuffItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006747 RID: 26439
		// (get) Token: 0x0602C146 RID: 180550 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C147 RID: 180551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006747")]
		public UIStringEvent onUpgradeClicked
		{
			[Token(Token = "0x602C146")]
			[Address(RVA = "0x27F57B0", Offset = "0x27F43B0", VA = "0x1827F57B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C147")]
			[Address(RVA = "0x27F5890", Offset = "0x27F4490", VA = "0x1827F5890")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006748 RID: 26440
		// (get) Token: 0x0602C148 RID: 180552 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C149 RID: 180553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006748")]
		public UIStringEvent onMaxLevelClicked
		{
			[Token(Token = "0x602C148")]
			[Address(RVA = "0x27F5750", Offset = "0x27F4350", VA = "0x1827F5750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C149")]
			[Address(RVA = "0x27F5810", Offset = "0x27F4410", VA = "0x1827F5810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602C14A RID: 180554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C14A")]
		[Address(RVA = "0x27F5410", Offset = "0x27F4010", VA = "0x1827F5410")]
		public void Render(RoguelikeOuterBuff buffData)
		{
		}

		// Token: 0x0602C14B RID: 180555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C14B")]
		[Address(RVA = "0x27F51D0", Offset = "0x27F3DD0", VA = "0x1827F51D0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0602C14C RID: 180556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C14C")]
		[Address(RVA = "0x27F52F0", Offset = "0x27F3EF0", VA = "0x1827F52F0")]
		public void EventOnMaxLevelClicked()
		{
		}

		// Token: 0x0602C14D RID: 180557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C14D")]
		[Address(RVA = "0x27F56F0", Offset = "0x27F42F0", VA = "0x1827F56F0")]
		public Act12D6OuterBuffItemView()
		{
		}

		// Token: 0x0403FE0C RID: 261644
		[Token(Token = "0x403FE0C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgLevelBg;

		// Token: 0x0403FE0D RID: 261645
		[Token(Token = "0x403FE0D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgLevel;

		// Token: 0x0403FE0E RID: 261646
		[Token(Token = "0x403FE0E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgBuffIcon;

		// Token: 0x0403FE0F RID: 261647
		[Token(Token = "0x403FE0F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtBuffName;

		// Token: 0x0403FE10 RID: 261648
		[Token(Token = "0x403FE10")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtBuffLevel;

		// Token: 0x0403FE11 RID: 261649
		[Token(Token = "0x403FE11")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtBuffDesc;

		// Token: 0x0403FE12 RID: 261650
		[Token(Token = "0x403FE12")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtBuffEffect;

		// Token: 0x0403FE13 RID: 261651
		[Token(Token = "0x403FE13")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _btnLevelUp;

		// Token: 0x0403FE14 RID: 261652
		[Token(Token = "0x403FE14")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _btnMaxLevel;

		// Token: 0x0403FE15 RID: 261653
		[Token(Token = "0x403FE15")]
		[FieldOffset(Offset = "0x60")]
		private string m_buffId;

		// Token: 0x0403FE18 RID: 261656
		[Token(Token = "0x403FE18")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onUpgradeClicked;

		// Token: 0x0403FE19 RID: 261657
		[Token(Token = "0x403FE19")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onUpgradeClicked;

		// Token: 0x0403FE1A RID: 261658
		[Token(Token = "0x403FE1A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onMaxLevelClicked;

		// Token: 0x0403FE1B RID: 261659
		[Token(Token = "0x403FE1B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onMaxLevelClicked;

		// Token: 0x0403FE1C RID: 261660
		[Token(Token = "0x403FE1C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FE1D RID: 261661
		[Token(Token = "0x403FE1D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403FE1E RID: 261662
		[Token(Token = "0x403FE1E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnMaxLevelClicked;

		// Token: 0x0403FE1F RID: 261663
		[Token(Token = "0x403FE1F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
