using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.LayoutToolkit
{
	// Token: 0x02007C65 RID: 31845
	[Token(Token = "0x2007C65")]
	public class fiVerticalLayout : fiLayout, IEnumerable
	{
		// Token: 0x0602C812 RID: 182290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C812")]
		[Address(RVA = "0x2874B30", Offset = "0x2873730", VA = "0x182874B30")]
		public void Add(fiLayout rule)
		{
		}

		// Token: 0x0602C813 RID: 182291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C813")]
		[Address(RVA = "0x2874A30", Offset = "0x2873630", VA = "0x182874A30")]
		public void Add(string sectionId, fiLayout rule)
		{
		}

		// Token: 0x0602C814 RID: 182292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C814")]
		[Address(RVA = "0x2874990", Offset = "0x2873590", VA = "0x182874990")]
		public void Add(string sectionId, float height)
		{
		}

		// Token: 0x0602C815 RID: 182293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C815")]
		[Address(RVA = "0x28748D0", Offset = "0x28734D0", VA = "0x1828748D0")]
		public void Add(float height)
		{
		}

		// Token: 0x0602C816 RID: 182294 RVA: 0x000E0688 File Offset: 0x000DE888
		[Token(Token = "0x602C816")]
		[Address(RVA = "0x2874B90", Offset = "0x2873790", VA = "0x182874B90", Slot = "5")]
		public override Rect GetSectionRect(string sectionId, Rect initial)
		{
			return default(Rect);
		}

		// Token: 0x0602C817 RID: 182295 RVA: 0x000E06A0 File Offset: 0x000DE8A0
		[Token(Token = "0x602C817")]
		[Address(RVA = "0x2874D70", Offset = "0x2873970", VA = "0x182874D70", Slot = "4")]
		public override bool RespondsTo(string sectionId)
		{
			return default(bool);
		}

		// Token: 0x1700682B RID: 26667
		// (get) Token: 0x0602C818 RID: 182296 RVA: 0x000E06B8 File Offset: 0x000DE8B8
		[Token(Token = "0x1700682B")]
		public override float Height
		{
			[Token(Token = "0x602C818")]
			[Address(RVA = "0x2874F60", Offset = "0x2873B60", VA = "0x182874F60", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0602C819 RID: 182297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C819")]
		[Address(RVA = "0x2874E80", Offset = "0x2873A80", VA = "0x182874E80", Slot = "7")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0602C81A RID: 182298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C81A")]
		[Address(RVA = "0x2874ED0", Offset = "0x2873AD0", VA = "0x182874ED0")]
		public fiVerticalLayout()
		{
		}

		// Token: 0x04040338 RID: 262968
		[Token(Token = "0x4040338")]
		[FieldOffset(Offset = "0x10")]
		private List<fiVerticalLayout.SectionItem> _items;

		// Token: 0x02007C66 RID: 31846
		[Token(Token = "0x2007C66")]
		private struct SectionItem
		{
			// Token: 0x04040339 RID: 262969
			[Token(Token = "0x4040339")]
			[FieldOffset(Offset = "0x0")]
			public string Id;

			// Token: 0x0404033A RID: 262970
			[Token(Token = "0x404033A")]
			[FieldOffset(Offset = "0x8")]
			public fiLayout Rule;
		}
	}
}
