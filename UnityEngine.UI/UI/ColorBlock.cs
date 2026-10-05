using System;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[Serializable]
	public struct ColorBlock : IEquatable<ColorBlock>
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002148 File Offset: 0x00000348
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000B")]
		public Color normalColor
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x253ECA0", Offset = "0x253D8A0", VA = "0x18253ECA0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x453ADB0", Offset = "0x45399B0", VA = "0x18453ADB0")]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000C")]
		public Color highlightedColor
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x4E6DD0", Offset = "0x4E59D0", VA = "0x1804E6DD0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x4E6EA0", Offset = "0x4E5AA0", VA = "0x1804E6EA0")]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002178 File Offset: 0x00000378
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000D")]
		public Color pressedColor
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xF10AF0", Offset = "0xF0F6F0", VA = "0x180F10AF0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x4A9EF00", Offset = "0x4A9DB00", VA = "0x184A9EF00")]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002190 File Offset: 0x00000390
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000E")]
		public Color selectedColor
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x4ED6A0", Offset = "0x4EC2A0", VA = "0x1804ED6A0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x4EEA20", Offset = "0x4ED620", VA = "0x1804EEA20")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000021A8 File Offset: 0x000003A8
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000F")]
		public Color disabledColor
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x312CBB0", Offset = "0x312B7B0", VA = "0x18312CBB0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x312CBA0", Offset = "0x312B7A0", VA = "0x18312CBA0")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000021C0 File Offset: 0x000003C0
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000010")]
		public float colorMultiplier
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x1251100", Offset = "0x124FD00", VA = "0x181251100")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x1692870", Offset = "0x1691470", VA = "0x181692870")]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000021D8 File Offset: 0x000003D8
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000011")]
		public float fadeDuration
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1E29290", Offset = "0x1E27E90", VA = "0x181E29290")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x4E48A80", Offset = "0x4E47680", VA = "0x184E48A80")]
			set
			{
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x5A08C80", Offset = "0x5A07880", VA = "0x185A08C80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x5A08D70", Offset = "0x5A07970", VA = "0x185A08D70", Slot = "4")]
		public bool Equals(ColorBlock other)
		{
			return default(bool);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x5A09430", Offset = "0x5A08030", VA = "0x185A09430")]
		public static bool operator ==(ColorBlock point1, ColorBlock point2)
		{
			return default(bool);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x5A094D0", Offset = "0x5A080D0", VA = "0x185A094D0")]
		public static bool operator !=(ColorBlock point1, ColorBlock point2)
		{
			return default(bool);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x5A09070", Offset = "0x5A07C70", VA = "0x185A09070", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x0")]
		[FormerlySerializedAs("normalColor")]
		[SerializeField]
		private Color m_NormalColor;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[FormerlySerializedAs("highlightedColor")]
		private Color m_HighlightedColor;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("pressedColor")]
		private Color m_PressedColor;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("m_HighlightedColor")]
		private Color m_SelectedColor;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("disabledColor")]
		[SerializeField]
		private Color m_DisabledColor;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Range(1f, 5f)]
		private float m_ColorMultiplier;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x54")]
		[FormerlySerializedAs("fadeDuration")]
		[SerializeField]
		private float m_FadeDuration;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x0")]
		public static ColorBlock defaultColorBlock;
	}
}
