using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001957 RID: 6487
	[Token(Token = "0x2001957")]
	public class DIYSortButton : MonoBehaviour
	{
		// Token: 0x14000049 RID: 73
		// (add) Token: 0x0600A31B RID: 41755 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A31C RID: 41756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000049")]
		public event Action<DIYSortButton> onButtonPressed
		{
			[Token(Token = "0x600A31B")]
			[Address(RVA = "0x31E2E60", Offset = "0x31E1A60", VA = "0x1831E2E60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A31C")]
			[Address(RVA = "0x31E2F10", Offset = "0x31E1B10", VA = "0x1831E2F10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600A31D RID: 41757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A31D")]
		[Address(RVA = "0x31E2D30", Offset = "0x31E1930", VA = "0x1831E2D30")]
		public void SetState(DIYSortButton.State state)
		{
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x0600A31E RID: 41758 RVA: 0x0003F6C0 File Offset: 0x0003D8C0
		[Token(Token = "0x170012E5")]
		public DIYSortButton.State currentState
		{
			[Token(Token = "0x600A31E")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return DIYSortButton.State.INACTIVE;
			}
		}

		// Token: 0x0600A31F RID: 41759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A31F")]
		[Address(RVA = "0x31E2D10", Offset = "0x31E1910", VA = "0x1831E2D10")]
		public void OnButtonPressed()
		{
		}

		// Token: 0x0600A320 RID: 41760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A320")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public DIYSortButton()
		{
		}

		// Token: 0x04009995 RID: 39317
		[Token(Token = "0x4009995")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _inactiveObjects;

		// Token: 0x04009996 RID: 39318
		[Token(Token = "0x4009996")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _ascentObjects;

		// Token: 0x04009997 RID: 39319
		[Token(Token = "0x4009997")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _descentObjects;

		// Token: 0x04009999 RID: 39321
		[Token(Token = "0x4009999")]
		[FieldOffset(Offset = "0x38")]
		private DIYSortButton.State m_currentState;

		// Token: 0x02001958 RID: 6488
		[Token(Token = "0x2001958")]
		public enum State
		{
			// Token: 0x0400999B RID: 39323
			[Token(Token = "0x400999B")]
			INACTIVE,
			// Token: 0x0400999C RID: 39324
			[Token(Token = "0x400999C")]
			ASCENT,
			// Token: 0x0400999D RID: 39325
			[Token(Token = "0x400999D")]
			DESCENT
		}
	}
}
