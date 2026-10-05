using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000537 RID: 1335
	[Token(Token = "0x2000537")]
	[RequireComponent(typeof(Renderer))]
	[ExecuteInEditMode]
	public class RendererSortingLayersSetter : MonoBehaviour
	{
		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06004FD2 RID: 20434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000252")]
		public Renderer renderer
		{
			[Token(Token = "0x6004FD2")]
			[Address(RVA = "0x1AF9310", Offset = "0x1AF7F10", VA = "0x181AF9310")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FD3")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public RendererSortingLayersSetter()
		{
		}

		// Token: 0x0400146D RID: 5229
		[Token(Token = "0x400146D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _sortingLayerID;

		// Token: 0x0400146E RID: 5230
		[Token(Token = "0x400146E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _sortingOrder;

		// Token: 0x0400146F RID: 5231
		[Token(Token = "0x400146F")]
		[FieldOffset(Offset = "0x20")]
		private Renderer m_renderer;
	}
}
