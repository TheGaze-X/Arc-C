using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	internal abstract class ABSPathDecoder
	{
		// Token: 0x06000393 RID: 915
		[Token(Token = "0x6000393")]
		internal abstract void FinalizePath(Path p, Vector3[] wps, bool isClosedPath);

		// Token: 0x06000394 RID: 916
		[Token(Token = "0x6000394")]
		internal abstract Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints);

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000395 RID: 917
		[Token(Token = "0x1700000B")]
		internal abstract int minInputWaypoints { [Token(Token = "0x6000395")] get; }

		// Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ABSPathDecoder()
		{
		}
	}
}
