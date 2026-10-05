using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D7D RID: 7549
	[Token(Token = "0x2001D7D")]
	public class ToggleButtonGroup : MonoBehaviour
	{
		// Token: 0x14000065 RID: 101
		// (add) Token: 0x0600BA6C RID: 47724 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600BA6D RID: 47725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000065")]
		public event Action<int> togglePressed
		{
			[Token(Token = "0x600BA6C")]
			[Address(RVA = "0x3381A60", Offset = "0x3380660", VA = "0x183381A60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600BA6D")]
			[Address(RVA = "0x3381B70", Offset = "0x3380770", VA = "0x183381B70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600BA6E RID: 47726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA6E")]
		[Address(RVA = "0x3381980", Offset = "0x3380580", VA = "0x183381980")]
		private void _OnTogglePressed(ToggleButton button)
		{
		}

		// Token: 0x0600BA6F RID: 47727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA6F")]
		[Address(RVA = "0x3381610", Offset = "0x3380210", VA = "0x183381610")]
		private void Awake()
		{
		}

		// Token: 0x0600BA70 RID: 47728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA70")]
		[Address(RVA = "0x33818D0", Offset = "0x33804D0", VA = "0x1833818D0")]
		public void SetToggleIndex(int index)
		{
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x0600BA71 RID: 47729 RVA: 0x00045B70 File Offset: 0x00043D70
		[Token(Token = "0x1700169C")]
		public int toggleIndex
		{
			[Token(Token = "0x600BA71")]
			[Address(RVA = "0x3381B10", Offset = "0x3380710", VA = "0x183381B10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600BA72 RID: 47730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA72")]
		[Address(RVA = "0x33817F0", Offset = "0x33803F0", VA = "0x1833817F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600BA73 RID: 47731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA73")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ToggleButtonGroup()
		{
		}

		// Token: 0x0400B994 RID: 47508
		[Token(Token = "0x400B994")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ToggleButton[] _toggles;
	}
}
