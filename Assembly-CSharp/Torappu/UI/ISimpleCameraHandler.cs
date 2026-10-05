using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003635 RID: 13877
	[Token(Token = "0x2003635")]
	public interface ISimpleCameraHandler
	{
		// Token: 0x06016180 RID: 90496
		[Token(Token = "0x6016180")]
		Camera GetSimpleCamera();

		// Token: 0x06016181 RID: 90497
		[Token(Token = "0x6016181")]
		bool IsValid();

		// Token: 0x06016182 RID: 90498
		[Token(Token = "0x6016182")]
		SortingInfo GetInitSortingInfo();

		// Token: 0x06016183 RID: 90499
		[Token(Token = "0x6016183")]
		void RequestSimpleCamera();

		// Token: 0x06016184 RID: 90500
		[Token(Token = "0x6016184")]
		void ReleaseSimpleCamera();

		// Token: 0x06016185 RID: 90501
		[Token(Token = "0x6016185")]
		void BindInitCanvasOnSimplePage(Canvas canvas);

		// Token: 0x06016186 RID: 90502
		[Token(Token = "0x6016186")]
		void AdjustSimpleCamToHighest();

		// Token: 0x06016187 RID: 90503
		[Token(Token = "0x6016187")]
		void AdjustSimpleCamToLowest();

		// Token: 0x06016188 RID: 90504
		[Token(Token = "0x6016188")]
		void AdjustSimplePageOrder(UIPage lower, UIPage upper);
	}
}
