using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView.Internal
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	public class ViewportMaterialView : MonoBehaviour
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public virtual Material Material
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x5BD4870", Offset = "0x5BD3470", VA = "0x185BD4870", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x5BD4920", Offset = "0x5BD3520", VA = "0x185BD4920", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		public virtual Texture Texture
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x5BD48C0", Offset = "0x5BD34C0", VA = "0x185BD48C0", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x5BD4980", Offset = "0x5BD3580", VA = "0x185BD4980", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x5BD45C0", Offset = "0x5BD31C0", VA = "0x185BD45C0")]
		public void SetFallbackVideoRect(Rect rect)
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x5BD46D0", Offset = "0x5BD32D0", VA = "0x185BD46D0")]
		public void SetFallbackVideoTexture(Texture2D texture)
		{
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x5BD4750", Offset = "0x5BD3350", VA = "0x185BD4750")]
		public void SetRenderBlackAsTransparent(bool enabled)
		{
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x5BD4500", Offset = "0x5BD3100", VA = "0x185BD4500")]
		protected void Awake()
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x5BD47E0", Offset = "0x5BD33E0", VA = "0x185BD47E0")]
		private Vector4 _toVector(Rect rect)
		{
			return default(Vector4);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("ViewportMaterialView.SetCutoutRect() has been replaced with ViewportMaterialView.SetRenderBlackAsTransparent(). Please call SetRenderBlackAsTransparent(true) instead.", true)]
		public void SetCutoutRect(Rect rect)
		{
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ViewportMaterialView()
		{
		}
	}
}
