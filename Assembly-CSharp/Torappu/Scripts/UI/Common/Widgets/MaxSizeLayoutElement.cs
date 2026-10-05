using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Scripts.UI.Common.Widgets
{
	// Token: 0x020017B6 RID: 6070
	[Token(Token = "0x20017B6")]
	[RequireComponent(typeof(RectTransform))]
	[Serializable]
	public class MaxSizeLayoutElement : LayoutElement
	{
		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x0600996F RID: 39279 RVA: 0x0003BA00 File Offset: 0x00039C00
		// (set) Token: 0x06009970 RID: 39280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700107F")]
		public override int layoutPriority
		{
			[Token(Token = "0x600996F")]
			[Address(RVA = "0x3147310", Offset = "0x3145F10", VA = "0x183147310", Slot = "43")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6009970")]
			[Address(RVA = "0x3147420", Offset = "0x3146020", VA = "0x183147420", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x06009971 RID: 39281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009971")]
		[Address(RVA = "0x3147280", Offset = "0x3145E80", VA = "0x183147280", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06009972 RID: 39282 RVA: 0x0003BA18 File Offset: 0x00039C18
		// (set) Token: 0x06009973 RID: 39283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001080")]
		public override float preferredHeight
		{
			[Token(Token = "0x6009972")]
			[Address(RVA = "0x3147320", Offset = "0x3145F20", VA = "0x183147320", Slot = "37")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6009973")]
			[Address(RVA = "0x3147430", Offset = "0x3146030", VA = "0x183147430", Slot = "38")]
			set
			{
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06009974 RID: 39284 RVA: 0x0003BA30 File Offset: 0x00039C30
		// (set) Token: 0x06009975 RID: 39285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001081")]
		public override float preferredWidth
		{
			[Token(Token = "0x6009974")]
			[Address(RVA = "0x31473A0", Offset = "0x3145FA0", VA = "0x1831473A0", Slot = "35")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6009975")]
			[Address(RVA = "0x3147440", Offset = "0x3146040", VA = "0x183147440", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x06009976 RID: 39286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009976")]
		[Address(RVA = "0x3147300", Offset = "0x3145F00", VA = "0x183147300")]
		public MaxSizeLayoutElement()
		{
		}

		// Token: 0x04008FA0 RID: 36768
		[Token(Token = "0x4008FA0")]
		[FieldOffset(Offset = "0x38")]
		public bool useMaxHeight;

		// Token: 0x04008FA1 RID: 36769
		[Token(Token = "0x4008FA1")]
		[FieldOffset(Offset = "0x3C")]
		public float maxHeight;

		// Token: 0x04008FA2 RID: 36770
		[Token(Token = "0x4008FA2")]
		[FieldOffset(Offset = "0x40")]
		public bool useMaxWidth;

		// Token: 0x04008FA3 RID: 36771
		[Token(Token = "0x4008FA3")]
		[FieldOffset(Offset = "0x44")]
		public float maxWidth;

		// Token: 0x04008FA4 RID: 36772
		[Token(Token = "0x4008FA4")]
		[FieldOffset(Offset = "0x48")]
		private bool m_ignoreOnGettingPreferedSize;

		// Token: 0x04008FA5 RID: 36773
		[Token(Token = "0x4008FA5")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform m_rectTransform;
	}
}
