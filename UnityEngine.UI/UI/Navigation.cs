using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[Serializable]
	public struct Navigation : IEquatable<Navigation>
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00003660 File Offset: 0x00001860
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000EB")]
		public Navigation.Mode mode
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			get
			{
				return Navigation.Mode.None;
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			set
			{
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00003678 File Offset: 0x00001878
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000EC")]
		public bool wrapAround
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x33E8C90", Offset = "0x33E7890", VA = "0x1833E8C90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x33E8CA0", Offset = "0x33E78A0", VA = "0x1833E8CA0")]
			set
			{
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000ED")]
		public Selectable selectOnUp
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
			set
			{
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000EE")]
		public Selectable selectOnDown
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000EF")]
		public Selectable selectOnLeft
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F0")]
		public Selectable selectOnRight
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x170000F1")]
		public static Navigation defaultNavigation
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x5B6C1A0", Offset = "0x5B6ADA0", VA = "0x185B6C1A0")]
			get
			{
				return default(Navigation);
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x5B6C090", Offset = "0x5B6AC90", VA = "0x185B6C090", Slot = "4")]
		public bool Equals(Navigation other)
		{
			return default(bool);
		}

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Navigation.Mode m_Mode;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[Tooltip("Enables navigation to wrap around from last to first or first to last element. Does not work for automatic grid navigation")]
		private bool m_WrapAround;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Selectable m_SelectOnUp;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Selectable m_SelectOnDown;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Selectable m_SelectOnLeft;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Selectable m_SelectOnRight;

		// Token: 0x0200005B RID: 91
		[Token(Token = "0x200005B")]
		[Flags]
		public enum Mode
		{
			// Token: 0x040001B8 RID: 440
			[Token(Token = "0x40001B8")]
			None = 0,
			// Token: 0x040001B9 RID: 441
			[Token(Token = "0x40001B9")]
			Horizontal = 1,
			// Token: 0x040001BA RID: 442
			[Token(Token = "0x40001BA")]
			Vertical = 2,
			// Token: 0x040001BB RID: 443
			[Token(Token = "0x40001BB")]
			Automatic = 3,
			// Token: 0x040001BC RID: 444
			[Token(Token = "0x40001BC")]
			Explicit = 4
		}
	}
}
