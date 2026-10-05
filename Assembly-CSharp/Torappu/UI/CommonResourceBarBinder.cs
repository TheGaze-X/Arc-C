using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200391A RID: 14618
	[Token(Token = "0x200391A")]
	public class CommonResourceBarBinder : DataBinder<ResourceBarViewProperty>
	{
		// Token: 0x060171AB RID: 94635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171AB")]
		[Address(RVA = "0xF707E0", Offset = "0xF6F3E0", VA = "0x180F707E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060171AC RID: 94636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171AC")]
		[Address(RVA = "0xF70980", Offset = "0xF6F580", VA = "0x180F70980")]
		private void _OnResourceBarCreated(GameObject inst)
		{
		}

		// Token: 0x060171AD RID: 94637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171AD")]
		[Address(RVA = "0xF70580", Offset = "0xF6F180", VA = "0x180F70580", Slot = "7")]
		public override void OnValueChanged(ResourceBarViewProperty property)
		{
		}

		// Token: 0x060171AE RID: 94638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171AE")]
		[Address(RVA = "0xF70AA0", Offset = "0xF6F6A0", VA = "0x180F70AA0")]
		public CommonResourceBarBinder()
		{
		}

		// Token: 0x0401BE39 RID: 114233
		[Token(Token = "0x401BE39")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Nullable")]
		private PrefabInstHolder _resourceBarHolder;

		// Token: 0x0401BE3A RID: 114234
		[Token(Token = "0x401BE3A")]
		[FieldOffset(Offset = "0x28")]
		private CommonResourceBar m_resourceBar;

		// Token: 0x0401BE3B RID: 114235
		[Token(Token = "0x401BE3B")]
		[FieldOffset(Offset = "0x30")]
		private ResourceBarViewModel m_viewModelCache;

		// Token: 0x0401BE3C RID: 114236
		[Token(Token = "0x401BE3C")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401BE3D RID: 114237
		[Token(Token = "0x401BE3D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401BE3E RID: 114238
		[Token(Token = "0x401BE3E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnResourceBarCreated;

		// Token: 0x0401BE3F RID: 114239
		[Token(Token = "0x401BE3F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401BE40 RID: 114240
		[Token(Token = "0x401BE40")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
