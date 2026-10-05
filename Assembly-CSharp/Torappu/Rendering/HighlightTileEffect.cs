using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x02002060 RID: 8288
	[Token(Token = "0x2002060")]
	public abstract class HighlightTileEffect : MonoBehaviour
	{
		// Token: 0x0600CC2D RID: 52269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC2D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public virtual void LitOn()
		{
		}

		// Token: 0x0600CC2E RID: 52270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC2E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public virtual void LitOff()
		{
		}

		// Token: 0x0600CC2F RID: 52271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC2F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public virtual void SwitchHighlightLevel(int level)
		{
		}

		// Token: 0x0600CC30 RID: 52272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC30")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public virtual void SetHighlightStrength(float strength)
		{
		}

		// Token: 0x0600CC31 RID: 52273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC31")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected HighlightTileEffect()
		{
		}
	}
}
