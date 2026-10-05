using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.LayoutToolkit
{
	// Token: 0x02007C5F RID: 31839
	[Token(Token = "0x2007C5F")]
	public class fiHorizontalLayout : fiLayout, IEnumerable
	{
		// Token: 0x0602C7F2 RID: 182258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7F2")]
		[Address(RVA = "0x2869F10", Offset = "0x2868B10", VA = "0x182869F10")]
		public fiHorizontalLayout()
		{
		}

		// Token: 0x0602C7F3 RID: 182259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7F3")]
		[Address(RVA = "0x2869FD0", Offset = "0x2868BD0", VA = "0x182869FD0")]
		public fiHorizontalLayout(fiLayout defaultRule)
		{
		}

		// Token: 0x0602C7F4 RID: 182260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7F4")]
		[Address(RVA = "0x2869A20", Offset = "0x2868620", VA = "0x182869A20")]
		public void Add(fiLayout rule)
		{
		}

		// Token: 0x0602C7F5 RID: 182261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7F5")]
		[Address(RVA = "0x2869930", Offset = "0x2868530", VA = "0x182869930")]
		public void Add(float width)
		{
		}

		// Token: 0x0602C7F6 RID: 182262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7F6")]
		[Address(RVA = "0x28698A0", Offset = "0x28684A0", VA = "0x1828698A0")]
		public void Add(string id)
		{
		}

		// Token: 0x0602C7F7 RID: 182263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7F7")]
		[Address(RVA = "0x2869870", Offset = "0x2868470", VA = "0x182869870")]
		public void Add(string id, float width)
		{
		}

		// Token: 0x0602C7F8 RID: 182264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7F8")]
		[Address(RVA = "0x28698D0", Offset = "0x28684D0", VA = "0x1828698D0")]
		public void Add(string id, fiLayout rule)
		{
		}

		// Token: 0x0602C7F9 RID: 182265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7F9")]
		[Address(RVA = "0x28699A0", Offset = "0x28685A0", VA = "0x1828699A0")]
		public void Add(float width, fiLayout rule)
		{
		}

		// Token: 0x0602C7FA RID: 182266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7FA")]
		[Address(RVA = "0x2869900", Offset = "0x2868500", VA = "0x182869900")]
		public void Add(string id, float width, fiLayout rule)
		{
		}

		// Token: 0x0602C7FB RID: 182267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7FB")]
		[Address(RVA = "0x2869750", Offset = "0x2868350", VA = "0x182869750")]
		private void ActualAdd(string id, float width, fiExpandMode expandMode, fiLayout rule)
		{
		}

		// Token: 0x17006825 RID: 26661
		// (get) Token: 0x0602C7FC RID: 182268 RVA: 0x000E0580 File Offset: 0x000DE780
		[Token(Token = "0x17006825")]
		private int ExpandCount
		{
			[Token(Token = "0x602C7FC")]
			[Address(RVA = "0x286A0C0", Offset = "0x2868CC0", VA = "0x18286A0C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006826 RID: 26662
		// (get) Token: 0x0602C7FD RID: 182269 RVA: 0x000E0598 File Offset: 0x000DE798
		[Token(Token = "0x17006826")]
		private float MinimumWidth
		{
			[Token(Token = "0x602C7FD")]
			[Address(RVA = "0x286A2B0", Offset = "0x2868EB0", VA = "0x18286A2B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0602C7FE RID: 182270 RVA: 0x000E05B0 File Offset: 0x000DE7B0
		[Token(Token = "0x602C7FE")]
		[Address(RVA = "0x2869A90", Offset = "0x2868690", VA = "0x182869A90", Slot = "5")]
		public override Rect GetSectionRect(string sectionId, Rect initial)
		{
			return default(Rect);
		}

		// Token: 0x0602C7FF RID: 182271 RVA: 0x000E05C8 File Offset: 0x000DE7C8
		[Token(Token = "0x602C7FF")]
		[Address(RVA = "0x2869DB0", Offset = "0x28689B0", VA = "0x182869DB0", Slot = "4")]
		public override bool RespondsTo(string sectionId)
		{
			return default(bool);
		}

		// Token: 0x17006827 RID: 26663
		// (get) Token: 0x0602C800 RID: 182272 RVA: 0x000E05E0 File Offset: 0x000DE7E0
		[Token(Token = "0x17006827")]
		public override float Height
		{
			[Token(Token = "0x602C800")]
			[Address(RVA = "0x286A180", Offset = "0x2868D80", VA = "0x18286A180", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0602C801 RID: 182273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C801")]
		[Address(RVA = "0x2869EC0", Offset = "0x2868AC0", VA = "0x182869EC0", Slot = "7")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0404032E RID: 262958
		[Token(Token = "0x404032E")]
		[FieldOffset(Offset = "0x10")]
		private List<fiHorizontalLayout.SectionItem> _items;

		// Token: 0x0404032F RID: 262959
		[Token(Token = "0x404032F")]
		[FieldOffset(Offset = "0x18")]
		private fiLayout _defaultRule;

		// Token: 0x02007C60 RID: 31840
		[Token(Token = "0x2007C60")]
		private struct SectionItem
		{
			// Token: 0x04040330 RID: 262960
			[Token(Token = "0x4040330")]
			[FieldOffset(Offset = "0x0")]
			public string Id;

			// Token: 0x04040331 RID: 262961
			[Token(Token = "0x4040331")]
			[FieldOffset(Offset = "0x8")]
			public float MinWidth;

			// Token: 0x04040332 RID: 262962
			[Token(Token = "0x4040332")]
			[FieldOffset(Offset = "0xC")]
			public fiExpandMode ExpandMode;

			// Token: 0x04040333 RID: 262963
			[Token(Token = "0x4040333")]
			[FieldOffset(Offset = "0x10")]
			public fiLayout Rule;
		}
	}
}
