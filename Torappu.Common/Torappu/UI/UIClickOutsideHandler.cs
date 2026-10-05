using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Torappu.UI
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	[Obsolete("Try to use ClickThrough")]
	[RequireComponent(typeof(RectTransform))]
	public class UIClickOutsideHandler : MonoBehaviour, IHotfixable
	{
		// Token: 0x06000939 RID: 2361 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x555EB90", Offset = "0x555D790", VA = "0x18555EB90")]
		private void Update()
		{
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x555EA00", Offset = "0x555D600", VA = "0x18555EA00")]
		private void OnEnable()
		{
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x555E970", Offset = "0x555D570", VA = "0x18555E970")]
		private void OnDisable()
		{
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x555E970", Offset = "0x555D570", VA = "0x18555E970")]
		private void _Clear()
		{
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x555EDC0", Offset = "0x555D9C0", VA = "0x18555EDC0")]
		private List<RaycastResult> _CalcPointerOverResult(Vector2 position, List<RaycastResult> results)
		{
			return null;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0000740C File Offset: 0x0000560C
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x555EF50", Offset = "0x555DB50", VA = "0x18555EF50")]
		private bool _IsPointerOverSelfOrChildren(List<RaycastResult> pointerResults)
		{
			return default(bool);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x555EA00", Offset = "0x555D600", VA = "0x18555EA00")]
		private void _SyncGraphicList()
		{
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x555F130", Offset = "0x555DD30", VA = "0x18555F130")]
		public UIClickOutsideHandler()
		{
		}

		// Token: 0x040008A2 RID: 2210
		[Token(Token = "0x40008A2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _NoneAsOut;

		// Token: 0x040008A3 RID: 2211
		[Token(Token = "0x40008A3")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent onClickOutside;

		// Token: 0x040008A4 RID: 2212
		[Token(Token = "0x40008A4")]
		[FieldOffset(Offset = "0x28")]
		private PointerEventData m_eventData;

		// Token: 0x040008A5 RID: 2213
		[Token(Token = "0x40008A5")]
		[FieldOffset(Offset = "0x30")]
		private List<RaycastResult> m_results;

		// Token: 0x040008A6 RID: 2214
		[Token(Token = "0x40008A6")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<GameObject> m_graphicObjects;
	}
}
