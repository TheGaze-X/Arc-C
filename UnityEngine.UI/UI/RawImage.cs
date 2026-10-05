using System;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	[RequireComponent(typeof(CanvasRenderer))]
	[AddComponentMenu("UI/Raw Image", 12)]
	public class RawImage : MaskableGraphic
	{
		// Token: 0x06000394 RID: 916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x5B6C860", Offset = "0x5B6B460", VA = "0x185B6C860")]
		protected RawImage()
		{
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F2")]
		public override Texture mainTexture
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x5B6C8C0", Offset = "0x5B6B4C0", VA = "0x185B6C8C0", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F3")]
		public Texture texture
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x4D6C490", Offset = "0x4D6B090", VA = "0x184D6C490")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x5B6CA50", Offset = "0x5B6B650", VA = "0x185B6CA50")]
			set
			{
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000398 RID: 920 RVA: 0x000036C0 File Offset: 0x000018C0
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F4")]
		public Rect uvRect
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x5A21EF0", Offset = "0x5A20AF0", VA = "0x185A21EF0")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x5B6CB30", Offset = "0x5B6B730", VA = "0x185B6CB30")]
			set
			{
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x5B6C690", Offset = "0x5B6B290", VA = "0x185B6C690", Slot = "47")]
		public override void SetNativeSize()
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x5B6C1C0", Offset = "0x5B6ADC0", VA = "0x185B6C1C0", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x5A1F770", Offset = "0x5A1E370", VA = "0x185A1F770", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0xE8")]
		[FormerlySerializedAs("m_Tex")]
		[SerializeField]
		private Texture m_Texture;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Rect m_UVRect;
	}
}
