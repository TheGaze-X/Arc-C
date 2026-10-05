using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BF8 RID: 7160
	[Token(Token = "0x2001BF8")]
	public class WorkshopSortButton : MonoBehaviour
	{
		// Token: 0x1400005C RID: 92
		// (add) Token: 0x0600B28E RID: 45710 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600B28F RID: 45711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400005C")]
		public event Action<WorkshopSortButton> onButtonPressed
		{
			[Token(Token = "0x600B28E")]
			[Address(RVA = "0x32EB8D0", Offset = "0x32EA4D0", VA = "0x1832EB8D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600B28F")]
			[Address(RVA = "0x32EB980", Offset = "0x32EA580", VA = "0x1832EB980")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600B290 RID: 45712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B290")]
		[Address(RVA = "0x31E2D30", Offset = "0x31E1930", VA = "0x1831E2D30")]
		public void SetState(WorkshopSortButton.State state)
		{
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x0600B291 RID: 45713 RVA: 0x000440E8 File Offset: 0x000422E8
		[Token(Token = "0x17001558")]
		public WorkshopSortButton.State currentState
		{
			[Token(Token = "0x600B291")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return WorkshopSortButton.State.INACTIVE;
			}
		}

		// Token: 0x0600B292 RID: 45714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B292")]
		[Address(RVA = "0x31E2D10", Offset = "0x31E1910", VA = "0x1831E2D10")]
		public void OnButtonPressed()
		{
		}

		// Token: 0x0600B293 RID: 45715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B293")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public WorkshopSortButton()
		{
		}

		// Token: 0x0400ADB1 RID: 44465
		[Token(Token = "0x400ADB1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _inactiveObjects;

		// Token: 0x0400ADB2 RID: 44466
		[Token(Token = "0x400ADB2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _ascentObjects;

		// Token: 0x0400ADB3 RID: 44467
		[Token(Token = "0x400ADB3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _descentObjects;

		// Token: 0x0400ADB5 RID: 44469
		[Token(Token = "0x400ADB5")]
		[FieldOffset(Offset = "0x38")]
		private WorkshopSortButton.State m_currentState;

		// Token: 0x02001BF9 RID: 7161
		[Token(Token = "0x2001BF9")]
		public enum State
		{
			// Token: 0x0400ADB7 RID: 44471
			[Token(Token = "0x400ADB7")]
			INACTIVE,
			// Token: 0x0400ADB8 RID: 44472
			[Token(Token = "0x400ADB8")]
			ASCENT,
			// Token: 0x0400ADB9 RID: 44473
			[Token(Token = "0x400ADB9")]
			DESCENT
		}
	}
}
