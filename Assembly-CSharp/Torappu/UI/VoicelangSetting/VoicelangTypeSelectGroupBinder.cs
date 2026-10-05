using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BC3 RID: 15299
	[Token(Token = "0x2003BC3")]
	public class VoicelangTypeSelectGroupBinder : DataBinder<VoicelangTypeSelectGroupViewProperty>, IHotfixable
	{
		// Token: 0x06017F4E RID: 98126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F4E")]
		[Address(RVA = "0x10755D0", Offset = "0x10741D0", VA = "0x1810755D0", Slot = "7")]
		public override void OnValueChanged(VoicelangTypeSelectGroupViewProperty property)
		{
		}

		// Token: 0x06017F4F RID: 98127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F4F")]
		[Address(RVA = "0x1075B90", Offset = "0x1074790", VA = "0x181075B90")]
		private void _InitIfNot(VoicelangTypeSelectGroupViewProperty property)
		{
		}

		// Token: 0x06017F50 RID: 98128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F50")]
		[Address(RVA = "0x1075CF0", Offset = "0x10748F0", VA = "0x181075CF0")]
		public VoicelangTypeSelectGroupBinder()
		{
		}

		// Token: 0x0401CFC6 RID: 118726
		[Token(Token = "0x401CFC6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform m_tabRoot;

		// Token: 0x0401CFC7 RID: 118727
		[Token(Token = "0x401CFC7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VoicelangTypeTabView m_prefab;

		// Token: 0x0401CFC8 RID: 118728
		[Token(Token = "0x401CFC8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UISelectGroupTypeEvent m_onClick;

		// Token: 0x0401CFC9 RID: 118729
		[Token(Token = "0x401CFC9")]
		[FieldOffset(Offset = "0x38")]
		private List<VoicelangTypeTabView> viewList;

		// Token: 0x0401CFCA RID: 118730
		[Token(Token = "0x401CFCA")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0401CFCB RID: 118731
		[Token(Token = "0x401CFCB")]
		[FieldOffset(Offset = "0x44")]
		private float groupSize;

		// Token: 0x0401CFCC RID: 118732
		[Token(Token = "0x401CFCC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401CFCD RID: 118733
		[Token(Token = "0x401CFCD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401CFCE RID: 118734
		[Token(Token = "0x401CFCE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
