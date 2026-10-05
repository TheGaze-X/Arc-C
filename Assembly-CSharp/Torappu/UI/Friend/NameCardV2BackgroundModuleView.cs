using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DF8 RID: 19960
	[Token(Token = "0x2004DF8")]
	public class NameCardV2BackgroundModuleView : NameCardV2BaseFixedModuleView<NameCardV2BackgroundModuleModel>
	{
		// Token: 0x0601DD4E RID: 122190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD4E")]
		[Address(RVA = "0x1772A60", Offset = "0x1771660", VA = "0x181772A60", Slot = "20")]
		public override void OnModuleViewRendered(NameCardV2BackgroundModuleModel model)
		{
		}

		// Token: 0x0601DD4F RID: 122191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD4F")]
		[Address(RVA = "0x1772690", Offset = "0x1771290", VA = "0x181772690", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0601DD50 RID: 122192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD50")]
		[Address(RVA = "0x17724D0", Offset = "0x17710D0", VA = "0x1817724D0")]
		public void ClickNamecardBackground()
		{
		}

		// Token: 0x0601DD51 RID: 122193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD51")]
		[Address(RVA = "0x1772AC0", Offset = "0x17716C0", VA = "0x181772AC0")]
		private void SetUIParticle(GameObject mainEffect)
		{
		}

		// Token: 0x0601DD52 RID: 122194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD52")]
		[Address(RVA = "0x1772C00", Offset = "0x1771800", VA = "0x181772C00")]
		public NameCardV2BackgroundModuleView()
		{
		}

		// Token: 0x0601DD53 RID: 122195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD53")]
		[Address(RVA = "0x1772BA0", Offset = "0x17717A0", VA = "0x181772BA0")]
		private void <>xLuaBaseProxy_OnApplyStyle(NameCardV2SkinStyle P0)
		{
		}

		// Token: 0x04027871 RID: 161905
		[Token(Token = "0x4027871")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _bgImg;

		// Token: 0x04027872 RID: 161906
		[Token(Token = "0x4027872")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _bgPureColor;

		// Token: 0x04027873 RID: 161907
		[Token(Token = "0x4027873")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _leftBorder;

		// Token: 0x04027874 RID: 161908
		[Token(Token = "0x4027874")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _rightBorder;

		// Token: 0x04027875 RID: 161909
		[Token(Token = "0x4027875")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _effectHolder;

		// Token: 0x04027876 RID: 161910
		[Token(Token = "0x4027876")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnModuleViewRendered;

		// Token: 0x04027877 RID: 161911
		[Token(Token = "0x4027877")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x04027878 RID: 161912
		[Token(Token = "0x4027878")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClickNamecardBackground;

		// Token: 0x04027879 RID: 161913
		[Token(Token = "0x4027879")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetUIParticle;

		// Token: 0x0402787A RID: 161914
		[Token(Token = "0x402787A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
