using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	[AddComponentMenu("UI Toolkit/Panel Raycaster (UI Toolkit)")]
	public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent
	{
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A2")]
		public IPanel panel
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "23")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x5B8D1A0", Offset = "0x5B8BDA0", VA = "0x185B8D1A0", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x5B8D010", Offset = "0x5B8BC10", VA = "0x185B8D010")]
		private void RegisterCallbacks()
		{
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x5B8D0A0", Offset = "0x5B8BCA0", VA = "0x185B8D0A0")]
		private void UnregisterCallbacks()
		{
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x5B8C9B0", Offset = "0x5B8B5B0", VA = "0x185B8C9B0")]
		private void OnPanelDestroyed()
		{
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A3")]
		private GameObject selectableGameObject
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x5B8D160", Offset = "0x5B8BD60", VA = "0x185B8D160")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00004788 File Offset: 0x00002988
		[Token(Token = "0x170001A4")]
		public override int sortOrderPriority
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x5B8D180", Offset = "0x5B8BD80", VA = "0x185B8D180", Slot = "20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x170001A5")]
		public override int renderOrderPriority
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x5B8D130", Offset = "0x5B8BD30", VA = "0x185B8D130", Slot = "21")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x5B8C9C0", Offset = "0x5B8B5C0", VA = "0x185B8C9C0", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A6")]
		public override Camera eventCamera
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x4CA5DA0", Offset = "0x4CA49A0", VA = "0x184CA5DA0")]
		private static int ConvertFloatBitsToInt(float f)
		{
			return 0;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public PanelRaycaster()
		{
		}

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BaseRuntimePanel m_Panel;

		// Token: 0x020000A7 RID: 167
		[Token(Token = "0x20000A7")]
		[StructLayout(2)]
		private struct FloatIntBits
		{
			// Token: 0x04000302 RID: 770
			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float f;

			// Token: 0x04000303 RID: 771
			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;
		}
	}
}
