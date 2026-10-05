using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E3B RID: 15931
	[Token(Token = "0x2003E3B")]
	public class SquadTabView : MonoBehaviour
	{
		// Token: 0x06018C0E RID: 101390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C0E")]
		[Address(RVA = "0x1180370", Offset = "0x117EF70", VA = "0x181180370")]
		public void Render(int index, string name, bool isSelected)
		{
		}

		// Token: 0x06018C0F RID: 101391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C0F")]
		[Address(RVA = "0x1180320", Offset = "0x117EF20", VA = "0x181180320")]
		public void EventOnTabClick()
		{
		}

		// Token: 0x06018C10 RID: 101392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C10")]
		[Address(RVA = "0x11802C0", Offset = "0x117EEC0", VA = "0x1811802C0")]
		public void EventOnReNameClick()
		{
		}

		// Token: 0x06018C11 RID: 101393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018C11")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public SquadTabView()
		{
		}

		// Token: 0x0401E6B4 RID: 124596
		[Token(Token = "0x401E6B4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x0401E6B5 RID: 124597
		[Token(Token = "0x401E6B5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x0401E6B6 RID: 124598
		[Token(Token = "0x401E6B6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _nameUnselected;

		// Token: 0x0401E6B7 RID: 124599
		[Token(Token = "0x401E6B7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SquadTabView.TabClickEvent _onTabClick;

		// Token: 0x0401E6B8 RID: 124600
		[Token(Token = "0x401E6B8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SquadTabView.TabClickEvent _onRenameClick;

		// Token: 0x0401E6B9 RID: 124601
		[Token(Token = "0x401E6B9")]
		[FieldOffset(Offset = "0x40")]
		private int m_indexCache;

		// Token: 0x02003E3C RID: 15932
		[Token(Token = "0x2003E3C")]
		[Serializable]
		public class TabClickEvent : UnityEvent<int>
		{
			// Token: 0x06018C12 RID: 101394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018C12")]
			[Address(RVA = "0x1180420", Offset = "0x117F020", VA = "0x181180420")]
			public TabClickEvent()
			{
			}
		}
	}
}
