using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("")]
	public class ImageEffectBase : MonoBehaviour
	{
		// Token: 0x06000217 RID: 535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x51E34F0", Offset = "0x51E20F0", VA = "0x1851E34F0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		protected Material material
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x51E3590", Offset = "0x51E2190", VA = "0x1851E3590")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x51E3470", Offset = "0x51E2070", VA = "0x1851E3470", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ImageEffectBase()
		{
		}

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x18")]
		public Shader shader;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;
	}
}
