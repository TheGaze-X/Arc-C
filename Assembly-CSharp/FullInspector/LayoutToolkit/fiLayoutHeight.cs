using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.LayoutToolkit
{
	// Token: 0x02007C62 RID: 31842
	[Token(Token = "0x2007C62")]
	public class fiLayoutHeight : fiLayout
	{
		// Token: 0x0602C806 RID: 182278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C806")]
		[Address(RVA = "0x286BF80", Offset = "0x286AB80", VA = "0x18286BF80")]
		public fiLayoutHeight(float height)
		{
		}

		// Token: 0x0602C807 RID: 182279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C807")]
		[Address(RVA = "0x2704DA0", Offset = "0x27039A0", VA = "0x182704DA0")]
		public fiLayoutHeight(string sectionId, float height)
		{
		}

		// Token: 0x0602C808 RID: 182280 RVA: 0x000E05F8 File Offset: 0x000DE7F8
		[Token(Token = "0x602C808")]
		[Address(RVA = "0x286BF70", Offset = "0x286AB70", VA = "0x18286BF70", Slot = "4")]
		public override bool RespondsTo(string sectionId)
		{
			return default(bool);
		}

		// Token: 0x0602C809 RID: 182281 RVA: 0x000E0610 File Offset: 0x000DE810
		[Token(Token = "0x602C809")]
		[Address(RVA = "0x286BF30", Offset = "0x286AB30", VA = "0x18286BF30", Slot = "5")]
		public override Rect GetSectionRect(string sectionId, Rect initial)
		{
			return default(Rect);
		}

		// Token: 0x0602C80A RID: 182282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C80A")]
		[Address(RVA = "0x5B4660", Offset = "0x5B3260", VA = "0x1805B4660")]
		public void SetHeight(float height)
		{
		}

		// Token: 0x17006829 RID: 26665
		// (get) Token: 0x0602C80B RID: 182283 RVA: 0x000E0628 File Offset: 0x000DE828
		[Token(Token = "0x17006829")]
		public override float Height
		{
			[Token(Token = "0x602C80B")]
			[Address(RVA = "0x5B4650", Offset = "0x5B3250", VA = "0x1805B4650", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x04040334 RID: 262964
		[Token(Token = "0x4040334")]
		[FieldOffset(Offset = "0x10")]
		private string _id;

		// Token: 0x04040335 RID: 262965
		[Token(Token = "0x4040335")]
		[FieldOffset(Offset = "0x18")]
		private float _height;
	}
}
