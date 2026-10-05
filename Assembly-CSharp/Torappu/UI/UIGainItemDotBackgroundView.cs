using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003934 RID: 14644
	[Token(Token = "0x2003934")]
	[RequireComponent(typeof(Image))]
	public class UIGainItemDotBackgroundView : MonoBehaviour
	{
		// Token: 0x06017252 RID: 94802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017252")]
		[Address(RVA = "0xF92830", Offset = "0xF91430", VA = "0x180F92830")]
		private void Start()
		{
		}

		// Token: 0x06017253 RID: 94803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017253")]
		[Address(RVA = "0xF92950", Offset = "0xF91550", VA = "0x180F92950")]
		private void Update()
		{
		}

		// Token: 0x06017254 RID: 94804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017254")]
		[Address(RVA = "0xF92790", Offset = "0xF91390", VA = "0x180F92790")]
		private void OnDestroy()
		{
		}

		// Token: 0x06017255 RID: 94805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017255")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIGainItemDotBackgroundView()
		{
		}

		// Token: 0x0401BF05 RID: 114437
		[Token(Token = "0x401BF05")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _tintColor;

		// Token: 0x0401BF06 RID: 114438
		[Token(Token = "0x401BF06")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _dissolveAmount;

		// Token: 0x0401BF07 RID: 114439
		[Token(Token = "0x401BF07")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector4 _dissolveTexST;

		// Token: 0x0401BF08 RID: 114440
		[Token(Token = "0x401BF08")]
		[FieldOffset(Offset = "0x40")]
		private Image m_image;

		// Token: 0x0401BF09 RID: 114441
		[Token(Token = "0x401BF09")]
		[FieldOffset(Offset = "0x48")]
		private Material m_material;

		// Token: 0x02003935 RID: 14645
		[Token(Token = "0x2003935")]
		internal static class Ids
		{
			// Token: 0x0401BF0A RID: 114442
			[Token(Token = "0x401BF0A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int AMOUNT_ID;

			// Token: 0x0401BF0B RID: 114443
			[Token(Token = "0x401BF0B")]
			[FieldOffset(Offset = "0x4")]
			public static readonly int DISSOLVE_TEX_ST_ID;

			// Token: 0x0401BF0C RID: 114444
			[Token(Token = "0x401BF0C")]
			[FieldOffset(Offset = "0x8")]
			public static readonly int TINT_COLOR_ID;
		}
	}
}
