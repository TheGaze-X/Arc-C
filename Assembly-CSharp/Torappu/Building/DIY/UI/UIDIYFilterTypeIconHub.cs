using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019D7 RID: 6615
	[Token(Token = "0x20019D7")]
	public class UIDIYFilterTypeIconHub : MonoISpriteHub
	{
		// Token: 0x0600A636 RID: 42550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A636")]
		[Address(RVA = "0x3227EC0", Offset = "0x3226AC0", VA = "0x183227EC0")]
		public Sprite GetIcon(DIYFilterType filterType)
		{
			return null;
		}

		// Token: 0x0600A637 RID: 42551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A637")]
		[Address(RVA = "0x3227E50", Offset = "0x3226A50", VA = "0x183227E50")]
		public Sprite GetIconLight(DIYFilterType filterType)
		{
			return null;
		}

		// Token: 0x0600A638 RID: 42552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A638")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public UIDIYFilterTypeIconHub()
		{
		}

		// Token: 0x04009E24 RID: 40484
		[Token(Token = "0x4009E24")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIDIYFilterTypeIconHub.Entry[] _entries;

		// Token: 0x04009E25 RID: 40485
		[Token(Token = "0x4009E25")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _defaultIcon;

		// Token: 0x020019D8 RID: 6616
		[Token(Token = "0x20019D8")]
		[Serializable]
		public class Entry
		{
			// Token: 0x0600A639 RID: 42553 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A639")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Entry()
			{
			}

			// Token: 0x04009E26 RID: 40486
			[Token(Token = "0x4009E26")]
			[FieldOffset(Offset = "0x10")]
			public DIYFilterType filterType;

			// Token: 0x04009E27 RID: 40487
			[Token(Token = "0x4009E27")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;

			// Token: 0x04009E28 RID: 40488
			[Token(Token = "0x4009E28")]
			[FieldOffset(Offset = "0x20")]
			public Sprite iconLight;
		}
	}
}
