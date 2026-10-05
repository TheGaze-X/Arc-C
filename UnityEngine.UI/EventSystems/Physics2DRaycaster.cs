using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Event/Physics 2D Raycaster")]
	public class Physics2DRaycaster : PhysicsRaycaster
	{
		// Token: 0x060007BC RID: 1980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x5B8DC00", Offset = "0x5B8C800", VA = "0x185B8DC00")]
		protected Physics2DRaycaster()
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x5B8D360", Offset = "0x5B8BF60", VA = "0x185B8D360", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x40")]
		private RaycastHit2D[] m_Hits;
	}
}
