using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E16 RID: 19990
	[Token(Token = "0x2004E16")]
	public class NameCardV2SignModuleView : NameCardV2BaseRemovableModuleView<NameCardV2SignModuleModel>
	{
		// Token: 0x0601DDDA RID: 122330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDDA")]
		[Address(RVA = "0x1779380", Offset = "0x1777F80", VA = "0x181779380", Slot = "20")]
		public override void OnModuleViewRendered(NameCardV2SignModuleModel model)
		{
		}

		// Token: 0x0601DDDB RID: 122331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDDB")]
		[Address(RVA = "0x1778F90", Offset = "0x1777B90", VA = "0x181778F90", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0601DDDC RID: 122332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDDC")]
		[Address(RVA = "0x17792F0", Offset = "0x1777EF0", VA = "0x1817792F0")]
		public void OnEditClick()
		{
		}

		// Token: 0x0601DDDD RID: 122333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDDD")]
		[Address(RVA = "0x1779490", Offset = "0x1778090", VA = "0x181779490")]
		public NameCardV2SignModuleView()
		{
		}

		// Token: 0x0601DDDE RID: 122334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDDE")]
		[Address(RVA = "0x1772BA0", Offset = "0x17717A0", VA = "0x181772BA0")]
		private void <>xLuaBaseProxy_OnApplyStyle(NameCardV2SkinStyle P0)
		{
		}

		// Token: 0x04027973 RID: 162163
		[Token(Token = "0x4027973")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Colored")]
		private Image _bgImg;

		// Token: 0x04027974 RID: 162164
		[Token(Token = "0x4027974")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Colored")]
		private Image[] _coloredIcons;

		// Token: 0x04027975 RID: 162165
		[Token(Token = "0x4027975")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Colored")]
		private Text[] _coloredTexts;

		// Token: 0x04027976 RID: 162166
		[Token(Token = "0x4027976")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Text _resumeText;

		// Token: 0x04027977 RID: 162167
		[Token(Token = "0x4027977")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Button _editSignBtn;

		// Token: 0x04027978 RID: 162168
		[Token(Token = "0x4027978")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private AudioClickPlayer _editSignAudio;

		// Token: 0x04027979 RID: 162169
		[Token(Token = "0x4027979")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnModuleViewRendered;

		// Token: 0x0402797A RID: 162170
		[Token(Token = "0x402797A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x0402797B RID: 162171
		[Token(Token = "0x402797B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEditClick;

		// Token: 0x0402797C RID: 162172
		[Token(Token = "0x402797C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E17 RID: 19991
		[Token(Token = "0x2004E17")]
		public class VirtualView : NameCardV2RemovableModuleVirtualView<NameCardV2SignModuleView, NameCardV2SignModuleModel>
		{
			// Token: 0x0601DDDF RID: 122335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DDDF")]
			[Address(RVA = "0x177EF20", Offset = "0x177DB20", VA = "0x18177EF20")]
			public VirtualView(NameCardV2BaseRemovableModuleView prefab, NameCardV2RemovableModuleBaseModel model)
			{
			}

			// Token: 0x0402797D RID: 162173
			[Token(Token = "0x402797D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
