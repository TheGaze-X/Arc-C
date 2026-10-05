using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.LayoutToolkit
{
	// Token: 0x02007C64 RID: 31844
	[Token(Token = "0x2007C64")]
	public class fiCenterVertical : fiLayout
	{
		// Token: 0x0602C80D RID: 182285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C80D")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public fiCenterVertical(string id, fiLayout centered)
		{
		}

		// Token: 0x0602C80E RID: 182286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C80E")]
		[Address(RVA = "0x2866D60", Offset = "0x2865960", VA = "0x182866D60")]
		public fiCenterVertical(fiLayout centered)
		{
		}

		// Token: 0x0602C80F RID: 182287 RVA: 0x000E0640 File Offset: 0x000DE840
		[Token(Token = "0x602C80F")]
		[Address(RVA = "0x2866CE0", Offset = "0x28658E0", VA = "0x182866CE0", Slot = "4")]
		public override bool RespondsTo(string sectionId)
		{
			return default(bool);
		}

		// Token: 0x0602C810 RID: 182288 RVA: 0x000E0658 File Offset: 0x000DE858
		[Token(Token = "0x602C810")]
		[Address(RVA = "0x2866BB0", Offset = "0x28657B0", VA = "0x182866BB0", Slot = "5")]
		public override Rect GetSectionRect(string sectionId, Rect initial)
		{
			return default(Rect);
		}

		// Token: 0x1700682A RID: 26666
		// (get) Token: 0x0602C811 RID: 182289 RVA: 0x000E0670 File Offset: 0x000DE870
		[Token(Token = "0x1700682A")]
		public override float Height
		{
			[Token(Token = "0x602C811")]
			[Address(RVA = "0x2866DE0", Offset = "0x28659E0", VA = "0x182866DE0", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x04040336 RID: 262966
		[Token(Token = "0x4040336")]
		[FieldOffset(Offset = "0x10")]
		private string _id;

		// Token: 0x04040337 RID: 262967
		[Token(Token = "0x4040337")]
		[FieldOffset(Offset = "0x18")]
		private fiLayout _centered;
	}
}
