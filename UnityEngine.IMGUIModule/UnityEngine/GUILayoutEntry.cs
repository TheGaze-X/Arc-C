using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	internal class GUILayoutEntry
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000218 RID: 536 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007B")]
		public GUIStyle style
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x59976F0", Offset = "0x59962F0", VA = "0x1859976F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x59A94F0", Offset = "0x59A80F0", VA = "0x1859A94F0")]
			set
			{
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x1700007C")]
		public virtual int marginLeft
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x59A93F0", Offset = "0x59A7FF0", VA = "0x1859A93F0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x1700007D")]
		public virtual int marginRight
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x59A9420", Offset = "0x59A8020", VA = "0x1859A9420", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x1700007E")]
		public virtual int marginTop
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x59A9450", Offset = "0x59A8050", VA = "0x1859A9450", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x1700007F")]
		public virtual int marginBottom
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x59A9350", Offset = "0x59A7F50", VA = "0x1859A9350", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x17000080")]
		public int marginHorizontal
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x59A9380", Offset = "0x59A7F80", VA = "0x1859A9380")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x17000081")]
		public int marginVertical
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x59A9480", Offset = "0x59A8080", VA = "0x1859A9480")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x59A9090", Offset = "0x59A7C90", VA = "0x1859A9090")]
		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x59A91F0", Offset = "0x59A7DF0", VA = "0x1859A91F0")]
		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public virtual void CalcWidth()
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public virtual void CalcHeight()
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x59A87B0", Offset = "0x59A73B0", VA = "0x1859A87B0", Slot = "10")]
		public virtual void SetHorizontal(float x, float width)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x59A87F0", Offset = "0x59A73F0", VA = "0x1859A87F0", Slot = "11")]
		public virtual void SetVertical(float y, float height)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x59A8700", Offset = "0x59A7300", VA = "0x1859A8700", Slot = "12")]
		protected virtual void ApplyStyleSettings(GUIStyle style)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x59A8360", Offset = "0x59A6F60", VA = "0x1859A8360", Slot = "13")]
		public virtual void ApplyOptions(GUILayoutOption[] options)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x59A8830", Offset = "0x59A7430", VA = "0x1859A8830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x10")]
		public float minWidth;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x14")]
		public float maxWidth;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x18")]
		public float minHeight;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x1C")]
		public float maxHeight;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x20")]
		public Rect rect;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x30")]
		public int stretchWidth;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x34")]
		public int stretchHeight;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x38")]
		public bool consideredForMargin;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x40")]
		private GUIStyle m_Style;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x0")]
		internal static Rect kDummyRect;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x10")]
		protected static int indent;
	}
}
