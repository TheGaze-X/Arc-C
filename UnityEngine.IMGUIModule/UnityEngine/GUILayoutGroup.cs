using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	[VisibleToOtherModules(new string[]
	{
		"UnityEngine.UIElementsModule",
		"Unity.UIElements"
	})]
	internal class GUILayoutGroup : GUILayoutEntry
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x17000083")]
		public override int marginLeft
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x21E8010", Offset = "0x21E6C10", VA = "0x1821E8010", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x17000084")]
		public override int marginRight
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x9069A0", Offset = "0x9055A0", VA = "0x1809069A0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x17000085")]
		public override int marginTop
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x12905A0", Offset = "0x128F1A0", VA = "0x1812905A0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x17000086")]
		public override int marginBottom
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x524DE50", Offset = "0x524CA50", VA = "0x18524DE50", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x59ABD70", Offset = "0x59AA970", VA = "0x1859ABD70")]
		public GUILayoutGroup()
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x59A95F0", Offset = "0x59A81F0", VA = "0x1859A95F0", Slot = "13")]
		public override void ApplyOptions(GUILayoutOption[] options)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x59A9710", Offset = "0x59A8310", VA = "0x1859A9710", Slot = "12")]
		protected override void ApplyStyleSettings(GUIStyle style)
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x59AA870", Offset = "0x59A9470", VA = "0x1859AA870")]
		public void ResetCursor()
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x59AA550", Offset = "0x59A9150", VA = "0x1859AA550")]
		public GUILayoutEntry GetNext()
		{
			return null;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x59A9540", Offset = "0x59A8140", VA = "0x1859A9540")]
		public void Add(GUILayoutEntry e)
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x59A9E80", Offset = "0x59A8A80", VA = "0x1859A9E80", Slot = "8")]
		public override void CalcWidth()
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x59AA880", Offset = "0x59A9480", VA = "0x1859AA880", Slot = "10")]
		public override void SetHorizontal(float x, float width)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x59A9810", Offset = "0x59A8410", VA = "0x1859A9810", Slot = "9")]
		public override void CalcHeight()
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x59AB050", Offset = "0x59A9C50", VA = "0x1859AB050", Slot = "11")]
		public override void SetVertical(float y, float height)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x59AB830", Offset = "0x59AA430", VA = "0x1859AB830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x48")]
		public List<GUILayoutEntry> entries;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x50")]
		public bool isVertical;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x51")]
		public bool resetCoords;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x54")]
		public float spacing;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x58")]
		public bool sameSize;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x59")]
		public bool isWindow;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x5C")]
		public int windowID;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x60")]
		private int m_Cursor;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x64")]
		protected int m_StretchableCountX;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x68")]
		protected int m_StretchableCountY;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x6C")]
		protected bool m_UserSpecifiedWidth;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x6D")]
		protected bool m_UserSpecifiedHeight;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x70")]
		protected float m_ChildMinWidth;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x74")]
		protected float m_ChildMaxWidth;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x78")]
		protected float m_ChildMinHeight;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x7C")]
		protected float m_ChildMaxHeight;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x80")]
		protected int m_MarginLeft;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x84")]
		protected int m_MarginRight;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x88")]
		protected int m_MarginTop;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x8C")]
		protected int m_MarginBottom;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly GUILayoutEntry none;
	}
}
