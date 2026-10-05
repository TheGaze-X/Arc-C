using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200012C RID: 300
	[Token(Token = "0x200012C")]
	public abstract class AbstractProgressBar : BindableElement, INotifyValueChanged<float>
	{
		// Token: 0x170001C4 RID: 452
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C4")]
		public string title
		{
			[Token(Token = "0x6000881")]
			[Address(RVA = "0x5ABF940", Offset = "0x5ABE540", VA = "0x185ABF940")]
			set
			{
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x000052E0 File Offset: 0x000034E0
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C5")]
		public float lowValue
		{
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x58BE960", Offset = "0x58BD560", VA = "0x1858BE960")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x5ABF920", Offset = "0x5ABE520", VA = "0x185ABF920")]
			set
			{
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x000052F8 File Offset: 0x000034F8
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C6")]
		public float highValue
		{
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x58BE950", Offset = "0x58BD550", VA = "0x1858BE950")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x5ABF900", Offset = "0x5ABE500", VA = "0x185ABF900")]
			set
			{
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x5ABF5B0", Offset = "0x5ABE1B0", VA = "0x185ABF5B0")]
		public AbstractProgressBar()
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x5ABF120", Offset = "0x5ABDD20", VA = "0x185ABF120")]
		private void OnGeometryChanged(GeometryChangedEvent e)
		{
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00005310 File Offset: 0x00003510
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C7")]
		public virtual float value
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x5ABF8F0", Offset = "0x5ABE4F0", VA = "0x185ABF8F0", Slot = "102")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x5ABF9A0", Offset = "0x5ABE5A0", VA = "0x185ABF9A0", Slot = "103")]
			set
			{
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x5ABF340", Offset = "0x5ABDF40", VA = "0x185ABF340", Slot = "101")]
		public void SetValueWithoutNotify(float newValue)
		{
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x5ABF170", Offset = "0x5ABDD70", VA = "0x185ABF170")]
		private void SetProgress(float p)
		{
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00005328 File Offset: 0x00003528
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x5ABF000", Offset = "0x5ABDC00", VA = "0x185ABF000")]
		private float CalculateProgressWidth(float width)
		{
			return 0f;
		}

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ussClassName;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string containerUssClassName;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string titleUssClassName;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string titleContainerUssClassName;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string progressUssClassName;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string backgroundUssClassName;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x3C0")]
		private readonly VisualElement m_Background;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x3C8")]
		private readonly VisualElement m_Progress;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x3D0")]
		private readonly Label m_Title;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x3D8")]
		private float m_LowValue;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x3DC")]
		private float m_HighValue;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x3E0")]
		private float m_Value;

		// Token: 0x0200012D RID: 301
		[Token(Token = "0x200012D")]
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x0600088E RID: 2190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x5AD4F20", Offset = "0x5AD3B20", VA = "0x185AD4F20", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x0600088F RID: 2191 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x5AD6E40", Offset = "0x5AD5A40", VA = "0x185AD6E40")]
			public UxmlTraits()
			{
			}

			// Token: 0x0400049B RID: 1179
			[Token(Token = "0x400049B")]
			[FieldOffset(Offset = "0x78")]
			private UxmlFloatAttributeDescription m_LowValue;

			// Token: 0x0400049C RID: 1180
			[Token(Token = "0x400049C")]
			[FieldOffset(Offset = "0x80")]
			private UxmlFloatAttributeDescription m_HighValue;

			// Token: 0x0400049D RID: 1181
			[Token(Token = "0x400049D")]
			[FieldOffset(Offset = "0x88")]
			private UxmlFloatAttributeDescription m_Value;

			// Token: 0x0400049E RID: 1182
			[Token(Token = "0x400049E")]
			[FieldOffset(Offset = "0x90")]
			private UxmlStringAttributeDescription m_Title;
		}
	}
}
