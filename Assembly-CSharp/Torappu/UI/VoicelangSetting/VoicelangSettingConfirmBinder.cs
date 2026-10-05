using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BBE RID: 15294
	[Token(Token = "0x2003BBE")]
	public class VoicelangSettingConfirmBinder : DataBinder<VoicelangSettingConfirmViewProperty>, IHotfixable
	{
		// Token: 0x06017F2E RID: 98094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F2E")]
		[Address(RVA = "0x106F2B0", Offset = "0x106DEB0", VA = "0x18106F2B0", Slot = "7")]
		public override void OnValueChanged(VoicelangSettingConfirmViewProperty property)
		{
		}

		// Token: 0x06017F2F RID: 98095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F2F")]
		[Address(RVA = "0x106F4C0", Offset = "0x106E0C0", VA = "0x18106F4C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017F30 RID: 98096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F30")]
		[Address(RVA = "0x106F5D0", Offset = "0x106E1D0", VA = "0x18106F5D0")]
		public VoicelangSettingConfirmBinder()
		{
		}

		// Token: 0x0401CF82 RID: 118658
		[Token(Token = "0x401CF82")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform m_panelRoot;

		// Token: 0x0401CF83 RID: 118659
		[Token(Token = "0x401CF83")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VoicelangSettingConfirmView m_prefab;

		// Token: 0x0401CF84 RID: 118660
		[Token(Token = "0x401CF84")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent m_onConfirm;

		// Token: 0x0401CF85 RID: 118661
		[Token(Token = "0x401CF85")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent m_onCancel;

		// Token: 0x0401CF86 RID: 118662
		[Token(Token = "0x401CF86")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UISelectLangTypeEvent m_onSelectLangType;

		// Token: 0x0401CF87 RID: 118663
		[Token(Token = "0x401CF87")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0401CF88 RID: 118664
		[Token(Token = "0x401CF88")]
		[FieldOffset(Offset = "0x50")]
		private VoicelangSettingConfirmView m_view;

		// Token: 0x0401CF89 RID: 118665
		[Token(Token = "0x401CF89")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401CF8A RID: 118666
		[Token(Token = "0x401CF8A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401CF8B RID: 118667
		[Token(Token = "0x401CF8B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
