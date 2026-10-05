using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063C4 RID: 25540
	[Token(Token = "0x20063C4")]
	[RequireComponent(typeof(TwoStateToggle))]
	public class AutoChessCharSelectFilterItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x14000090 RID: 144
		// (add) Token: 0x06024D32 RID: 150834 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06024D33 RID: 150835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000090")]
		public event Action<ProfessionCategory, bool> onItemClick
		{
			[Token(Token = "0x6024D32")]
			[Address(RVA = "0x1FB92D0", Offset = "0x1FB7ED0", VA = "0x181FB92D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6024D33")]
			[Address(RVA = "0x1FB93D0", Offset = "0x1FB7FD0", VA = "0x181FB93D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06024D34 RID: 150836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D34")]
		[Address(RVA = "0x1FB9040", Offset = "0x1FB7C40", VA = "0x181FB9040")]
		public void Render(ProfessionCategory filter)
		{
		}

		// Token: 0x06024D35 RID: 150837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D35")]
		[Address(RVA = "0x1FB9190", Offset = "0x1FB7D90", VA = "0x181FB9190")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024D36 RID: 150838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D36")]
		[Address(RVA = "0x1FB8FC0", Offset = "0x1FB7BC0", VA = "0x181FB8FC0")]
		public void EventOnClick()
		{
		}

		// Token: 0x06024D37 RID: 150839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D37")]
		[Address(RVA = "0x1FB9270", Offset = "0x1FB7E70", VA = "0x181FB9270")]
		public AutoChessCharSelectFilterItem()
		{
		}

		// Token: 0x040337BE RID: 210878
		[Token(Token = "0x40337BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ProfessionCategory _filter;

		// Token: 0x040337BF RID: 210879
		[Token(Token = "0x40337BF")]
		[FieldOffset(Offset = "0x20")]
		private TwoStateToggle m_toggle;

		// Token: 0x040337C0 RID: 210880
		[Token(Token = "0x40337C0")]
		[FieldOffset(Offset = "0x28")]
		private ProfessionCategory m_filter;

		// Token: 0x040337C2 RID: 210882
		[Token(Token = "0x40337C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_onItemClick;

		// Token: 0x040337C3 RID: 210883
		[Token(Token = "0x40337C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_onItemClick;

		// Token: 0x040337C4 RID: 210884
		[Token(Token = "0x40337C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040337C5 RID: 210885
		[Token(Token = "0x40337C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040337C6 RID: 210886
		[Token(Token = "0x40337C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x040337C7 RID: 210887
		[Token(Token = "0x40337C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
