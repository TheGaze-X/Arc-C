using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Fx
{
	// Token: 0x02002034 RID: 8244
	[Token(Token = "0x2002034")]
	[RequireComponent(typeof(Renderer))]
	public class FXInitBaseline : MonoBehaviour
	{
		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x0600CB27 RID: 52007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700180B")]
		private MaterialPropertyBlock PropertyBlock
		{
			[Token(Token = "0x600CB27")]
			[Address(RVA = "0x34C0480", Offset = "0x34BF080", VA = "0x1834C0480")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CB28 RID: 52008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB28")]
		[Address(RVA = "0x34C0360", Offset = "0x34BEF60", VA = "0x1834C0360")]
		private void Awake()
		{
		}

		// Token: 0x0600CB29 RID: 52009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB29")]
		[Address(RVA = "0x34C03B0", Offset = "0x34BEFB0", VA = "0x1834C03B0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600CB2A RID: 52010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB2A")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public FXInitBaseline()
		{
		}

		// Token: 0x0400D51D RID: 54557
		[Token(Token = "0x400D51D")]
		[FieldOffset(Offset = "0x18")]
		public Transform _host;

		// Token: 0x0400D51E RID: 54558
		[Token(Token = "0x400D51E")]
		[FieldOffset(Offset = "0x20")]
		private MaterialPropertyBlock m_propertyBlock;

		// Token: 0x0400D51F RID: 54559
		[Token(Token = "0x400D51F")]
		[FieldOffset(Offset = "0x28")]
		private Renderer m_renderer;
	}
}
