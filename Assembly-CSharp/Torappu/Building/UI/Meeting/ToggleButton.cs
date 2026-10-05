using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D7C RID: 7548
	[Token(Token = "0x2001D7C")]
	public class ToggleButton : MonoBehaviour
	{
		// Token: 0x14000064 RID: 100
		// (add) Token: 0x0600BA65 RID: 47717 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600BA66 RID: 47718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000064")]
		public event Action<ToggleButton> pressed
		{
			[Token(Token = "0x600BA65")]
			[Address(RVA = "0x3381C60", Offset = "0x3380860", VA = "0x183381C60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600BA66")]
			[Address(RVA = "0x3381D10", Offset = "0x3380910", VA = "0x183381D10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x0600BA67 RID: 47719 RVA: 0x00045B58 File Offset: 0x00043D58
		[Token(Token = "0x1700169B")]
		public bool on
		{
			[Token(Token = "0x600BA67")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600BA68 RID: 47720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA68")]
		[Address(RVA = "0x3381C20", Offset = "0x3380820", VA = "0x183381C20")]
		public void SetToggleState(bool on)
		{
		}

		// Token: 0x0600BA69 RID: 47721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA69")]
		[Address(RVA = "0x31BD1E0", Offset = "0x31BBDE0", VA = "0x1831BD1E0")]
		public void OnPressed()
		{
		}

		// Token: 0x0600BA6A RID: 47722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA6A")]
		[Address(RVA = "0x22F73B0", Offset = "0x22F5FB0", VA = "0x1822F73B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600BA6B RID: 47723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA6B")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ToggleButton()
		{
		}

		// Token: 0x0400B990 RID: 47504
		[Token(Token = "0x400B990")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _onPanel;

		// Token: 0x0400B991 RID: 47505
		[Token(Token = "0x400B991")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _offPanel;

		// Token: 0x0400B993 RID: 47507
		[Token(Token = "0x400B993")]
		[FieldOffset(Offset = "0x30")]
		private bool m_on;
	}
}
