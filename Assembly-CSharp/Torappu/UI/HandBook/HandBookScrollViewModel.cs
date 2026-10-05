using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066C2 RID: 26306
	[Token(Token = "0x20066C2")]
	public class HandBookScrollViewModel
	{
		// Token: 0x17005980 RID: 22912
		// (get) Token: 0x06025C66 RID: 154726 RVA: 0x000C9078 File Offset: 0x000C7278
		// (set) Token: 0x06025C67 RID: 154727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005980")]
		public bool zoomFlag
		{
			[Token(Token = "0x6025C66")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025C67")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x17005981 RID: 22913
		// (get) Token: 0x06025C68 RID: 154728 RVA: 0x000C9090 File Offset: 0x000C7290
		// (set) Token: 0x06025C69 RID: 154729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005981")]
		public float zoomValue
		{
			[Token(Token = "0x6025C68")]
			[Address(RVA = "0x20BDE20", Offset = "0x20BCA20", VA = "0x1820BDE20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6025C69")]
			[Address(RVA = "0x20BDEF0", Offset = "0x20BCAF0", VA = "0x1820BDEF0")]
			set
			{
			}
		}

		// Token: 0x17005982 RID: 22914
		// (get) Token: 0x06025C6A RID: 154730 RVA: 0x000C90A8 File Offset: 0x000C72A8
		// (set) Token: 0x06025C6B RID: 154731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005982")]
		public bool dirtyFlag
		{
			[Token(Token = "0x6025C6A")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025C6B")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			set
			{
			}
		}

		// Token: 0x17005983 RID: 22915
		// (get) Token: 0x06025C6C RID: 154732 RVA: 0x000C90C0 File Offset: 0x000C72C0
		// (set) Token: 0x06025C6D RID: 154733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005983")]
		public Vector2 scrollPos
		{
			[Token(Token = "0x6025C6C")]
			[Address(RVA = "0x20BDE00", Offset = "0x20BCA00", VA = "0x1820BDE00")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6025C6D")]
			[Address(RVA = "0x20BDE40", Offset = "0x20BCA40", VA = "0x1820BDE40")]
			set
			{
			}
		}

		// Token: 0x17005984 RID: 22916
		// (get) Token: 0x06025C6E RID: 154734 RVA: 0x000C90D8 File Offset: 0x000C72D8
		// (set) Token: 0x06025C6F RID: 154735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005984")]
		public bool onScroll
		{
			[Token(Token = "0x6025C6E")]
			[Address(RVA = "0x4EA840", Offset = "0x4E9440", VA = "0x1804EA840")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025C6F")]
			[Address(RVA = "0x4EA980", Offset = "0x4E9580", VA = "0x1804EA980")]
			set
			{
			}
		}

		// Token: 0x17005985 RID: 22917
		// (get) Token: 0x06025C70 RID: 154736 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025C71 RID: 154737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005985")]
		public string selectedChar
		{
			[Token(Token = "0x6025C70")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x6025C71")]
			[Address(RVA = "0x20BDE50", Offset = "0x20BCA50", VA = "0x1820BDE50")]
			set
			{
			}
		}

		// Token: 0x06025C72 RID: 154738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C72")]
		[Address(RVA = "0x20BDDA0", Offset = "0x20BC9A0", VA = "0x1820BDDA0")]
		public HandBookScrollViewModel()
		{
		}

		// Token: 0x040351AD RID: 217517
		[Token(Token = "0x40351AD")]
		[FieldOffset(Offset = "0x10")]
		private bool m_zoomFlag;

		// Token: 0x040351AE RID: 217518
		[Token(Token = "0x40351AE")]
		[FieldOffset(Offset = "0x14")]
		private float m_zoomValue;

		// Token: 0x040351AF RID: 217519
		[Token(Token = "0x40351AF")]
		[FieldOffset(Offset = "0x18")]
		private bool m_dirtyFlag;

		// Token: 0x040351B0 RID: 217520
		[Token(Token = "0x40351B0")]
		[FieldOffset(Offset = "0x1C")]
		private Vector2 m_scrollPos;

		// Token: 0x040351B1 RID: 217521
		[Token(Token = "0x40351B1")]
		[FieldOffset(Offset = "0x24")]
		private bool m_onScroll;

		// Token: 0x040351B2 RID: 217522
		[Token(Token = "0x40351B2")]
		[FieldOffset(Offset = "0x28")]
		public HandBookCardView SelectedCardData;

		// Token: 0x040351B3 RID: 217523
		[Token(Token = "0x40351B3")]
		[FieldOffset(Offset = "0x30")]
		public bool lastSelected;

		// Token: 0x040351B4 RID: 217524
		[Token(Token = "0x40351B4")]
		[FieldOffset(Offset = "0x31")]
		public bool quickAnim;

		// Token: 0x040351B5 RID: 217525
		[Token(Token = "0x40351B5")]
		[FieldOffset(Offset = "0x38")]
		private string m_selectedChar;
	}
}
