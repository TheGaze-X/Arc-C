using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003734 RID: 14132
	[Token(Token = "0x2003734")]
	public class UIItemDescFloatBinder : DataBinder<UIItemDescViewProperty>
	{
		// Token: 0x06016734 RID: 91956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016734")]
		[Address(RVA = "0xEE51F0", Offset = "0xEE3DF0", VA = "0x180EE51F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x06016735 RID: 91957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035D5")]
		public UIItemDescFloat itemDescFloat
		{
			[Token(Token = "0x6016735")]
			[Address(RVA = "0xEE5330", Offset = "0xEE3F30", VA = "0x180EE5330")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016736 RID: 91958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016736")]
		[Address(RVA = "0xEE4E60", Offset = "0xEE3A60", VA = "0x180EE4E60")]
		public void Clean()
		{
		}

		// Token: 0x06016737 RID: 91959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016737")]
		[Address(RVA = "0xEE4EE0", Offset = "0xEE3AE0", VA = "0x180EE4EE0", Slot = "7")]
		public override void OnValueChanged(UIItemDescViewProperty property)
		{
		}

		// Token: 0x06016738 RID: 91960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016738")]
		[Address(RVA = "0xEE52C0", Offset = "0xEE3EC0", VA = "0x180EE52C0")]
		public UIItemDescFloatBinder()
		{
		}

		// Token: 0x0401B05E RID: 110686
		[Token(Token = "0x401B05E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PrefabInstHolder _descFloatHolder;

		// Token: 0x0401B05F RID: 110687
		[Token(Token = "0x401B05F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _descTextBound;

		// Token: 0x0401B060 RID: 110688
		[Token(Token = "0x401B060")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _eventCloseItemDesc;

		// Token: 0x0401B061 RID: 110689
		[Token(Token = "0x401B061")]
		[FieldOffset(Offset = "0x38")]
		private UIItemDescViewModel m_viewModelCache;

		// Token: 0x0401B062 RID: 110690
		[Token(Token = "0x401B062")]
		[FieldOffset(Offset = "0x40")]
		private UIItemDescFloat m_descFloat;

		// Token: 0x0401B063 RID: 110691
		[Token(Token = "0x401B063")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0401B064 RID: 110692
		[Token(Token = "0x401B064")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B065 RID: 110693
		[Token(Token = "0x401B065")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemDescFloat;

		// Token: 0x0401B066 RID: 110694
		[Token(Token = "0x401B066")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Clean;

		// Token: 0x0401B067 RID: 110695
		[Token(Token = "0x401B067")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401B068 RID: 110696
		[Token(Token = "0x401B068")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
