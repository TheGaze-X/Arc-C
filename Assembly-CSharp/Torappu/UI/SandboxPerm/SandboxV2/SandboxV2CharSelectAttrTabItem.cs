using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004031 RID: 16433
	[Token(Token = "0x2004031")]
	public class SandboxV2CharSelectAttrTabItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060196F1 RID: 104177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196F1")]
		[Address(RVA = "0x121D680", Offset = "0x121C280", VA = "0x18121D680")]
		public void Render(SandboxV2CharSelectTabEnum attryTabType)
		{
		}

		// Token: 0x060196F2 RID: 104178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196F2")]
		[Address(RVA = "0x121D770", Offset = "0x121C370", VA = "0x18121D770")]
		private void _OnToggle(TwoStateToggle.State state)
		{
		}

		// Token: 0x17003C95 RID: 15509
		// (get) Token: 0x060196F3 RID: 104179 RVA: 0x0009E028 File Offset: 0x0009C228
		[Token(Token = "0x17003C95")]
		public SandboxV2CharSelectTabEnum attrTabType
		{
			[Token(Token = "0x60196F3")]
			[Address(RVA = "0x121D8F0", Offset = "0x121C4F0", VA = "0x18121D8F0")]
			get
			{
				return SandboxV2CharSelectTabEnum.FOOD;
			}
		}

		// Token: 0x060196F4 RID: 104180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196F4")]
		[Address(RVA = "0x121D890", Offset = "0x121C490", VA = "0x18121D890")]
		public SandboxV2CharSelectAttrTabItem()
		{
		}

		// Token: 0x0401FACE RID: 129742
		[Token(Token = "0x401FACE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2CharSelectTabEnum _tabType;

		// Token: 0x0401FACF RID: 129743
		[Token(Token = "0x401FACF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2CharSelectAttrTabItem.CharAttrTabTypeMessage _onSortTypeChanged;

		// Token: 0x0401FAD0 RID: 129744
		[Token(Token = "0x401FAD0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _twoStateToggle;

		// Token: 0x0401FAD1 RID: 129745
		[Token(Token = "0x401FAD1")]
		[FieldOffset(Offset = "0x30")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401FAD2 RID: 129746
		[Token(Token = "0x401FAD2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401FAD3 RID: 129747
		[Token(Token = "0x401FAD3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnToggle;

		// Token: 0x0401FAD4 RID: 129748
		[Token(Token = "0x401FAD4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_attrTabType;

		// Token: 0x0401FAD5 RID: 129749
		[Token(Token = "0x401FAD5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004032 RID: 16434
		[Token(Token = "0x2004032")]
		[Serializable]
		public class CharAttrTabTypeMessage : UnityEvent<SandboxV2CharSelectTabEnum>
		{
			// Token: 0x060196F5 RID: 104181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60196F5")]
			[Address(RVA = "0x1213410", Offset = "0x1212010", VA = "0x181213410")]
			public CharAttrTabTypeMessage()
			{
			}
		}
	}
}
