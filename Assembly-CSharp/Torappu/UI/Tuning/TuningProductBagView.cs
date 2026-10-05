using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CF9 RID: 15609
	[Token(Token = "0x2003CF9")]
	public class TuningProductBagView : DataBinder<TuningProductBagProperty>
	{
		// Token: 0x0601856C RID: 99692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601856C")]
		[Address(RVA = "0x10DF0E0", Offset = "0x10DDCE0", VA = "0x1810DF0E0", Slot = "7")]
		public override void OnValueChanged(TuningProductBagProperty property)
		{
		}

		// Token: 0x0601856D RID: 99693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601856D")]
		[Address(RVA = "0x10DF2F0", Offset = "0x10DDEF0", VA = "0x1810DF2F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601856E RID: 99694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601856E")]
		[Address(RVA = "0x10DF420", Offset = "0x10DE020", VA = "0x1810DF420")]
		public TuningProductBagView()
		{
		}

		// Token: 0x0401DBF2 RID: 121842
		[Token(Token = "0x401DBF2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TuningProductBagPanelView _viewPrefab;

		// Token: 0x0401DBF3 RID: 121843
		[Token(Token = "0x401DBF3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _viewHolder;

		// Token: 0x0401DBF4 RID: 121844
		[Token(Token = "0x401DBF4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _bagDeco;

		// Token: 0x0401DBF5 RID: 121845
		[Token(Token = "0x401DBF5")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401DBF6 RID: 121846
		[Token(Token = "0x401DBF6")]
		[FieldOffset(Offset = "0x40")]
		private TuningProductBagPanelView m_view;

		// Token: 0x0401DBF7 RID: 121847
		[Token(Token = "0x401DBF7")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<string> onSelectProductType;

		// Token: 0x0401DBF8 RID: 121848
		[Token(Token = "0x401DBF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401DBF9 RID: 121849
		[Token(Token = "0x401DBF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DBFA RID: 121850
		[Token(Token = "0x401DBFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
