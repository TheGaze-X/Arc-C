using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
	[Serializable]
	public sealed class GUISettings
	{
		// Token: 0x0600010F RID: 271
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x59956F0", Offset = "0x59942F0", VA = "0x1859956F0")]
		[MethodImpl(4096)]
		private static extern float Internal_GetCursorFlashSpeed();

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x1700002F")]
		public bool doubleClickSelectsWord
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x5995790", Offset = "0x5994390", VA = "0x185995790")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x17000030")]
		public bool tripleClickSelectsLine
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x59957B0", Offset = "0x59943B0", VA = "0x1859957B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x17000031")]
		public Color cursorColor
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x4889C00", Offset = "0x4888800", VA = "0x184889C00")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x17000032")]
		public float cursorFlashSpeed
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x5995750", Offset = "0x5994350", VA = "0x185995750")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x17000033")]
		public Color selectionColor
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x59957A0", Offset = "0x59943A0", VA = "0x1859957A0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x5995720", Offset = "0x5994320", VA = "0x185995720")]
		public GUISettings()
		{
		}

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_DoubleClickSelectsWord;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool m_TripleClickSelectsLine;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Color m_CursorColor;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_CursorFlashSpeed;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color m_SelectionColor;
	}
}
